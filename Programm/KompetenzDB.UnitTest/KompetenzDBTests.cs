using NUnit.Framework;
using GUI;

namespace KompetenzDB.UnitTest
{
    public class KompetenzDBTests
    {
        /// <summary>
        /// Test für Einfügen mitarbeiter Data in MySQL
        /// </summary>
        [Test]
        public void InsertDataTest()
        {
            //arrange
            var test = new insertData();
            //act
            string ergebnis =test.InsertData("Unittest", "passwort", "max", "mustermann", "code", "it", "mitarbeiter");
            //assert
            Assert.AreEqual("Unittestpasswortmaxmustermanncodeitmitarbeiter", ergebnis);
        }
        /// <summary>
        /// Test für Einfügen Kompetenz Data in MySQL
        /// </summary>
        [Test]
        public void InsertKompetenzTest()
        {
            //arrange
            var test = new insertData();
            //act
            string ergebnis = test.InsertKompetenz("KompetenzTest", "Test", "-", "Beschreibung");
            //assert
            Assert.AreEqual("KompetenzTestTest-Beschreibung", ergebnis);
        }
        /// <summary>
        /// Test für Einfügen Projekt Data in MySQL
        /// </summary>
        [Test]
        public void InsertProjektTest()
        {
            //arrange
            var test = new insertData();
            //act
            string ergebnis = test.InsertProjekt("ProjektTest", "2020-01-01", "2020-01-23", "Beschreibung test");
            //assert
            Assert.AreEqual("ProjektTest2020-01-012020-01-23Beschreibung test", ergebnis);
        }
        /// <summary>
        /// Test damit man Passwort zu Hash String umwandeln
        /// </summary>
        [Test]
        public void HashStringTest()
        {
            //arrange
            string password = "123";
            //act
            string ergebnis = Encrypt.HashString(password);
            //assert
            Assert.AreEqual("0A60650A405902004202F09D04107E0480670EF0DC04F0B80A004A01F03F0FF01F0A007E09908E0860F70F70A207A0E3", ergebnis);
        }
        /// <summary>
        /// Test damit man Passwort zu Salt String umwandeln und hier wird die lange von dem Ergebnis
        /// gezählt weil die Salt sich immer verändert
        /// </summary>
        [Test]
        public void SaltStringTest()
        {
            //arrange
            string password = "123";
            //act
            string ergebnis = Encrypt.SaltString(password);
            //assert
            Assert.AreEqual(96, ergebnis.Length);
        }
        /// <summary>
        /// Test wie man Salt erstellen kann  und hier wird die lange von dem Ergebnis
        /// gezählt weil die Salt sich immer verändert
        /// </summary>
        [Test]
        public void CreateSaltTest()
        {
            //act
            string ergebnis = Encrypt.CreateSalt(10);
            //assert
            Assert.AreEqual(16, ergebnis.Length);
        }
        /// <summary>
        /// Test wie man Hash Data bekommen und hier wird die lange von dem Ergebnis
        /// gezählt weil die byte sich immer verändert
        /// </summary>
        [Test]
        public void GetHashTest()
        {
            //arrange
            string password = "123";
            //act
            byte[] ergebnis = Encrypt.GetHash(password);
            //assert
            Assert.AreEqual(32, ergebnis.Length);
        }
        /// <summary>
        /// Test wie man Salt Data bekommen und hier wird die lange von dem Ergebnis
        /// gezählt weil die byte sich immer verändert
        /// </summary>
        [Test]
        public void GetSaltTest()
        {
            //arrange
            string password = "123";
            string salt = Encrypt.CreateSalt(10);
            //act
            byte[] ergebnis = Encrypt.GetSalt(password,salt);
            //assert
            Assert.AreEqual(32, ergebnis.Length);
        }
    }
}
