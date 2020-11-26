using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreData.Concretes
{
    public class AuthorRepository
    {
        private readonly BookStoreDbContext _db;
        public AuthorRepository()
        {
            _db = new BookStoreDbContext();
        }
        public IEnumerable<Book> GetAuthorBooks(Author author)
        {
            return _db.Books.Where(x => x.AuthorId == author.AuthorId).ToList();
        }

        public IEnumerable<Author> GetAuthors()
        {
            return _db.Authors.ToList();
        }
    }
}
