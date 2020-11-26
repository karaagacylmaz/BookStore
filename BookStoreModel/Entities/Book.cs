using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreModel.Entities
{
    public class Book
    {
        public int BookId { get; set; }
        public int AuthorId { get; set; }
        public int PublisherId { get; set; }
        public string Isbn { get; set; }
        public bool IsValidIsbn { get; set; }
        public string Format { get; set; }
        public System.DateTime ReleaseDate { get; set; }
        public int Version { get; set; }
        public string Preface { get; set; }
        public int QuantityLeft { get; set; }
        public int WarehouseLocation { get; set; }
        public System.DateTime NextStockDate { get; set; }

        public virtual Author Author { get; set; }
        public virtual Publisher Publisher { get; set; }
    }
}
