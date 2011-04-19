using System;
using System.Linq;
using Microsoft.SharePoint;
using Microsoft.SharePoint.WebControls;

using FluentRibbon.Libraries;
using FluentRibbon.Definitions;
using FluentRibbon.Definitions.Controls;

namespace FluentRibbon.Elementary.Layouts
{
    public partial class RibbonPage : RibbonLayoutsPage
    {
        public override TabDefinition GetTabDefinition()
        {
            return new TabDefinition()
            {
                Id = "TestRibbon",
                Title = "Test",
                Groups = new GroupDefinition[]
                {
                    new GroupDefinition()
                    {
                        Id = "TestGroup",
                        Title = "Test group",
                        Template = GroupTemplateLibrary.SimpleTemplate,
                        Controls = new ControlDefinition[]
                        {
                            new ButtonDefinition()
                            {
                                Id = "TestButton",
                                Title = "Test button",
                                CommandJavaScript = "alert('test!');",
                                Image = ImageLibrary.GetStandardImage(6, 0)
                            }
                        }
                    }
                }

            };
        }
    }
}
