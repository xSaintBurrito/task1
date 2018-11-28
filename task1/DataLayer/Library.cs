using System;
using System.Collections.Generic;
using DataLayer;
namespace DataLayer
{
    public class Library : ILibrary
    {
        void ILibrary.showHistoryEvents(){
            foreach(Event _event in pastEvent){
                Console.WriteLine(_event.mess);
            }
        }
        bool ILibrary.addClient(Client client){
            if (!this.checkClientExist(client))
            {
                clients.Add(client);
                Event addClientEvent = new Event();
                addClientEvent.OnLibraryAfter += (text) => Console.WriteLine("you add client " + text);
                addClientEvent.addEvent(client._id.ToString() + " " + client._name + " " + client._surname);
                pastEvent.Add(addClientEvent);
                return true;
            }
            else
            {
                return false;
            } 
        }
        bool ILibrary.deleteClient(Client client){
            if(clients.Remove(client)){
                Event deleteClient = new Event();
                deleteClient.OnLibraryAfter += (text) => Console.WriteLine("you delete client " + text);
                deleteClient.addEvent(client._id.ToString() + " " + client._name + " " + client._surname);
                pastEvent.Add(deleteClient);
                return true;
            }
            else{
                return false;
            }
        }

        bool checkClientExist(Client new_client){
            foreach (Client client in clients)
            {
                if(client._id == new_client._id){
                    return true;
                }
            }
            return false;
        }
        void ILibrary.showclients(){
            foreach(Client client in clients){
                Console.WriteLine("id " + client._id + " name " + client._name + " " + client._surname + " " + client._adress);
            }
        }
        bool ILibrary.eraseBook(Book book){
            foreach (KeyValuePair<String, Book> _book in books)
            {
                if (_book.Value._id == book._id)
                {
                    if(books.Remove(_book))
                    {
                        Event renting = new Event();
                        renting.OnLibraryAfter += (text) => Console.WriteLine("You delete " + text);
                        renting.addEvent(_book.Value._id.ToString());
                        pastEvent.Add(renting);
                        return true;
                    }
                    else{
                        return false;
                    }
                }
            }
            return false;
        }
        void ILibrary.showbooks(){
            foreach (KeyValuePair<String, Book> _book in books)
            {
                Console.WriteLine("title -> " + _book.Key + " author id " + _book.Value._authorName);
            }
        }
        bool ILibrary.rentBook(Book book, Client client)
        {
            if (clients.Contains(client) && client.number_of_books < 3)
            {
                foreach (KeyValuePair<String, Book> _book in books)
                {
                    if (Equals(_book.Value._title, book._title) && _book.Value._isTaken == false)
                    {
                        _book.Value._isTaken = true;
                        Event renting = new Event();
                        renting.OnLibraryAfter += (text) => Console.WriteLine("you rent " + text);
                        renting.addEvent(_book.Value._id.ToString());
                        pastEvent.Add(renting);
                        client.number_of_books++;
                        return true;
                    }
                }
                return false;
            }
            else{
                return false;
            }
        }
        bool ILibrary.giveBackBook(Book book, Client client)
        {
            if (clients.Contains(client))
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
                        client.number_of_books--;
                        return true;
                    }
                }
                return false;
            }
            else
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
        private List<KeyValuePair<string, Book>> books;
        public Library()
        {
            pastEvent = new List<Event>();
            clients = new List<Client>();
            rents = new List<Rent>();
            books = new List<KeyValuePair<string, Book>>();
        }
        

       /* public bool addClient(Client client)
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
        */

        public bool addClient(Client client)
        {
            if (clients.Exists(c => c._id == client._id)) return false;
            clients.Add(client);
            return true;
        }


    }

}
