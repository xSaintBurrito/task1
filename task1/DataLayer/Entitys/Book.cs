using System;
namespace DataLayer
{
    public class Book
    {
        public DateTime _publishedDate { get; set; }
        public bool _isTaken { get; set; }
        public String _authorName { get; set; }
        public String _title { get; set; }
        public int _id { get; set; }
        public Book(int id, String authorname, String title, DateTime publishDate)
        {
            _id = id;
            _authorName = authorname;
            _title = title;
            _isTaken = false;
            _publishedDate = publishDate;
        }
    }
}
