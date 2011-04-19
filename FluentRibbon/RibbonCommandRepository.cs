using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentRibbon.Definitions;
using FluentRibbon.Definitions.Controls;
using Microsoft.SharePoint.WebControls;

namespace FluentRibbon
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

        List<IRibbonCommand> commands = new List<IRibbonCommand>();

        public int GetCommandsCount()
        {
            return commands.Count;
        }

        public IEnumerable<IRibbonCommand> GetCommands()
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
                controls = (definition as ContextualGroupDefinition).Tabs.SelectMany(t => t.Groups).SelectMany(g => g.Controls);
            else if (definition is TabDefinition)
                controls = (definition as TabDefinition).Groups.SelectMany(g => g.Controls);
            else if (definition is GroupDefinition)
                controls = (definition as GroupDefinition).Controls;
            else if (definition is ControlDefinition)
                controls = new ControlDefinition[] { definition as ControlDefinition };
            else
                throw new ArgumentException();

            // MRUSplitButtonDefinition: Command="{Id}MenuCommand"
            commands.AddRange(
                controls
                .WithDescendants(c => c is IContainer ? (c as IContainer).Controls : null)
                .OfType<MRUSplitButtonDefinition>()
                .Select<MRUSplitButtonDefinition, IRibbonCommand>(c =>
                    new SPRibbonCommand(
                        c.FullId + "MenuCommand",
                        "handleCommand(properties['CommandValueId']);",
                        "true"
                        )
                    )
                );

            // Buttons of all types, including Button, SplitButton, ToggleButton
            commands.AddRange(
                controls
                .WithDescendants(c => c is IContainer ? (c as IContainer).Controls : null)
                .OfType<ButtonBaseDefinition>()
                .Select<ButtonBaseDefinition, IRibbonCommand>(b => new SPRibbonCommand(b.FullId + "Command", b.CommandJavaScript, b.CommandEnableJavaScript)));
        }



    }
}
