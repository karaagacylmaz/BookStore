using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace BookStoreService.DTOs
{
    [DataContract]
    public class PublisherDTO : BaseDTO
    {
        [DataMember]
        public int PublisherId { get; set; }
        [DataMember]
        public string PublisherName { get; set; }
    }
}