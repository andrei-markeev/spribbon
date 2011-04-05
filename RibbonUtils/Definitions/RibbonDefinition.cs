using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RibbonUtils.Definitions
{
    /// <summary>
    /// Base class for all other definitions
    /// </summary>
    public abstract class RibbonDefinition
    {
        /// <summary>
        /// Element unique identifier. It is required for every Ribbon element. Can contain dots ('.').
        /// </summary>
        public string Id;
    }
}
