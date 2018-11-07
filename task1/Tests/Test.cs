using NUnit.Framework;
using System;
using DataLayer;
using LogicLayer;
namespace Tests
{
    [TestFixture()]
    public class Test
    {
        [Test()]
        public void TestCase()
        {
            UserPanel userPanel = new UserPanel();
            Book book = new Book(2, "elo elo", "twoja stara", DateTime.Today);
            Client client = new Client("jan", "pawel", "ul.elo");
            Assert.AreEqual(false, userPanel.rentBook(book, client));
        }
    }
}
