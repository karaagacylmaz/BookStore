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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "PublisherService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select PublisherService.svc or PublisherService.svc.cs at the Solution Explorer and start debugging.
    public class PublisherService : IPublisherService
    {
        private readonly PublisherLogic _publisherLogic;
        public PublisherService()
        {
            _publisherLogic = new PublisherLogic();
        }
        public IEnumerable<BookDTO> GetPublisherBooks(Publisher publisher)
        {
            List<BookDTO> books = new List<BookDTO>();
            var bookList = _publisherLogic.GetPublisherBooks(publisher);
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

        public IEnumerable<PublisherDTO> GetPublishers()
        {
            List<PublisherDTO> publishers = new List<PublisherDTO>();
            var publisherList =_publisherLogic.GetPublishers().ToList();
            publisherList.ForEach(x =>
            {
                publishers.Add(new PublisherDTO
                {
                    PublisherId = x.PublisherId,
                    PublisherName = x.PublisherName,
                });
            });

            return publishers;
        }
    }
}
