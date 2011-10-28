using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace FluentRibbon.Definitions.Controls
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
                new XAttribute("LabelText", this.Title)
                );

            if (this.ToolTip != null && !String.IsNullOrEmpty(this.ToolTip.Title))
            {
                controlElement.Add(new XAttribute("ToolTipTitle", this.ToolTip.Title));
                controlElement.Add(new XAttribute("ToolTipDescription", this.ToolTip.Description));
            }

            if (this.Image != null)
            {
                if (this.Image.Url16 != null)
                    controlElement.Add(new XAttribute("Image16by16", this.Image.Url16));
                if (this.Image.Url32 != null)
                    controlElement.Add(new XAttribute("Image32by32", this.Image.Url32));

                if (this.Image.X.HasValue)
                {
                    if (this.Image.Url16 != null)
                        controlElement.Add(new XAttribute("Image16by16Left", -this.Image.X.Value * 16));
                    if (this.Image.Url32 != null)
                        controlElement.Add(new XAttribute("Image32by32Left", -this.Image.X.Value * 32));
                }

                if (this.Image.Y.HasValue)
                {
                    if (this.Image.Url16 != null)
                        controlElement.Add(new XAttribute("Image16by16Top", -this.Image.Y.Value * 16));
                    if (this.Image.Url32 != null)
                        controlElement.Add(new XAttribute("Image32by32Top", -this.Image.Y.Value * 32));
                }
            }

        }

        internal override void Validate()
        {
            base.Validate();
            ValidationHelper.Current.CheckNotNull(this, "Title");
        }

        /// <summary>
        /// Displayable title for control. Required.
        /// </summary>
        public string Title;

        /// <summary>
        /// Control description
        /// </summary>
        [Obsolete("Description is dummy property, which never gets displayed. Use Tooltip.Description instead.")]
        public string Description = string.Empty;

        /// <summary>
        /// ToolTip
        /// </summary>
        public ToolTipDefinition ToolTip;

        /// <summary>
        /// Image that is displayed on the control
        /// </summary>
        public ImageDefinition Image;

    }
}
