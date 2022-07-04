using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StressTest
{
  
    public enum Material { StainlessSteel, Aluminium, ReinforcedConcrete, Composite, Titanium }

    public enum CrossSection { IBeam, Box, ZShaped, CShaped }

    public enum TestResult { Pass, Fail }

    public struct TestCaseResult
    {
        public TestResult result;

        
        public string reasonForFailure;
    }

    public class StressTestCase
    {

        private Material girderMaterial;

        private CrossSection crossSection;

        private int lengthInMm;

        private int heightInMm;

        private int widthInMm;

        private TestCaseResult? testCaseResult;

        public StressTestCase() : this(Material.StainlessSteel, CrossSection.IBeam, 4000, 20, 15) { }

        public StressTestCase(Material girderMaterial, CrossSection crossSection, int lengthInMm, int heightInMm, int widthInMm)
        {
            this.girderMaterial = girderMaterial;
            this.crossSection = crossSection;
            this.lengthInMm = lengthInMm;
            this.heightInMm = heightInMm;
            this.widthInMm = widthInMm;
            this.testCaseResult = null;
        }

        public void PerformStressTest()
        {
            
            TestCaseResult tcr = new TestCaseResult();

            string[] failureReasons = { "Fracture detected", "Beam snapped", "Beam dimensions wrong", "Beam warped", "Other" };

            if (Utility.Rand.Next(10) == 9)
            {
                tcr.result = TestResult.Fail;
                tcr.reasonForFailure = failureReasons[Utility.Rand.Next(5)];
            }
            else
            {
                tcr.result = TestResult.Pass;
                
            }
            testCaseResult = tcr;
        }

        public TestCaseResult? GetStressTestResult()
        {
            if (testCaseResult.HasValue)
            {
                return testCaseResult.Value;
            }
            else
            {
                return null;
            }
        }

        public override string ToString()
        {
            string stressTestPerformed;
            if (testCaseResult.HasValue)
            {
                stressTestPerformed = "Stress Test Completed";
            }
            else
            {
                stressTestPerformed = "No Stress Test Performed";
            }
            return string.Format("Material: {0}, CrossSection: {1}, Length: {2}mm, Height: {3}mm, Width: {4}mm, {5}",
                girderMaterial.ToString(), crossSection.ToString(), lengthInMm, heightInMm, widthInMm, stressTestPerformed);
        }
    }
}
