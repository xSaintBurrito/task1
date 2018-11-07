using System;
namespace DataLayer
{
    public class Rent
    {
        public Client _client { get; set; }
        public Book _book{ get; set; }
        public Date _takeDate { get; set; }
        public Date _expirationDate { get; set; }
        public Rent(Client client,Book book,Date start, Date expiration)
        {
            _client = client;
            _book = book;
            _takeDate = start;
            _expirationDate = expiration;
        }
    }
}
