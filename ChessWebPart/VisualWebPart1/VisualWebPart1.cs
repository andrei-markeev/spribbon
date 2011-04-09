using System;
using System.Linq;
using System.ComponentModel;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using Microsoft.SharePoint;
using Microsoft.SharePoint.WebControls;
using RibbonUtils;
using RibbonUtils.Definitions;
using RibbonUtils.Definitions.Controls;
using RibbonUtils.Libraries;

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
                        GroupTemplates = new TemplateDefinition[] { GroupTemplateLibrary.SimpleTemplate },
                        Groups = new GroupDefinition[]
                        {
                            new GroupDefinition()
                            {
                                Id="Game",
                                Title="Game",
                                Description="",
                                Template=GroupTemplateLibrary.SimpleTemplate.Id,
                                Size=GroupTemplateLibrary.SimpleTemplate.SizeId,
                                Controls= new ControlDefinition[]
                                {
                                    new ButtonDefinition()
                                    {
                                        Id = "New",
                                        Title = "Start new game",
                                        Description = "Create new user",
                                        CommandName = "Chess.NewGame",
                                        CommandJavaScript = "window.location.reload();",
                                        Image16Url="/_layouts/images/ChessWebPart/new16.png",
                                        Image32Url="/_layouts/images/ChessWebPart/new32.png",
                                        TemplateAlias = GroupTemplateLibrary.SimpleTemplate.SectionIds.First()
                                    },
                                    new ButtonDefinition()
                                    {
                                        Id = "Undo",
                                        Title = "Undo last move",
                                        CommandName = "Chess.UndoMove",
                                        CommandJavaScript = "Gb();",
                                        Image16Url = RibbonHelper.GetStandardImage16(),
                                        Image32Url = RibbonHelper.GetStandardImage32(),
                                        ImageX = 3,
                                        ImageY = 13,
                                        TemplateAlias = GroupTemplateLibrary.SimpleTemplate.SectionIds.First()
                                    },
                                    new ButtonDefinition()
                                    {
                                        Id= "Swap",
                                        Title= "Swap sides",
                                        CommandName = "Chess.SwapSides",
                                        CommandJavaScript = "Rf(8-P);",
                                        Image16Url = RibbonHelper.GetStandardImage16(),
                                        Image32Url = RibbonHelper.GetStandardImage32(),
                                        ImageX = 12,
                                        ImageY = 2,
                                        TemplateAlias = GroupTemplateLibrary.SimpleTemplate.SectionIds.First()
                                    }
                                }

                            },

                            new GroupDefinition()
                            {
                                Id="Options",
                                Title="Options",
                                Description="",
                                Template=GroupTemplateLibrary.SimpleTemplate.Id,
                                Size=GroupTemplateLibrary.SimpleTemplate.SizeId,
                                Controls= new ControlDefinition[]
                                {
                                    new FlyoutAnchorDefinition()
                                    {
                                        Id="Promotion",
                                        Title="Promote",
                                        CommandName="SelectPromotion",
                                        Image16Url="/_layouts/images/ChessWebPart/promote16.png",
                                        Image32Url="/_layouts/images/ChessWebPart/promote32.png",
                                        TemplateAlias = GroupTemplateLibrary.SimpleTemplate.SectionIds.First(),
                                        Controls = new ControlDefinition[]
                                        {
                                            new ButtonDefinition()
                                            {
                                                Id = "Queen",
                                                Title = "Queen",
                                                CommandName = "PromoteQueen",
                                                CommandJavaScript = "chessPromotion = 0;",
                                                Image32Url = "/_layouts/images/ChessWebPart/5.gif"
                                            },
                                            new ButtonDefinition()
                                            {
                                                Id = "Bishop",
                                                Title = "Bishop",
                                                CommandName = "PromoteBishop",
                                                CommandJavaScript = "chessPromotion = 1;",
                                                Image32Url = "/_layouts/images/ChessWebPart/4.gif"
                                            },
                                            new ButtonDefinition()
                                            {
                                                Id = "Knight",
                                                Title = "Knight",
                                                CommandName = "PromoteKnight",
                                                CommandJavaScript = "chessPromotion = 2;",
                                                Image32Url = "/_layouts/images/ChessWebPart/3.gif"
                                            },
                                            new ButtonDefinition()
                                            {
                                                Id = "Rook",
                                                Title = "Rook",
                                                CommandName = "PromoteRook",
                                                CommandJavaScript = "chessPromotion = 3;",
                                                Image32Url = "/_layouts/images/ChessWebPart/2.gif"
                                            }
                                        }
                                    },
                                    new FlyoutAnchorDefinition()
                                    {
                                        Id="Difficulty",
                                        Title = "Computer level",
                                        Image16Url = RibbonHelper.GetStandardImage16(),
                                        Image32Url = RibbonHelper.GetStandardImage32(),
                                        ImageX = 5,
                                        ImageY = 9,
                                        TemplateAlias = GroupTemplateLibrary.SimpleTemplate.SectionIds.First(),
                                        Controls = new ControlDefinition[]
                                        {
                                            new ButtonDefinition()
                                            {
                                                Id = "Stupid",
                                                Title = "Stupid",
                                                CommandName = "StupidDifficulty",
                                                CommandJavaScript = "chessDifficulty = 1;"
                                            },
                                            new ButtonDefinition()
                                            {
                                                Id = "Middling",
                                                Title = "Middling",
                                                CommandName = "MiddlingDifficulty",
                                                CommandJavaScript = "chessDifficulty = 2;"
                                            },
                                            new ButtonDefinition()
                                            {
                                                Id = "Slow",
                                                Title = "Slow",
                                                CommandName = "SlowDifficulty",
                                                CommandJavaScript = "chessDifficulty = 3;"
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
