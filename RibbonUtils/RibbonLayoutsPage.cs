using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.SharePoint.WebControls;
using RibbonUtils.Definitions;

namespace RibbonUtils
{
    /// <summary>
    /// <para>
    /// This base class simplifies creation of Application Page with custom ribbon tab.
    /// </para>
    /// <para>
    /// You need to inherit from this class rather when from LayoutsPageBase, to use the functionality.
    /// Also, you should override the GetTabDefinition method and provide ribbon tab definition, using <see cref="TabDefinition"/> class.
    /// </para>
    /// </summary>
    public abstract class RibbonLayoutsPage : LayoutsPageBase
    {

        /// <summary>
        /// Provide ribbon tab definition.
        /// </summary>
        /// <returns>
        /// If you return null here, tab will not be shown.
        /// Overwise, the ribbon tab is created and activated when the page is displayed.
        /// </returns>
        public abstract TabDefinition GetTabDefinition();

        /// <summary>
        /// Adding ribbon tab to page here
        /// </summary>
        protected override void OnPreRender(EventArgs e)
        {
 	        base.OnPreRender(e);

            var tabDefinition = GetTabDefinition();
            if (tabDefinition != null && !this.DesignMode)
                RibbonController.Current.AddRibbonTabToPage(tabDefinition, this);
        }


    }
}
