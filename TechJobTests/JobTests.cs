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

    [TestClass]
    public class TestJobConstructorSetsAllFields
    {
        [TestMethod]
        public void TestMethod2()
        {
            Job test_job3 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality Control"), new CoreCompetency("Persistence"));

            Assert.AreEqual("Product tester", test_job3.Name);
            Assert.AreEqual("ACME", test_job3.EmployerName.Value);
            Assert.AreEqual("Desert", test_job3.EmployerLocation.Value);
            Assert.AreEqual("Quality Control", test_job3.JobType.Value);
            Assert.AreEqual("Persistence", test_job3.JobCoreCompetency.Value);
        }

        }

    [TestClass]
    public class TestJobsForEquality
        {
            [TestMethod]
            public void TestMethod3()
            {
                Job test_job4 = new Job("Job description", new Employer("ACME"), new Location("Desert"), new PositionType("Quality Control"), new CoreCompetency("Persistence"));
                Job test_job5 = new Job("Job description", new Employer("ACME"), new Location("Desert"), new PositionType("Quality Control"), new CoreCompetency("Persistence"));

                Assert.IsFalse(Job.Equals(test_job4, test_job5)); 
            }
        }
    }
}
