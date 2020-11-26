using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreData.Concretes
{
    public class PublisherRepository
    {
        private readonly BookStoreDbContext _db;
        public PublisherRepository()
        {
            _db = new BookStoreDbContext();
        }
        
        public IEnumerable<Book> GetPublisherBooks(Publisher publisher)
        {
            return _db.Books.Where(x => x.PublisherId == publisher.PublisherId).ToList();
        }

        public IEnumerable<Publisher> GetPublishers()
        {
            return _db.Publishers.ToList();
        }
    }
}
