using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RibbonUtils.Definitions.Controls
{
    /// <summary>
    /// Button with dropdown menu
    /// </summary>
    public class SplitButtonDefinition : ButtonBaseDefinition, IContainer
    {

        internal override string Tag
        {
            get { return "SplitButton"; }
        }

        /// <summary>
        /// Menu controls
        /// </summary>
        public IEnumerable<ControlDefinition> Controls { get; set; }
    }
}
