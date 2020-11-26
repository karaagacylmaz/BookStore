using BookStoreData;
using BookStoreData.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreBusiness.BookBusiness
{
    public class PublisherLogic
    {
        private readonly PublisherRepository _repository;
        public PublisherLogic()
        {
            _repository = new PublisherRepository();
        }

        public IEnumerable<Book> GetPublisherBooks(Publisher publisher)
        {
            return _repository.GetPublisherBooks(publisher);
        }

        public IEnumerable<Publisher> GetPublishers()
        {
            return _repository.GetPublishers();
        }
    }
}
