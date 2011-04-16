using RibbonUtils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Reflection;
using RibbonUtils.Definitions;
using System.ComponentModel.DataAnnotations;

namespace RibbonUtils.Tests
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
        [DeploymentItem("RibbonUtils.dll")]
        [ExpectedException(typeof(ValidationException))]
        public void CheckArrayTest1()
        {
            ValidationHelper_Accessor target = new ValidationHelper_Accessor();
            FieldInfo field = typeof(ValidationHelperTester).GetField("ArrayField");

            // ArrayField is null
            RibbonDefinition obj = new ValidationHelperTester();
            target.CheckArray(field, obj);

            Assert.Fail("Expected ValidationException was not thrown!");
        }

        [TestMethod()]
        [DeploymentItem("RibbonUtils.dll")]
        [ExpectedException(typeof(ValidationException))]
        public void CheckArrayTest2()
        {
            ValidationHelper_Accessor target = new ValidationHelper_Accessor();
            FieldInfo field = typeof(ValidationHelperTester).GetField("ArrayField");

            // ArrayField is empty array
            RibbonDefinition obj = new ValidationHelperTester() { ArrayField = new TabDefinition[] { } };
            target.CheckArray(field, obj);

            Assert.Fail("Expected ValidationException was not thrown!");
        }

        [TestMethod()]
        [DeploymentItem("RibbonUtils.dll")]
        public void CheckArrayTest3()
        {
            ValidationHelper_Accessor target = new ValidationHelper_Accessor();
            FieldInfo field = typeof(ValidationHelperTester).GetField("ArrayField");

            // ArrayField filled properly
            RibbonDefinition obj = new ValidationHelperTester() { ArrayField = new TabDefinition[] { new TabDefinition() } };
            target.CheckArray(field, obj);
        }

        #endregion

        #region RangeField tests

        [TestMethod()]
        [DeploymentItem("RibbonUtils.dll")]
        [ExpectedException(typeof(ValidationException))]
        public void CheckIntRangeTest1()
        {
            ValidationHelper_Accessor target = new ValidationHelper_Accessor();
            FieldInfo field = typeof(ValidationHelperTester).GetField("RangeField");
            
            // RangeField is null
            RibbonDefinition obj = new ValidationHelperTester();
            target.CheckIntRange(field, obj);

            Assert.Fail("Expected ValidationException was not thrown!");
        }

        [TestMethod()]
        [DeploymentItem("RibbonUtils.dll")]
        [ExpectedException(typeof(ValidationException))]
        public void CheckIntRangeTest2()
        {
            ValidationHelper_Accessor target = new ValidationHelper_Accessor();
            FieldInfo field = typeof(ValidationHelperTester).GetField("RangeField");

            // RangeField is outside of the range
            RibbonDefinition obj = new ValidationHelperTester() { RangeField = -1 };
            target.CheckIntRange(field, obj);

            Assert.Fail("Expected ValidationException was not thrown!");
        }

        [TestMethod()]
        [DeploymentItem("RibbonUtils.dll")]
        public void CheckIntRangeTest3()
        {
            ValidationHelper_Accessor target = new ValidationHelper_Accessor();
            FieldInfo field = typeof(ValidationHelperTester).GetField("RangeField");
            // RangeField is null
            RibbonDefinition obj = new ValidationHelperTester() { RangeField = 5 };
            target.CheckIntRange(field, obj);
        }

        #endregion

        #region RequiredField tests

        [TestMethod()]
        [DeploymentItem("RibbonUtils.dll")]
        [ExpectedException(typeof(ValidationException))]
        public void CheckRequiredTest1()
        {
            ValidationHelper_Accessor target = new ValidationHelper_Accessor();
            FieldInfo field = typeof(ValidationHelperTester).GetField("RequiredField");

            // RequiredField is null
            RibbonDefinition obj = new ValidationHelperTester();
            target.CheckRequired(field, obj);

            Assert.Fail("Expected ValidationException was not thrown!");
        }

        [TestMethod()]
        [DeploymentItem("RibbonUtils.dll")]
        public void CheckRequiredTest2()
        {
            ValidationHelper_Accessor target = new ValidationHelper_Accessor();
            FieldInfo field = typeof(ValidationHelperTester).GetField("RequiredField");

            // RequiredField is not null
            RibbonDefinition obj = new ValidationHelperTester() { RequiredField = String.Empty };
            target.CheckRequired(field, obj);

        }

        #endregion

        #region RegexField tests

        [TestMethod()]
        [DeploymentItem("RibbonUtils.dll")]
        [ExpectedException(typeof(ValidationException))]
        public void CheckRegularExpressionTest1()
        {
            ValidationHelper_Accessor target = new ValidationHelper_Accessor();
            FieldInfo field = typeof(ValidationHelperTester).GetField("RegexField");

            // RegexField is null
            RibbonDefinition obj = new ValidationHelperTester();
            target.CheckRegularExpression(field, obj);

            Assert.Fail("Expected ValidationException was not thrown!");
        }

        [TestMethod()]
        [DeploymentItem("RibbonUtils.dll")]
        [ExpectedException(typeof(ValidationException))]
        public void CheckRegularExpressionTest2()
        {
            ValidationHelper_Accessor target = new ValidationHelper_Accessor();
            FieldInfo field = typeof(ValidationHelperTester).GetField("RegexField");

            // RegexField has invalid characters
            RibbonDefinition obj = new ValidationHelperTester() { RegexField = "Bad.Test" };
            target.CheckRegularExpression(field, obj);

            Assert.Fail("Expected ValidationException was not thrown!");
        }

        [TestMethod()]
        [DeploymentItem("RibbonUtils.dll")]
        public void CheckRegularExpressionTest3()
        {
            ValidationHelper_Accessor target = new ValidationHelper_Accessor();
            FieldInfo field = typeof(ValidationHelperTester).GetField("RegexField");

            // RegexField is null
            RibbonDefinition obj = new ValidationHelperTester() { RegexField = "GoodTest" };
            target.CheckRegularExpression(field, obj);
        }

        [TestMethod()]
        [DeploymentItem("RibbonUtils.dll")]
        [ExpectedException(typeof(ValidationException))]
        public void CheckRegularExpressionTest4()
        {
            ValidationHelper_Accessor target = new ValidationHelper_Accessor();
            FieldInfo field = typeof(ValidationHelperTester).GetField("RegexField");

            // RegexField is null
            RibbonDefinition obj = new ValidationHelperTester() { RegexField = "Good Test" };
            target.CheckRegularExpression(field, obj);
        }

        #endregion

        #region RequiredRangeField tests (complex)

        [TestMethod()]
        [DeploymentItem("RibbonUtils.dll")]
        [ExpectedException(typeof(ValidationException))]
        public void ValidateOneFieldTest1()
        {
            ValidationHelper_Accessor target = new ValidationHelper_Accessor();
            FieldInfo field = typeof(ValidationHelperTester).GetField("RequiredRangeField");

            // RequiredRangeField is null
            RibbonDefinition obj = new ValidationHelperTester();
            target.ValidateOneField(field, obj);

            Assert.Fail("Expected ValidationException was not thrown!");
        }

        [TestMethod()]
        [DeploymentItem("RibbonUtils.dll")]
        [ExpectedException(typeof(ValidationException))]
        public void ValidateOneFieldTest2()
        {
            ValidationHelper_Accessor target = new ValidationHelper_Accessor();
            FieldInfo field = typeof(ValidationHelperTester).GetField("RequiredRangeField");

            // RequiredRangeField is not in range
            RibbonDefinition obj = new ValidationHelperTester() { RequiredRangeField = -1 };
            target.ValidateOneField(field, obj);

            Assert.Fail("Expected ValidationException was not thrown!");
        }


        [TestMethod()]
        [DeploymentItem("RibbonUtils.dll")]
        public void ValidateOneFieldTest3()
        {
            ValidationHelper_Accessor target = new ValidationHelper_Accessor();
            FieldInfo field = typeof(ValidationHelperTester).GetField("RequiredRangeField");

            // RequiredRangeField is ok
            RibbonDefinition obj = new ValidationHelperTester() { RequiredRangeField = 11 };
            target.ValidateOneField(field, obj);

        }

        #endregion

    }
}
