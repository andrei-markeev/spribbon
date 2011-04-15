using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace RibbonUtils.Definitions
{
    /// <summary>
    /// Control group
    /// </summary>
    public class GroupDefinition : RibbonDefinition
    {
        /// <summary>
        /// Title. Will be displayed below the controls with small gray font. Required.
        /// </summary>
        [Required]
        public string Title;

        /// <summary>
        /// Group template. For standard templates, see <see cref="Libraries.GroupTemplateLibrary"/>. Required.
        /// </summary>
        [Required]
        public GroupTemplateDefinition Template;
        
        /// <summary>
        /// Collection of inner controls
        /// </summary>
        public ControlDefinition[] Controls;

    }
}
