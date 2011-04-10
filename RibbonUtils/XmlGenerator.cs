using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RibbonUtils.Definitions;
using System.Xml.Linq;
using RibbonUtils.Definitions.Controls;

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

        internal string GetContextualGroupXML(ContextualGroupDefinition definition)
        {
            return new XDocument(GetContextualGroupElement(definition as ContextualGroupDefinition)).ToString();
        }

        internal string GetTabXML(TabDefinition definition)
        {
            return new XDocument(GetTabElement(definition as TabDefinition)).ToString();
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
                    new XAttribute("Id", RibbonHelper.RibbonId(definition.Id)),
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
                    new XAttribute("Id", RibbonHelper.RibbonId(definition.Id)),
                    new XAttribute("Title", definition.Title),
                    new XAttribute("Sequence", "501"),
                    new XElement("Scaling",
                        new XAttribute("Id", RibbonHelper.RibbonId(definition.Id + ".Scaling"))
                    ),
                    new XElement("Groups",
                        new XAttribute("Id", RibbonHelper.RibbonId(definition.Id + ".Groups"))
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
                
                string groupId = RibbonHelper.RibbonId(definition.Id + "." + group.Id);

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


        private void RecursiveAddControls(XElement parent, IEnumerable<ControlDefinition> controls, string groupId)
        {
            int controlIndex = 0;
            foreach (ControlDefinition control in controls)
            {
                control.NameSpace = groupId;

                controlIndex++;
                var controlElement = new XElement(control.Tag,
                        new XAttribute("Sequence", controlIndex)
                        );
                
                control.AddAttributes(controlElement);

                AddContainerAttributes(controlElement, control as IContainer, control.FullId);

                parent.Add(controlElement);
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
