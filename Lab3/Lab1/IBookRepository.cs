using System.Collections.Generic;

namespace Lab3
{
    public interface IBookRepository
    {
        void AddBook(Book toAdd);

        List<Book> RetriveAllBooks();

        List<Book> RetriveAllOrderByYearDescending();

        List<Book> RetriveAllOrderByYearAscending();

        List<Book> RetriveAllOrderByPriceDescending();

        List<Book> RetriveAllOrderByPriceAscending();
    
        List<Book> RetriveAllBooksGroupedByGenre(Generes genre);
    }
}
