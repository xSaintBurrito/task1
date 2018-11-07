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
        public void addBooks(List<Book> books)
        {
            for (int i = 0; i < this.generate;i++){
                books.Add(new Book(i, "author" + i, "title" + i, DateTime.Now));
            }
        }
        public void addClients(List<Client> clients)
        {
            for (int i = 0; i < this.generate; i++)
            {
                clients.Add(new Client(i, " name" + i, " surname" + i, " adress" + i));
            }
        }
    }
}
