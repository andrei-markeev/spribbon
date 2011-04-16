using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RibbonUtils.Definitions;

namespace RibbonUtils
{
    public partial class RibbonCustomAction
    {
        /// <summary>
        /// Registers custom ribbon tab for a list at specified SPWeb.
        /// </summary>
        /// <param name="tabDefinition">Definition of the ribbon tab.</param>
        public void AddTab(TabDefinition tabDefinition)
        {
            RibbonXML =
                ConcatXML(RibbonXML, XmlGenerator.Current.GetCommandUIDefinitionXML(
                    "Ribbon.Tabs._children",
                    XmlGenerator.Current.GetTabXML(tabDefinition)));

            RibbonCommandsXML = ConcatXML(RibbonCommandsXML, GetCommandsXML(tabDefinition));
        }

        /// <summary>
        /// Registers custom ribbon tab for a list at specified SPWeb, replacing one of the existing tabs.
        /// </summary>
        /// <param name="tabDefinition">Definition of the ribbon tab.</param>
        /// <param name="oldTabId">Valid existing ribbon tab id, for tab which will be replaced.</param>
        public void ReplaceTab(TabDefinition tabDefinition, string oldTabId)
        {
            RibbonXML =
                ConcatXML(RibbonXML, XmlGenerator.Current.GetCommandUIDefinitionXML(
                    oldTabId,
                    XmlGenerator.Current.GetTabXML(tabDefinition)));

            RibbonCommandsXML = ConcatXML(RibbonCommandsXML, GetCommandsXML(tabDefinition));
        }
    }
}
