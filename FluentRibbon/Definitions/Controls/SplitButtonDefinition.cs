using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FluentRibbon.Definitions.Controls
{
    /// <summary>
    /// Button with dropdown menu
    /// </summary>
    public class SplitButtonDefinition : ButtonBaseDefinition, IContainer
    {
        internal override void Validate()
        {
            base.Validate();
            ValidationHelper.Current.CheckArrayHasElements(this, "Controls");
        }

        internal override string Tag
        {
            get { return "SplitButton"; }
        }

        /// <summary>
        /// Menu controls
        /// </summary>
        public IEnumerable<ControlDefinition> Controls { get; set; }

        /// <summary>
        /// Controls size. By default, 32x32
        /// </summary>
        public ControlSize ControlsSize { get; set; }

    }
}
