using System.Collections.Generic;
using System.Linq;

namespace Lab3
{
    public class BookRepository : IBookRepository
    {
        private List<Book> bookList;
        private List<Book> cBookList;
        private int lastSort = 0;

        public BookRepository() {
            bookList = new List<Book>();
        }

        public void AddBook(Book toAdd) {
            bookList.Add(toAdd);
        }

        public List<Book> RetriveAllBooks() {
            return bookList;
        }

        public List<Book> RetriveAllOrderByYearDescending()
        {
            if (lastSort != 1)
            {
                cBookList = bookList.OrderByDescending(x => x.Year).ToList();
                lastSort = 1;
            }
            return cBookList;
        }

        public List<Book> RetriveAllOrderByYearAscending()
        {
            if (lastSort != 2)
            {
                cBookList = bookList.OrderBy(x => x.Year).ToList();
                lastSort = 2;
            }
            return cBookList;
        }

        public List<Book> RetriveAllOrderByPriceDescending()
        {
            if (lastSort != 3)
            {
                cBookList = bookList.OrderByDescending(x => x.Price).ToList();
                lastSort = 3;
            }
            return cBookList;
        }

        public List<Book> RetriveAllOrderByPriceAscending()
        {
            if (lastSort != 4)
            {
                cBookList = bookList.OrderBy(x => x.Price).ToList();
                lastSort = 4;
            }
            return cBookList;
        }

        public List<Book> RetriveAllBooksGroupedByGenre(Book.Generes genre)
        {
            List<Book> list = new List<Book>(bookList.Where(x => x.Genre == genre));
            return list;
        }
    }
}
