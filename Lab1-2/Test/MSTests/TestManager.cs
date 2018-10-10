using Lab1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Test.MSTests
{
    [TestClass]
    public class TestManager
    {
        [TestMethod]
        public void ManagerDefaultConstructorValues()
        {
            var employee = new Manager(0, "Stefan", "Munteanu", new DateTime(2016, 7, 15), new DateTime(2018, 10, 05), 1000.0, "UAIC", 1);

            Assert.AreEqual(0, employee.Id);
            Assert.AreEqual("Stefan", employee.FirstName);
            Assert.AreEqual("Munteanu", employee.LastName);
            Assert.AreEqual(new DateTime(2016, 7, 15), employee.StartDate);
            Assert.AreEqual(new DateTime(2018, 10, 05), employee.EndDate);
            Assert.AreEqual(1000, employee.Salary);
            Assert.AreEqual("UAIC", employee.TeamName);
            Assert.AreEqual(1, employee.TeamSize);

            employee = new Manager(0, "Stefan", "Munteanu", new DateTime(2016, 7, 15), new DateTime(2018, 10, 05), 1000.0, null, 2);

            Assert.AreEqual(0, employee.Id);
            Assert.AreEqual("Stefan", employee.FirstName);
            Assert.AreEqual("Munteanu", employee.LastName);
            Assert.AreEqual(new DateTime(2016, 7, 15), employee.StartDate);
            Assert.AreEqual(new DateTime(2018, 10, 05), employee.EndDate);
            Assert.AreEqual(1000, employee.Salary);
            Assert.AreEqual("No team", employee.TeamName);
            Assert.AreEqual(0, employee.TeamSize);
        }

        [TestMethod]
        public void ManagerGetFullName()
        {
            var employee = new Manager(0, "Stefan", "Munteanu", new DateTime(2016, 7, 15), new DateTime(2018, 10, 05), 1000.0, "UAIC", 1);

            Assert.AreEqual("First name: " + "Stefan" + " Last name:  " + "Munteanu" + "\n", employee.GetFullName());

            employee = new Manager(0, "", "Munteanu", new DateTime(2016, 7, 15), new DateTime(2018, 10, 05), 1000.0, "UAIC", 1);

            Assert.AreEqual("First name: " + "First name not known." + " Last name:  " + "Munteanu" + "\n", employee.GetFullName());

            employee = new Manager(0, "Stefan", "", new DateTime(2016, 7, 15), new DateTime(2018, 10, 05), 1000.0, "UAIC", 1);

            Assert.AreEqual("First name: " + "Stefan" + " Last name:  " + "Last name not known." + "\n", employee.GetFullName());

            employee = new Manager(0, "", "", new DateTime(2016, 7, 15), new DateTime(2018, 10, 05), 1000.0, "UAIC", 1);

            Assert.AreEqual("First name: " + "First name not known." + " Last name:  " + "Last name not known." + "\n", employee.GetFullName());
        }

        [TestMethod]
        public void ManagerIsActive()
        {

            var employee = new Manager(0, "Stefan", "Munteanu", new DateTime(2016, 7, 15), new DateTime(2019, 10, 05), 1000.0, "UAIC", 1);

            Assert.AreEqual(true, employee.IsActive());


            employee = new Manager(0, "Stefan", "Munteanu", new DateTime(2016, 7, 15), new DateTime(2017, 10, 05), 1000.0, "UAIC", 1);

            Assert.AreEqual(false, employee.IsActive());


            employee = new Manager(0, "Stefan", "Munteanu", new DateTime(2020, 7, 15), new DateTime(2021, 10, 05), 1000.0, "UAIC", 1);

            Assert.AreEqual(false, employee.IsActive());
        }

    }
}
