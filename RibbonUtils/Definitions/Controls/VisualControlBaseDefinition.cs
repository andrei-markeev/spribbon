using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.ComponentModel.DataAnnotations;

namespace RibbonUtils.Definitions.Controls
{
    /// <summary>
    /// Base class for all controls with visual look (with title and image)
    /// </summary>
    public abstract class VisualControlBaseDefinition : ControlDefinition
    {
        internal override void AddAttributes(XElement controlElement)
        {
            base.AddAttributes(controlElement);

            controlElement.Add(
                new XAttribute("LabelText", this.Title),
                new XAttribute("Description", this.Description)
                );

            if (!String.IsNullOrEmpty(this.ToolTipTitle))
            {
                controlElement.Add(new XAttribute("ToolTipTitle", this.ToolTipTitle));
                controlElement.Add(new XAttribute("ToolTipDescription", this.ToolTipDescription));
            }

            if (this.Image16Url != null)
                controlElement.Add(new XAttribute("Image16by16", this.Image16Url));
            if (this.Image32Url != null)
                controlElement.Add(new XAttribute("Image32by32", this.Image32Url));

            if (this.ImageX.HasValue)
            {
                if (this.Image16Url != null)
                    controlElement.Add(new XAttribute("Image16by16Left", -this.ImageX.Value * 16));
                if (this.Image32Url != null)
                    controlElement.Add(new XAttribute("Image32by32Left", -this.ImageX.Value * 32));
            }

            if (this.ImageY.HasValue)
            {
                if (this.Image16Url != null)
                    controlElement.Add(new XAttribute("Image16by16Top", -this.ImageY.Value * 16));
                if (this.Image32Url != null)
                    controlElement.Add(new XAttribute("Image32by32Top", -this.ImageY.Value * 32));
            }

        }

        /// <summary>
        /// Displayable title for control. Required.
        /// </summary>
        [Required]
        public string Title;

        /// <summary>
        /// Control description
        /// </summary>
        public string Description = string.Empty;

        /// <summary>
        /// Tooltip title
        /// </summary>
        public string ToolTipTitle;

        /// <summary>
        /// Tooltip text
        /// </summary>
        public string ToolTipDescription = string.Empty;

        /// <summary>
        /// Image url for 16x16 image
        /// </summary>
        public string Image16Url;

        /// <summary>
        /// Image url for 32x32 image
        /// </summary>
        public string Image32Url;

        /// <summary>
        /// X-coordinate for composite images (for example, for OOTB formatmap.png)
        /// </summary>
        public int? ImageX;

        /// <summary>
        /// Y-coordinate for composite images (for example, for OOTB formatmap.png)
        /// </summary>
        public int? ImageY;

    }
}
