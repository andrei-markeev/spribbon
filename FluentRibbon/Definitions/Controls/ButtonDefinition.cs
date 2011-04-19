using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FluentRibbon.Definitions.Controls
{
    /// <summary>
    /// Simple button. Does not have inner controls.
    /// </summary>
    public class ButtonDefinition : ButtonBaseDefinition
    {
        internal override string Tag
        {
            get { return "Button"; }
        }
    }
}
