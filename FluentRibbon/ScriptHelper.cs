﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentRibbon.Commands;

namespace FluentRibbon
{
    internal class ScriptHelper
    {

        internal static string GetCommandsScript(IEnumerable<FluentRibbonCommand> commands)
        {
            if (commands == null || commands.Count() == 0)
                return String.Empty;

            return String.Format(@" 
                <script language=""javascript"" defer=""true""> 
                 //<![CDATA[
                    function getFocusedCommands()
                    {{
                        return [{0}];
                    }}
                    function getGlobalCommands()
                    {{
                        return [{1}];
                    }}
                    function commandEnabled(commandId)
                    {{
{2}
                        return false;
                    }}
                    function handleCommand(commandId, properties, sequence)
                    {{
{3}
                        return false;
                    }}

                 //]]> 
                </script>",
                String.Join(",", commands.Where(c => !String.IsNullOrEmpty(c.Id) && c.Id.EndsWith("QueryCommand")).Select(c => "'" + c.Id + "'").ToArray()),
                String.Join(",", commands.Where(c => !String.IsNullOrEmpty(c.Id) && !c.Id.EndsWith("QueryCommand")).Select(c => "'" + c.Id + "'").ToArray()),
                String.Join("\n", commands.Select(c => String.Format("if (commandId == '{0}') {{ return {1}; }}", c.Id, c.EnabledStatement ?? String.Empty)).ToArray()),
                String.Join("\n", commands.Select(c => String.Format("if (commandId == '{0}') {{ {1}; return true; }}", c.Id, c.HandlerStatement ?? String.Empty)).ToArray())
                 );
        }

        internal static string GetPageComponentScript(string nameSpace)
        {
            // This is not the best way to load the script, but it has an important advantage: you don't need to deploy FluentRibbon.
            // All is now in the assembly, and all you need is to install the assembly in GAC.
            return @" 
                 <script language=""javascript"" defer=""true""> 
                 //<![CDATA[
Type.registerNamespace('{0}');

// RibbonApp Page Component
{0}.PageComponent = function () {
    {0}.PageComponent.initializeBase(this);
}
{0}.PageComponent.initialize = function () {
    ExecuteOrDelayUntilScriptLoaded(
        Function.createDelegate(
            null,
            {0}.PageComponent.initializePageComponent),
        'SP.Ribbon.js');
}
{0}.PageComponent.initialize = function (controlId) {
    {0}.PageComponent.ControlClientId = controlId;
    ExecuteOrDelayUntilScriptLoaded(
        Function.createDelegate(
            null,
            {0}.PageComponent.initializePageComponent),
        'SP.Ribbon.js');
}
{0}.PageComponent.initializePageComponent = function () {
    var ribbonPageManager = SP.Ribbon.PageManager.get_instance();
    if (null !== ribbonPageManager) {
        ribbonPageManager.addPageComponent({0}.PageComponent.instance);
        ribbonPageManager
            .get_focusManager()
            .requestFocusForComponent({0}.PageComponent.instance);
    }
}
{0}.PageComponent.refreshRibbonStatus = function () {
    SP.Ribbon.PageManager
        .get_instance()
        .get_commandDispatcher()
        .executeCommand(Commands.CommandIds.ApplicationStateChanged, null);
}
{0}.PageComponent.ControlClientId = null;
 
{0}.PageComponent.prototype = {
    init: function () {
    },
    getFocusedCommands: function () {
        return getFocusedCommands();
    },
    getGlobalCommands: function () {
        return getGlobalCommands();
    },
    isFocusable: function () {
        return true;
    },
    receiveFocus: function() {
        return true;
    },
    yieldFocus: function() {
        return true;
    },
    canHandleCommand: function (commandId) {
        return commandEnabled(commandId);
    },
    handleCommand: function (commandId, properties, sequence) {
        return handleCommand(commandId, properties, sequence);
    }
}
 
// Register classes

function initContextualPageComponent() {{
    {0}.PageComponent.registerClass('{0}.PageComponent', CUI.Page.PageComponent);
    {0}.PageComponent.instance = new {0}.PageComponent();
    {0}.PageComponent.initialize();
}}

ExecuteOrDelayUntilScriptLoaded(initContextualPageComponent,'sp.ribbon.js');

                 //]]> 
                 </script>".Replace("{0}", nameSpace);
        }

    }
}
