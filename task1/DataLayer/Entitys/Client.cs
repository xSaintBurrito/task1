using System;
namespace DataLayer
{
    public class Client
    {
        public int _id { get; set; }
        public String _name { get; set; }
        public String _surname { get; set; }
        public String _adress { get; set; }
        public Client(int _id, String name,String surname,String adress)
        {
            _name = name;
            _surname = surname;
            _adress = adress;
        }
    }
}
