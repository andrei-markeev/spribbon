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
                Title = "Fluent Ribbon API",
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
                                Id = "Group1",
                                Title = "Textbox group",
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
                                        Id = "TextBox",
                                        InitialValueJavaScript = "return window.fluentTextBoxText || 'Hello from SPRibbon!';"
                                    },
                                    new ButtonDefinition()
                                    {
                                        Id = "Button",
                                        Title = "Save!",
                                        Image = new ImageDefinition() { Url16 = "/_layouts/images/saveitem.gif" },
                                        CommandJavaScript = "var value = document.getElementById('Ribbon.Tab1.Group1.TextBox').value; alert(value); window.fluentTextBoxText = value;"
                                    }
                                }

                            },

                            new GroupDefinition()
                            {
                                Id = "Group2",
                                Title = "Dropdown group",
                                Template = GroupTemplateLibrary.ThreeRowTemplate,
                                Controls = new ControlDefinition[]
                                {
                                    new LabelDefinition()
                                    {
                                        Id = "Label",
                                        Title = "Select your data:",
                                        Image = new ImageDefinition() { Url16 = "/_layouts/images/wpedit.gif" },
                                        ForId = "DropDown"
                                    },
                                    new DropDownDefinition()
                                    { 
                                        Id = "DropDown",
                                        InitialValueJavaScript = "return window.fluentDropDownSelectedItem || '';",
                                        ControlsSize = ControlSize.Size16x16,
                                        Controls = new ControlDefinition[]
                                        {
                                            new ButtonDefinition()
                                            {
                                                Id = "DropDownItem1",
                                                Title = "Choice 1",
                                                CommandJavaScript = "window.fluentDropDownSelectedItem = 'Choice 1'; SP.Ribbon.PageManager.get_instance().get_commandDispatcher().executeCommand(Commands.CommandIds.ApplicationStateChanged,null);"
                                            },
                                            new ButtonDefinition()
                                            {
                                                Id = "DropDownItem2",
                                                Title = "Choice 2",
                                                CommandJavaScript = "window.fluentDropDownSelectedItem = 'Choice 2'; SP.Ribbon.PageManager.get_instance().get_commandDispatcher().executeCommand(Commands.CommandIds.ApplicationStateChanged,null);"
                                            }
                                        }
                                    },
                                    new ButtonDefinition()
                                    {
                                        Id = "Button",
                                        Title = "Save!",
                                        Image = new ImageDefinition() { Url16 = "/_layouts/images/saveitem.gif" },
                                        CommandJavaScript = "alert(document.getElementById('Ribbon.Tab1.Group2.DropDown').parentElement.innerText);"
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
                                Id = "ToggleGroup",
                                Title = "Toggle group",
                                Template = GroupTemplateLibrary.SimpleTemplate,
                                Controls = new ControlDefinition[]
                                {
                                    new ToggleButtonDefinition()
                                    {
                                        Id = "ToggleButton1",
                                        Title = "Toggle button 1",
                                        Image = ImageLibrary.GetStandardImage(7,10),
                                        CommandJavaScript = "window._myFluentButtonToggled = 1; SP.Ribbon.PageManager.get_instance().get_commandDispatcher().executeCommand(Commands.CommandIds.ApplicationStateChanged,null);",
                                        InitialValueJavaScript = "return (window._myFluentButtonToggled || 1) == 1;"
                                    },
                                    new ToggleButtonDefinition()
                                    {
                                        Id = "ToggleButton2",
                                        Title = "Toggle button 2",
                                        Image = ImageLibrary.GetStandardImage(7,11),
                                        CommandJavaScript = "window._myFluentButtonToggled = 2; SP.Ribbon.PageManager.get_instance().get_commandDispatcher().executeCommand(Commands.CommandIds.ApplicationStateChanged,null);",
                                        InitialValueJavaScript = "return (window._myFluentButtonToggled || 1) == 2;"
                                    }
                                }

                            },
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
                                        CommandJavaScript = "alert('split test!'); document.getElementById('Ribbon.Tab2.Group.SplitButton-Large').style.display = 'none';",
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

                            },
                            new GroupDefinition()
                            {
                                Id = "StandardButtonsGroup",
                                Template = GroupTemplateLibrary.SimpleTemplate,
                                Title = "Standard buttons",
                                Controls = new ControlDefinition[]
                                {
                                    ControlLibrary.StandardButtons.ListItem.Actions_AttachFile("alert('this button looks like standard Attach button')"),
                                    ControlLibrary.StandardButtons.ListItem.Manage_ViewProperties("alert('this button looks like standard View properties button')"),
                                    ControlLibrary.StandardButtons.ListForm_Edit.Commit_Cancel("alert('this button looks like standard Cancel button')"),
                                    ControlLibrary.StandardButtons.ListForm_Edit.Actions_DeleteItem("alert('this button looks like standard Delete button')")
                                }
                            }

                        }
                    }
                }
            };

        }
    }
}
