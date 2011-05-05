using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

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
        public string RequiredField;

        /// <summary>
        /// ArrayElementsRequired
        /// </summary>
        public RibbonDefinition[] ArrayField;

        /// <summary>
        /// Range(1, 9)
        /// </summary>
        public int RangeField;

        /// <summary>
        /// RegularExpression("[A-Za-z]+")
        /// </summary>
        public string RegexField;

        /// <summary>
        /// Required + Range(10, 15)
        /// </summary>
        public int RequiredRangeField;
    }

}
