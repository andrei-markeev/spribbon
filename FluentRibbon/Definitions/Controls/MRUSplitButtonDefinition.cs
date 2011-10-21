using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace FluentRibbon.Definitions.Controls
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

        internal override void Validate()
        {
            base.Validate();
            ValidationHelper.Current.CheckNotNull(this, "InitialItem");
            ValidationHelper.Current.CheckArrayHasElements(this, "Controls");
        }

        internal override string Tag
        {
            get { return "MRUSplitButton"; }
        }

        /// <summary>
        /// Initial button ID, this must be ID of one of inner controls. Required.
        /// </summary>
        public string InitialItem;

        /// <summary>
        /// Menu controls. At least one member is required.
        /// </summary>
        public IEnumerable<ControlDefinition> Controls { get; set; }


        /// <summary>
        /// Controls size. By default, 32x32
        /// </summary>
        public ControlSize ControlsSize { get; set; }

    }
}
