using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;
using System;

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

    [TestClass]
    public class TestForToString
    {
        [TestMethod]
        public void TestMethod4()
        {
            Job test_job6 = new Job("Job description", new Employer("ACME"), new Location("Desert"), new PositionType("Quality Control"), new CoreCompetency("Persistence"));

            string correctString = "Job Name: ________ " + "/n" +
                "Employer Name: ______" + "/n" +
                "Location: ______" + "/n" +
                "Position Type:______" + "/n" +
                "Core Competency: _______"; 

            Assert.AreEqual(correctString, test_job6.ToString());
        }
    }
}

    [TestClass]
    public class TestForToString2
    {
        [TestMethod]
        public void TestMethod5()
        {
        Job test_job7 = new Job("Job description", new Employer("ACME"), new Location("Desert"), new PositionType("Quality Control"), new CoreCompetency("Persistence"));

        string correctString = "ID: " + test_job7.Id + "\n" +
            "Job Name: " + test_job7.Name + "\n" +
            "Employer Name: " + test_job7.EmployerName + "\n" +
            "Location: " + test_job7.EmployerLocation + "\n" +
            "Position Type: " + test_job7.JobType + "\n" +
            "Core Competency: " + test_job7.JobCoreCompetency + "\n";

        Assert.AreEqual(correctString, test_job7.ToString()); 
    }
}
