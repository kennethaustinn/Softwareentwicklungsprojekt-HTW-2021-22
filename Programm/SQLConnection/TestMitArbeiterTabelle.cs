using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace SQLConnection
{

    [TestFixture]
    /**hier wird getestet ob die namen von DB sind innerhalb c# programm richtig gespeichert */
    class TestMitArbeiterTabelle
    {
        
        [TestCase]
        public void TestBenutzernamen() /**Benutzer namen von Mitarbeiter mittels NUNIT-TEST */
        {
            ConnectToDataBase c = new ConnectToDataBase();  /// Verbindung erstellt
            c.ReadMitarbeiter();  

            Assert.AreEqual("maxm", c.informationenList[0][1]);
            Assert.AreEqual("thomasm", c.informationenList[1][1]);
            Assert.AreEqual("jakobs", c.informationenList[2][1]);
        }
        [TestCase]
        /** hier wird getestet ob all Mitabeiter_ID wird richitg innerhalb Programm gelessen */
        public void TestMitarbeiterID()
        {
            ConnectToDataBase b = new ConnectToDataBase();
            b.ReadMitarbeiter();
            Assert.AreEqual(1, Int32.Parse(b.informationenList[0][0]));
            Assert.AreEqual(2, Int32.Parse(b.informationenList[1][0]));
            Assert.AreEqual(3, Int32.Parse(b.informationenList[2][0]));

        }

        [TestCase]
        /**hier wird dir RolleVonMitarbeiter geprüft*/
        public void TestRolleVonMitarbeiter()
        {
          
            ConnectToDataBase b = new ConnectToDataBase();
            b.ReadMitarbeiter();
            Assert.AreEqual("Mitarbeiter", (b.informationenList[0][8]));
            Assert.AreEqual("Administrator", (b.informationenList[1][8]));
            Assert.AreEqual("Mitarbeiter", (b.informationenList[2][8]));
        }

        [TestCase]
        /** VornamName von Mitarbeiter testen*/
        public void TestVornameVonMitarbeiter()
        {
            ConnectToDataBase b = new ConnectToDataBase();
            b.ReadMitarbeiter();
            Assert.AreEqual("Max", (b.informationenList[0][4]));
            Assert.AreEqual("Thomas", (b.informationenList[1][4]));
            Assert.AreEqual("Jakob", (b.informationenList[2][4]));
        }

        [TestCase]
        /** NachName von Mitarbeiter testen*/
        public void TestNameVonMitarbeiter()

        {
            ConnectToDataBase b = new ConnectToDataBase();
            b.ReadMitarbeiter();
            Assert.AreEqual("Mustermann", (b.informationenList[0][5]));
            Assert.AreEqual("Müller", (b.informationenList[1][5]));
            Assert.AreEqual("Schwarz", (b.informationenList[2][5]));
        }

        [TestCase]
        /**  Aufgabenbereichen von Mitarbeiter testen*/
        public void TestAufgabenbereichen()
        { 
        ConnectToDataBase b = new ConnectToDataBase();
        b.ReadMitarbeiter();

            Assert.AreEqual("Backend", (b.informationenList[0][6]));
            Assert.AreEqual("System", (b.informationenList[1][6]));
            Assert.AreEqual("Content Manager", (b.informationenList[2][6]));
        }

        [TestCase]
        
        public void TestAbteilung()

        {
            ConnectToDataBase b = new ConnectToDataBase();
               b.ReadMitarbeiter();

            Assert.AreEqual("IT", (b.informationenList[0][7]));
            Assert.AreEqual("IT", (b.informationenList[1][7]));
            Assert.AreEqual("IT", (b.informationenList[2][7]));
        }
    }
}
