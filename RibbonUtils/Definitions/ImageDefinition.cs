using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RibbonUtils.Definitions
{
    /// <summary>
    /// Definition for image, which is embedded into button or another ribbon control.
    /// You can use <see cref="Libraries.ImageLibrary"/> for some standard SharePoint images.
    /// </summary>
    public class ImageDefinition
    {
        /// <summary>
        /// Url for 32x32 image thumbnail
        /// </summary>
        public string Url32;

        /// <summary>
        /// Url for 16x16 image thumbnail
        /// </summary>
        public string Url16;

        /// <summary>
        /// X-coordinate for composite images (for example, for OOTB formatmap.png)
        /// </summary>
        public int? X;

        /// <summary>
        /// Y-coordinate for composite images (for example, for OOTB formatmap.png)
        /// </summary>
        public int? Y;
    }
}
