using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RibbonUtils.Definitions
{
    /// <summary>
    /// Abstract class for all controls with inner elements
    /// </summary>
    public abstract class ContainerDefinition : ControlDefinition
    {
        /// <summary>
        /// Inner controls
        /// </summary>
        public IEnumerable<ControlDefinition> Controls;
    }
}
