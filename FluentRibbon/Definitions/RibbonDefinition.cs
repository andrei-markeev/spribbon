using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FluentRibbon.Definitions
{
    /// <summary>
    /// Base class for all other definitions
    /// </summary>
    public abstract class RibbonDefinition
    {
        internal virtual void Validate()
        {
            ValidationHelper.Current.CheckNotNull(this, "Id");
            ValidationHelper.Current.CheckRegularExpression(this, "Id", "[A-Za-z_][A-Za-z0-9_]*");
        }

        /// <summary>
        /// <para>Element identifier. It is required for every Ribbon element.</para>
        /// <para>
        /// Please, do not include namespace!
        /// Namespace is calculated automatically from parent elements' ids.
        /// Dots ('.') are not allowed within the Id.
        /// </para>
        /// </summary>
        public string Id;
    }
}
