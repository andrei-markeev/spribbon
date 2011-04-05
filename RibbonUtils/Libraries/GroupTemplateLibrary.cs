using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using RibbonUtils.Definitions;

namespace RibbonUtils.Libraries
{
    /// <summary>
    /// Library, which contains Ribbon Group Templates
    /// </summary>
    /// <remarks>
    /// Control groups in the Ribbon accumulate controls, such as buttons, menus, drop downs, and other stuff.
    /// Definining group template, you provide visual control composition.
    /// For example, in one group it could be one large button and three small ones.
    /// </remarks>
    public class GroupTemplateLibrary
    {
        /// <summary>
        /// This simple group template allows you create plain ribbon group with unspecified number of large (32x32 icons) controls inside.
        /// This group template contains only one control section.
        /// </summary>
        public static TemplateDefinition SimpleTemplate = new TemplateDefinition()
        {
            Id = "Ribbon.Templates.SimpleGroupTemplate",
            SizeId = "Large",
            SectionIds = new string[] { "o1" },
            GetXMLFunc = (TemplateDefinition definition) =>
                {
                    return new XDocument(
                        new XElement("GroupTemplate",
                            new XAttribute("Id", definition.Id),
                            new XElement("Layout",
                                new XAttribute("Title", definition.SizeId),
                                new XElement("OverflowSection",
                                    new XAttribute("Type", "OneRow"),
                                    new XAttribute("TemplateAlias", definition.SectionIds.First()),
                                    new XAttribute("DisplayMode", definition.SizeId)
                                    )
                                )
                            )).ToString();
                 }
        };
    }
}
