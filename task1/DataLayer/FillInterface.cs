using System;
using System.Collections.Generic;
namespace DataLayer
{
    public interface FillInterface
    {
        bool addBooks(List<Book> books);
        bool addClients(List<Client> clients);
    }
}
