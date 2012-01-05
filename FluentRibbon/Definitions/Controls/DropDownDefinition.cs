using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace FluentRibbon.Definitions.Controls
{
    /// <summary>
    /// Dropdown control
    /// </summary>
    public class DropDownDefinition : VisualControlBaseDefinition, IContainer, IInitializable
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public DropDownDefinition()
        {
            base.Title = String.Empty;
        }

        internal override void AddAttributes(System.Xml.Linq.XElement controlElement)
        {
            base.AddAttributes(controlElement);
            controlElement.Add(new XAttribute("Width", Width.ToString() + "px"));
            controlElement.Attribute("LabelText").Remove();
        }

        internal override string Tag
        {
            get { return "DropDown"; }
        }

        /// <summary>
        /// Use this script to set up initial value for the drop down
        /// </summary>
        public string InitialValueJavaScript { get; set; }

        /// <summary>
        /// List of options inside the dropdown
        /// </summary>
        public IEnumerable<ControlDefinition> Controls { get; set; }

        /// <summary>
        /// Size of the controls
        /// </summary>
        public ControlSize ControlsSize { get; set; }

        /// <summary>
        /// Width of the dropdown in pixels. 75 by default.
        /// </summary>
        public int Width = 75;
    }
}
