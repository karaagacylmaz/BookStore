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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "AuthorService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select AuthorService.svc or AuthorService.svc.cs at the Solution Explorer and start debugging.
    public class AuthorService : IAuthorService
    {
        private readonly AuthorLogic _authorLogic;
        public AuthorService()
        {
            _authorLogic = new AuthorLogic();
        }
        public IEnumerable<BookDTO> GetAuthorBooks(Author author)
        {
            List<BookDTO> books = new List<BookDTO>();
           var bookList = _authorLogic.GetAuthorBooks(author);
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

        public IEnumerable<AuthorDTO> GetAuthors()
        {
            List<AuthorDTO> authors = new List<AuthorDTO>();
           var authorList = _authorLogic.GetAuthors().ToList();
            authorList.ForEach(x =>
            {
                authors.Add(new AuthorDTO
                {
                    AuthorId = x.AuthorId,
                    FirstName = x.FirstName,
                    LastName = x.LastName
                });
            });

            return authors;
        }
    }
}
