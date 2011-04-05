using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RibbonUtils.Definitions
{
    public class TabDefinition : RibbonDefinition
    {
        public string Title;
        public IEnumerable<GroupDefinition> Groups;
        public object Description = string.Empty;
        public IEnumerable<TemplateDefinition> GroupTemplates;
    }
}
