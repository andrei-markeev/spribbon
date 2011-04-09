using System;
using System.Linq;
using Microsoft.SharePoint;
using Microsoft.SharePoint.WebControls;

using RibbonUtils.Libraries;
using RibbonUtils.Definitions;
using RibbonUtils.Definitions.Controls;

namespace RibbonUtils.Elementary.Layouts
{
    public partial class RibbonPage : RibbonLayoutsPage
    {
        public override TabDefinition GetTabDefinition()
        {
            return new TabDefinition()
            {
                Id = "TestRibbon",
                Title = "Test",
                GroupTemplates = new TemplateDefinition[] { GroupTemplateLibrary.SimpleTemplate },
                Groups = new GroupDefinition[]
            {
                new GroupDefinition()
                {
                    Id = "TestGroup",
                    Title = "Test group",
                    Size = GroupTemplateLibrary.SimpleTemplate.SizeId,
                    Template = GroupTemplateLibrary.SimpleTemplate.Id,
                    Controls = new ControlDefinition[]
                    {
                        new ButtonDefinition()
                        {
                            Id = "TestButton",
                            Title = "Test button",
                            TemplateAlias = GroupTemplateLibrary.SimpleTemplate.SectionIds.First(),
                            CommandName = "TestCommand",
                            CommandJavaScript = "alert('test!');",
                            Image32Url = RibbonHelper.GetStandardImage32(),
                            ImageX = 6,
                            ImageY = 0
                        }
                    }
                }
            }

            };
        }
    }
}
