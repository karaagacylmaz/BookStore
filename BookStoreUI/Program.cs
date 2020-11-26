using BookStoreUI.AuthorService;
using BookStoreUI.BookService;
using BookStoreUI.PublisherService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Publisher = BookStoreUI.PublisherService.Publisher;

namespace BookStoreUI
{
    class Program
    {
        static void Main(string[] args)
        {
            BookService.Book newBook = new BookService.Book
            {
                AuthorId = 1,
                Format = "PRINTED",
                Isbn = "123-asd-1234",
                NextStockDate = DateTime.Now.AddMonths(2),
                Preface = "önsöz123",
                PublisherId = 1,
                QuantityLeft = 2,
                ReleaseDate = DateTime.Now,
                Version = 1,
                WarehouseLocation = 5
            };

            //client.ClientCredentials.UserName.UserName = "test1";
            //client.ClientCredentials.UserName.Password = "1tset";




            BookServiceClient client = new BookServiceClient();
            var book = client.CheckStock("978-975-4187-53-3");
            var isbnList = new List<string>();
            isbnList.Add("978-975-4187-53-3");
            var bookList = client.CheckStocks(isbnList.ToArray());
            string message = client.AddBookToStock(newBook);
            client.Close();

            Console.WriteLine(book.AuthorName);
            Console.WriteLine(book.BookId);
            Console.WriteLine(book.Format);
            Console.WriteLine(book.Isbn);
            Console.WriteLine(book.IsValidIsbn);
            Console.WriteLine(book.NextStockDate);
            Console.WriteLine(book.Preface);
            Console.WriteLine(book.PublisherName);
            Console.WriteLine(book.QuantityLeft);
            Console.WriteLine(book.ReleaseDate);
            Console.WriteLine(book.Version);
            Console.WriteLine(book.WarehouseLocation);
            //---------------------------------------
            Console.WriteLine("---------------------------------------");
            Console.WriteLine(bookList.FirstOrDefault().AuthorName);
            Console.WriteLine("---------------------------------------");
            Console.WriteLine(message);

            Console.WriteLine("----------AUTHOR-----------------------------");
            var author = new AuthorService.Author()
            {
                AuthorId = 1
            };
            AuthorServiceClient authorClient = new AuthorServiceClient();
            var authorList = authorClient.GetAuthors();
            var authorBooks = authorClient.GetAuthorBooks(author);
            authorClient.Close();
            Console.WriteLine(authorList.FirstOrDefault().FirstName);
            Console.WriteLine(authorBooks.FirstOrDefault().Isbn);
            Console.WriteLine("----------Publisher-----------------------------");
            var publisher = new Publisher()
            {
                PublisherId = 1
            };
            PublisherServiceClient publisherClient = new PublisherServiceClient();
            var publisherList = publisherClient.GetPublishers();
            var publisherBooks = publisherClient.GetPublisherBooks(publisher);
            publisherClient.Close();
            Console.WriteLine(publisherList.FirstOrDefault().PublisherName);
            Console.WriteLine(publisherBooks.FirstOrDefault().Isbn);

            Console.ReadLine();

        }
    }
}
