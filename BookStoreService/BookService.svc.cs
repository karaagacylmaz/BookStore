using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using BookStoreBusiness.BookBusiness;
using BookStoreData;
using BookStoreService.DTOs;

namespace BookStoreService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "BookService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select BookService.svc or BookService.svc.cs at the Solution Explorer and start debugging.
    public class BookService : IBookService
    {
        private readonly BookLogic _bookLogic;
        public BookService()
        {
            _bookLogic = new BookLogic();
        }

        public string AddBookToStock(Book book)
        {
            string message = "";
            try
            {
              message = _bookLogic.AddBookToStock(book);
            }
            catch (Exception ex)
            {
                message = ex.Message;
            }
            return message;
        }

        public BookDTO CheckStock(string isbn)
        {
            var book = _bookLogic.CheckStock(isbn);
            return new BookDTO
            {
                AuthorName = book.Author.FirstName + ' ' + book.Author.LastName,
                BookId = book.BookId,
                Format = book.Format,
                Isbn = book.Isbn,
                IsValidIsbn = book.IsValidIsbn,
                Message = "",
                StatusCode = 200,
                NextStockDate = book.NextStockDate,
                Preface = book.Preface,
                PublisherName = book.Publisher.PublisherName,
                QuantityLeft = book.QuantityLeft,
                ReleaseDate = book.ReleaseDate,
                Version = book.Version,
                WarehouseLocation = book.WarehouseLocation,
            };
        }

        public List<BookDTO> CheckStock(List<string> isbn)
        {
            var books = new List<BookDTO>();
            var bookList = _bookLogic.CheckStock(isbn).ToList();
            foreach (var book in bookList)
            {
                books.Add(new BookDTO
                {
                    AuthorName = book.Author.FirstName + ' ' + book.Author.LastName,
                    BookId = book.BookId,
                    Format = book.Format,
                    Isbn = book.Isbn,
                    IsValidIsbn = book.IsValidIsbn,
                    Message = "",
                    StatusCode = 200,
                    NextStockDate = book.NextStockDate,
                    Preface = book.Preface,
                    PublisherName = book.Publisher.PublisherName,
                    QuantityLeft = book.QuantityLeft,
                    ReleaseDate = book.ReleaseDate,
                    Version = book.Version,
                    WarehouseLocation = book.WarehouseLocation,
                });
            }
            return books;
        }
    }
}
