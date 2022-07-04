using MatrixMultiplication;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Lab4UnitTests
{
    
    [TestClass()]
    public class MatrixTest
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
        public void MatrixMultiplyTest1()
        {
            double[,] matrix1 = { { 4, 6 }, { 2, 2 }, { 5, 1 } };
            double[,] matrix2 = { { 1, 5, 1 }, { 7, 3, 1 } };
            double[,] expected = { { 19, 17 }, { 39, 49 } };
            double[,] actual;
            actual = Matrix.MatrixMultiply(matrix1, matrix2);
            Assert.AreEqual(expected[0, 0], actual[0, 0], 0.000001);
            Assert.AreEqual(expected[0, 1], actual[0, 1], 0.000001);
            Assert.AreEqual(expected[1, 0], actual[1, 0], 0.000001);
            Assert.AreEqual(expected[1, 1], actual[1, 1], 0.000001);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void MatrixMultiplyTest2()
        {
            double[,] matrix1 = { { 4, 6 }, { 2, 2 }, { 5, 1 } };
            double[,] matrix2 = { { 1, 5, 1 }, { 7, -3, 1 } };
            double[,] actual;
            actual = Matrix.MatrixMultiply(matrix1, matrix2);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void MatrixMultiplyTest3()
        {
            double[,] matrix1 = { { 4, 6 }, { 2, 2 }, { 5, 1 }, { 4, 4 } };
            double[,] matrix2 = { { 1, 5, 1 }, { 7, 3, 1 } };
            double[,] actual;
            actual = Matrix.MatrixMultiply(matrix1, matrix2);
        }
    }
}
