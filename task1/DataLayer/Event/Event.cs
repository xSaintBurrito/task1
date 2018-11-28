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
        public String mess { get; set; }


        protected virtual void LibraryAfter(String mess){
            this.mess = mess;
            if(OnLibraryAfter != null)
                OnLibraryAfter(mess);
        }
    }
}
