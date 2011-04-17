using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RibbonUtils.Definitions.Controls;

namespace RibbonUtils.Libraries
{
    /// <summary>
    /// This library contains control definitions
    /// </summary>
    public class ControlLibrary
    {
        private static Random random;
        private static Random GetRandom()
        {
            if (random == null)
                random = new Random();
            return random;
        }

        /// <summary>
        /// Create random simple button control.
        /// This will use random standard image, random button caption and javascript notification action through SP.UI.Notify.
        /// </summary>
        /// <returns>Returns random button definition</returns>
        public static ButtonDefinition CreateRandomButton()
        {
            string id = GetRandom().Next(100, 999).ToString();

            return new ButtonDefinition()
            {
                Id = "Button" + id,
                Title = "Button #" + id,
                Image = ImageLibrary.GetStandardImage(GetRandom().Next(0, 15), GetRandom().Next(0, 15)),
                CommandJavaScript = "SP.UI.Notify.addNotification('hello from button #" + id + "!');"
            };
        }
    }
}
