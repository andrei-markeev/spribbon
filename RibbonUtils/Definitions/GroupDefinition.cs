using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RibbonUtils.Definitions
{
    /// <summary>
    /// Control group
    /// </summary>
    public class GroupDefinition : RibbonDefinition
    {
        /// <summary>
        /// Title. Will be displayed below the controls with small gray font.
        /// </summary>
        public string Title;

        /// <summary>
        /// Group description
        /// </summary>
        public string Description = string.Empty;

        /// <summary>
        /// Size identifier from <see cref="TemplateDefition"/>
        /// </summary>
        public object Size;
        
        /// <summary>
        /// Collection of inner controls
        /// </summary>
        public IEnumerable<ControlDefinition> Controls;

        /// <summary>
        /// Group template id. For standard templates, see <see cref="GroupTemplateLibrary"/>.
        /// </summary>
        public string Template;
    }
}
