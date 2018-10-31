using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab3;
using System.Linq;

namespace Test.MSTests
{
    [TestClass]
    public class TestBookRepository
    {
        private static BookRepository books;

        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            books = new BookRepository(new Book(1, "1", "Description", 10, 2008, Generes.Action));
            books.AddBook(new Book(2, "2", "Description", 20, 2009, Generes.Action));
            books.AddBook(new Book(3, "3", "Description", 30, 2010, Generes.Action));
            books.AddBook(new Book(4, "4", "Description", 40, 2011, Generes.Kids));
            books.AddBook(new Book(5, "5", "Description", 50, 2012, Generes.Kids));
            books.AddBook(new Book(6, "6", "Description", 60, 2013, Generes.Manual));
            books.AddBook(new Book(7, "7", "Description", 70, 2014, Generes.Science));
            books.AddBook(new Book(8, "8", "Description", 80, 2015, Generes.Action));
            books.AddBook(new Book(9, "9", "Description", 90, 2016, Generes.Story), new Book(10, "10", "Description", 100, 2017, Generes.Story));
        }


        [TestMethod]
        public void TestRetriveAllBooks()
        {
            Assert.AreEqual(books.RetriveAllBooks().Count, 10);
        }

        [TestMethod]
        public void TestRetriveAllOrderByYearAscending()
        {
            CollectionAssert.AreEqual(books.MRetriveAllOrderByYearAscending(), books.RetriveAllBooks());
        }

        [TestMethod]
        public void RetriveAllOrderByYearDescending()
        {
            CollectionAssert.AreEqual(books.RetriveAllBooks().Reverse<Book>().ToList(), books.MRetriveAllOrderByYearDescending());
        }

        [TestMethod]
        public void TestRetriveAllOrderByPriceAscending()
        {
            CollectionAssert.AreEqual(books.MRetriveAllOrderByPriceAscending(), books.RetriveAllBooks().ToList());
        }

        [TestMethod]
        public void TestRetriveAllOrderByPriceDescending()
        {
            CollectionAssert.AreEqual(books.RetriveAllBooks().Reverse<Book>().ToList(), books.MRetriveAllOrderByPriceDescending());
        }

        [TestMethod]
        public void TestRetriveAllBooksGroupedByGenre()
        {
            Assert.AreEqual(books.MRetriveAllBooksGroupedByGenre(Generes.Action).Count, 4);
        }
    }
}
