using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.UI.WebControls.WebParts;
using Microsoft.SharePoint.WebControls;
using System.Xml;
using FluentRibbon.Definitions;
using Microsoft.SharePoint;

namespace FluentRibbon
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

                WebPartManager webPartManager = WebPartManager.GetCurrentWebPartManager(this.Page);
                if (webPartManager.DisplayMode.Name != WebPartManager.BrowseDisplayMode.Name)
                    return info;

                var contextualGroupDefinition = GetContextualGroupDefinition();
                if (contextualGroupDefinition == null)
                    return info;

                WebPartRibbonContextualGroup contextualGroup = new WebPartRibbonContextualGroup();

                // Contextual group
                contextualGroup.Id = "Ribbon." + contextualGroupDefinition.Id;
                contextualGroup.Command = contextualGroupDefinition.Id + ".EnableContextualGroup";
                contextualGroup.VisibilityContext = contextualGroupDefinition.Id + ".CustomVisibilityContext";
                info.ContextualGroups.Add(contextualGroup);

                // Tabs
                foreach (TabDefinition tab in contextualGroupDefinition.Tabs)
                {
                    WebPartRibbonTab ribbonTab = new WebPartRibbonTab();
                    ribbonTab.Id = "Ribbon." + tab.Id;
                    ribbonTab.VisibilityContext = tab.Id + ".CustomVisibilityContext";
                    info.Tabs.Add(ribbonTab);
                }

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

            WebPartManager webPartManager = WebPartManager.GetCurrentWebPartManager(this.Page);
            if (webPartManager.DisplayMode.Name != WebPartManager.BrowseDisplayMode.Name)
                return;

            var contextualGroupDefinition = GetContextualGroupDefinition();
            if (contextualGroupDefinition == null)
                return;

            // Adds contextual tab (but does not shows it until webpart is not selected)
            RibbonController.Current.AddRibbonContextualTabToPage(contextualGroupDefinition, this.Page);
        }

    }
}
