using System;
using Lab1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.MSTests
{

    [TestClass]
    public class TestEmployee
    {
        [TestMethod]
        public void EmployeeDefaultConstructorValues()
        {
            var employee = new Employee(0, "Stefan", "Munteanu", new DateTime(2016, 7, 15), new DateTime(2018, 10, 05), 1000.0);

            Assert.AreEqual(0, employee.Id);
            Assert.AreEqual("Stefan", employee.FirstName);
            Assert.AreEqual("Munteanu", employee.LastName);
            Assert.AreEqual(new DateTime(2016, 7, 15), employee.StartDate);
            Assert.AreEqual(new DateTime(2018, 10, 05), employee.EndDate);
            Assert.AreEqual(1000, employee.Salary);

            employee = new Employee(0, "", null, new DateTime(2016, 7, 15), new DateTime(2018, 10, 05), 1000.0);

            Assert.AreEqual(0, employee.Id);
            Assert.AreEqual("First name not known.", employee.FirstName);
            Assert.AreEqual("Last name not known.", employee.LastName);
            Assert.AreEqual(new DateTime(2016, 7, 15), employee.StartDate);
            Assert.AreEqual(new DateTime(2018, 10, 05), employee.EndDate);
            Assert.AreEqual(1000, employee.Salary);
        }
    }
}
