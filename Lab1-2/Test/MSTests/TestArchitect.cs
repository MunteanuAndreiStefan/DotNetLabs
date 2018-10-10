using Lab1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Test.MSTests
{
    [TestClass]
    public class TestArchitect
    {
        [TestMethod]
        public void ArchitectDefaultConstructorValues()
        {
            var employee = new Architect(0, "Stefan", "Munteanu", new DateTime(2016, 7, 15), new DateTime(2018, 10, 05), 1000.0, "Romania", 3, 2, 5);

            Assert.AreEqual(0, employee.Id);
            Assert.AreEqual("Stefan", employee.FirstName);
            Assert.AreEqual("Munteanu", employee.LastName);
            Assert.AreEqual(new DateTime(2016, 7, 15), employee.StartDate);
            Assert.AreEqual(new DateTime(2018, 10, 05), employee.EndDate);
            Assert.AreEqual(1000, employee.Salary);
            Assert.AreEqual("Romania", employee.Country);
            Assert.AreEqual(3, employee.Rank);
            Assert.AreEqual(2, employee.YearsOfExperience);
            Assert.AreEqual(5, employee.NumberOfProjectsWorkingOn);

            employee = new Architect(0, "Stefan", "Munteanu", new DateTime(2016, 7, 15), new DateTime(2018, 10, 05), 1000.0, null, 3, 2, 5);

            Assert.AreEqual(0, employee.Id);
            Assert.AreEqual("Stefan", employee.FirstName);
            Assert.AreEqual("Munteanu", employee.LastName);
            Assert.AreEqual(new DateTime(2016, 7, 15), employee.StartDate);
            Assert.AreEqual(new DateTime(2018, 10, 05), employee.EndDate);
            Assert.AreEqual(1000, employee.Salary);
            Assert.AreEqual("No known country.", employee.Country);
            Assert.AreEqual(3, employee.Rank);
            Assert.AreEqual(2, employee.YearsOfExperience);
            Assert.AreEqual(5, employee.NumberOfProjectsWorkingOn);
        }

        [TestMethod]
        public void ArchitectGetFullName()
        {
            var employee = new Architect(0, "Stefan", "Munteanu", new DateTime(2016, 7, 15), new DateTime(2018, 10, 05), 1000.0, "Romania", 3, 2, 5);

            Assert.AreEqual("First name: " + "Stefan" + " Last name:  " + "Munteanu" + "\n", employee.GetFullName());

            employee = new Architect(0, "", "Munteanu", new DateTime(2016, 7, 15), new DateTime(2018, 10, 05), 1000.0, null, 3, 2, 5);

            Assert.AreEqual("First name: " + "First name not known." + " Last name:  " + "Munteanu" + "\n", employee.GetFullName());

            employee = new Architect(0, "Stefan", "", new DateTime(2016, 7, 15), new DateTime(2018, 10, 05), 1000.0, null, 3, 2, 5);

            Assert.AreEqual("First name: " + "Stefan" + " Last name:  " + "Last name not known." + "\n", employee.GetFullName());

            employee = new Architect(0, null, "", new DateTime(2016, 7, 15), new DateTime(2018, 10, 05), 1000.0, null, 3, 2, 5);

            Assert.AreEqual("First name: " + "First name not known." + " Last name:  " + "Last name not known." + "\n", employee.GetFullName());
        }

        [TestMethod]
        public void ArchitectIsActive()
        {

            var employee = new Architect(0, "Stefan", "Munteanu", new DateTime(2016, 7, 15), new DateTime(2019, 10, 05), 1000.0, "Romania", 3, 2, 5);

            Assert.AreEqual(true, employee.IsActive());


            employee = new Architect(0, "Stefan", "Munteanu", new DateTime(2016, 7, 15), new DateTime(2017, 10, 05), 1000.0, "Romania", 3, 2, 5);

            Assert.AreEqual(false, employee.IsActive());


            employee = new Architect(0, "Stefan", "Munteanu", new DateTime(2020, 7, 15), new DateTime(2021, 10, 05), 1000.0, "Romania", 3, 2, 5);

            Assert.AreEqual(false, employee.IsActive());
        }

    }
}
