using FluentRibbon;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Reflection;
using FluentRibbon.Definitions;

namespace FluentRibbon.Tests
{


    /// <summary>
    ///This is a test class for ValidationHelperTest and is intended
    ///to contain all ValidationHelperTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ValidationHelperTest
    {

        #region ArrayField tests

        [TestMethod()]
        [DeploymentItem("FluentRibbon.dll")]
        [ExpectedException(typeof(ValidationException))]
        public void CheckArrayTest1()
        {
            ValidationHelper_Accessor target = new ValidationHelper_Accessor();

            // ArrayField is null
            RibbonDefinition obj = new ValidationHelperTester();
            target.CheckArrayHasElements(obj, "ArrayField");

            Assert.Fail("Expected ValidationException was not thrown!");
        }

        [TestMethod()]
        [DeploymentItem("FluentRibbon.dll")]
        [ExpectedException(typeof(ValidationException))]
        public void CheckArrayTest2()
        {
            ValidationHelper_Accessor target = new ValidationHelper_Accessor();

            // ArrayField is empty array
            RibbonDefinition obj = new ValidationHelperTester() { ArrayField = new TabDefinition[] { } };
            target.CheckArrayHasElements(obj, "ArrayField");

            Assert.Fail("Expected ValidationException was not thrown!");
        }

        [TestMethod()]
        [DeploymentItem("FluentRibbon.dll")]
        public void CheckArrayTest3()
        {
            ValidationHelper_Accessor target = new ValidationHelper_Accessor();

            // ArrayField filled properly
            RibbonDefinition obj = new ValidationHelperTester() { ArrayField = new TabDefinition[] { new TabDefinition() } };
            target.CheckArrayHasElements(obj, "ArrayField");
        }

        #endregion

        #region RangeField tests

        [TestMethod()]
        [DeploymentItem("FluentRibbon.dll")]
        [ExpectedException(typeof(ValidationException))]
        public void CheckIntRangeTest1()
        {
            ValidationHelper_Accessor target = new ValidationHelper_Accessor();
            
            // RangeField is null
            RibbonDefinition obj = new ValidationHelperTester();
            target.CheckIntRange(obj, "RangeField", 1, 9);

            Assert.Fail("Expected ValidationException was not thrown!");
        }

        [TestMethod()]
        [DeploymentItem("FluentRibbon.dll")]
        [ExpectedException(typeof(ValidationException))]
        public void CheckIntRangeTest2()
        {
            ValidationHelper_Accessor target = new ValidationHelper_Accessor();

            // RangeField is outside of the range
            RibbonDefinition obj = new ValidationHelperTester() { RangeField = -1 };
            target.CheckIntRange(obj, "RangeField", 1, 9);

            Assert.Fail("Expected ValidationException was not thrown!");
        }

        [TestMethod()]
        [DeploymentItem("FluentRibbon.dll")]
        public void CheckIntRangeTest3()
        {
            ValidationHelper_Accessor target = new ValidationHelper_Accessor();
            // RangeField is in range
            RibbonDefinition obj = new ValidationHelperTester() { RangeField = 5 };
            target.CheckIntRange(obj, "RangeField", 1, 9);
        }

        #endregion

        #region RequiredField tests

        [TestMethod()]
        [DeploymentItem("FluentRibbon.dll")]
        [ExpectedException(typeof(ValidationException))]
        public void CheckRequiredTest1()
        {
            ValidationHelper_Accessor target = new ValidationHelper_Accessor();

            // RequiredField is null
            RibbonDefinition obj = new ValidationHelperTester();
            target.CheckNotNull(obj, "RequiredField");

            Assert.Fail("Expected ValidationException was not thrown!");
        }

        [TestMethod()]
        [DeploymentItem("FluentRibbon.dll")]
        public void CheckRequiredTest2()
        {
            ValidationHelper_Accessor target = new ValidationHelper_Accessor();

            // RequiredField is not null
            RibbonDefinition obj = new ValidationHelperTester() { RequiredField = String.Empty };
            target.CheckNotNull(obj, "RequiredField");

        }

        #endregion

        #region RegexField tests

        [TestMethod()]
        [DeploymentItem("FluentRibbon.dll")]
        [ExpectedException(typeof(ValidationException))]
        public void CheckRegularExpressionTest1()
        {
            ValidationHelper_Accessor target = new ValidationHelper_Accessor();

            // RegexField is null
            RibbonDefinition obj = new ValidationHelperTester();
            target.CheckRegularExpression(obj, "RegexField", "[A-Za-z]+");

            Assert.Fail("Expected ValidationException was not thrown!");
        }

        [TestMethod()]
        [DeploymentItem("FluentRibbon.dll")]
        [ExpectedException(typeof(ValidationException))]
        public void CheckRegularExpressionTest2()
        {
            ValidationHelper_Accessor target = new ValidationHelper_Accessor();

            // RegexField has invalid characters
            RibbonDefinition obj = new ValidationHelperTester() { RegexField = "Bad.Test" };
            target.CheckRegularExpression(obj, "RegexField", "[A-Za-z]+");

            Assert.Fail("Expected ValidationException was not thrown!");
        }

        [TestMethod()]
        [DeploymentItem("FluentRibbon.dll")]
        public void CheckRegularExpressionTest3()
        {
            ValidationHelper_Accessor target = new ValidationHelper_Accessor();

            // RegexField is null
            RibbonDefinition obj = new ValidationHelperTester() { RegexField = "GoodTest" };
            target.CheckRegularExpression(obj, "RegexField", "[A-Za-z]+");
        }

        [TestMethod()]
        [DeploymentItem("FluentRibbon.dll")]
        [ExpectedException(typeof(ValidationException))]
        public void CheckRegularExpressionTest4()
        {
            ValidationHelper_Accessor target = new ValidationHelper_Accessor();

            // RegexField is null
            RibbonDefinition obj = new ValidationHelperTester() { RegexField = "Good Test" };
            target.CheckRegularExpression(obj, "RegexField", "[A-Za-z]+");
        }

        #endregion

    }
}
