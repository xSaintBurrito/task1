using System;
using System.Collections.Generic;
namespace DataLayer
{
    public class FillLibrary : FillInterface
    {
        private int generate;
        public FillLibrary(int howMany){
            this.generate = howMany;
        }
        public void addBooks(ref List<KeyValuePair<string, Book>> books)
        {
            for (int i = 0; i < this.generate; i++){
                books.Add(new KeyValuePair<string, Book>("title"+i,new Book(i,"author"+i, "title" + i,DateTime.Now)));   
            }
        }
        public void addClients(ref List<Client> clients)
        {
            for (int i = 0; i < this.generate; i++)
            {
                clients.Add(new Client(i, " name" + i, " surname" + i, " adress" + i));
            }
        }
    }
}
