using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace SQLConnection
{

    [TestFixture]
    class TestConnectToDataBase
    {
        /*hier wird getestet ob die namen von DB sind innerhalb c# programm richtig gespeichert */
        [TestCase]
        public void TestBenutzernamen() /*Benutzer namen von Mitarbeiter */
        {
            ConnectToDataBase c = new ConnectToDataBase(); // hier wird Verbindung gesetzt und erstellt // Sprint 1 
            c.Read(); // hier wird die information von Database to C# programm transportiert und innerhalb informationlist gespeichert 

            Assert.AreEqual("maxm", c.informationenList[0][1]);
            Assert.AreEqual("thomasm", c.informationenList[1][1]);
            Assert.AreEqual("jakobs", c.informationenList[2][1]);
        }
        [TestCase]
        /** hier wird getestet ob all Mitabeiter_ID wird richitg innerhalb Programm gelessen*/
        public void TestMitarbeiterID()
        {
            ConnectToDataBase b = new ConnectToDataBase();
            b.Read();
            Assert.AreEqual(1, Int32.Parse(b.informationenList[0][0]));
            Assert.AreEqual(2, Int32.Parse(b.informationenList[1][0]));
            Assert.AreEqual(3, Int32.Parse(b.informationenList[2][0]));

        }

        [TestCase]
        public void TestRolleVonMitarbeiter()
        {
            /**hier wird dir RolleVonMitarbeiter geprüft*/
            ConnectToDataBase b = new ConnectToDataBase();
            b.Read();
            Assert.AreEqual("Mitarbeiter", (b.informationenList[0][8]));
            Assert.AreEqual("Administrator", (b.informationenList[1][8]));
            Assert.AreEqual("Mitarbeiter", (b.informationenList[2][8]));
        }

        [TestCase]
        public void TestVornameVonMitarbeiter()
        {
            ConnectToDataBase b = new ConnectToDataBase();
            b.Read();
            Assert.AreEqual("Max", (b.informationenList[0][4]));
            Assert.AreEqual("Thomas", (b.informationenList[1][4]));
            Assert.AreEqual("Jakob", (b.informationenList[2][4]));
        }

        [TestCase]
        public void TestNameVonMitarbeiter()

        {
            ConnectToDataBase b = new ConnectToDataBase();
            b.Read();
            Assert.AreEqual("Mustermann", (b.informationenList[0][5]));
            Assert.AreEqual("Müller", (b.informationenList[1][5]));
            Assert.AreEqual("Schwarz", (b.informationenList[2][5]));
        }
        

    }
}
