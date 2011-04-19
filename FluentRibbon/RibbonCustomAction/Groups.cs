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
        /// Registers custom ribbon controls group for a list at specified SPWeb.
        /// </summary>
        /// <param name="groupDefinition">Definition of the ribbon group.</param>
        /// <param name="tabId">Id of parent tab for this group. For example, it could be "Ribbon.ListItem".</param>
        /// <param name="sequence">Sequence for the group, for positioning it within the tab.</param>
        public void AddControlGroup(GroupDefinition groupDefinition, string tabId, int sequence)
        {
            // bad code, really
            // TODO: refactoring

            string groupXML = XmlGenerator.Current.GetGroupXML(groupDefinition, sequence, tabId);

            var fragments = groupXML.Replace("<root>", "").Replace("</root>", "").Split(new string[] { "</Scaling>" }, StringSplitOptions.None);

            string scalingFragment = fragments[0].Replace("<Scaling", "<root") + "</root>";
            string groupFragment = fragments[1];

            RibbonXML =
                ConcatXML(RibbonXML, XmlGenerator.Current.GetCommandUIDefinitionXML(
                    tabId + ".Groups._children",
                    groupFragment));

            RibbonXML =
                ConcatXML(RibbonXML, XmlGenerator.Current.GetCommandUIDefinitionXML(
                    tabId + ".Scaling._children",
                    scalingFragment));

            RibbonCommandsXML = ConcatXML(RibbonCommandsXML, GetCommandsXML(groupDefinition));
        }

        /// <summary>
        /// Registers custom ribbon controls group for a list at specified SPWeb, replacing one of the existing groups.
        /// </summary>
        /// <param name="groupDefinition">Definition of the ribbon group.</param>
        /// <param name="oldGroupId">Valid existing ribbon control group id, for group which will be replaced.</param>
        /// <param name="sequence">Sequence for the group, for positioning it within the tab.</param>
        public void ReplaceControlGroup(GroupDefinition groupDefinition, string oldGroupId, int sequence)
        {
            // bad code, really
            // TODO: refactoring

            string groupXML = XmlGenerator.Current.GetGroupXML(groupDefinition, sequence, oldGroupId);

            var fragments = groupXML.Replace("<root>", "").Replace("</root>", "").Split(new string[] { "</Scaling>" }, StringSplitOptions.None);

            string scalingFragment = fragments[0].Replace("<Scaling", "<root") + "</root>";
            string groupFragment = fragments[1];

            RibbonXML =
                ConcatXML(RibbonXML, XmlGenerator.Current.GetCommandUIDefinitionXML(
                    oldGroupId,
                    groupFragment));

            RibbonXML =
                ConcatXML(RibbonXML, XmlGenerator.Current.GetCommandUIDefinitionXML(
                    oldGroupId.Substring(0, oldGroupId.LastIndexOf('.')) + ".Scaling._children",
                    scalingFragment));

            RibbonCommandsXML = ConcatXML(RibbonCommandsXML, GetCommandsXML(groupDefinition));
        }
    }
}
