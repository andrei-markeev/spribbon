using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FluentRibbon
{
    /// <summary>
    /// Display forms for a SharePoint list.
    /// Helper enumeration for <see cref="RibbonCustomAction"/> class Provision methods.
    /// </summary>
    public enum ListForms
    {
        /// <summary>
        /// View of the list
        /// </summary>
        ListView,

        /// <summary>
        /// New element creation
        /// </summary>
        NewForm,

        /// <summary>
        /// Edit existing list element
        /// </summary>
        EditForm,

        /// <summary>
        /// Display one item
        /// </summary>
        DisplayForm,

        /// <summary>
        /// All the forms
        /// </summary>
        All
    }
}
