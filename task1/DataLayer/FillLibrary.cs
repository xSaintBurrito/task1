using System;
using System.Collections.Generic;
namespace DataLayer
{
    public class FillLibrary : FillInterface
    {

        int generate;
        public FillLibrary(int howMany){
            generate = howMany;
        }
        public bool addBooks(List<Book> books)
        {
            bool success = true;
            for (int i = 0; i < this.generate;i++){
                books.Add(new Book(i, "author" + i, "title" + i, DateTime.Now));
            }
            return success;
        }
        public bool addClients(List<Client> clients)
        {
            bool success = true;
            for (int i = 0; i < this.generate; i++)
            {
                clients.Add(new Client(i, " name" + i, " surname" + i, " adress" + i));
            }
            return success;
        }
    }
}
