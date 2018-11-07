using System;
using System.Collections.Generic;
namespace DataLayer
{
    public class Library
    {
        List<Client> clients;
        public Library(){

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
    }
}
