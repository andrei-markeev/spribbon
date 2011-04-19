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
        /// Adds control to existing control group
        /// </summary>
        /// <param name="controlDefinition">Definition of ribbon control.</param>
        /// <param name="controlGroupId">Id of a control group, where the control will be inserted into. For example: "Ribbon.ListItem.New"</param>
        /// <param name="controlSequence">Sequence value for this control to position it inside the group.</param>
        public void AddControl(ControlDefinition controlDefinition, string controlGroupId, int controlSequence)
        {
            RibbonXML =
                ConcatXML(RibbonXML, XmlGenerator.Current.GetCommandUIDefinitionXML(
                    controlGroupId + ".Controls._children",
                    XmlGenerator.Current.GetControlXML(controlDefinition, controlSequence, controlGroupId)));

            RibbonCommandsXML = ConcatXML(RibbonCommandsXML, GetCommandsXML(controlDefinition));
        }

        /// <summary>
        /// Replaces control with custom one.
        /// </summary>
        /// <param name="controlDefinition">Definition of ribbon control.</param>
        /// <param name="controlId">Id of the old control, which will be replaced</param>
        /// <param name="controlSequence">Sequence value for this control to position it inside the group.</param>
        public void ReplaceControl(ControlDefinition controlDefinition, string controlId, int controlSequence)
        {
            RibbonXML =
                ConcatXML(RibbonXML, XmlGenerator.Current.GetCommandUIDefinitionXML(
                    controlId,
                    XmlGenerator.Current.GetControlXML(
                        controlDefinition,
                        controlSequence,
                        controlId.Substring(0, controlId.LastIndexOf('.'))
                        )));

            RibbonCommandsXML = ConcatXML(RibbonCommandsXML, GetCommandsXML(controlDefinition));
        }
    }
}
