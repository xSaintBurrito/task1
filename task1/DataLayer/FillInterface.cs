using System;
using System.Collections.Generic;
namespace DataLayer
{
    public interface FillInterface
    {
        void addBooks(ref List<KeyValuePair<string, Book>> books);
        void addClients(ref List<Client> clients);
    }
}
