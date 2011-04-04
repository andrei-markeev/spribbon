using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using RibbonUtils.ControlDefinitions;

namespace RibbonUtils
{
    /// <summary>
    /// Some helper functions for the ribbon
    /// </summary>
    public class RibbonHelper
    {
        /// <summary>
        /// Adds "Ribbon." prefix to Id parameter
        /// </summary>
        /// <param name="id">Ribbon element Id</param>
        /// <returns>Returns "Ribbon." + id</returns>
        public static string RibbonId(string id)
        {
            return "Ribbon." + id;
        }

        /// <summary>
        /// Generates Ribbon XML based on ContextualGroupDefinition object
        /// </summary>
        /// <param name="definition"></param>
        /// <returns>XML for Ribbon, it can be used in RegisterDataExtension method of the SPRibbon object</returns>
        public static string GetContextualGroupXML(ContextualGroupDefinition definition)
        {

            XDocument document =
            new XDocument(
                new XElement("ContextualGroup",
                    new XAttribute("Color", "Yellow"),
                    new XAttribute("Command", definition.Command),
                    new XAttribute("Id", RibbonId(definition.Id)),
                    new XAttribute("Title", definition.Title),
                    new XAttribute("Sequence", "502"),
                    new XAttribute("ContextualGroupId", definition.Id),
                    new XElement("Tab",
                        new XAttribute("Id", RibbonId(definition.Tab.Id)),
                        new XAttribute("Title", definition.Tab.Title),
                        new XAttribute("Description", definition.Tab.Description),
                        new XAttribute("Command", definition.Command),
                        new XAttribute("Sequence", "501"),
                        new XElement("Scaling",
                            new XAttribute("Id", RibbonId(definition.Tab.Id + ".Scaling"))
                        ),
                        new XElement("Groups",
                            new XAttribute("Id", RibbonId(definition.Tab.Id + ".Groups"))
                            )
                    )
                    )
                );

            int groupIndex = 0;
            foreach (GroupDefinition group in definition.Tab.Groups)
            {
                groupIndex++;
                string groupId = RibbonId(definition.Tab.Id + "." + group.Id);

                document.Element("ContextualGroup").Element("Tab").Element("Scaling").Add(
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
                        new XAttribute("Command", definition.Command),
                        new XAttribute("Sequence", groupIndex),
                        new XAttribute("Template", group.Template),
                        new XElement("Controls",
                            new XAttribute("Id", groupId + ".Controls")
                            )
                    );

                document.Element("ContextualGroup").Element("Tab").Element("Groups").Add(groupElement);

                RecursiveAddControls(groupElement.Element("Controls"), group.Controls, groupId);

            }

            return document.ToString();

        }

        private static void RecursiveAddControls(XElement parent, IEnumerable<ControlDefinition> controls, string groupId)
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

        /// <summary>
        /// Returns standard SharePoint image stack for 16x16 size (formatmap16x16.png)
        /// </summary>
        public static string GetStandardImage16()
        {
            return "/_layouts/1033/images/formatmap16x16.png";
        }

        /// <summary>
        /// Returns standard SharePoint image stack for 32x32 size (formatmap16x16.png)
        /// </summary>
        public static string GetStandardImage32()
        {
            return "/_layouts/1033/images/formatmap32x32.png";
        }

    }
}
