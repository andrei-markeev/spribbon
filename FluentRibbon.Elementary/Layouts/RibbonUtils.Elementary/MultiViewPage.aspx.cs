using System;
using Microsoft.SharePoint;
using Microsoft.SharePoint.WebControls;
using FluentRibbon;
using FluentRibbon.Definitions;
using System.Web.UI;
using FluentRibbon.Libraries;
using FluentRibbon.Definitions.Controls;

namespace RibbonUtils.Elementary.Layouts.RibbonUtils.Elementary
{
    public partial class MultiViewPage : LayoutsPageBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                SwitchView(1);
            }
            else
            {
                var eventArgument = Request.Form["__EVENTARGUMENT"];
                int viewNumber;
                if (Int32.TryParse(eventArgument, out viewNumber))
                    SwitchView(viewNumber);
            }

            RibbonController.Current.AddRibbonTabToPage(GetTabDefinition(), this, true);
        }

        private void SwitchView(int viewNumber)
        {
            switch (viewNumber)
            {
                case 1:
                    MultiView.SetActiveView(View1);
                    break;
                case 2:
                    MultiView.SetActiveView(View2);
                    break;
                case 3:
                    MultiView.SetActiveView(View3);
                    break;
            }
        }

        public TabDefinition GetTabDefinition()
        {
            var updatePanelScript = Page.ClientScript.GetPostBackEventReference(MultiViewUpdatePanel, "{0}") + ";";
            var ribbonRefreshScript = "SP.Ribbon.PageManager.get_instance().get_commandDispatcher().executeCommand(Commands.CommandIds.ApplicationStateChanged, null);";
            return new TabDefinition()
            {
                Id = "Tab1",
                Title = "Toggle",
                Groups = new GroupDefinition[]
                {
                    new GroupDefinition()
                    {
                        Id = "Group1",
                        Title = "Switch view",
                        Template = GroupTemplateLibrary.SimpleTemplate,
                        Controls = new ControlDefinition[]
                        {
                            new ToggleButtonDefinition()
                            {
                                Id = "View1",
                                Title = "View 1",
                                Image = ImageLibrary.GetStandardImage(6,3),
                                InitialValueJavaScript = "return (window.fr_CurrentView || 1) == 1",
                                CommandJavaScript = "window.fr_CurrentView = 1;" + ribbonRefreshScript + String.Format(updatePanelScript, 1)
                            },
                            new ToggleButtonDefinition()
                            {
                                Id = "View2",
                                Title = "View 2",
                                Image = ImageLibrary.GetStandardImage(6,3),
                                InitialValueJavaScript = "return (window.fr_CurrentView || 1) == 2",
                                CommandJavaScript = "window.fr_CurrentView = 2;" + ribbonRefreshScript + String.Format(updatePanelScript, 2)
                            },
                            new ToggleButtonDefinition()
                            {
                                Id = "View3",
                                Title = "View 3",
                                Image = ImageLibrary.GetStandardImage(6,3),
                                InitialValueJavaScript = "return (window.fr_CurrentView || 1) == 3",
                                CommandJavaScript = "window.fr_CurrentView = 3;" + ribbonRefreshScript + String.Format(updatePanelScript, 3)
                            }
                        }
                    }
                }
            };
        }
    }
}
