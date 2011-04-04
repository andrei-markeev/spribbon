using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RibbonUtils
{
    public class TabDefinition
    {
        public string Id;
        public string Title;
        public IEnumerable<GroupDefinition> Groups;
        public object Description = string.Empty;
    }
}
