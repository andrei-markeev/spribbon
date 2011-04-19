using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FluentRibbon.Definitions
{
    /// <summary>
    /// ToolTip definition for ribbon controls. Is displayed automatically using SharePoint js &amp; style templates when mouse is over a control.
    /// </summary>
    public class ToolTipDefinition
    {

        /// <summary>
        /// Tooltip title
        /// </summary>
        public string Title = string.Empty;

        /// <summary>
        /// Tooltip text
        /// </summary>
        public string Description = string.Empty;

    }
}
