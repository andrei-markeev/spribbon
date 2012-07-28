using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using FluentRibbon.Definitions;

namespace FluentRibbon
{
    internal class ValidationHelper
    {
        #region Singleton
        private static ValidationHelper instance = new ValidationHelper();

        internal static ValidationHelper Current
        {
            get { return instance; }
        }

        private ValidationHelper()
        {
        }
        #endregion

        internal void CheckArrayHasElements(RibbonDefinition obj, string fieldName)
        {
            IEnumerable<RibbonDefinition> value;
            if (obj.GetType().GetMember(fieldName).First().MemberType == MemberTypes.Property)
                value = (IEnumerable<RibbonDefinition>)obj.GetType().GetProperty(fieldName).GetValue(obj, null);
            else
                value = (IEnumerable<RibbonDefinition>)obj.GetType().GetField(fieldName).GetValue(obj);

            if (value == null || value.Count() == 0)
            {
                throw new ValidationException(
                    String.Format("{0}{1}: Validation failed! {2} is required to have at least one element.",
                        obj.GetType().Name,
                        obj.Id != null ? " (id='" + obj.Id + "')" : String.Empty,
                        fieldName
                        )
                    );
            }
        }

        internal void CheckNotNull(RibbonDefinition obj, string fieldName)
        {
            object value = obj.GetType().GetField(fieldName).GetValue(obj);

            if (value == null)
            {
                throw new ValidationException(
                    String.Format("{0}{1}: Validation failed! {2} is required.",
                        obj.GetType().Name,
                        obj.Id != null ? " (id='" + obj.Id + "')" : String.Empty,
                        fieldName
                        )
                    );
            }

        }

        internal void CheckIntRange(RibbonDefinition obj, string fieldName, int minimum, int maximum)
        {
            int value = (int)obj.GetType().GetField(fieldName).GetValue(obj);

            if (value < minimum || value > maximum)
            {
                throw new ValidationException(
                    String.Format("{0}{1}: Validation failed! {2} has value {3}, which is outside of allowed range [{4}..{5}].",
                        obj.GetType().Name,
                        obj.Id != null ? " (id='" + obj.Id + "')" : String.Empty,
                        fieldName,
                        value,
                        minimum,
                        maximum
                        )
                    );
            }
        }

        internal void CheckRegularExpression(RibbonDefinition obj, string fieldName, string pattern)
        {
            string value = (string)obj.GetType().GetField(fieldName).GetValue(obj);

            if (!pattern.StartsWith("^"))
                pattern = "^" + pattern;

            if (!pattern.EndsWith("$"))
                pattern += "$";

            if (value == null || !new Regex(pattern).Match(value).Success)
            {
                throw new ValidationException(
                    String.Format("{0}{1}: Validation failed! {2} has value '{3}', which doesn't match validation pattern '{4}'.",
                        obj.GetType().Name,
                        obj.Id != null ? " (id='" + obj.Id + "')" : String.Empty,
                        fieldName,
                        value == null ? String.Empty : value,
                        pattern
                        )
                    );
            }
        }
    }
}
