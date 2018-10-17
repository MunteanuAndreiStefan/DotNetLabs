using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab3;
using System.Linq;

namespace Test.MSTests
{
    [TestClass]
    public class TestBookRepositoryLinq
    {
        private static BookRepository books;

        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            books = new BookRepository(new Book(1, "1", "Description", 10, 2008, Book.Generes.action));
            books.AddBook(new Book(2, "2", "Description", 20, 2009, Book.Generes.action));
            books.AddBook(new Book(3, "3", "Description", 30, 2010, Book.Generes.action));
            books.AddBook(new Book(4, "4", "Description", 40, 2011, Book.Generes.kids));
            books.AddBook(new Book(5, "5", "Description", 50, 2012, Book.Generes.kids));
            books.AddBook(new Book(6, "6", "Description", 60, 2013, Book.Generes.manual));
            books.AddBook(new Book(7, "7", "Description", 70, 2014, Book.Generes.science));
            books.AddBook(new Book(8, "8", "Description", 80, 2015, Book.Generes.action));
            books.AddBook(new Book(9, "9", "Description", 90, 2016, Book.Generes.story), new Book(10, "10", "Description", 100, 2017, Book.Generes.story));
        }


        [TestMethod]
        public void TestRetriveAllBooks()
        {
            Assert.AreEqual(books.RetriveAllBooks().Count, 10);
        }

        [TestMethod]
        public void TestRetriveAllOrderByYearAscending()
        {
            CollectionAssert.AreEqual(books.RetriveAllOrderByYearAscending(), books.RetriveAllBooks());
        }

        [TestMethod]
        public void RetriveAllOrderByYearDescending()
        {
            CollectionAssert.AreEqual(books.RetriveAllBooks().Reverse<Book>().ToList(), books.RetriveAllOrderByYearDescending());
        }

        [TestMethod]
        public void TestRetriveAllOrderByPriceAscending()
        {
            CollectionAssert.AreEqual(books.RetriveAllOrderByPriceAscending(), books.RetriveAllBooks().ToList());
        }

        [TestMethod]
        public void TestRetriveAllOrderByPriceDescending()
        {
            CollectionAssert.AreEqual(books.RetriveAllBooks().Reverse<Book>().ToList(), books.RetriveAllOrderByPriceDescending());
        }

        [TestMethod]
        public void TestRetriveAllBooksGroupedByGenre()
        {
            Assert.AreEqual(books.RetriveAllBooksGroupedByGenre(Book.Generes.action).Count, 4);
        }
    }
}
