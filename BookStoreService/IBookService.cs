using BookStoreData;
using BookStoreService.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace BookStoreService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IBookService" in both code and config file together.
    [ServiceContract]
    public interface IBookService
    {
        [OperationContract(Name = "CheckStock")]
        BookDTO CheckStock(string isbn);
        [OperationContract(Name = "CheckStocks")]
        List<BookDTO> CheckStock(List<string> isbn);
        [OperationContract]
        string AddBookToStock(Book book);
    }
}
