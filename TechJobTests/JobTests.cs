using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobTests
{
    [TestClass]
    public class TestSettingJobId
    {
        [TestMethod]
        public void TestMethod1()
        {
            Job test_job1 = new Job();
            Job test_job2 = new Job();
            Assert.IsTrue(test_job1.Id != test_job2.Id && (test_job1.Id + 1) == test_job2.Id); 
        }
    }
}
