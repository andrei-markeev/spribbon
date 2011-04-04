using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.UI.WebControls.WebParts;
using Microsoft.SharePoint.WebControls;
using System.Xml;

namespace RibbonUtils
{
    public abstract class ContextualWebPart : WebPart, IWebPartPageComponentProvider
    {
        /// <summary>
        /// Return contextual group definition for the webpart here
        /// </summary>
        /// <remarks>
        /// If you return null, contextual tab will not be shown
        /// </remarks>
        public abstract ContextualGroupDefinition GetContextualGroupDefinition();


        public WebPartContextualInfo WebPartContextualInfo
        {
            get
            {
                WebPartContextualInfo info = new WebPartContextualInfo();

                var contextualGroupDefinition = GetContextualGroupDefinition();
                if (contextualGroupDefinition == null)
                    return info;

                WebPartRibbonContextualGroup contextualGroup = new WebPartRibbonContextualGroup();
                WebPartRibbonTab ribbonTab = new WebPartRibbonTab();

                //Create the contextual group object and initialize its values.
                contextualGroup.Id = RibbonHelper.RibbonId(contextualGroupDefinition.Id);
                contextualGroup.Command = contextualGroupDefinition.Command;
                contextualGroup.VisibilityContext = contextualGroupDefinition.Id + ".CustomVisibilityContext";

                //Create the tab object and initialize its values.
                ribbonTab.Id = RibbonHelper.RibbonId(contextualGroupDefinition.Tab.Id);
                ribbonTab.VisibilityContext = contextualGroupDefinition.Tab.Id + ".CustomVisibilityContext";

                //Add the contextual group and tab to the WebPartContextualInfo.
                info.ContextualGroups.Add(contextualGroup);
                info.Tabs.Add(ribbonTab);
                info.PageComponentId = SPRibbon.GetWebPartPageComponentId(this);

                return info;
            }
        }

        private void AddContextualTab()
        {
            var contextualGroupDefinition = GetContextualGroupDefinition();
            if (contextualGroupDefinition == null)
                return;

            //Gets the current instance of the ribbon on the page.
            Microsoft.Web.CommandUI.Ribbon ribbon = SPRibbon.GetCurrent(this.Page);

            //Prepares an XmlDocument object used to load the ribbon extensions.
            XmlDocument ribbonExtensions = new XmlDocument();

            //Load the contextual tab XML and register the ribbon extension.
            ribbonExtensions.LoadXml(RibbonHelper.GetContextualGroupXML(contextualGroupDefinition));
            ribbon.RegisterDataExtension(ribbonExtensions.FirstChild, "Ribbon.ContextualTabs._children");

            //Load the custom templates and register the ribbon extension.
            foreach (TemplateDefinition template in contextualGroupDefinition.GroupTemplates)
            {
                ribbonExtensions.LoadXml(template.XML);
                ribbon.RegisterDataExtension(ribbonExtensions.FirstChild, "Ribbon.Templates._children");
            }

            List<IRibbonCommand> commands = contextualGroupDefinition
                .Tab
                .Groups
                .SelectMany(c => c.Controls)
                .WithDescendants(c => c.Controls)
                .Where(c => !String.IsNullOrEmpty(c.CommandName))
                .Select<ControlDefinition, IRibbonCommand>(b => new SPRibbonCommand(b.CommandName, b.CommandJavaScript, b.CommandEnableJavaScript)).ToList();

            ScriptLink.RegisterScriptAfterUI(this.Page, "SP.Runtime.js", false, true);
            ScriptLink.RegisterScriptAfterUI(this.Page, "SP.js", false, true);
            ScriptLink.RegisterScriptAfterUI(this.Page, "CUI.js", false, true);
            ScriptLink.RegisterScriptAfterUI(this.Page, "SP.Ribbon.js", false, true);

            SPRibbonScriptManager ribbonScriptManager = new SPRibbonScriptManager();
            
            ribbonScriptManager.RegisterGetCommandsFunction(this.Page, "getGlobalCommands", commands);
            ribbonScriptManager.RegisterCommandEnabledFunction(this.Page, "commandEnabled", commands);
            ribbonScriptManager.RegisterHandleCommandFunction(this.Page, "handleCommand", commands);
            
            // This is not the best way to load the script, but it has an important advantage: you don't need to deploy RibbonUtils.
            // All is now in the assembly, and all you need is to install the assembly in GAC.
            string  script = @" 
                 <script language=""javascript"" defer=""true""> 
                 //<![CDATA[
Type.registerNamespace('RibbonUtils.ContextualWebPart');

// RibbonApp Page Component
RibbonUtils.ContextualWebPart.PageComponent = function () {
    RibbonUtils.ContextualWebPart.PageComponent.initializeBase(this);
}
RibbonUtils.ContextualWebPart.PageComponent.initialize = function () {
    ExecuteOrDelayUntilScriptLoaded(
        Function.createDelegate(
            null,
            RibbonUtils.ContextualWebPart.PageComponent.initializePageComponent),
        'SP.Ribbon.js');
}
RibbonUtils.ContextualWebPart.PageComponent.initialize = function (controlId) {
    RibbonUtils.ContextualWebPart.PageComponent.ControlClientId = controlId;
    ExecuteOrDelayUntilScriptLoaded(
        Function.createDelegate(
            null,
            RibbonUtils.ContextualWebPart.PageComponent.initializePageComponent),
        'SP.Ribbon.js');
}
RibbonUtils.ContextualWebPart.PageComponent.initializePageComponent = function () {
    var ribbonPageManager = SP.Ribbon.PageManager.get_instance();
    if (null !== ribbonPageManager) {
        ribbonPageManager.addPageComponent(RibbonUtils.ContextualWebPart.PageComponent.instance);
        ribbonPageManager
            .get_focusManager()
            .requestFocusForComponent(RibbonUtils.ContextualWebPart.PageComponent.instance);
    }
}
RibbonUtils.ContextualWebPart.PageComponent.refreshRibbonStatus = function () {
    SP.Ribbon.PageManager
        .get_instance()
        .get_commandDispatcher()
        .executeCommand(Commands.CommandIds.ApplicationStateChanged, null);
}
RibbonUtils.ContextualWebPart.PageComponent.ControlClientId = null;
 
RibbonUtils.ContextualWebPart.PageComponent.prototype = {
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

function initContextualPageComponent() {
    RibbonUtils.ContextualWebPart.PageComponent.registerClass('RibbonUtils.ContextualWebPart.PageComponent', CUI.Page.PageComponent);
    RibbonUtils.ContextualWebPart.PageComponent.instance = new RibbonUtils.ContextualWebPart.PageComponent();
    RibbonUtils.ContextualWebPart.PageComponent.initialize();
}

ExecuteOrDelayUntilScriptLoaded(initContextualPageComponent,'sp.ribbon.js');

                 //]]> 
                 </script>";

             this.Page.ClientScript.RegisterClientScriptBlock(this.Page.GetType(), "InitPageComponent", script);
        }


        protected override void OnPreRender(EventArgs e)
        {
            base.OnPreRender(e);

            // Adds contextual tab (but does not shows it until webpart is not selected)
            this.AddContextualTab();

        }

    }
}
