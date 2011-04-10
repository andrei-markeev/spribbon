using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace RibbonUtils.Definitions.Controls
{
    /// <summary>
    /// Abstract parent for any Button-like control
    /// </summary>
    public abstract class ButtonBaseDefinition : VisualControlBaseDefinition
    {
        internal override void AddAttributes(XElement controlElement)
        {
            base.AddAttributes(controlElement);

            if (!String.IsNullOrEmpty(this.CommandJavaScript))
                controlElement.Add(new XAttribute("Command", this.FullId + "Command"));

        }

        /// <summary>
        /// Javascript will be run when button is pressed.
        /// Required for all types of buttons.
        /// </summary>
        public string CommandJavaScript = string.Empty;

        /// <summary>
        /// Javascript to determine, if control is enabled or disabled.
        /// By default it is "true" (always enabled).
        /// </summary>
        public string CommandEnableJavaScript = "true";
    }
}
