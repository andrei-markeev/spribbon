using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using FluentRibbon.Libraries;

namespace FluentRibbon.Definitions
{
    /// <summary>
    /// Definition for a ribbon tab
    /// </summary>
    public class TabDefinition : RibbonDefinition
    {
        /// <summary>
        /// Title, it will be displayed as the tab caption.
        /// </summary>
        [Required]
        public string Title;

        /// <summary>
        /// <para>Templates for control groups within the tab.</para>
        /// <para>By default, it equals to <see cref="GroupTemplateLibrary.AllTemplates"/>.</para>
        /// </summary>
        [ArrayElementsRequired]
        public GroupTemplateDefinition[] GroupTemplates = GroupTemplateLibrary.AllTemplates;

        /// <summary>
        /// Groups of controls. Required at least one group.
        /// </summary>
        [ArrayElementsRequired]
        public GroupDefinition[] Groups;
    }
}
