using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentRibbon.Definitions;
using System.Xml.Linq;
using FluentRibbon.Definitions.Controls;
using Microsoft.SharePoint.WebControls;
using FluentRibbon.Commands;

namespace FluentRibbon
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


        internal string GetCommandUIExtensionXML(string definitionsXml, string commandXml, string templatesXml)
        {
            var parsedElements = ParseXml(definitionsXml);
            var commandElements = ParseXml(String.IsNullOrEmpty(commandXml) ? "<root></root>" : commandXml);
            var templateElements = ParseXml(String.IsNullOrEmpty(templatesXml) ? "<root></root>" : templatesXml);

            var document = new XDocument(
                new XElement("CommandUIExtension",
                    new XElement("CommandUIDefinitions")
                    )
                );

            document.Element("CommandUIExtension").Element("CommandUIDefinitions").Add(parsedElements);

            foreach (var templateElement in templateElements)
            {
                document.Element("CommandUIExtension").Element("CommandUIDefinitions").Add(
                    new XElement("CommandUIDefinition",
                        new XAttribute("Location", "Ribbon.Templates._children"),
                        templateElement));
            }

            if (!String.IsNullOrEmpty(commandXml))
                document.Element("CommandUIExtension").Add(
                    new XElement("CommandUIHandlers",
                        commandElements
                        ));


            return document.ToString();
        }

        internal string GetCommandUIDefinitionXML(string location, string definitionXml)
        {
            if (String.IsNullOrEmpty(definitionXml))
                return new XDocument(
                    new XElement("CommandUIDefinition",
                        new XAttribute("Location", location))).ToString();

            var parsedElements = ParseXml(definitionXml);

            var document = new XDocument(new XElement("root"));

            foreach (var parsedElement in parsedElements)
            {
                document.Element("root").Add(
                    new XElement("CommandUIDefinition",
                        new XAttribute("Location", location),
                        parsedElement
                    ));
            }

            return document.ToString();
        }

        internal string GetCommandUIHandlerXML(FluentRibbonCommand command)
        {
            return new XDocument(
                new XElement("CommandUIHandler",
                    new XAttribute("Command", command.Id),
                    new XAttribute("CommandAction", "javascript: " + command.HandlerStatement + ";"),
                    new XAttribute("EnabledScript", command.EnabledStatement))).ToString();
        }

        internal string GetContextualGroupXML(ContextualGroupDefinition definition)
        {
            definition.Validate();
            return new XDocument(GetContextualGroupElement(definition)).ToString();
        }

        internal string GetTabXML(TabDefinition definition)
        {
            definition.Validate();
            return new XDocument(GetTabElement(definition)).ToString();
        }

        internal string GetGroupXML(GroupDefinition definition, int sequence, string tabId)
        {
            definition.Validate();
            return new XDocument(GetGroupElement(definition, sequence, tabId)).ToString();
        }

        internal string GetControlXML(ControlDefinition definition, int sequence, string groupId)
        {
            definition.Validate();
            return new XDocument(GetControlElement(definition, sequence, groupId)).ToString();
        }

        #region Private methods

        /// <summary>
        /// Generates Ribbon XML based on ContextualGroupDefinition object
        /// </summary>
        /// <param name="definition"></param>
        /// <returns>XML for Ribbon, it can be used in RegisterDataExtension method of the SPRibbon object</returns>
        private XElement GetContextualGroupElement(ContextualGroupDefinition definition)
        {
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
                groupIndex++;
                
                var groupElement = GetGroupElement(group, groupIndex, "Ribbon." + definition.Id);

                tabElement.Element("Scaling").AddFirst(groupElement.Element("Scaling").Element("MaxSize"));
                tabElement.Element("Scaling").Add(groupElement.Element("Scaling").Element("Scaling"));
                tabElement.Element("Groups").Add(groupElement.Element("Group"));
            }

            return tabElement;

        }

        private XElement GetGroupElement(GroupDefinition definition, int groupIndex, string tabId)
        {
            // Setting up some calculated fields to all group controls, including inner
            foreach (var control in definition.Controls.WithDescendants(c => c is IContainer ? (c as IContainer).Controls : null))
            {
                control.ParentGroup = definition;
            }

            string groupId = tabId + "." + definition.Id;

            var scalingElement = new XElement("Scaling",
                new XAttribute("Id", tabId + ".Scaling"),
                new XElement("MaxSize",
                    new XAttribute("Id", groupId + ".MaxSize"),
                    new XAttribute("GroupId", groupId),
                    new XAttribute("Size", definition.Template.SizeId)
                ),
                new XElement("Scale",
                    new XAttribute("Id", groupId + ".Scale"),
                    new XAttribute("GroupId", groupId),
                    new XAttribute("Size", definition.Template.SizeId)
                )
                );

            var groupElement = new XElement("Group",
                    new XAttribute("Id", groupId),
                    new XAttribute("Title", definition.Title),
                    new XAttribute("Sequence", groupIndex),
                    new XAttribute("Template", definition.Template.Id),
                    new XElement("Controls",
                        new XAttribute("Id", groupId + ".Controls")
                        )
                );

            RecursiveAddControls(groupElement.Element("Controls"), definition.Controls, groupId);

            return new XElement("root", scalingElement, groupElement);
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

        private IEnumerable<XElement> ParseXml(string xml)
        {
            var parsedElements = XDocument.Parse(xml).Elements();
            if (parsedElements.First().Name == "root")
                parsedElements = parsedElements.First().Elements();
            return parsedElements;
        }

        #endregion

    }
}
