using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RibbonUtils.Definitions;
using System.Web.UI;
using Microsoft.SharePoint.WebControls;
using System.Xml;
using Microsoft.Web.CommandUI;

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
            AddGroupTemplatesRibbonExtensions(definition.Tab.GroupTemplates, page);
            AddCommands(definition.Tab.Groups, page);
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

        private void AddGroupTemplatesRibbonExtensions(IEnumerable<TemplateDefinition> templates, Page page)
        {
            Ribbon ribbon = SPRibbon.GetCurrent(page);
            XmlDocument ribbonExtensions = new XmlDocument();

            foreach (TemplateDefinition template in templates)
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

            commands.AddRange(
                groups
                .SelectMany(g => g.Controls)
                .WithDescendants(c => c is ContainerDefinition ? (c as ContainerDefinition).Controls : null)
                .Where(c => !String.IsNullOrEmpty(c.CommandName))
                .Select<ControlDefinition, IRibbonCommand>(b => new SPRibbonCommand(b.CommandName, b.CommandJavaScript, b.CommandEnableJavaScript)));

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
