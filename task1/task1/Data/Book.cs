using System;
namespace task1
{
    public class Book
    {
        public Book(int id,String authorname,Date date, String title)
        {
            _id = id;
            _authorname = authorname;
            _dateofpublishing = date;
            _title = title;
            _isTaken = false;
        }
        public int _id{ get;set; }
        public String _authorname{ get;set; }

        public Date _dateofpublishing{ get;set; }
        public String _title{ get;set; }
        public bool _isTaken{ get;set; }
    }
}
