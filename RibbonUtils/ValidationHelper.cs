using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using RibbonUtils.Definitions;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace RibbonUtils
{
    internal class ValidationHelper
    {
        #region Singleton

        private static ValidationHelper instance = null;

        internal static ValidationHelper Current
        {
            get
            {
                if (instance == null)
                    instance = new ValidationHelper();

                return instance;
            }
        }

        private ValidationHelper()
        {

        }

        #endregion

        internal void ValidateOneField(FieldInfo field, RibbonDefinition obj)
        {
            CheckRequired(field, obj);

            if (field.FieldType == typeof(Int32))
                CheckIntRange(field, obj);

            if (field.FieldType == typeof(String))
                CheckRegularExpression(field, obj);

            if (field.FieldType.IsArray)
                CheckArray(field, obj);
        }

        private void CheckArray(FieldInfo field, RibbonDefinition obj)
        {
            var attribute = (ArrayElementsRequiredAttribute)field.GetCustomAttributes(typeof(ArrayElementsRequiredAttribute), false).FirstOrDefault();

            if (attribute != null)
            {
                var value = (IEnumerable<RibbonDefinition>)field.GetValue(obj);
                if (value == null || value.Count() == 0)
                    throw new ValidationException(
                        String.Format("{0}{1}: Validation failed! {2} is required to have at least one element.",
                            obj.GetType().Name,
                            obj.Id != null ? " (id='" + obj.Id + "')" : String.Empty,
                            field.Name
                            )
                        );
            }
        }

        private void CheckRequired(FieldInfo field, RibbonDefinition obj)
        {
            var attribute = field.GetCustomAttributes(typeof(RequiredAttribute), false).FirstOrDefault();

            if (attribute != null)
            {
                if (field.GetValue(obj).Equals(field.FieldType.IsValueType ? Activator.CreateInstance(field.FieldType) : null))
                    throw new ValidationException(
                        String.Format("{0}{1}: Validation failed! {2} is required.",
                            obj.GetType().Name,
                            obj.Id != null ? " (id='" + obj.Id + "')" : String.Empty,
                            field.Name
                            )
                        );
            }

        }

        private void CheckIntRange(FieldInfo field, RibbonDefinition obj)
        {
            var attribute = (RangeAttribute)field.GetCustomAttributes(typeof(RangeAttribute), false).FirstOrDefault();

            if (attribute != null)
            {
                int value = (int)field.GetValue(obj);
                if (value < Convert.ToInt32(attribute.Minimum) || value > Convert.ToInt32(attribute.Maximum))
                {
                    throw new ValidationException(
                        String.Format("{0}{1}: Validation failed! {2} has value {3}, which is outside of allowed range [{4}..{5}].",
                            obj.GetType().Name,
                            obj.Id != null ? " (id='" + obj.Id + "')" : String.Empty,
                            field.Name,
                            value,
                            Convert.ToInt32(attribute.Minimum),
                            Convert.ToInt32(attribute.Maximum)
                            )
                        );
                }
            }
        }

        private void CheckRegularExpression(FieldInfo field, RibbonDefinition obj)
        {
            var attribute = (RegularExpressionAttribute)field.GetCustomAttributes(typeof(RegularExpressionAttribute), false).FirstOrDefault();

            if (attribute != null)
            {
                string value = (string)field.GetValue(obj);
                if (value == null || !new Regex(attribute.Pattern).Match(value).Success)
                {
                    throw new ValidationException(
                        String.Format("{0}{1}: Validation failed! {2} has value '{3}', which doesn't match validation pattern '{4}'.",
                            obj.GetType().Name,
                            obj.Id != null ? " (id='" + obj.Id + "')" : String.Empty,
                            field.Name,
                            value == null ? String.Empty : value,
                            attribute.Pattern
                            )
                        );
                }

            }
        }
    }
}
