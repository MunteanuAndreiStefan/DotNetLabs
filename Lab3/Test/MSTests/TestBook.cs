using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab3;
using System.Linq;

namespace Test.MSTests
{
    [TestClass]
    public class TestBook
    {
        private static Book product;

        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            product = new Book();
        }

        [TestMethod]
        public void BookDefaultConstructorValues()
        {
            Assert.AreEqual(0, product.Id);
            Assert.IsTrue("No name".ToCharArray().SequenceEqual(product.Name));
            Assert.AreEqual("No description", product.Description);
            Assert.AreEqual(0.0, product.Price);
            Assert.AreEqual(0, product.Year);
        }

        [TestMethod]
        public void BookConstructorValues()
        {
            var book = new Book(1, "Test", "BlaBla", 100, 2018, Book.Generes.story);
            Assert.AreEqual(1, book.Id);
            Assert.IsTrue("Test".ToCharArray().SequenceEqual(book.Name));
            Assert.AreEqual("BlaBla", book.Description);
            Assert.AreEqual(100, book.Price);
            Assert.AreEqual(2018, book.Year);
            Assert.AreEqual(Book.Generes.story, book.Genre);
        }
    }
}
