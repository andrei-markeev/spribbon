using System;
using System.Linq;
using System.ComponentModel;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using Microsoft.SharePoint;
using Microsoft.SharePoint.WebControls;
using FluentRibbon;
using FluentRibbon.Definitions;
using FluentRibbon.Definitions.Controls;
using FluentRibbon.Libraries;

namespace ChessWebPart.VisualWebPart1
{
    [ToolboxItemAttribute(false)]
    public class VisualWebPart1 : ContextualWebPart
    {
        // Visual Studio might automatically update this path when you change the Visual Web Part project item.
        private const string _ascxPath = @"~/_CONTROLTEMPLATES/ChessWebPart/VisualWebPart1/VisualWebPart1UserControl.ascx";

        protected override void CreateChildControls()
        {
            Control control = Page.LoadControl(_ascxPath);
            Controls.Add(control);
        }

        public override ContextualGroupDefinition GetContextualGroupDefinition()
        {
            return new ContextualGroupDefinition()
            {
                Id = "GamesContextualGroup",
                Title = "Games",
                Tabs = new TabDefinition[]
                {
                    new TabDefinition()
                    {
                        Id = "GamesTab",
                        Title = "Chess",
                        Groups = new GroupDefinition[]
                        {
                            new GroupDefinition()
                            {
                                Id="Game",
                                Title="Game",
                                Template=GroupTemplateLibrary.SimpleTemplate,
                                Controls= new ControlDefinition[]
                                {
                                    new ButtonDefinition()
                                    {
                                        Id = "New",
                                        Title = "Start new game",
                                        CommandJavaScript = "window.location.reload();",
                                        Image = new ImageDefinition() 
                                        { 
                                            Url16 = "/_layouts/images/ChessWebPart/new16.png", 
                                            Url32 = "/_layouts/images/ChessWebPart/new32.png"
                                        }
                                    },
                                    new ButtonDefinition()
                                    {
                                        Id = "Undo",
                                        Title = "Undo last move",
                                        CommandJavaScript = "Gb();",
                                        Image = ImageLibrary.GetStandardImage(3,13)
                                    },
                                    new ButtonDefinition()
                                    {
                                        Id= "Swap",
                                        Title= "Swap sides",
                                        CommandJavaScript = "Rf(8-P);",
                                        Image = ImageLibrary.GetStandardImage(12,2)
                                    }
                                }

                            },

                            new GroupDefinition()
                            {
                                Id="Options",
                                Title="Options",
                                Template=GroupTemplateLibrary.SimpleTemplate,
                                Controls= new ControlDefinition[]
                                {
                                    new FlyoutAnchorDefinition()
                                    {
                                        Id="Promotion",
                                        Title="Promote",
                                        Image = new ImageDefinition()
                                        {
                                            Url16 = "/_layouts/images/ChessWebPart/promote16.png",
                                            Url32 = "/_layouts/images/ChessWebPart/promote32.png"
                                        },
                                        Controls = new ControlDefinition[]
                                        {
                                            new ButtonDefinition()
                                            {
                                                Id = "Queen",
                                                Title = "Queen",
                                                CommandJavaScript = "chessPromotion = 0; SP.UI.Notify.addNotification('Pawn now promotes to queen');",
                                                Image = new ImageDefinition() { Url32 = "/_layouts/images/ChessWebPart/5.gif" }
                                            },
                                            new ButtonDefinition()
                                            {
                                                Id = "Bishop",
                                                Title = "Bishop",
                                                CommandJavaScript = "chessPromotion = 1; SP.UI.Notify.addNotification('Pawn now promotes to bishop');",
                                                Image = new ImageDefinition() { Url32 = "/_layouts/images/ChessWebPart/4.gif" }
                                            },
                                            new ButtonDefinition()
                                            {
                                                Id = "Knight",
                                                Title = "Knight",
                                                CommandJavaScript = "chessPromotion = 2; SP.UI.Notify.addNotification('Pawn now promotes to knight');",
                                                Image = new ImageDefinition() { Url32 = "/_layouts/images/ChessWebPart/3.gif" }
                                            },
                                            new ButtonDefinition()
                                            {
                                                Id = "Rook",
                                                Title = "Rook",
                                                CommandJavaScript = "chessPromotion = 3; SP.UI.Notify.addNotification('Pawn now promotes to rook');",
                                                Image = new ImageDefinition() { Url32 = "/_layouts/images/ChessWebPart/2.gif" }
                                            }
                                        }
                                    },
                                    new FlyoutAnchorDefinition()
                                    {
                                        Id="Difficulty",
                                        Title = "Computer level",
                                        Image = ImageLibrary.GetStandardImage(5,9),
                                        Controls = new ControlDefinition[]
                                        {
                                            new ButtonDefinition()
                                            {
                                                Id = "Stupid",
                                                Title = "Stupid",
                                                CommandJavaScript = "chessDifficulty = 1; SP.UI.Notify.addNotification('Difficulty is set to easy!');"
                                            },
                                            new ButtonDefinition()
                                            {
                                                Id = "Middling",
                                                Title = "Middling",
                                                CommandJavaScript = "chessDifficulty = 2; SP.UI.Notify.addNotification('Difficulty is set to middle!');"
                                            },
                                            new ButtonDefinition()
                                            {
                                                Id = "Slow",
                                                Title = "Slow",
                                                CommandJavaScript = "chessDifficulty = 3; SP.UI.Notify.addNotification('Difficulty level is set to hard!');"
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
