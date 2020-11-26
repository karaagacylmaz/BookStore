using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreData.Concretes
{
    public class BookRepository
    {
        private readonly BookStoreDbContext _db;
        public BookRepository()
        {
            _db = new BookStoreDbContext();
        }
        public void AddBookToStock(Book book)
        {
            _db.Books.Add(book);
            _db.SaveChanges();
        }

        public Book CheckStock(string isbn)
        {
            return _db.Books.FirstOrDefault(x => x.Isbn == isbn);
        }

        public IEnumerable<Book> CheckStock(List<string> isbnList)
        {
            return _db.Books.Where(x => isbnList.Contains(x.Isbn)).ToList();
        }
    }
}
