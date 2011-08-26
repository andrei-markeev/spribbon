using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.ComponentModel.DataAnnotations;
using FluentRibbon.Definitions.Controls;

namespace FluentRibbon.Definitions
{
    /// <summary>
    /// Abstract parent class for all concrete control definition
    /// </summary>
    public abstract class ControlDefinition : RibbonDefinition
    {
        /// <summary>
        /// Tag for a concrete control
        /// </summary>
        internal abstract string Tag { get; }

        /// <summary>
        /// This procedure generates XML elements for all the fields of the class,
        /// and also can provide some extra elements, which are calculated automatically.
        /// </summary>
        internal virtual void AddAttributes(XElement controlElement)
        {

            controlElement.Add(new XAttribute("Id", FullId));

            if (this is IInitializable)
            {
                controlElement.Add(new XAttribute("Command", FullId + "Command"));
                controlElement.Add(new XAttribute("QueryCommand", FullId + "QueryCommand"));
            }

            if (FullId.EndsWith("Menu.MainSection." + this.Id))
            {
                controlElement.Add(
                    new XAttribute("MenuItemId", FullId),
                    new XAttribute("CommandValueId", FullId + "Command")
                    );
            }
            else
            {
                if (this.TemplateAlias != null)
                    controlElement.Add(new XAttribute("TemplateAlias", this.TemplateAlias));
                else
                    if (this.ParentGroup == null)
                        throw new ValidationException(
                            String.Format("Control {0}{1}: you need to set TemplateAlias property manually for detached from group control.",
                                this.GetType().Name,
                                this.Id != null ? " (Id='" + this.Id + "')" : String.Empty)
                            );
                    else
                        controlElement.Add(new XAttribute("TemplateAlias", this.ParentGroup.Template.SectionIds.First()));
            }

        }

        /// <summary>
        /// Namespace for Id. Is calculated automatically in XmlGenerator
        /// </summary>
        internal string NameSpace;

        /// <summary>
        /// Parent tab for this control. It is filled in XmlGenerator
        /// </summary>
        internal GroupDefinition ParentGroup;

        /// <summary>
        /// Id with namespace. Is calculated automatically in XmlGenerator
        /// </summary>
        internal string FullId
        {
            get
            {
                return NameSpace + "." + Id;
            }
        }

        /// <summary>
        /// <para>
        /// A string that matches the value of the TemplateAlias attribute 
        /// for a ControlRef element, an OverflowArea element, or an OverflowSection element in a GroupTemplate element. 
        /// The TemplateAlias attribute is used to size and position controls within a group 
        /// when a template is applied to the group.
        /// </para>
        /// <para>
        /// If you use standard templates from <see cref="Libraries.GroupTemplateLibrary"/>, or your own templates
        /// with single section, you can leave this field blank to use first alias of the template.
        /// </para>
        /// <para>
        /// For inner controls (for instance, inside SplitButton control) this field is ignored.
        /// </para>
        /// </summary>
        public string TemplateAlias;

    }
}
