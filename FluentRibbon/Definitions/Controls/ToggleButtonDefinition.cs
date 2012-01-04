using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FluentRibbon.Definitions.Controls
{
    /// <summary>
    /// Button which can toggle its current state from "Turned off" to "Turned on" and vice versa.
    /// </summary>
    public class ToggleButtonDefinition : ButtonBaseDefinition, IInitializable
    {
        internal override string Tag
        {
            get { return "ToggleButton"; }
        }

        /// <summary>
        /// The script, which should return the initial state of the ToggleButton (true for ON, false for OFF).
        /// </summary>
        public string InitialValueJavaScript { get; set; }
    }
}
