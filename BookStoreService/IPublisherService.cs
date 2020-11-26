using BookStoreData;
using BookStoreService.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace BookStoreService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IPublisherService" in both code and config file together.
    [ServiceContract]
    public interface IPublisherService
    {
        [OperationContract]
        IEnumerable<BookDTO> GetPublisherBooks(Publisher publisher);

        [OperationContract]
        IEnumerable<PublisherDTO> GetPublishers();
    }
}
