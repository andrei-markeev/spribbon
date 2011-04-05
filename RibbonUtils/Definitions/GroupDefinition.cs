using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RibbonUtils.Definitions
{
    public class GroupDefinition : RibbonDefinition
    {
        public string Title;
        public string Description = string.Empty;
        public object Size;
        public IEnumerable<ControlDefinition> Controls;
        public string Template;
    }
}
