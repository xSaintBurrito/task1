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
            FillInterface fill = new FillLibrary(30);
            ILibrary library = new Library(); 
            library.fillBooks(fill);
            library.showbooks();
            UserPanel userPanel = new UserPanel(library);
            Client tomek = new Client(0,"tomek","elo","warszawa");
            Book tytul = new Book(0, "elo", "title2", DateTime.Now);
            Assert.AreEqual(true,userPanel.rentaBook(tytul,tomek));

        }
    }
}
