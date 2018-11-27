using System;
namespace DataLayer
{
    public class Event
    {
        public delegate void LibraryAfterEvent(String elo);
        public event LibraryAfterEvent OnLibraryAfter;
        public void addEvent(String mess){

            LibraryAfter(mess);
        }

        protected virtual void LibraryAfter(String mess){
            if(OnLibraryAfter != null)
                OnLibraryAfter(mess);
        }
    }
}
