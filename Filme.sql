-- MySQL dump 10.13  Distrib 8.0.23, for Win64 (x86_64)
--
-- Host: localhost    Database: filme
-- ------------------------------------------------------
-- Server version	8.0.23

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `filme`
--

DROP TABLE IF EXISTS `filme`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `filme` (
  `id` int NOT NULL,
  `titulo` varchar(45) DEFAULT NULL,
  `estudio` varchar(45) DEFAULT NULL,
  `data` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `filme`
--

LOCK TABLES `filme` WRITE;
/*!40000 ALTER TABLE `filme` DISABLE KEYS */;
INSERT INTO `filme` VALUES (1,'The Incredible Hulk','Marvel','12/06/2008'),(2,'Iron Man','Marvel','30/04/2008'),(3,'Iron Man 2','Marvel','28/04/2010'),(4,'Thor','Marvel','21/04/2011'),(5,'Captain America: The First Avenger','Marvel','22/07/2011'),(6,'The Avengers','Marvel','25/04/2012'),(7,'Iron Man 3','Marvel','18/04/2013'),(8,'Thor: The Dark World','Marvel','29/10/2013'),(9,'Captain America: The Winter Soldier','Marvel','20/03/2014'),(10,'Guardians of the Galaxy','Marvel','30/07/2014'),(11,'Avengers: Age of Ultron','Marvel','22/04/2015'),(12,'Ant-Man','Marvel','14/07/2015'),(13,'Captain America: Civil War','Marvel','27/04/2016'),(14,'Doctor Strange','Marvel','25/10/2016'),(15,'Guardians of the Galaxy Vol. 2','Marvel','19/04/2017'),(16,'Spider-Man: Homecoming','Marvel','05/07/2017'),(17,'Thor: Ragnarok','Marvel','25/10/2017'),(18,'Black Panther','Marvel','13/02/2018'),(19,'Avengers: Infinity War','Marvel','25/04/2018'),(20,'Ant-Man and the Wasp','Marvel','04/07/2018'),(21,'Captain Marvel','Marvel','08/03/2019'),(22,'Avengers: Endgame','Marvel','26/04/2019'),(23,'Spider-Man: Far From Home','Marvel','05/07/2019');
/*!40000 ALTER TABLE `filme` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'filme'
--

--
-- Dumping routines for database 'filme'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-04-09 10:10:11
