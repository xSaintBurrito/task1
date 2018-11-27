using System;
using System.Collections.Generic;
using DataLayer;
namespace DataLayer
{
    public class Library : ILibrary
    {
        void ILibrary.showbooks(){
            foreach (KeyValuePair<String, Book> _book in books)
            {

                Console.WriteLine("title -> " + _book.Key + " author id " + _book.Value._authorName);
            }
        }
        bool ILibrary.rentBook(Book book, Client client)
        {

            foreach( KeyValuePair<String,Book> _book in books){
                if(Equals(_book.Value._title,book._title) && _book.Value._isTaken == false){
                    _book.Value._isTaken = true;
                    Event renting = new Event();
                    renting.OnLibraryAfter += (text) => Console.WriteLine("you rent " + text);
                    renting.addEvent(_book.Value._id.ToString());
                    pastEvent.Add(renting);
                    return true;
                }
            }
            return false;
        }
        bool ILibrary.giveBackBook(Book book, Client client)
        {
            foreach (KeyValuePair<String, Book> _book in books)
            {
                if (_book.Value._isTaken == true && _book.Value._id == book._id)
                {
                    _book.Value._isTaken = false;
                    Event giveBack = new Event();
                    giveBack.OnLibraryAfter += (text) => Console.WriteLine("you give back " + text);
                    giveBack.addEvent(_book.Value._id.ToString());
                    pastEvent.Add(giveBack);
                    return true;
                }
            }
            return false;
        }

        bool ILibrary.addBook(Book book)
        {
            foreach (KeyValuePair<String, Book> _book in books)
            {
                if (_book.Value._id == book._id)
                {
                    Console.WriteLine("wrong id");
                    return false;
                }
            }
            books.Add(new KeyValuePair<string, Book>(book._title, book));
            return true;
        }
        void ILibrary.fillBooks(FillInterface fill){
            fill.addBooks(ref books);
        }

        private List<Event> pastEvent;
        private List<Client> clients;
        private List<Rent> rents;
        private List<Incident> incidents;
        private List<KeyValuePair<string, Book>> books;
        public Library()
        {
            pastEvent = new List<Event>();
            clients = new List<Client>();
            rents = new List<Rent>();
            incidents = new List<Incident>();
            books = new List<KeyValuePair<string, Book>>();
        }
        

        public bool addClient(Client client)
        {
            bool valid_id = true;
            int id = client._id;
            for (int i = 0; i < clients.Count; i++)
            {
                if (clients[i]._id == id)
                    valid_id = false;
            }
            if (valid_id == true)
            {
                clients.Add(client);
                return valid_id;
            }
            return valid_id;
        }



    }

}
