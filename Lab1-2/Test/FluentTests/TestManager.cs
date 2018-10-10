using FluentAssertions;
using Lab1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Test.FluentTests
{
    [TestClass]
    class TestManager
    {
        [TestMethod]
        public void ManagerDefaultConstructorValues()
        {
            var employee = new Manager(0, "Stefan", "Munteanu", new DateTime(2016, 7, 15), new DateTime(2018, 10, 05), 1000.0, "UAIC", 1);

            employee.Id.Should().Be(0);
            employee.FirstName.Should().Be("Stefan");
            employee.LastName.Should().Be("Munteanu");
            employee.StartDate.Should().Be(new DateTime(2016, 7, 15));
            employee.EndDate.Should().Be(new DateTime(2018, 10, 05));
            employee.Salary.Should().Be(1000);
            employee.TeamName.Should().Be("UAIC");
            employee.TeamSize.Should().Be(1);

            employee = new Manager(0, "Stefan", "Munteanu", new DateTime(2016, 7, 15), new DateTime(2018, 10, 05), 1000.0, null, 2);

            employee.Id.Should().Be(0);
            employee.FirstName.Should().Be("Stefan");
            employee.LastName.Should().Be("Munteanu");
            employee.StartDate.Should().Be(new DateTime(2016, 7, 15));
            employee.EndDate.Should().Be(new DateTime(2018, 10, 05));
            employee.Salary.Should().Be(1000);
            employee.TeamName.Should().Be("No team");
            employee.TeamSize.Should().Be(0);
        }

        [TestMethod]
        public void ManagerGetFullName()
        {
            var employee = new Manager(0, "Stefan", "Munteanu", new DateTime(2016, 7, 15), new DateTime(2018, 10, 05), 1000.0, "UAIC", 1);
            employee.GetFullName().Should().Be("First name: " + "Stefan" + " Last name:  " + "Munteanu" + "\n");

            employee = new Manager(0, "", "Munteanu", new DateTime(2016, 7, 15), new DateTime(2018, 10, 05), 1000.0, "UAIC", 1);
            employee.GetFullName().Should().Be("First name: " + "First name not known." + " Last name:  " + "Munteanu" + "\n");

            employee = new Manager(0, "Stefan", "", new DateTime(2016, 7, 15), new DateTime(2018, 10, 05), 1000.0, "UAIC", 1);
            employee.GetFullName().Should().Be("First name: " + "Stefan" + " Last name:  " + "Last name not known." + "\n");

            employee = new Manager(0, "", "", new DateTime(2016, 7, 15), new DateTime(2018, 10, 05), 1000.0, "UAIC", 1);
            employee.GetFullName().Should().Be("First name: " + "First name not known." + " Last name:  " + "Last name not known." + "\n");
        }

        [TestMethod]
        public void ManagerIsActive()
        {

            var employee = new Manager(0, "Stefan", "Munteanu", new DateTime(2016, 7, 15), new DateTime(2019, 10, 05), 1000.0, "UAIC", 1);
            employee.IsActive().Should().Be(true);


            employee = new Manager(0, "Stefan", "Munteanu", new DateTime(2016, 7, 15), new DateTime(2017, 10, 05), 1000.0, "UAIC", 1);
            employee.IsActive().Should().Be(false);


            employee = new Manager(0, "Stefan", "Munteanu", new DateTime(2020, 7, 15), new DateTime(2021, 10, 05), 1000.0, "UAIC", 1);
            employee.IsActive().Should().Be(false);
        }

        [TestMethod]
        public void ManagerSalutation()
        {
            var employee = new Manager(0, "Stefan", "Munteanu", new DateTime(2016, 7, 15), new DateTime(2019, 10, 05), 1000.0, "UAIC", 1);
            employee.Salutation().Should().Be("Hello, Manager");
        }
    }
}
