using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace BookStoreService.DTOs
{
    [DataContract]
    public class BaseDTO
    {
        [DataMember]
        public string Message { get; set; } = "Başarılı";
        [DataMember]
        public int StatusCode { get; set; } = 200;
    }
}