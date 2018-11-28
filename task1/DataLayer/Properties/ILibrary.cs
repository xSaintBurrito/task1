using System;
namespace DataLayer
{
    public interface ILibrary
    {
        bool rentBook(Book book,Client client);
        bool giveBackBook(Book book,Client client);
        bool addBook(Book book);
        void fillBooks(FillInterface fill);
        void showbooks();
        void showclients();
        void showHistoryEvents();
        bool eraseBook(Book book);
        bool addClient(Client client);
        bool deleteClient(Client client);
    }
}
