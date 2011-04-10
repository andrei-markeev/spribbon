using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace RibbonUtils.Definitions
{
    /// <summary>
    /// Base class for all other definitions
    /// </summary>
    public abstract class RibbonDefinition
    {
        /// <summary>
        /// Validate required properties (marked with <see cref="RequiredAttribute"/>) 
        /// and throw an Exception if required data was not provided.
        /// </summary>
        internal virtual void Validate()
        {
            foreach (var field in this.GetType().GetFields())
            {
                ValidationHelper.Current.ValidateOneField(field, this);

                if (field.FieldType.IsArray)
                {
                    if (field.FieldType.GetElementType().IsSubclassOf(typeof(RibbonDefinition)))
                    {
                        foreach (var value in (field.GetValue(this) as IEnumerable<RibbonDefinition>))
                        {
                            value.Validate();
                        }
                    }
                }
                else if (field.FieldType.IsSubclassOf(typeof(RibbonDefinition)))
                {
                    (field.GetValue(this) as RibbonDefinition).Validate();
                }
            }
            
        }

        /// <summary>
        /// <para>Element identifier. It is required for every Ribbon element.</para>
        /// <para>
        /// Please, do not include namespace!
        /// Namespace is calculated automatically from parent elements' ids.
        /// Dots ('.') are not allowed within the Id.
        /// </para>
        /// </summary>
        [Required]
        [RegularExpression("[A-Za-z_][A-Za-z0-9]*")]
        public string Id;
    }
}
