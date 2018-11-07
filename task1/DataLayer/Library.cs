using System;
using System.Collections.Generic;
using DataLayer;
namespace DataLayer
{
    public class Library
    {
        private List<Client> clients;
        private List<Rent> rents;
        private List<Incident> incidents;
        private List<Book> books;
        public Library(){
            clients = new List<Client>();
            rents = new List<Rent>();
            incidents = new List<Incident>();
        }
        public bool addBook(Book book)
        {
            bool valid_id = true;
            int id = book._id;
            for (int i = 0; i < books.Count; i++)
            {
                if (clients[i]._id == id)
                    valid_id = false;
            }
            if (valid_id == true)
            {
                books.Add(book);
                return valid_id;
            }
            return valid_id;
        }

        public bool addClient(Client client){
            bool valid_id = true;
            int id = client._id;
            for (int i = 0; i < clients.Count;i++){
                if (clients[i]._id == id)
                    valid_id = false;
            }
            if(valid_id == true){
                clients.Add(client);
                return valid_id;
            }
            return valid_id;
        }
        public bool rentBook(Client client,Book book){
            if (book._isTaken == false){
                book._isTaken = true;
                Rent rent = new Rent(client, book);
                incidents.Add(new Incident("rent a book " + book._title + " by " + client._name + " " + client._surname));
                rents.Add(rent);
            }
            return false;
        }

        public bool returnBook(Client client,Book book){
            bool valid_operation = false;
            Rent temp = null;
            for (int i = 0; i < rents.Count; i++){
                if(book == rents[i]._book && client == rents[i]._client)
                {
                    temp = rents[i];
                    valid_operation = true;
                }
            }
            if (temp != null)
            {
                incidents.Add(new Incident("return a book " + book._title + " by " + client._name + " " + client._surname));
                rents.Remove(temp);
            }
            return valid_operation;
        }
    }
}
