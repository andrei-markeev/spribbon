using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentRibbon.Definitions;
using FluentRibbon.Definitions.Controls;

namespace FluentRibbon.Commands
{
    /// <summary>
    /// Helper class for Ribbon commands managing and collecting
    /// </summary>
    internal class RibbonCommandRepository
    {
        #region Singleton

        private static RibbonCommandRepository instance = null;

        public static RibbonCommandRepository Current
        {
            get
            {
                if (instance == null)
                    instance = new RibbonCommandRepository();

                return instance;
            }
        }

        private RibbonCommandRepository()
        {
        }

        #endregion

        List<FluentRibbonCommand> commands = new List<FluentRibbonCommand>();

        public int GetCommandsCount()
        {
            return commands.Count;
        }

        public IEnumerable<FluentRibbonCommand> GetCommands()
        {
            return commands.AsReadOnly();
        }

        public void ClearCommands()
        {
            commands.Clear();
        }

        public void AddCommands(RibbonDefinition definition)
        {
            IEnumerable<ControlDefinition> controls;

            if (definition is ContextualGroupDefinition)
                controls = (definition as ContextualGroupDefinition).Tabs.SelectMany(t => t.Groups).SelectMany(g => g.Controls).ToArray();
            else if (definition is TabDefinition)
                controls = (definition as TabDefinition).Groups.SelectMany(g => g.Controls).ToArray();
            else if (definition is GroupDefinition)
                controls = (definition as GroupDefinition).Controls.ToArray();
            else if (definition is ControlDefinition)
                controls = new ControlDefinition[] { definition as ControlDefinition };
            else
                throw new ArgumentException();

            // MRUSplitButtonDefinition: Command="{Id}MenuCommand"
            commands.AddRange(
                controls
                .WithDescendants(c => c is IContainer ? (c as IContainer).Controls : null)
                .OfType<MRUSplitButtonDefinition>()
                .Select<MRUSplitButtonDefinition, FluentRibbonCommand>(c =>
                    new FluentRibbonCommand(
                        c.FullId + "MenuCommand",
                        "handleCommand(properties['CommandValueId']);",
                        "true"
                        )
                    ).ToArray()
                );

            // Buttons of all types, including Button, SplitButton, ToggleButton
            commands.AddRange(
                controls
                .WithDescendants(c => c is IContainer ? (c as IContainer).Controls : null)
                .OfType<ButtonBaseDefinition>()
                .Select<ButtonBaseDefinition, FluentRibbonCommand>(b => new FluentRibbonCommand(b.FullId + "Command", b.CommandJavaScript, b.CommandEnableJavaScript)).ToArray());

            // Initializable controls
            var initializationScript = "function initialValue() { {IVScript} }; var v = initialValue(); if (v != null) { properties['On'] = true; properties['Value'] = v; }";
            commands.AddRange(
                controls
                .WithDescendants(c => c is IContainer ? (c as IContainer).Controls : null)
                .Where(c => c is IInitializable)
                .SelectMany(c => new FluentRibbonCommand[]
                    {
                        new FluentRibbonCommand(c.FullId + "Command", String.Empty, "true"),
                        new FluentRibbonCommand(c.FullId + "QueryCommand", initializationScript.Replace("{IVScript}", (c as IInitializable).InitialValueJavaScript), "true")
                    }).ToArray());


        }



    }
}
