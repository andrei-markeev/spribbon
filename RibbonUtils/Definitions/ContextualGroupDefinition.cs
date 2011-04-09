using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
        public string Title;
        
        /// <summary>
        /// Inner tab
        /// </summary>
        public IEnumerable<TabDefinition> Tabs;
    }
}
