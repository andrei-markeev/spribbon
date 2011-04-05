using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.UI.WebControls.WebParts;
using Microsoft.SharePoint.WebControls;
using System.Xml;
using RibbonUtils.Definitions;

namespace RibbonUtils
{
    /// <summary>
    /// <para>
    /// Contextual webpart base class simplifies creation of webparts with contextual ribbon tabs.
    /// </para>
    /// <para>
    /// All you need to use this mechanism is to inherit from ContextualWebPart and override GetContextualGroupDefinition property.
    /// </para>
    /// </summary>
    public abstract class ContextualWebPart : WebPart, IWebPartPageComponentProvider
    {
        /// <summary>
        /// Return contextual group definition for the webpart here
        /// </summary>
        /// <remarks>
        /// If you return null, contextual tab will not be shown
        /// </remarks>
        public abstract ContextualGroupDefinition GetContextualGroupDefinition();

        /// <summary>
        /// IWebPartPageComponentProvider realization
        /// </summary>
        public WebPartContextualInfo WebPartContextualInfo
        {
            get
            {
                WebPartContextualInfo info = new WebPartContextualInfo();

                var contextualGroupDefinition = GetContextualGroupDefinition();
                if (contextualGroupDefinition == null)
                    return info;

                WebPartRibbonContextualGroup contextualGroup = new WebPartRibbonContextualGroup();
                WebPartRibbonTab ribbonTab = new WebPartRibbonTab();

                //Create the contextual group object and initialize its values.
                contextualGroup.Id = RibbonHelper.RibbonId(contextualGroupDefinition.Id);
                contextualGroup.Command = contextualGroupDefinition.Id + ".EnableContextualGroup";
                contextualGroup.VisibilityContext = contextualGroupDefinition.Id + ".CustomVisibilityContext";

                //Create the tab object and initialize its values.
                ribbonTab.Id = RibbonHelper.RibbonId(contextualGroupDefinition.Tab.Id);
                ribbonTab.VisibilityContext = contextualGroupDefinition.Tab.Id + ".CustomVisibilityContext";

                //Add the contextual group and tab to the WebPartContextualInfo.
                info.ContextualGroups.Add(contextualGroup);
                info.Tabs.Add(ribbonTab);
                info.PageComponentId = SPRibbon.GetWebPartPageComponentId(this);

                return info;
            }
        }

        /// <summary>
        /// Adding ribbon tab to page here
        /// </summary>
        protected override void OnPreRender(EventArgs e)
        {
            base.OnPreRender(e);

            var contextualGroupDefinition = GetContextualGroupDefinition();
            if (contextualGroupDefinition == null)
                return;

            // Adds contextual tab (but does not shows it until webpart is not selected)
            RibbonController.Current.AddRibbonContextualTabToPage(contextualGroupDefinition, this.Page);
        }

    }
}
