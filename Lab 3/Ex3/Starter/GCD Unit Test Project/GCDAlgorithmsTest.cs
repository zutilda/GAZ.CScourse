using GreatestCommonDivisor;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace GCDTestProject
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

        public void FindGCDEuclidTest()
        {
            int a = 298467352;
            int b = 569484;
            int expected = 4;
            int actual;
            long time;
            actual = GCDAlgorithms.FindGCDEuclid(a, b, out time);
            Assert.AreEqual(expected, actual);
        }

        

    }
}
namespace Module_3_Unit_Test_Project
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
        public void FindGCDSteinTest()
        {
            int u = 298467352; 
            int v = 569484; 
            long time = 0; 
            int expected = 4; 
            int actual;
            actual = GCDAlgorithms.FindGCDStein(u, v, out time);
            Assert.AreEqual(expected, actual);
            
        }
    }
}
