using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace BookStoreService.DTOs
{
    [DataContract]
    public class AuthorDTO : BaseDTO
    {
        [DataMember]
        public int AuthorId { get; set; }
        [DataMember]
        public string FirstName { get; set; }
        [DataMember]
        public string LastName { get; set; }
    }
}