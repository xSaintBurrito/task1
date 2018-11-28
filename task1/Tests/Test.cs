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
        public void LibraryClientMenagment()
        {
            FillInterface fill = new FillLibrary(30);
            ILibrary library = new Library(); 
            library.fillBooks(fill);
            Client tomek = new Client(0, "Tomek", "One", "warszawa");
            Client romek = new Client(1, "Romek", "Two", "warszawa");
            Client atomek = new Client(2, "Atomek", "Three", "warszawa");
            WorkerPanel workerPanel = new WorkerPanel(library);
            Assert.AreEqual(true,workerPanel.addClient(tomek));
            Assert.AreEqual(true, workerPanel.addClient(romek));
            Assert.AreEqual(true, workerPanel.deleteClient(romek));
            Assert.AreEqual(false, workerPanel.deleteClient(atomek));
        }

        [Test()]
        public void LibraryBookMenagment()
        {
            FillInterface fill = new FillLibrary(30);
            ILibrary library = new Library();
            library.fillBooks(fill);
            WorkerPanel workerPanel = new WorkerPanel(library);
            Book LOTR = new Book(31, "J.R.R", "LOTR", DateTime.Now);
            Book starwars = new Book(32, "Miekka fryta", "Star wars", DateTime.Now);
            Assert.AreEqual(true,workerPanel.addBook(LOTR));
            Assert.AreEqual(false, workerPanel.deleteBook(starwars));
            Assert.AreEqual(true, workerPanel.deleteBook(LOTR));
            workerPanel.showCurrentStateBooks();


        }
        /*
        [Test()]
        public void TestCase()
        {
            FillInterface fill = new FillLibrary(30);
            ILibrary library = new Library();
            library.fillBooks(fill);
            //library.showbooks();
            UserPanel userPanel = new UserPanel(library);
            WorkerPanel workerPanel = new WorkerPanel(library);
            Client tomek = new Client(0, "tomek", "elo", "warszawa");
            Book tytul = new Book(4, "elo", "title4", DateTime.Now);
            workerPanel.addClient(tomek);
            Assert.AreEqual(true, userPanel.rentaBook(tytul, tomek));
            Assert.AreEqual(true, userPanel.giveBackBook(tytul, tomek));
        }
        [Test()]
        public void TestCase()
        {
            FillInterface fill = new FillLibrary(30);
            ILibrary library = new Library();
            library.fillBooks(fill);
            //library.showbooks();
            UserPanel userPanel = new UserPanel(library);
            WorkerPanel workerPanel = new WorkerPanel(library);
            Client tomek = new Client(0, "tomek", "elo", "warszawa");
            Book tytul = new Book(4, "elo", "title4", DateTime.Now);
            workerPanel.addClient(tomek);
            Assert.AreEqual(true, userPanel.rentaBook(tytul, tomek));
            Assert.AreEqual(true, userPanel.giveBackBook(tytul, tomek));
        }*/
    }
}
