using Calc_Triangle;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
namespace Test_CalcAreaTriangle
{
    
    
    /// <summary>
    ///This is a test class for AreaTriangleTest and is intended
    ///to contain all AreaTriangleTest Unit Tests
    ///</summary>
    [TestClass()]
    public class AreaTriangleTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for CalcAreaTriangle
        ///</summary>
        [TestMethod()]
        public void CalcAreaTriangleTest()
        {
            double side1 = 3; // TODO: Initialize to an appropriate value
            double side2 = 5; // TODO: Initialize to an appropriate value
            double side3 = 4; // TODO: Initialize to an appropriate value
            double expected = 6; // TODO: Initialize to an appropriate value
            Debug.WriteLine("expected result: " + expected.ToString());
            double actual;
            actual = AreaTriangle.CalcAreaTriangle(side1, side2, side3);
            Assert.AreEqual(expected, actual);
            Debug.WriteLine("result: " + actual.ToString());
            //Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
