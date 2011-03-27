// <auto-generated />
namespace IronJS.Tests.UnitTests.Sputnik.Conformance.NativeECMAScriptObjects.TheMathObject.FunctionPropertiesOfTheMathObject
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class AsinTests : SputnikTestFixture
    {
        public AsinTests()
            : base(@"Conformance\15_Native_ECMA_Script_Objects\15.8_The_Math_Object\15.8.2_Function_Properties_of_the_Math_Object\15.8.2.3_asin")
        {
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.8.2.3")]
        [Description("If x is NaN, Math.asin(x) is NaN")]
        public void S15_8_2_3_A1()
        {
            RunFile(@"S15.8.2.3_A1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.8.2.3")]
        [Description("If x is greater than 1, Math.asin(x) is NaN")]
        public void S15_8_2_3_A2()
        {
            RunFile(@"S15.8.2.3_A2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.8.2.3")]
        [Description("If x is less than -1, Math.asin(x) is NaN")]
        public void S15_8_2_3_A3()
        {
            RunFile(@"S15.8.2.3_A3.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.8.2.3")]
        [Description("If x is +0, Math.asin(x) is +0")]
        public void S15_8_2_3_A4()
        {
            RunFile(@"S15.8.2.3_A4.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.8.2.3")]
        [Description("If x is -0, Math.asin(x) is -0")]
        public void S15_8_2_3_A5()
        {
            RunFile(@"S15.8.2.3_A5.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.8.2.3")]
        [Description("Math.asin, recommended that implementations use the approximation algorithms for IEEE 754 arithmetic contained in fdlibm")]
        public void S15_8_2_3_A6()
        {
            RunFile(@"S15.8.2.3_A6.js");
        }
    }
}