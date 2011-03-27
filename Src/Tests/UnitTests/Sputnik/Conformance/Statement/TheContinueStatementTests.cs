// <auto-generated />
namespace IronJS.Tests.UnitTests.Sputnik.Conformance.Statement
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class TheContinueStatementTests : SputnikTestFixture
    {
        public TheContinueStatementTests()
            : base(@"Conformance\12_Statement\12.7_The_continue_Statement")
        {
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 12.7")]
        [Description("Appearing of continue without an IterationStatement leads to syntax error")]
        public void S12_7_A1_T1()
        {
            RunFile_ExpectException(@"S12.7_A1_T1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 12.7")]
        [Description("Appearing of continue without an IterationStatement leads to syntax error")]
        public void S12_7_A1_T2()
        {
            RunFile_ExpectException(@"S12.7_A1_T2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 12.7")]
        [Description("Appearing of continue without an IterationStatement leads to syntax error")]
        public void S12_7_A1_T3()
        {
            RunFile_ExpectException(@"S12.7_A1_T3.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 12.7")]
        [Description("Appearing of continue without an IterationStatement leads to syntax error")]
        public void S12_7_A1_T4()
        {
            RunFile_ExpectException(@"S12.7_A1_T4.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 12.7")]
        [Description("Since LineTerminator between \"continue\" and Identifier is not allowed, \"continue\" is evaluated without label")]
        public void S12_7_A2()
        {
            RunFile(@"S12.7_A2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 12.7")]
        [Description("When \"continue Identifier\" is evaluated (continue, empty, empty) is returned")]
        public void S12_7_A3()
        {
            RunFile(@"S12.7_A3.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 12.7")]
        [Description("When \"continue Identifier\" is evaluated (continue, empty, Identifier) is returned")]
        public void S12_7_A4_T1()
        {
            RunFile(@"S12.7_A4_T1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 12.7")]
        [Description("When \"continue Identifier\" is evaluated (continue, empty, Identifier) is returned")]
        public void S12_7_A4_T2()
        {
            RunFile(@"S12.7_A4_T2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 12.7")]
        [Description("When \"continue Identifier\" is evaluated (continue, empty, Identifier) is returned")]
        public void S12_7_A4_T3()
        {
            RunFile(@"S12.7_A4_T3.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 12.7")]
        [Description("When \"continue Identifier\" is evaluated Identifier must be label in the label set of an enclosing (but not crossing function boundaries) IterationStatement")]
        public void S12_7_A5_T1()
        {
            RunFile_ExpectException(@"S12.7_A5_T1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 12.7")]
        [Description("When \"continue Identifier\" is evaluated Identifier must be label in the label set of an enclosing (but not crossing function boundaries) IterationStatement")]
        public void S12_7_A5_T2()
        {
            RunFile_ExpectException(@"S12.7_A5_T2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 12.7")]
        [Description("When \"continue Identifier\" is evaluated Identifier must be label in the label set of an enclosing (but not crossing function boundaries) IterationStatement")]
        public void S12_7_A5_T3()
        {
            RunFile_ExpectException(@"S12.7_A5_T3.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 12.7")]
        [Description("Appearing of \"continue\" within a function call that is within an IterationStatement yields SyntaxError")]
        public void S12_7_A6()
        {
            RunFile_ExpectException(@"S12.7_A6.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 12.7")]
        [Description("Appearing of continue within eval statement that is within an IterationStatement yields SyntaxError")]
        public void S12_7_A7()
        {
            RunFile(@"S12.7_A7.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 12.7")]
        [Description("Appearing of \"continue\" within a \"try/catch\" Block yields SyntaxError")]
        public void S12_7_A8_T1()
        {
            RunFile_ExpectException(@"S12.7_A8_T1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 12.7")]
        [Description("Appearing of \"continue\" within a \"try/catch\" Block yields SyntaxError")]
        public void S12_7_A8_T2()
        {
            RunFile_ExpectException(@"S12.7_A8_T2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 12.7")]
        [Description("Continue inside of try-catch nested in a loop is allowed")]
        public void S12_7_A9_T1()
        {
            RunFile(@"S12.7_A9_T1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 12.7")]
        [Description("Continue inside of try-catch nested in a loop is allowed")]
        public void S12_7_A9_T2()
        {
            RunFile(@"S12.7_A9_T2.js");
        }
    }
}