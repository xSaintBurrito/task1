using System;
using System.Collections.Generic;
namespace DataLayer
{
    public interface FillInterface
    {
        void addBooks(List<Book> books);
        void addClients(List<Client> clients);
    }
}
