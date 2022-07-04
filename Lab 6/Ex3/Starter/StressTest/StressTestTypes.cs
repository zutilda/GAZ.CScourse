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
      
        public TestResult Result;

        public string ReasonForFailure;
    }



    public class StressTestCase
    {
        public Material girderMaterial;

        public CrossSection crossSection;

        public int lengthInMm;

        public int heightInMm;

        public int widthInMm;

        public TestCaseResult TestCaseResult;
        public StressTestCase()
        {
            girderMaterial = Material.Aluminium;
            crossSection = CrossSection.Box;
            lengthInMm = 50;
            heightInMm = 100;
            widthInMm = 40;
        }
       
        public StressTestCase(Material girderMaterial, CrossSection crossSection, int lengthInMm, int heightInMm, int widthInMm)
        {
            this.girderMaterial = girderMaterial;
            this.crossSection = crossSection;
            this.lengthInMm = lengthInMm;
            this.heightInMm = heightInMm;
            this.widthInMm = widthInMm;
        }
        public void PerformStressTest()
        {
           
            string[] failureReasons = 
            {
                "Fracture detected", 
                "Beam snapped", 
                "Beam dimensions wrong", 
                "Beam warped", 
                "Other" 
            };

           
            if (Utility.Rand.Next(10) == 9)
            {
                TestCaseResult.Result = TestResult.Fail;
                int failureCode = Utility.Rand.Next(5);
                TestCaseResult.ReasonForFailure = failureReasons[failureCode];
            }
            else
            {
                TestCaseResult.Result = TestResult.Pass;
            }
        }

      
        public TestCaseResult GetStressTestResult()
        {
            return TestCaseResult;
        }

      
        public override string ToString()
        {
            return string.Format("Material: {0}, CrossSection: {1}, Length: {2}mm, Height: {3}mm, Width: {4}mm",
                girderMaterial.ToString(), crossSection.ToString(), lengthInMm, heightInMm, widthInMm);
        }

    }
     
   
}
