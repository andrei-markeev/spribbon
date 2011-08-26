using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FluentRibbon.Definitions.Controls
{
    /// <summary>
    /// Interface for all controls those have a value or a state, which can be initialized (for example, TextBox)
    /// </summary>
    public interface IInitializable
    {
        /// <summary>
        /// Command, which should initialize the control value or state
        /// </summary>
        string InitialValueJavaScript { get; set; }
    }
}
