CREATE DATABASE  IF NOT EXISTS `kompetenzdb` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `kompetenzdb`;
-- MariaDB dump 10.17  Distrib 10.4.14-MariaDB, for Win64 (AMD64)
--
-- Host: 127.0.0.1    Database: kompetenzdb
-- ------------------------------------------------------
-- Server version	10.4.14-MariaDB

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `kompetenz`
--

DROP TABLE IF EXISTS `kompetenz`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `kompetenz` (
  `Kompetenz_ID` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(45) NOT NULL,
  `Bezeichnung` varchar(45) DEFAULT NULL,
  `Alternativebezeichnung` varchar(45) DEFAULT NULL,
  `Beschreibung` longtext DEFAULT NULL,
  PRIMARY KEY (`Kompetenz_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `kompetenz`
--

LOCK TABLES `kompetenz` WRITE;
/*!40000 ALTER TABLE `kompetenz` DISABLE KEYS */;
INSERT INTO `kompetenz` VALUES (1,'Textverarbeitungte','Schreibprogramm',NULL,'die Erstellung und Bearbeitung von schriftlichen Texten mithilfe von organisatorischen und technischen Mitteln'),(2,'Tabellenkalkulation',NULL,NULL,'Eingabe und Verarbeitung von numerischen und alphanumerischen Daten in Form einer Tabelle'),(3,'Präsentationsprogramme','Präsentation',NULL,'Erarbeitung und Präsentation eines Vortrages oder Referates unterstützt.'),(4,'Frontend','User Interface / User Experience','UI / UX','Entwicklung dynamischer Anwendungen sowie die Konzeption moderner und nutzerfreundlicher User-Interfaces'),(5,'Backend','Programmierung','Coding','Tätigkeit, Computerprogramme zu erstellen');
/*!40000 ALTER TABLE `kompetenz` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `mitarbeiter`
--

DROP TABLE IF EXISTS `mitarbeiter`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `mitarbeiter` (
  `Mitarbeiter_ID` int(11) NOT NULL AUTO_INCREMENT,
  `Benutzername` varchar(20) NOT NULL,
  `Hashedpasswort` varbinary(256) NOT NULL,
  `Saltedpasswort` varbinary(256) NOT NULL,
  `Vorname` varchar(20) DEFAULT NULL,
  `Name` varchar(20) NOT NULL,
  `Aufgabenbereich` varchar(20) NOT NULL,
  `Abteilung` varchar(20) NOT NULL,
  `Rolle` varchar(20) NOT NULL,
  `Biographie` longtext DEFAULT NULL,
  `Deaktiviert` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`Mitarbeiter_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `mitarbeiter`
--

LOCK TABLES `mitarbeiter` WRITE;
/*!40000 ALTER TABLE `mitarbeiter` DISABLE KEYS */;
INSERT INTO `mitarbeiter` VALUES (1,'maxm','09B0870690A40A704209509A02D0020980C306F0B70060230F20DF0AC0DA08403602307D0F008D08D0FD05B03703704C','0260450800C60040400ED09209009606D01F0210B10D609500603409607D0D70DC0050810E60E80EB06702905109F00C','Max','Mustermann','Backend','IT','Mitarbeiter','',0),(2,'thomasm','09B0870690A40A704209509A02D0020980C306F0B70060230F20DF0AC0DA08403602307D0F008D08D0FD05B03703704C','0440FC0B503D0290EA04001C07E0FC01B0520820730AE02E0C903F0850620C402709006F0580BC0AD07E0210F60A90B5','Thomas','Müller','System','IT','Administrator','',0),(3,'jakobs','09B0870690A40A704209509A02D0020980C306F0B70060230F20DF0AC0DA08403602307D0F008D08D0FD05B03703704C','0140E80440D10180EE0A300B0E60350FC0680EB0AC01904007E03505C0E40FD09C0AF07D0A40D40F40D20140B2034092','Jakob','Schwarz','Content Manager','IT','Mitarbeiter','',0);
/*!40000 ALTER TABLE `mitarbeiter` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `mitarbeiter_hat_kompetenz`
--

DROP TABLE IF EXISTS `mitarbeiter_hat_kompetenz`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `mitarbeiter_hat_kompetenz` (
  `Zugeordnete_Mitarbeiter` int(11) NOT NULL,
  `Zugeordnete_Kompetenz` int(11) NOT NULL,
  PRIMARY KEY (`Zugeordnete_Mitarbeiter`,`Zugeordnete_Kompetenz`),
  KEY `fk_Mitarbeiter_has_Kompetenzen_Kompetenzen1_idx` (`Zugeordnete_Kompetenz`),
  KEY `fk_Mitarbeiter_has_Kompetenzen_Mitarbeiter1_idx` (`Zugeordnete_Mitarbeiter`),
  CONSTRAINT `fk_Mitarbeiter_has_Kompetenzen_Kompetenzen1` FOREIGN KEY (`Zugeordnete_Kompetenz`) REFERENCES `kompetenz` (`Kompetenz_ID`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_Mitarbeiter_has_Kompetenzen_Mitarbeiter1` FOREIGN KEY (`Zugeordnete_Mitarbeiter`) REFERENCES `mitarbeiter` (`Mitarbeiter_ID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `mitarbeiter_hat_kompetenz`
--

LOCK TABLES `mitarbeiter_hat_kompetenz` WRITE;
/*!40000 ALTER TABLE `mitarbeiter_hat_kompetenz` DISABLE KEYS */;
INSERT INTO `mitarbeiter_hat_kompetenz` VALUES (1,5),(2,5),(3,4),(4,4),(5,4);
/*!40000 ALTER TABLE `mitarbeiter_hat_kompetenz` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `mitarbeiter_hat_projekt`
--

DROP TABLE IF EXISTS `mitarbeiter_hat_projekt`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `mitarbeiter_hat_projekt` (
  `Zugeordnete_Mitarbeiter` int(11) NOT NULL,
  `Zugeordnete_Projekt` int(11) NOT NULL,
  PRIMARY KEY (`Zugeordnete_Mitarbeiter`,`Zugeordnete_Projekt`),
  KEY `fk_Mitarbeiter_has_Projekt_Projekt1_idx` (`Zugeordnete_Projekt`),
  KEY `fk_Mitarbeiter_has_Projekt_Mitarbeiter_idx` (`Zugeordnete_Mitarbeiter`),
  CONSTRAINT `fk_Mitarbeiter_has_Projekt_Mitarbeiter` FOREIGN KEY (`Zugeordnete_Mitarbeiter`) REFERENCES `mitarbeiter` (`Mitarbeiter_ID`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_Mitarbeiter_has_Projekt_Projekt1` FOREIGN KEY (`Zugeordnete_Projekt`) REFERENCES `projekt` (`Projekt_ID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `mitarbeiter_hat_projekt`
--

LOCK TABLES `mitarbeiter_hat_projekt` WRITE;
/*!40000 ALTER TABLE `mitarbeiter_hat_projekt` DISABLE KEYS */;
/*!40000 ALTER TABLE `mitarbeiter_hat_projekt` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `projekt`
--

DROP TABLE IF EXISTS `projekt`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `projekt` (
  `Projekt_ID` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(45) NOT NULL,
  `Start` date NOT NULL,
  `Ende` date DEFAULT NULL,
  `Beschreibung` longtext DEFAULT NULL,
  PRIMARY KEY (`Projekt_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `projekt`
--

LOCK TABLES `projekt` WRITE;
/*!40000 ALTER TABLE `projekt` DISABLE KEYS */;
INSERT INTO `projekt` VALUES (1,'Flöhmarkt Webapplikation','2020-02-01','2020-12-15','Es handelt sich um eine Webapplikation für Marktplatz für gebrauchte Ware'),(2,'Ballspiel Android','2019-05-30','2019-07-28','Es ist eine Ballspiel wird in Android Handy betrieben'),(3,'Kompetenzdatenbank','2021-10-20',NULL,'Datenbankanwendung, die Mitarbeiter, Projekte und Kompetenzen verwaltet in Desktop');
/*!40000 ALTER TABLE `projekt` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `projekt_hat_kompetenz`
--

DROP TABLE IF EXISTS `projekt_hat_kompetenz`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `projekt_hat_kompetenz` (
  `Zugeordnete_Projekt` int(11) NOT NULL,
  `Zugeordnete_Kompetenz` int(11) NOT NULL,
  PRIMARY KEY (`Zugeordnete_Projekt`,`Zugeordnete_Kompetenz`),
  KEY `fk_Projekt_has_Kompetenzen_Kompetenzen1_idx` (`Zugeordnete_Kompetenz`),
  KEY `fk_Projekt_has_Kompetenzen_Projekt1_idx` (`Zugeordnete_Projekt`),
  CONSTRAINT `fk_Projekt_has_Kompetenzen_Kompetenzen1` FOREIGN KEY (`Zugeordnete_Kompetenz`) REFERENCES `kompetenz` (`Kompetenz_ID`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_Projekt_has_Kompetenzen_Projekt1` FOREIGN KEY (`Zugeordnete_Projekt`) REFERENCES `projekt` (`Projekt_ID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `projekt_hat_kompetenz`
--

LOCK TABLES `projekt_hat_kompetenz` WRITE;
/*!40000 ALTER TABLE `projekt_hat_kompetenz` DISABLE KEYS */;
/*!40000 ALTER TABLE `projekt_hat_kompetenz` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `unterkompetenz`
--

DROP TABLE IF EXISTS `unterkompetenz`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `unterkompetenz` (
  `Unterkompetenz_ID` int(11) NOT NULL,
  `Kompetenz_id` int(11) NOT NULL,
  `Name` varchar(45) NOT NULL,
  PRIMARY KEY (`Unterkompetenz_ID`),
  KEY `Unterkompetenz_idx` (`Kompetenz_id`),
  CONSTRAINT `fk_unterkompetenz` FOREIGN KEY (`Kompetenz_id`) REFERENCES `kompetenz` (`Kompetenz_ID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `unterkompetenz`
--

LOCK TABLES `unterkompetenz` WRITE;
/*!40000 ALTER TABLE `unterkompetenz` DISABLE KEYS */;
INSERT INTO `unterkompetenz` VALUES (1,4,'Bildverarbeitung'),(2,4,'Content Management'),(3,5,'Datenbankmanagement'),(4,5,'Softwareentwicklung'),(5,5,'IT-Sicherheit'),(6,4,'HTML & CSS Programmierung');
/*!40000 ALTER TABLE `unterkompetenz` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping routines for database 'kompetenzdb'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

<<<<<<< HEAD:Datenbank/Dump mit Deaktiviert.sql
-- Dump completed on 2022-01-12 11:55:11
=======
-- Dump completed on 2022-01-22 11:41:44
>>>>>>> Kenneth:Datenbank/DumpAktuell.sql
