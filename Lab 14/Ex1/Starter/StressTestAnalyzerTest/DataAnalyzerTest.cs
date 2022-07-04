using StressDataAnalyzer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using StressTestResult;
using System.Collections.Generic;

namespace StressDataAnalyzerTest
{
    
    [TestClass()]
    public class DataAnalyzerTest
    {
        object[,] testQueryCriteria = {{ DateTime.MinValue, DateTime.MaxValue, (short)100, (short)500, (short)10, (short)5000, (short)0, (short)1500, 41073, 1065864},
                                       { new DateTime(2009, 11, 1), new DateTime(2010, 2, 1), (short)280, (short)400, (short)10, (short)1000, (short)200, (short)750, 1180, 30252},
                                       { new DateTime(2009, 8, 1), new DateTime(2010, 3, 31), (short)320, (short)320, (short)10, (short)5000, (short)0, (short)1500, 785, 20377},
                                       { new DateTime(2009, 8, 1), new DateTime(2010, 3, 31), (short)500, (short)500, (short)10, (short)5000, (short)0, (short)1500, 829, 21513},
                                       { new DateTime(2010, 6, 1), new DateTime(2010, 6, 30), (short)200, (short)500, (short)10, (short)5000, (short)0, (short)1500, 0, 99}
                                     };

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
        [DeploymentItem("StressDataAnalyzer.exe")]
        public void CreateQueryandFormatResultsTest()
        {
            DataAnalyzer_Accessor target = new DataAnalyzer_Accessor();
            target.ReadTestData();

            for (int testCount = 0; testCount < testQueryCriteria.GetLength(0); testCount++)
            {
                DateTime dateStart = (DateTime)testQueryCriteria[testCount, 0];
                DateTime dateEnd = (DateTime)testQueryCriteria[testCount, 1];
                if (dateEnd < DateTime.MaxValue)
                {
                    dateEnd = dateEnd.AddDays(1);
                }

                short temperatureStart = (short)testQueryCriteria[testCount, 2];
                short temperatureEnd = (short)testQueryCriteria[testCount, 3];
                short appliedStressStart = (short)testQueryCriteria[testCount, 4];
                short appliedStressEnd = (short)testQueryCriteria[testCount, 5];
                short deflectionStart = (short)testQueryCriteria[testCount, 6];
                short deflectionEnd = (short)testQueryCriteria[testCount, 7];
                int expectedCount = (int)testQueryCriteria[testCount, 8];

                IEnumerable<TestResult> actual = target.CreateQuery(dateStart, dateEnd, temperatureStart, temperatureEnd, appliedStressStart, appliedStressEnd, deflectionStart, deflectionEnd);
                int actualCount = actual.Count();
                Assert.AreEqual(expectedCount, actualCount);

                string actualFormattedResults = target.FormatResults(actual);
                int actualFormattedResultsLength = actualFormattedResults.Length;
                int expectedFormattedResultsLength = (int)testQueryCriteria[testCount, 9];
                Assert.AreEqual(expectedFormattedResultsLength, actualFormattedResultsLength);
            }
        }
    }
}
