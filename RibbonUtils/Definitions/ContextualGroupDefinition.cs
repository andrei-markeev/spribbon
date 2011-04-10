using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace RibbonUtils.Definitions
{
    /// <summary>
    /// Contextual tab group
    /// </summary>
    public class ContextualGroupDefinition : RibbonDefinition
    {

        /// <summary>
        /// Title. Will be shown above inner tabs
        /// </summary>
        [Required]
        public string Title;

        /// <summary>
        /// Color for the tab. By default it's yellow.
        /// </summary>
        public ContextualGroupColor Color = ContextualGroupColor.Yellow;
        
        /// <summary>
        /// Inner tabs
        /// </summary>
        [ArrayElementsRequired]
        public TabDefinition[] Tabs;

    }
}
