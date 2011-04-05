using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

using RibbonUtils.Definitions;
using RibbonUtils.Definitions.Controls;

namespace RibbonUtils
{
    /// <summary>
    /// Some helper functions for the ribbon
    /// </summary>
    public class RibbonHelper
    {

        /// <summary>
        /// Adds "Ribbon." prefix to Id parameter
        /// </summary>
        /// <param name="id">Ribbon element Id</param>
        /// <returns>Returns "Ribbon." + id</returns>
        public static string RibbonId(string id)
        {
            return "Ribbon." + id;
        }

        /// <summary>
        /// Returns standard SharePoint image stack for 16x16 size (formatmap16x16.png)
        /// </summary>
        public static string GetStandardImage16()
        {
            return "/_layouts/1033/images/formatmap16x16.png";
        }

        /// <summary>
        /// Returns standard SharePoint image stack for 32x32 size (formatmap16x16.png)
        /// </summary>
        public static string GetStandardImage32()
        {
            return "/_layouts/1033/images/formatmap32x32.png";
        }


    }
}
