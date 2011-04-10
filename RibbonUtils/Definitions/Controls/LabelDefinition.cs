using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.ComponentModel.DataAnnotations;

namespace RibbonUtils.Definitions.Controls
{
    /// <summary>
    /// Label for another control
    /// </summary>
    public class LabelDefinition : VisualControlBaseDefinition
    {
        internal override void AddAttributes(XElement controlElement)
        {
            controlElement.Add(new XAttribute("ForId", this.NameSpace + "." + this.ForId));

            base.AddAttributes(controlElement);
        }

        internal override string Tag
        {
            get { return "Label"; }
        }

        /// <summary>
        /// Id of referenced control
        /// </summary>
        [Required]
        public string ForId;
    }
}
