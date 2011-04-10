using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RibbonUtils.Definitions;
using System.Web.UI;
using Microsoft.SharePoint.WebControls;
using System.Xml;
using Microsoft.Web.CommandUI;
using RibbonUtils.Definitions.Controls;

namespace RibbonUtils
{

    internal class RibbonController
    {
        #region Singleton

        private static RibbonController instance = null;

        public static RibbonController Current
        {
            get
            {
                if (instance == null)
                    instance = new RibbonController();

                return instance;
            }
        }

        private RibbonController()
        {
        }

        #endregion

        internal void AddRibbonContextualTabToPage(ContextualGroupDefinition definition, Page page)
        {
            page.PreRenderComplete += new EventHandler(page_PreRenderComplete);

            AddRibbonExtension(XmlGenerator.Current.GetContextualGroupXML(definition), page, "Ribbon.ContextualTabs");
            AddGroupTemplatesRibbonExtensions(definition.Tabs.SelectMany(t => t.GroupTemplates), page);
            AddCommands(definition.Tabs.SelectMany(t => t.Groups), page);
        }

        internal void AddRibbonTabToPage(TabDefinition definition, Page page)
        {
            AddRibbonExtension(XmlGenerator.Current.GetTabXML(definition), page, "Ribbon.Tabs");
            AddGroupTemplatesRibbonExtensions(definition.GroupTemplates, page);
            AddCommands(definition.Groups, page);
            RegisterCommands(page);

            Ribbon ribbon = SPRibbon.GetCurrent(page);
            ribbon.MakeTabAvailable(RibbonHelper.RibbonId(definition.Id));
            ribbon.InitialTabId = RibbonHelper.RibbonId(definition.Id);
        }

        #region Private functions

        List<IRibbonCommand> commands = new List<IRibbonCommand>();

        private void page_PreRenderComplete(object sender, EventArgs e)
        {
            Page page = sender as Page;
            
            if (commands.Count > 0)
                RegisterCommands(page);
        }

        private void AddGroupTemplatesRibbonExtensions(IEnumerable<GroupTemplateDefinition> templates, Page page)
        {
            Ribbon ribbon = SPRibbon.GetCurrent(page);
            XmlDocument ribbonExtensions = new XmlDocument();

            foreach (GroupTemplateDefinition template in templates)
            {
                ribbonExtensions.LoadXml(template.XML);
                ribbon.RegisterDataExtension(ribbonExtensions.FirstChild, "Ribbon.Templates._children");
            }
        }

        private void AddRibbonExtension(string xml, Page page, string parentId)
        {
            Ribbon ribbon = SPRibbon.GetCurrent(page);
            ribbon.Minimized = false;
            ribbon.CommandUIVisible = true;
            XmlDocument ribbonExtensions = new XmlDocument();
            ribbonExtensions.LoadXml(xml);
            ribbon.RegisterDataExtension(ribbonExtensions.FirstChild, parentId + "._children");
        }

        private void AddCommands(IEnumerable<GroupDefinition> groups, Page page)
        {
            
            // MRUSplitButtonDefinition: Command="{Id}MenuCommand"
            commands.AddRange(
                groups
                .SelectMany(g => g.Controls)
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
                groups
                .SelectMany(g => g.Controls)
                .WithDescendants(c => c is IContainer ? (c as IContainer).Controls : null)
                .OfType<ButtonBaseDefinition>()
                .Select<ButtonBaseDefinition, IRibbonCommand>(b => new SPRibbonCommand(b.FullId + "Command", b.CommandJavaScript, b.CommandEnableJavaScript)));
        }

        private void RegisterCommands(Page page)
        {
            SPRibbonScriptManager ribbonScriptManager = new SPRibbonScriptManager();

            ribbonScriptManager.RegisterGetCommandsFunction(page, "getGlobalCommands", commands);
            ribbonScriptManager.RegisterCommandEnabledFunction(page, "commandEnabled", commands);
            ribbonScriptManager.RegisterHandleCommandFunction(page, "handleCommand", commands);

            page.ClientScript.RegisterClientScriptBlock(
                page.GetType(),
                "InitPageComponent",
                PageComponentScript.GetText("RibbonUtils"));

            commands.Clear();
        }

        #endregion

    }
}
