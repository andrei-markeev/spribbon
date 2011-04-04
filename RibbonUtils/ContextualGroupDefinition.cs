using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RibbonUtils
{
    public class ContextualGroupDefinition
    {
        public string Id;
        public string Title;
        public string Command;
        public TabDefinition Tab;
        public IEnumerable<TemplateDefinition> GroupTemplates;
    }
}
