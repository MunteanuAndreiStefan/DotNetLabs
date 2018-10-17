using System.Collections.Generic;
using System.Linq;

namespace Lab3
{
    class BookRepository
    {
        private List<Book> bookList;
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
                bookList.OrderByDescending(x => x.Year);
                lastSort = 1;
            }
            return bookList;
        }

        public List<Book> RetriveAllOrderByYearAscending()
        {
            if (lastSort != 2)
            {
                bookList.OrderBy(x => x.Year);
                lastSort = 2;
            }
            return bookList;
        }

        public List<Book> RetriveAllOrderByPriceDescending()
        {
            if (lastSort != 3)
            {
                bookList.OrderByDescending(x => x.Price);
                lastSort = 3;
            }
            return bookList;
        }

        public List<Book> RetriveAllOrderByPriceAscending()
        {
            if (lastSort != 4)
            {
                bookList.OrderBy(x => x.Price);
                lastSort = 4;
            }
            return bookList;
        }

        public List<Book> RetriveAllBooksGroupedByGenre(Book.Generes genre)
        {
            List<Book> list = new List<Book> (bookList.Where(x => x.Genre == genre));
            return list;
        }
    }
}
