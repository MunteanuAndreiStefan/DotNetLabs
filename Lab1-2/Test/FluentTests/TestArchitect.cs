using FluentAssertions;
using Lab1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Test.FluentTests
{
    [TestClass]
    public class TestArchitect
    {
        [TestMethod]
        public void ArchitectDefaultConstructorValues()
        {
            var employee = new Architect(0, "Stefan", "Munteanu", new DateTime(2016, 7, 15), new DateTime(2018, 10, 05), 1000.0, "Romania", 3, 2, 5);

            employee.Id.Should().Be(0);
            employee.FirstName.Should().Be("Stefan");
            employee.LastName.Should().Be("Munteanu");
            employee.StartDate.Should().Be(new DateTime(2016, 7, 15));
            employee.EndDate.Should().Be(new DateTime(2018, 10, 05));
            employee.Salary.Should().Be(1000);
            employee.Country.Should().Be("Romania");
            employee.Rank.Should().Be(3);
            employee.YearsOfExperience.Should().Be(2);
            employee.NumberOfProjectsWorkingOn.Should().Be(5);

            employee = new Architect(0, "Stefan", "Munteanu", new DateTime(2016, 7, 15), new DateTime(2018, 10, 05), 1000.0, null, 3, 2, 5);

            employee.Id.Should().Be(0);
            employee.FirstName.Should().Be("Stefan");
            employee.LastName.Should().Be("Munteanu");
            employee.StartDate.Should().Be(new DateTime(2016, 7, 15));
            employee.EndDate.Should().Be(new DateTime(2018, 10, 05));
            employee.Salary.Should().Be(1000);
            employee.Country.Should().Be("No known country.");
            employee.Rank.Should().Be(3);
            employee.YearsOfExperience.Should().Be(2);
            employee.NumberOfProjectsWorkingOn.Should().Be(5);
        }

        [TestMethod]
        public void ArchitectGetFullName()
        {
            var employee = new Architect(0, "Stefan", "Munteanu", new DateTime(2016, 7, 15), new DateTime(2018, 10, 05), 1000.0, "Romania", 3, 2, 5);
            employee.GetFullName().Should().Be("First name: " + "Stefan" + " Last name:  " + "Munteanu" + "\n");

            employee = new Architect(0, "", "Munteanu", new DateTime(2016, 7, 15), new DateTime(2018, 10, 05), 1000.0, null, 3, 2, 5);
            employee.GetFullName().Should().Be("First name: " + "First name not known." + " Last name:  " + "Munteanu" + "\n");

            employee = new Architect(0, "Stefan", "", new DateTime(2016, 7, 15), new DateTime(2018, 10, 05), 1000.0, null, 3, 2, 5);
            employee.GetFullName().Should().Be("First name: " + "Stefan" + " Last name:  " + "Last name not known." + "\n");

            employee = new Architect(0, null, "", new DateTime(2016, 7, 15), new DateTime(2018, 10, 05), 1000.0, null, 3, 2, 5);
            employee.GetFullName().Should().Be("First name: " + "First name not known." + " Last name:  " + "Last name not known." + "\n");
        }

        [TestMethod]
        public void ArchitectIsActive()
        {
            var employee = new Architect(0, "Stefan", "Munteanu", new DateTime(2016, 7, 15), new DateTime(2019, 10, 05), 1000.0, "Romania", 3, 2, 5);
            employee.IsActive().Should().Be(true);

            employee = new Architect(0, "Stefan", "Munteanu", new DateTime(2016, 7, 15), new DateTime(2017, 10, 05), 1000.0, "Romania", 3, 2, 5);
            employee.IsActive().Should().Be(false);

            employee = new Architect(0, "Stefan", "Munteanu", new DateTime(2020, 7, 15), new DateTime(2021, 10, 05), 1000.0, "Romania", 3, 2, 5);
            employee.IsActive().Should().Be(false);
        }

        [TestMethod]
        public void ArchitectSalutation()
        {
            var employee = new Architect(0, "Stefan", "Munteanu", new DateTime(2016, 7, 15), new DateTime(2019, 10, 05), 1000.0, "Romania", 3, 2, 5);
            employee.Salutation().Should().Be("Hello, Architect");
        }

    }
}
