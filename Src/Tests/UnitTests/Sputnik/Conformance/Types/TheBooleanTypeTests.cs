// <auto-generated />
namespace IronJS.Tests.UnitTests.Sputnik.Conformance.Types
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class TheBooleanTypeTests : SputnikTestFixture
    {
        public TheBooleanTypeTests()
            : base(@"Conformance\08_Types\8.3_The_Boolean_Type")
        {
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 8.3")]
        [Description("The Boolean type have two values, called true and false")]
        public void S8_3_A1_T1()
        {
            RunFile(@"S8.3_A1_T1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 8.3")]
        [Description("The Boolean type have two values, called true and false")]
        public void S8_3_A1_T2()
        {
            RunFile(@"S8.3_A1_T2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 8.3")]
        [Description("The true is reserved word")]
        public void S8_3_A2_1()
        {
            RunFile_ExpectException(@"S8.3_A2.1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 8.3")]
        [Description("The false is reserved word")]
        public void S8_3_A2_2()
        {
            RunFile_ExpectException(@"S8.3_A2.2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 8.3")]
        [Description("Applaing negation to boolean works well")]
        public void S8_3_A3()
        {
            RunFile(@"S8.3_A3.js");
        }
    }
}