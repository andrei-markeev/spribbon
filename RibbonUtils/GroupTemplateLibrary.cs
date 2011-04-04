using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace RibbonUtils
{
    public class GroupTemplateLibrary
    {
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
