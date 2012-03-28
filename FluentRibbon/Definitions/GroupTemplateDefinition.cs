using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FluentRibbon.Definitions
{
    /// <summary>
    /// Control group template definition.
    /// </summary>
    public class GroupTemplateDefinition : RibbonDefinition
    {
        /// <summary>
        /// Id for size tags. This property is obsolete! Please, use <seealso cref="SizeIds"/> instead.
        /// </summary>
        [Obsolete("Please, use SizeIds array instead of SizeId property. This will allow you to add scaling to the ribbon.")]
        public string SizeId;

        /// <summary>
        /// Id for size tags. You will need this id when creating <see cref="GroupDefinition"/> instances.
        /// </summary>
        public IEnumerable<RibbonScales> SizeIds;

        /// <summary>
        /// Section ids for placing controls in. You should use this ids when creating <see cref="ControlDefinition"/> descendent classes instances.
        /// </summary>
        public IEnumerable<string> SectionIds;

        public Func<GroupTemplateDefinition, string> GetXMLFunc;
        internal string XML
        {
            get
            {
                return GetXMLFunc(this);
            }
        }
    }
}
