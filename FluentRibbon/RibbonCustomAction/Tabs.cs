using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentRibbon.Definitions;

namespace FluentRibbon
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
        /// <param name="oldTabId">Valid existing ribbon tab id, for tab which will be replaced. <seealso cref="SPRibbonIds"/></param>
        public void ReplaceTab(TabDefinition tabDefinition, string oldTabId)
        {
            RibbonXML =
                ConcatXML(RibbonXML, XmlGenerator.Current.GetCommandUIDefinitionXML(
                    oldTabId,
                    XmlGenerator.Current.GetTabXML(tabDefinition)));

            RibbonCommandsXML = ConcatXML(RibbonCommandsXML, GetCommandsXML(tabDefinition));
        }

        /// <summary>
        /// Adds custom tab to specified contextual tab group
        /// </summary>
        /// <param name="tabDefinition">Definition of the ribbon tab.</param>
        /// <param name="contextualGroupId">Valid existing ribbon contextual tab group id, inside which the tab will be added. <seealso cref="SPRibbonIds"/></param>
        public void AddTabToContextualGroup(TabDefinition tabDefinition, string contextualGroupId)
        {
            RibbonXML =
                ConcatXML(RibbonXML, XmlGenerator.Current.GetCommandUIDefinitionXML(
                    contextualGroupId + "._children",
                    XmlGenerator.Current.GetTabXML(tabDefinition)));

            RibbonCommandsXML = ConcatXML(RibbonCommandsXML, GetCommandsXML(tabDefinition));
        }
    }
}
