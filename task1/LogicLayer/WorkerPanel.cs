using System;
using DataLayer;
namespace LogicLayer
{
    public class WorkerPanel
    {
        private Library library;
        public WorkerPanel()
        {
            library = new Library();
        }

        public bool addClient(Client client){
            return library.addClient(client);
        }
    }
}
