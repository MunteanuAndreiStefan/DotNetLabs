using System;
using Lab1;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.FluentTests
{
    [TestClass]
    public class TestProduct
    {

        private static Product product;

        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            product = new Product();
        }

        [TestMethod]
        public void ProductIsValid()
        {
            product.IsValid().Should().BeFalse();
        }

        [TestMethod]
        public void ProductDefaultConstructorValues()
        {
            product.Id.Should().Be(0);
            product.Name.Should().Be("No name");
            product.Description.Should().Be("No description");
            product.StartDate.Should().Be(new DateTime(1996, 10, 22));
            product.EndDate.Should().Be(new DateTime(1996, 11, 01));
            product.Price.Should().Be(0.0);
            product.VAT.Should().Be(0);
        }

        [TestMethod]
        public void ProductComputeVAT()
        {
            product.ComputeVAT().Should().Be(0);
        }
    }
}
