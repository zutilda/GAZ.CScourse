using GAZCSCourseLab3;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace GCD_Test_Project
{

    [TestClass()]
    public class GCDAlgorithmsTest
    {


        private TestContext testContextInstance;

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


        [TestMethod()]
        public void FindGCDEuclidTest()
        {
            int a = 2806; 
            int b = 345; 
            int expected =23; 
            int actual;
            actual = GCDAlgorithmsTest.FindGCDEuclid(a, b);
            Assert.AreEqual(expected, actual);
         }
        [TestMethod()]
        public void FindGCDEuclidTest1()
        {
            int c = 0; 
            int d = 10; 
            int expected = 10; 
            int actual;
            actual = GCDAlgorithmsTest.FindGCDEuclid(c, d);
            Assert.AreEqual(expected, actual);
        }
    }
}
