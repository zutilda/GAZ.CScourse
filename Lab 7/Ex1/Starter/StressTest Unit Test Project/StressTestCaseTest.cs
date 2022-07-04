using StressTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Module_7_Unit_Test_Project
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
            string exp = "Material: Composite, CrossSection: CShaped, Length: 5000mm, Height: 32mm, Width: 18mm, No Stress Test Performed";
         
            StressTestCase target = new StressTestCase(girderMaterial, crossSection, lengthInMm, heightInMm, widthInMm);
            Assert.AreEqual(exp, target.ToString());
            
          
        }

        [TestMethod()]
        public void StressTestCaseConstructorTest1()
        {
            StressTestCase target = new StressTestCase();
          
        }

        [TestMethod()]
        public void GetStressTestResultTest()
        {
            StressTestCase target = new StressTestCase();
            Assert.IsFalse(target.GetStressTestResult().HasValue);
            target.PerformStressTest();
            Assert.IsTrue(target.GetStressTestResult().HasValue);
        }

        [TestMethod()]
        public void PerformStressTestTest()
        {
            for (int i = 0; i < 30; i++)
            {
                StressTestCase target = new StressTestCase();
                target.PerformStressTest();
                Assert.IsTrue(target.GetStressTestResult().HasValue);
                TestCaseResult actual = target.GetStressTestResult().Value;
                if (actual.result == TestResult.Fail)
                    Assert.IsTrue(actual.reasonForFailure.Length > 0);
                else
                    Assert.IsTrue(actual.reasonForFailure == null);
            }
        }

        [TestMethod()]
        public void ToStringTest()
        {
            StressTestCase target = new StressTestCase();
            string expected = "Material: StainlessSteel, CrossSection: IBeam, Length: 4000mm, Height: 20mm, Width: 15mm, No Stress Test Performed";
            string actual;
            actual = target.ToString();
            Assert.AreEqual(expected, actual);
        }
    }
}
