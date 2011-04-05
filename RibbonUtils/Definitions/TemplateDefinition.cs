using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RibbonUtils.Definitions
{
    public class TemplateDefinition : RibbonDefinition
    {
        public string SizeId;
        public IEnumerable<string> SectionIds;
        internal Func<TemplateDefinition, string> GetXMLFunc;

        public string XML
        {
            get
            {
                return GetXMLFunc(this);
            }
        }
    }
}
