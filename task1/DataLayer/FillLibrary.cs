using System;
using System.Collections.Generic;
namespace DataLayer
{
    public class FillLibrary : FillInterface
    {
        public bool addBooks(List<Book> books, Library library)
        {
            bool success = true;
            for (int i = 0; i < books.Count;i++){
                if( !library.addBook(books[i])) success = false;
            }
            return success;
        }
        public bool addClients(List<Client> clients, Library library)
        {
            bool success = true;
            for (int i = 0; i < clients.Count; i++)
            {
                if (!library.addClient(clients[i])) success = false;
            }
            return success;
        }
    }
}
