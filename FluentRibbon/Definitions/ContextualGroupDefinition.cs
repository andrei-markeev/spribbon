using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FluentRibbon.Definitions
{
    /// <summary>
    /// Contextual tab group
    /// </summary>
    public class ContextualGroupDefinition : RibbonDefinition
    {
        internal override void Validate()
        {
            base.Validate();
            ValidationHelper.Current.CheckNotNull(this, "Title");
            ValidationHelper.Current.CheckArrayHasElements(this, "Tabs");
        }

        /// <summary>
        /// Title. Will be shown above inner tabs. Required.
        /// </summary>
        public string Title;

        /// <summary>
        /// Color for the tab. By default it's yellow.
        /// </summary>
        public ContextualGroupColor Color = ContextualGroupColor.Yellow;
        
        /// <summary>
        /// Inner tabs. At least one tab is required.
        /// </summary>
        public TabDefinition[] Tabs;

    }
}
