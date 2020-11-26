using BookStoreData;
using BookStoreData.Concretes;
using BookStoreExternalServices;
//using BookStoreModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreBusiness.BookBusiness
{
    public class BookLogic
    {
        private readonly BookRepository _repository;
        public BookLogic()
        {
            _repository = new BookRepository();
        }

        public Book CheckStock(string isbn)
        {
            var book = _repository.CheckStock(isbn);
            return book;
        }

        public IEnumerable<Book> CheckStock(List<string> isbnList)
        {
            return _repository.CheckStock(isbnList);
        }

        public string AddBookToStock(Book book)
        {
            bool isValidIsbn = IsbnChecker.Check(book.Isbn);
            if (!isValidIsbn)
            {
                throw new Exception("ISBN NO Geçerli değil");
            }

            if (book.WarehouseLocation < 1 && book.WarehouseLocation > 999)
            {
                throw new Exception("Depo yeri geçerli değil");
            }

            book.IsValidIsbn = true;
            _repository.AddBookToStock(book);
            return "Yeni kitap başarıyla eklendi";
        }
    }
}
