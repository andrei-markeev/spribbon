using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FluentRibbon.Definitions
{
    /// <summary>
    /// Control group
    /// </summary>
    public class GroupDefinition : RibbonDefinition
    {
        internal override void Validate()
        {
            base.Validate();
            ValidationHelper.Current.CheckNotNull(this, "Title");
            ValidationHelper.Current.CheckNotNull(this, "Template");
            ValidationHelper.Current.CheckArrayHasElements(this, "Controls");
        }
        
        /// <summary>
        /// Title. Will be displayed below the controls with small gray font. Required.
        /// </summary>
        public string Title;

        /// <summary>
        /// Group template. For standard templates, see <see cref="Libraries.GroupTemplateLibrary"/>. Required.
        /// </summary>
        public GroupTemplateDefinition Template;
        
        /// <summary>
        /// Collection of inner controls
        /// </summary>
        public ControlDefinition[] Controls;

    }
}
