﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RibbonUtils.Definitions.Controls
{
    /// <summary>
    /// Anchor for dropdown menu.
    /// Does not have any action on click.
    /// </summary>
    public class FlyoutAnchorDefinition : VisualControlBaseDefinition, IContainer
    {
        internal override string Tag
        {
            get { return "FlyoutAnchor"; }
        }

        /// <summary>
        /// Menu controls
        /// </summary>
        public IEnumerable<ControlDefinition> Controls { get; set; }

    }
}
