using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using FluentRibbon.Definitions;
using FluentRibbon.Libraries;
using Microsoft.SharePoint;
using System.Collections.Generic;

namespace FluentRibbon.DelegateControl.ControlTemplates.FluentRibbon.DelegateControl
{
    public partial class RibbonControlTest : RibbonControl
    {
        public override bool DisplayTab
        {
            get
            {
                return !SPContext.Current.IsPopUI;
            }
        }

        public override TabDefinition GetTabDefinition()
        {
            var controls = new List<ControlDefinition>();
            controls.Add(ControlLibrary.CreateRandomButton());
            if (SPContext.Current.Web.CurrentUser.IsSiteAdmin)
                controls.Add(ControlLibrary.CreateRandomButton());

            return new TabDefinition()
            {
                Id = "CommonTasks",
                Title = "Common tasks",
                Groups = new GroupDefinition[]
                {
                    new GroupDefinition()
                    {
                        Id = "Sample",
                        Title = "Sample",
                        Template = GroupTemplateLibrary.SimpleTemplate,
                        Controls = controls.ToArray()
                    }
                }
            };
        }
    }
}
