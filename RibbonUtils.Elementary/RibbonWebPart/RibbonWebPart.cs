using System;
using System.Linq;
using System.ComponentModel;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using Microsoft.SharePoint;
using Microsoft.SharePoint.WebControls;
using RibbonUtils.Definitions;
using RibbonUtils.Libraries;
using RibbonUtils.Definitions.Controls;

namespace RibbonUtils.Elementary.VisualWebPart1
{
    [ToolboxItemAttribute(false)]
    public class RibbonWebPart : ContextualWebPart
    {
        // Visual Studio might automatically update this path when you change the Visual Web Part project item.
        private const string _ascxPath = @"~/_CONTROLTEMPLATES/RibbonUtils.Elementary/RibbonWebPart/RibbonWebPartUserControl.ascx";

        protected override void CreateChildControls()
        {
            Control control = Page.LoadControl(_ascxPath);
            Controls.Add(control);
        }

        public override ContextualGroupDefinition GetContextualGroupDefinition()
        {
            return new ContextualGroupDefinition()
            {
                Id = "TestContextualGroup",
                Title = "Contextual actions",
                Tab = new TabDefinition()
                {
                    Id = "TestTab",
                    Title = "My tab",
                    GroupTemplates = new TemplateDefinition[] { GroupTemplateLibrary.SimpleTemplate },
                    Groups = new GroupDefinition[]
                {
                    new GroupDefinition()
                    {
                        Id = "TestControlGroup",
                        Title = "Buttons group",
                        Size = GroupTemplateLibrary.SimpleTemplate.SizeId,
                        Template = GroupTemplateLibrary.SimpleTemplate.Id,
                        Controls = new ControlDefinition[]
                        {
                            new ButtonDefinition()
                            {
                                Id = "TestButton",
                                Title = "Test alert",
                                Image32Url = "/_layouts/images/erroricon.png",
                                CommandName = "TestAlert",
                                CommandJavaScript = "alert('test')",
                                TemplateAlias = GroupTemplateLibrary.SimpleTemplate.SectionIds.First()
                            }
                        }

                    }
                }
                }
            };

        }
    }
}
