using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RibbonUtils.Definitions
{
    /// <summary>
    /// Definition for ribbon tab
    /// </summary>
    public class TabDefinition : RibbonDefinition
    {
        /// <summary>
        /// Title, it will be displayed as the tab caption
        /// </summary>
        public string Title;

        /// <summary>
        /// Templates for control groups within the tab. See <see cref="GroupTemplateLibrary"/> for standard templates.
        /// </summary>
        public IEnumerable<TemplateDefinition> GroupTemplates;

        /// <summary>
        /// Groups of controls
        /// </summary>
        public IEnumerable<GroupDefinition> Groups;

        /// <summary>
        /// Description for the tab usage
        /// </summary>
        public object Description = string.Empty;
    }
}
