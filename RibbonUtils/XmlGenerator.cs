using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RibbonUtils.Definitions;
using System.Xml.Linq;
using RibbonUtils.Definitions.Controls;

namespace RibbonUtils
{
    public class XmlGenerator
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

        private XElement GetTabElement(TabDefinition definition)
        {
            var tabElement =
                new XElement("Tab",
                    new XAttribute("Id", RibbonHelper.RibbonId(definition.Id)),
                    new XAttribute("Title", definition.Title),
                    new XAttribute("Description", definition.Description),
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
                groupIndex++;
                string groupId = RibbonHelper.RibbonId(definition.Id + "." + group.Id);

                tabElement.Element("Scaling").Add(
                    new XElement("MaxSize",
                        new XAttribute("Id", groupId + ".MaxSize"),
                        new XAttribute("GroupId", groupId),
                        new XAttribute("Size", group.Size)
                    ),
                    new XElement("Scale",
                        new XAttribute("Id", groupId + ".Scale"),
                        new XAttribute("GroupId", groupId),
                        new XAttribute("Size", group.Size)
                    ));

                XElement groupElement = new XElement("Group",
                        new XAttribute("Id", groupId),
                        new XAttribute("Title", group.Title),
                        new XAttribute("Description", group.Description),
                        new XAttribute("Sequence", groupIndex),
                        new XAttribute("Template", group.Template),
                        new XElement("Controls",
                            new XAttribute("Id", groupId + ".Controls")
                            )
                    );

                tabElement.Element("Groups").Add(groupElement);

                RecursiveAddControls(groupElement.Element("Controls"), group.Controls, groupId);

            }

            return tabElement;

        }

        /// <summary>
        /// Generates Ribbon XML based on ContextualGroupDefinition object
        /// </summary>
        /// <param name="definition"></param>
        /// <returns>XML for Ribbon, it can be used in RegisterDataExtension method of the SPRibbon object</returns>
        private XElement GetContextualGroupElement(ContextualGroupDefinition definition)
        {
            var tabElement = GetTabElement(definition.Tab);

            return new XElement("ContextualGroup",
                    new XAttribute("Color", "Yellow"),
                    new XAttribute("Command", definition.Command),
                    new XAttribute("Id", RibbonHelper.RibbonId(definition.Id)),
                    new XAttribute("Title", definition.Title),
                    new XAttribute("Sequence", "502"),
                    new XAttribute("ContextualGroupId", definition.Id),
                    tabElement
                );

        }

        private void RecursiveAddControls(XElement parent, IEnumerable<ControlDefinition> controls, string groupId)
        {
            int controlIndex = 0;
            foreach (ControlDefinition control in controls)
            {
                controlIndex++;
                var controlElement = new XElement(control.Type,
                        new XAttribute("Id", groupId + "." + control.Id),
                        new XAttribute("Sequence", controlIndex),
                        new XAttribute("LabelText", control.Title),
                        new XAttribute("Description", control.Description)
                        );
                parent.Add(controlElement);

                if (control.TemplateAlias != null)
                    controlElement.Add(new XAttribute("TemplateAlias", control.TemplateAlias));

                if (control.CommandName != null)
                    controlElement.Add(new XAttribute("Command", control.CommandName));

                if (!String.IsNullOrEmpty(control.ToolTipTitle))
                {
                    controlElement.Add(new XAttribute("ToolTipTitle", control.ToolTipTitle));
                    controlElement.Add(new XAttribute("ToolTipDescription", control.ToolTipDescription));
                }

                if (control.Image16Url != null)
                    controlElement.Add(new XAttribute("Image16by16", control.Image16Url));
                if (control.Image32Url != null)
                    controlElement.Add(new XAttribute("Image32by32", control.Image32Url));

                if (control.ImageX.HasValue)
                {
                    if (control.Image16Url != null)
                        controlElement.Add(new XAttribute("Image16by16Left", -control.ImageX.Value * 16));
                    if (control.Image32Url != null)
                        controlElement.Add(new XAttribute("Image32by32Left", -control.ImageX.Value * 32));
                }

                if (control.ImageY.HasValue)
                {
                    if (control.Image16Url != null)
                        controlElement.Add(new XAttribute("Image16by16Top", -control.ImageY.Value * 16));
                    if (control.Image32Url != null)
                        controlElement.Add(new XAttribute("Image32by32Top", -control.ImageY.Value * 32));
                }

                if (control.GetType() == typeof(FlyoutAnchorDefinition)
                    && control.Controls != null
                    && control.Controls.Count() > 0)
                {
                    string menuId = groupId + "." + control.Id + ".Menu";
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

                    RecursiveAddControls(controlsElement, control.Controls, sectionId);
                }

            }

        }

        #endregion
    }
}
