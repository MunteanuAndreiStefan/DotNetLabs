using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab1;
using System.Collections.Generic;
using System.Linq;

namespace Test.MSTests
{
    [TestClass]
    public class TestProductRepository
    {

        private static ProductRepository products;
        private static Product pr1;
        private static Product pr2;
        private static Product pr3;

        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            products = new ProductRepository();
            pr1 = new Product();
            pr2 = new Product();
            pr3 = new Product();
            products.AddProduct(pr1);
            products.AddProduct(pr2);
            products.AddProduct(pr3);
        }

        [TestMethod]
        public void TestAddProduct()
        {
            var prod = new ProductRepository();
            prod.AddProduct(pr1);
            prod.AddProduct(pr2);
            prod.AddProduct(pr3);
            Assert.AreEqual(products.FindAllProducts().Count, 3);
            bool contains = products.FindAllProducts().Any(e => prod.FindAllProducts().Any(d => d.Equals(e)));
            Assert.AreEqual(true, contains);
        }

        [TestMethod]
        public void TestGetProductByPosition()
        {
            Assert.AreEqual(products.GetProductByPosition(1), pr2);
        }

        [TestMethod]
        public void TestRemoveProductByName()
        {
            var prods = new ProductRepository();
            prods.AddProduct(pr1);
            prods.AddProduct(pr2);
            prods.AddProduct(pr3);
            prods.RemoveProductByName("No name");
            Assert.AreEqual(prods.FindAllProducts().Count, 0);
        }

        [TestMethod]
        public void TestGetProductByName()
        {
            Assert.AreEqual(products.GetProductByName("No name"), pr1);
        }

        [TestMethod]
        public void TestFindAllProducts()
        {
            var prod = new List<Product> { pr1, pr2, pr3 };
            bool contains = products.FindAllProducts().Any(e => prod.Any(d => d.Equals(e)));
            Assert.AreEqual(true, contains);
        }
    }
}
