using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RibbonUtils
{
    public class TemplateDefinition
    {
        public string Id;
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
