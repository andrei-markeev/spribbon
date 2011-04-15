using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RibbonUtils.Definitions;
using System.Xml.Linq;
using RibbonUtils.Definitions.Controls;
using Microsoft.SharePoint.WebControls;

namespace RibbonUtils
{
    internal class XmlGenerator
    {
        #region Singleton

        private static XmlGenerator instance = null;

        public static XmlGenerator Current
        {
            get
            {
                if (instance == null)
                    instance = new XmlGenerator();

                return instance;
            }
        }

        private XmlGenerator()
        {
        }

        #endregion


        internal string GetCommandUIDefinitionXML(string location, string definitionXml, string commandXml)
        {
            var parsedElements = XDocument.Parse(definitionXml).Elements();
            var commandElements = XDocument.Parse(commandXml).Elements();

            var document = new XDocument(
                new XElement("CommandUIExtension",
                    new XElement("CommandUIDefinitions",
                        new XElement("CommandUIDefinition",
                            new XAttribute("Location", location),
                            parsedElements
                            )
                        )
                    )
                );

            if (!String.IsNullOrEmpty(commandXml))
                document.Element("CommandUIExtension").Add(
                    new XElement("CommandUIHandlers",
                        commandElements
                        ));


            return document.ToString();
        }

        internal string GetCommandUIHandlerXML(IRibbonCommand command)
        {
            return new XDocument(
                new XElement("CommandUIHandler",
                    new XAttribute("Command", command.Id),
                    new XAttribute("CommandAction", "javascript: " + command.HandlerStatement + ";"),
                    new XAttribute("EnabledScript", command.EnabledStatement))).ToString();
        }

        internal string GetContextualGroupXML(ContextualGroupDefinition definition)
        {
            return new XDocument(GetContextualGroupElement(definition)).ToString();
        }

        internal string GetTabXML(TabDefinition definition)
        {
            return new XDocument(GetTabElement(definition)).ToString();
        }

        internal string GetControlXML(ControlDefinition controlDefinition, int sequence, string groupId)
        {
            return new XDocument(GetControlElement(controlDefinition, sequence, groupId)).ToString();
        }

        #region Private methods

        /// <summary>
        /// Generates Ribbon XML based on ContextualGroupDefinition object
        /// </summary>
        /// <param name="definition"></param>
        /// <returns>XML for Ribbon, it can be used in RegisterDataExtension method of the SPRibbon object</returns>
        private XElement GetContextualGroupElement(ContextualGroupDefinition definition)
        {
            definition.Validate();

            var groupElement = new XElement("ContextualGroup",
                    new XAttribute("Color", definition.Color.ToString()),
                    new XAttribute("Command", definition.Id + ".EnableContextualGroup"),
                    new XAttribute("Id", "Ribbon." + definition.Id),
                    new XAttribute("Title", definition.Title),
                    new XAttribute("Sequence", "502"),
                    new XAttribute("ContextualGroupId", definition.Id)
                );

            foreach (TabDefinition tab in definition.Tabs)
            {
                groupElement.Add(GetTabElement(tab));
            }

            return groupElement;
        }
        private XElement GetTabElement(TabDefinition definition)
        {
            var tabElement =
                new XElement("Tab",
                    new XAttribute("Id", "Ribbon." + definition.Id),
                    new XAttribute("Title", definition.Title),
                    new XAttribute("Sequence", "501"),
                    new XElement("Scaling",
                        new XAttribute("Id", "Ribbon." + definition.Id + ".Scaling")
                    ),
                    new XElement("Groups",
                        new XAttribute("Id", "Ribbon." + definition.Id + ".Groups")
                        )
                );

            int groupIndex = 0;
            foreach (GroupDefinition group in definition.Groups)
            {
                // Setting up some calculated fields to all group controls, including inner
                foreach (var control in group.Controls.WithDescendants(c => c is IContainer ? (c as IContainer).Controls : null))
                {
                    control.ParentGroup = group;
                }
                
                groupIndex++;
                
                string groupId = "Ribbon." + definition.Id + "." + group.Id;

                tabElement.Element("Scaling").Add(
                    new XElement("MaxSize",
                        new XAttribute("Id", groupId + ".MaxSize"),
                        new XAttribute("GroupId", groupId),
                        new XAttribute("Size", group.Template.SizeId)
                    ),
                    new XElement("Scale",
                        new XAttribute("Id", groupId + ".Scale"),
                        new XAttribute("GroupId", groupId),
                        new XAttribute("Size", group.Template.SizeId)
                    ));

                XElement groupElement = new XElement("Group",
                        new XAttribute("Id", groupId),
                        new XAttribute("Title", group.Title),
                        new XAttribute("Sequence", groupIndex),
                        new XAttribute("Template", group.Template.Id),
                        new XElement("Controls",
                            new XAttribute("Id", groupId + ".Controls")
                            )
                    );

                tabElement.Element("Groups").Add(groupElement);

                RecursiveAddControls(groupElement.Element("Controls"), group.Controls, groupId);

            }

            return tabElement;

        }

        private XElement GetControlElement(ControlDefinition control, int controlIndex, string groupId)
        {
            var controlElement = new XElement(control.Tag,
                    new XAttribute("Sequence", controlIndex)
                    );
            
            control.NameSpace = groupId;
            control.AddAttributes(controlElement);

            AddContainerAttributes(controlElement, control as IContainer, control.FullId);

            return controlElement;
        }

        private void RecursiveAddControls(XElement parent, IEnumerable<ControlDefinition> controls, string groupId)
        {
            int controlIndex = 0;
            foreach (ControlDefinition control in controls)
            {
                controlIndex++;
                parent.Add(GetControlElement(control, controlIndex, groupId));
            }

        }

        private void AddContainerAttributes(XElement controlElement, IContainer container, string containerId)
        {
            if (container == null
                || container.Controls == null
                || container.Controls.Count() == 0)
                return;

            string menuId = containerId + ".Menu";
            string sectionId = menuId + ".MainSection";
            string controlsId = sectionId + ".Controls";

            var controlsElement = new XElement("Controls", new XAttribute("Id", controlsId));

            controlElement.Add(
                new XElement("Menu",
                    new XAttribute("Id", menuId),
                    new XElement("MenuSection",
                        new XAttribute("Id", sectionId),
                        new XAttribute("DisplayMode", "Menu32"),
                        controlsElement)
                ));

            RecursiveAddControls(controlsElement, container.Controls, sectionId);
        }

        #endregion

    }
}
