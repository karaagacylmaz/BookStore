using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace BookStoreService.DTOs
{
    [DataContract]
    public class BookDTO : BaseDTO
    {
        [DataMember]
        public int BookId { get; set; }
        [DataMember]
        public string AuthorName { get; set; }
        [DataMember]
        public string PublisherName { get; set; }
        [DataMember]
        public string Isbn { get; set; }
        [DataMember]
        public bool IsValidIsbn { get; set; }
        [DataMember]
        public string Format { get; set; }
        [DataMember]
        public System.DateTime ReleaseDate { get; set; }
        [DataMember]
        public int Version { get; set; }
        [DataMember]
        public string Preface { get; set; }
        [DataMember]
        public int QuantityLeft { get; set; }
        [DataMember]
        public int WarehouseLocation { get; set; }
        [DataMember]
        public System.DateTime NextStockDate { get; set; }
    }
}
