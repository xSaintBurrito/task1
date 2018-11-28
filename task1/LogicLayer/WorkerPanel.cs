using System;
using DataLayer;
namespace LogicLayer
{
    public class WorkerPanel
    {
        private ILibrary library;
        public WorkerPanel(ILibrary library)
        {
            this.library = library;
        }

        public bool addBook(Book book){
            return library.addBook(book);
        }
        public bool deleteBook(Book book)
        {
            return library.eraseBook(book);
        }
    }
}
