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
            AddRibbonExtension(XmlGenerator.Current.GetContextualGroupXML(definition), page, "Ribbon.ContextualTabs");
            AddGroupTemplatesRibbonExtensions(definition.Tab.GroupTemplates, page);
            AddCommands(definition.Tab.Groups, page);
        }

        internal void AddRibbonTabToPage(TabDefinition definition, Page page)
        {
            AddRibbonExtension(XmlGenerator.Current.GetTabXML(definition), page, "Ribbon.Tabs");
            AddGroupTemplatesRibbonExtensions(definition.GroupTemplates, page);
            AddCommands(definition.Groups, page);

            Ribbon ribbon = SPRibbon.GetCurrent(page);
            ribbon.MakeTabAvailable(RibbonHelper.RibbonId(definition.Id));
            ribbon.InitialTabId = RibbonHelper.RibbonId(definition.Id);
        }

        #region Private functions

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

        private static void AddCommands(IEnumerable<GroupDefinition> groups, Page page)
        {

            List<IRibbonCommand> commands = groups
                .SelectMany(c => c.Controls)
                .WithDescendants(c => c.Controls)
                .Where(c => !String.IsNullOrEmpty(c.CommandName))
                .Select<ControlDefinition, IRibbonCommand>(b => new SPRibbonCommand(b.CommandName, b.CommandJavaScript, b.CommandEnableJavaScript)).ToList();

            ScriptLink.Register(page, "SP.Runtime.js", false, true);
            ScriptLink.Register(page, "SP.js", false, true);
            ScriptLink.Register(page, "CUI.js", false, true);
            ScriptLink.Register(page, "SP.Ribbon.js", false, true);

            SPRibbonScriptManager ribbonScriptManager = new SPRibbonScriptManager();

            ribbonScriptManager.RegisterGetCommandsFunction(page, "getGlobalCommands", commands);
            ribbonScriptManager.RegisterCommandEnabledFunction(page, "commandEnabled", commands);
            ribbonScriptManager.RegisterHandleCommandFunction(page, "handleCommand", commands);

            page.ClientScript.RegisterClientScriptBlock(
                page.GetType(), 
                "InitPageComponent",
                PageComponentScript.GetText("RibbonUtils"));

        }

        #endregion

    }
}
