using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FluentRibbon
{
    internal class PageComponentScript
    {
        internal static string GetText(string nameSpace)
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
        // if you have something to initalize
    },
    getFocusedCommands: function () {
        return [];
    },
    getGlobalCommands: function () {
        // Server side commands will show up here
        return getGlobalCommands();
    },
    isFocusable: function () {
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
