using System;
using FluentAssertions;
using Lab1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.FluentTests
{

    [TestClass]
    public class TestEmployee
    {
        [TestMethod]
        public void EmployeeDefaultConstructorValues()
        {
            var employee = new Employee(0, "Stefan", "Munteanu", new DateTime(2016, 7, 15), new DateTime(2018, 10, 05), 1000.0);

            employee.Id.Should().Be(0);
            employee.FirstName.Should().Be("Stefan");
            employee.LastName.Should().Be("Munteanu");
            employee.StartDate.Should().Be(new DateTime(2016, 7, 15));
            employee.EndDate.Should().Be(new DateTime(2018, 10, 05));
            employee.Salary.Should().Be(1000);

            employee = new Employee(0, "", null, new DateTime(2016, 7, 15), new DateTime(2018, 10, 05), 1000.0);

            employee.Id.Should().Be(0);
            employee.FirstName.Should().Be("First name not known.");
            employee.LastName.Should().Be("Last name not known.");
            employee.StartDate.Should().Be(new DateTime(2016, 7, 15));
            employee.EndDate.Should().Be(new DateTime(2018, 10, 05));
            employee.Salary.Should().Be(1000);

        }

        [TestMethod]
        public void EmployeeSalutation()
        {
            var employee = new Employee(0, "Stefan", "Munteanu", new DateTime(2016, 7, 15), new DateTime(2018, 10, 05), 1000.0);
            employee.Salutation().Should().Be("Hello, employee");
        }
    }
}
