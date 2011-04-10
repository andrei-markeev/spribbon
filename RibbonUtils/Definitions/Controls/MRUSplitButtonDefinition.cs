using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.ComponentModel.DataAnnotations;

namespace RibbonUtils.Definitions.Controls
{
    /// <summary>
    /// SplitButton, which is contains most recent clicked of it's inner buttons as the default button.
    /// So, MRUSplitButton is not a button itself, and don't have any visual elements
    /// </summary>
    public class MRUSplitButtonDefinition : ControlDefinition, IContainer
    {
        internal override void AddAttributes(XElement controlElement)
        {
            base.AddAttributes(controlElement);

            controlElement.Add(
                new XAttribute("Command", this.FullId + "MenuCommand"),
                new XAttribute("InitialItem", this.FullId + ".Menu.MainSection." + this.InitialItem)
                );
        }

        internal override string Tag
        {
            get { return "MRUSplitButton"; }
        }

        /// <summary>
        /// Initial button ID, this must be ID of one of inner controls. Required.
        /// </summary>
        [Required]
        public string InitialItem;

        /// <summary>
        /// Menu controls. At least one member is required.
        /// </summary>
        [ArrayElementsRequired]
        public IEnumerable<ControlDefinition> Controls { get; set; }
    }
}
