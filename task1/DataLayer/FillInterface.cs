using System;
using System.Collections.Generic;
namespace DataLayer
{
    public interface FillInterface
    {
        bool addBooks(List<Book> books,Library library);
        bool addClients(List<Client> clients, Library library);
    }
}
