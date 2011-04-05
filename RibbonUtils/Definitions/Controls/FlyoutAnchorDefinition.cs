using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RibbonUtils.Definitions.Controls
{
    /// <summary>
    /// Anchor for dropdown menu.
    /// Does not have any action.
    /// Inner controls are required.
    /// </summary>
    public class FlyoutAnchorDefinition : ControlDefinition
    {
        internal override string Type
        {
            get { return "FlyoutAnchor"; }
        }
    }
}
