using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using FluentRibbon.Definitions;

namespace FluentRibbon.Tests
{
    /// <summary>
    /// Sample class for using with ValidationHelper
    /// </summary>
    class ValidationHelperTester : RibbonDefinition
    {
        /// <summary>
        /// Required
        /// </summary>
        [Required]
        public string RequiredField;

        /// <summary>
        /// ArrayElementsRequired
        /// </summary>
        [ArrayElementsRequired]
        public RibbonDefinition[] ArrayField;

        /// <summary>
        /// Range(1, 9)
        /// </summary>
        [Range(1, 9)]
        public int RangeField;

        /// <summary>
        /// RegularExpression("[A-Za-z]+")
        /// </summary>
        [RegularExpression("[A-Za-z]+")]
        public string RegexField;

        /// <summary>
        /// Required + Range(10, 15)
        /// </summary>
        [Required]
        [Range(10, 15)]
        public int RequiredRangeField;
    }

}
