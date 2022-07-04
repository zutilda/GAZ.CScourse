using StressTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Lab6UnitTests
{


    [TestClass()]
    public class StressTestCaseTest
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

       
        [TestMethod()]
        public void StressTestCaseConstructorTest()
        {
            Material girderMaterial = Material.Composite;
            CrossSection crossSection = CrossSection.CShaped;
            int lengthInMm = 5000;
            int heightInMm = 32;
            int widthInMm = 18;
            StressTestCase target = new StressTestCase(girderMaterial, crossSection, lengthInMm, heightInMm, widthInMm);
            Assert.AreEqual(Material.Composite, target.girderMaterial);
            Assert.AreEqual(CrossSection.CShaped, target.crossSection);
            Assert.AreEqual(5000, target.lengthInMm);
            Assert.AreEqual(32, target.heightInMm);
            Assert.AreEqual(18, target.widthInMm);
        }

        [TestMethod()]
        public void StressTestCaseConstructorTest1()
        {
            StressTestCase target = new StressTestCase();
            Assert.AreEqual(Material.Aluminium, target.girderMaterial);
            Assert.AreEqual(CrossSection.Box, target.crossSection);
            Assert.AreEqual(50, target.lengthInMm);
            Assert.AreEqual(100, target.heightInMm);
            Assert.AreEqual(40, target.widthInMm);
        }

        [TestMethod()]
        public void GetStressTestResultTest()
        {
            StressTestCase target = new StressTestCase();
            TestCaseResult actual = target.GetStressTestResult();
            Assert.IsTrue(actual.Result == TestResult.Pass);
            Assert.IsTrue(actual.ReasonForFailure == null);
        }

        [TestMethod()]
        public void PerformStressTestTest()
        {
            for (int i = 0; i < 30; i++)
            {
                StressTestCase target = new StressTestCase();
                target.PerformStressTest();
                TestCaseResult actual = target.GetStressTestResult();
                if (actual.Result == TestResult.Fail)
                    Assert.IsTrue(actual.ReasonForFailure.Length > 0);
                else
                    Assert.IsTrue(actual.ReasonForFailure == null);
            }
        }

        [TestMethod()]
        public void ToStringTest()
        {
            StressTestCase target = new StressTestCase();
            string expected = "Material: Aluminium, CrossSection: Box, Length: 50mm, Height: 100mm, Width: 40mm";
            string actual;
            actual = target.ToString();
            Assert.AreEqual(expected, actual);
        }

    }
}
