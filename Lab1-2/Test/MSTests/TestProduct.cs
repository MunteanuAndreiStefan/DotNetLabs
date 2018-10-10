using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab1;

namespace Test.MSTests
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
            Assert.AreEqual(false, product.IsValid());
        }

        [TestMethod]
        public void ProductDefaultConstructorValues()
        {
            Assert.AreEqual(0, product.Id);
            Assert.AreEqual("No name", product.Name);
            Assert.AreEqual("No description", product.Description);
            Assert.AreEqual(new DateTime(1996, 10, 22), product.StartDate);
            Assert.AreEqual(new DateTime(1996, 11, 01), product.EndDate);
            Assert.AreEqual(0.0, product.Price);
            Assert.AreEqual(0, product.VAT);
        }

        [TestMethod]
        public void ProductComputeVAT()
        {
            Assert.AreEqual(0, product.ComputeVAT());
        }
    }
}
