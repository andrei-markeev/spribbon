using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FluentRibbon.Definitions.Controls
{
    /// <summary>
    /// Textbox control
    /// </summary>
    public class TextBoxDefinition : ControlDefinition, IInitializable
    {
        internal override string Tag
        {
            get { return "TextBox"; }
        }

        
        /// <summary>
        /// The script, which should return the initial textbox value.
        /// </summary>
        /// <example>
        /// <para>Example of initialization code:</para>
        /// <code language="cs">
        /// var textBox = new TextBoxDefinition()
        /// {
        ///   Id = "TextBox1",
        ///   InitialValueJavaScript = "return 'Hello, world!';"
        /// }
        /// </code>
        /// </example>
        public string InitialValueJavaScript { get; set; }

    }
}
