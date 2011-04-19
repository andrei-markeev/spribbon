using System;
using System.Linq;
using System.ComponentModel;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using Microsoft.SharePoint;
using Microsoft.SharePoint.WebControls;
using FluentRibbon.Definitions;
using FluentRibbon.Libraries;
using FluentRibbon.Definitions.Controls;

namespace FluentRibbon.Elementary.WebParts
{
    [ToolboxItemAttribute(false)]
    public class RibbonWebPart : ContextualWebPart
    {
        // Visual Studio might automatically update this path when you change the Visual Web Part project item.
        private const string _ascxPath = @"~/_CONTROLTEMPLATES/FluentRibbon.Elementary/RibbonWebPart/RibbonWebPartUserControl.ascx";

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
                Title = "Ribbon Utils",
                Tabs = new TabDefinition[]
                {
                    new TabDefinition()
                    {
                        Id = "Tab1",
                        Title = "for SharePoint 2010",
                        Groups = new GroupDefinition[]
                        {
                            new GroupDefinition()
                            {
                                Id = "Group",
                                Title = "Three-row group",
                                Template = GroupTemplateLibrary.ThreeRowTemplate,
                                Controls = new ControlDefinition[]
                                {
                                    new LabelDefinition()
                                    {
                                        Id = "Label",
                                        Title = "Enter your data:",
                                        Image = new ImageDefinition() { Url16 = "/_layouts/images/wpedit.gif" },
                                        ForId = "TextBox"
                                    },
                                    new TextBoxDefinition()
                                    {
                                        Id = "TextBox"
                                    },
                                    new ButtonDefinition()
                                    {
                                        Id = "Button",
                                        Title = "Save!",
                                        Image = new ImageDefinition() { Url16 = "/_layouts/images/saveitem.gif" },
                                        CommandJavaScript = "alert('simple test')"
                                    }
                                }

                            }
                        }
                    },
                    new TabDefinition()
                    {
                        Id = "Tab2",
                        Title = "on CodePlex",
                        Groups = new GroupDefinition[]
                        {
                            new GroupDefinition()
                            {
                                Id = "Group",
                                Title = "Buttons group",
                                Template = GroupTemplateLibrary.SimpleTemplate,
                                Controls = new ControlDefinition[]
                                {
                                    new MRUSplitButtonDefinition()
                                    {
                                        Id = "MRUSplitButton",
                                        InitialItem = "Button1",
                                        Controls = new ControlDefinition[]
                                        {
                                            new ButtonDefinition()
                                            {
                                                Id = "Button1",
                                                Title = "MRU test 1",
                                                CommandJavaScript = "alert('mru test 1')",
                                                Image = new ImageDefinition() { Url32 = "/_layouts/images/gbsmpset.gif" }
                                            },
                                            new ButtonDefinition()
                                            {
                                                Id = "Button2",
                                                Title = "MRU test 2",
                                                CommandJavaScript = "alert('mru test 2')",
                                                Image = new ImageDefinition() { Url32 = "/_layouts/images/lg_ICASCX.gif" }
                                            }
                                        }
                                    },
                                    new SplitButtonDefinition()
                                    {
                                        Id = "SplitButton",
                                        Title = "Split button",
                                        Image = new ImageDefinition() { Url32 = "/_layouts/images/LG_DATASOURCE.gif" },
                                        CommandJavaScript = "alert('split test!')",
                                        Controls = new ControlDefinition[]
                                        {
                                            new ButtonDefinition()
                                            {
                                                Id = "Button1",
                                                Title = "Split test 1",
                                                CommandJavaScript = "alert('split test 1')",
                                                Image = new ImageDefinition() { Url32 = "/_layouts/images/lg_ICACCDB.gif" }
                                            },
                                            new ButtonDefinition()
                                            {
                                                Id = "Button2",
                                                Title = "Split test 2",
                                                CommandJavaScript = "alert('split test 2')",
                                                Image = new ImageDefinition() { Url32 = "/_layouts/images/lg_ICASAX.gif" }
                                            }
                                        }
                                    }
                                }

                            }
                        }
                    }
                }
            };

        }
    }
}
