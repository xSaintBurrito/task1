using System;
namespace DataLayer
{
    public class Rent
    {
        public Client _client { get; set; }
        public Book _book{ get; set; }
        public DateTime _takeDate { get; set; }
        public DateTime _expirationDate { get; set; }
        public Rent(Client client,Book book)
        {
            _client = client;
            _book = book;
            _takeDate = DateTime.Now;
            _expirationDate = _takeDate.AddDays(30);
        }
    }
}
