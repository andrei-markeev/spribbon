using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FluentRibbon.Definitions.Controls
{
    /// <summary>
    /// Interface for all controls with inner elements
    /// </summary>
    public interface IContainer
    {
        /// <summary>
        /// Child controls of a container
        /// </summary>
        IEnumerable<ControlDefinition> Controls { get; set; }
    }
}
