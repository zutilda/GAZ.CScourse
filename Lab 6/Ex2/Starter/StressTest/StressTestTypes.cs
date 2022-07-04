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
}
