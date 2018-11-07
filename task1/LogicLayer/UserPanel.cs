using System;
using DataLayer;
namespace LogicLayer
{
    public class UserPanel
    {
        Library library;
        public UserPanel(){
            library = new Library();
        }
        public bool rentBook(Book book,Client client){
            return library.rentBook(client, book);
        }

        



    }
}
