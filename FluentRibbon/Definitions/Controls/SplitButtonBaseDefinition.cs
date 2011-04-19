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

        internal override string Tag
        {
            get { return "SplitButton"; }
        }

        /// <summary>
        /// Menu controls
        /// </summary>
        [ArrayElementsRequired]
        public IEnumerable<ControlDefinition> Controls { get; set; }
    }
}
