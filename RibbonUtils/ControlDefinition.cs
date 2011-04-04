using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RibbonUtils
{
    public abstract class ControlDefinition
    {
        internal abstract string Type { get; }

        public string Id;
        public string Title;
        public string Description = string.Empty;
        public string ToolTipTitle;
        public string ToolTipDescription = string.Empty;
        public string Image16Url;
        public string Image32Url;
        public int? ImageX;
        public int? ImageY;
        public string TemplateAlias;
        public string CommandName;
        public string CommandJavaScript = string.Empty;
        public string CommandEnableJavaScript = "true";
        public IEnumerable<ControlDefinition> Controls;
    }
}
