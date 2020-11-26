using BookStoreData;
using BookStoreData.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreBusiness.BookBusiness
{
    public class AuthorLogic
    {
        private readonly AuthorRepository _repository;
        public AuthorLogic()
        {
            _repository = new AuthorRepository();
        }

        public IEnumerable<Book> GetAuthorBooks(Author author)
        {
            return _repository.GetAuthorBooks(author);
        }

        public IEnumerable<Author> GetAuthors()
        {
            return _repository.GetAuthors();
        }
    }
}
