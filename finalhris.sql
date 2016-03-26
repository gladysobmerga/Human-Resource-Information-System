-- MySQL dump 10.10
--
-- Host: localhost    Database: final_hris
-- ------------------------------------------------------
-- Server version	5.0.22-community-nt

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
-- Table structure for table `employees`
--

DROP TABLE IF EXISTS `employees`;
CREATE TABLE `employees` (
  `count` int(11) unsigned NOT NULL auto_increment,
  `Employee_Code` int(11) NOT NULL default '0',
  `Position` varchar(50) default NULL,
  `Department` varchar(50) default NULL,
  `Status` varchar(50) default NULL,
  `Date_Started` varchar(50) default NULL,
  `Username` varchar(50) default NULL,
  `Password` varchar(50) default NULL,
  PRIMARY KEY  (`count`,`Employee_Code`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `employees`
--


/*!40000 ALTER TABLE `employees` DISABLE KEYS */;
LOCK TABLES `employees` WRITE;
INSERT INTO `employees` VALUES (1,1,'','','','','lol','lol'),(2,3,'','','','','be','be'),(3,5,'','','','','',''),(4,32,'hoo','hooo','hoo','hoo','hooo','hoo'),(5,0,'','','','','',''),(6,0,'','','','','',''),(7,0,'','','','','',''),(8,0,'','','','','',''),(9,0,'','','','','',''),(10,0,'','','','','',''),(11,0,'','','','','',''),(12,0,'','','','','',''),(13,0,'','','','','',''),(14,36,'hi','hi','hi','hi','hi','hi'),(15,0,'','','','','',''),(16,0,'','','','','',''),(17,0,'','','','','',''),(18,0,'','','','','',''),(19,0,'','','','','',''),(20,0,'','','','','',''),(21,0,'','','','','',''),(22,0,'','','','','',''),(23,0,'','','','','',''),(24,0,'','','','','',''),(25,0,'','','','','',''),(26,0,'','','','','',''),(27,0,'','','','','',''),(28,0,'','','','','',''),(29,0,'','','','','',''),(30,0,'','','','','',''),(31,0,'','','','','',''),(32,0,'','','','','',''),(33,0,'','','','','',''),(34,0,'','','','','',''),(35,0,'','','','','',''),(36,0,'','','','','',''),(37,0,'','','','','',''),(38,0,'','','','','',''),(39,0,'','','','','',''),(40,0,'','','','','',''),(41,0,'','','','','',''),(42,0,'','','','','',''),(43,0,'','','','','',''),(44,0,'','','','','',''),(45,0,'','','','','',''),(46,0,'','','','','',''),(47,0,'','','','','',''),(48,0,'','','','','',''),(49,0,'','','','','',''),(50,0,'','','','','',''),(51,0,'','','','','',''),(52,0,'','','','','',''),(53,0,'','','','','',''),(54,0,'','','','','',''),(55,0,'','','','','',''),(56,0,'','','','','',''),(57,0,'','','','','',''),(58,0,'','','','','',''),(59,0,'','','','','',''),(60,0,'','','','','',''),(61,0,'','','','','',''),(62,0,'','','','','',''),(63,0,'','','','','',''),(64,0,'','','','','',''),(65,0,'','','','','',''),(66,0,'','','','','',''),(67,0,'','','','','',''),(68,0,'','','','','',''),(69,0,'','','','','',''),(70,0,'','','','','',''),(71,0,'','','','','',''),(72,0,'','','','','',''),(73,0,'','','','','',''),(74,0,'','','','','',''),(75,0,'','','','','',''),(76,0,'','','','','',''),(77,0,'','','','','',''),(78,0,'','','','','',''),(79,0,'','','','','',''),(80,0,'','','','','',''),(81,0,'','','','','',''),(82,0,'','','','','',''),(83,0,'','','','','',''),(84,0,'','','','','',''),(85,0,'','','','','',''),(86,0,'','','','','',''),(87,0,'','','','','',''),(88,0,'','','','','',''),(89,0,'','','','','',''),(90,0,'','','','','',''),(91,0,'','','','','',''),(92,0,'','','','','',''),(93,0,'','','','','',''),(94,0,'','','','','',''),(95,0,'','','','','',''),(96,0,'','','','','',''),(97,0,'','','','','',''),(98,0,'','','','','',''),(99,0,'','','','','',''),(100,0,'','','','','',''),(101,0,'','','','','','');
UNLOCK TABLES;
/*!40000 ALTER TABLE `employees` ENABLE KEYS */;

--
-- Table structure for table `payroll_sheet`
--

DROP TABLE IF EXISTS `payroll_sheet`;
CREATE TABLE `payroll_sheet` (
  `id` smallint(5) unsigned NOT NULL auto_increment,
  `Employee_ID` int(11) NOT NULL default '0',
  `Salary_Rate` int(11) default NULL,
  PRIMARY KEY  (`id`,`Employee_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `payroll_sheet`
--


/*!40000 ALTER TABLE `payroll_sheet` DISABLE KEYS */;
LOCK TABLES `payroll_sheet` WRITE;
INSERT INTO `payroll_sheet` VALUES (1,5,4),(2,3,5),(3,0,0),(4,0,0),(5,0,0),(6,19,19),(7,0,0),(8,0,0),(9,0,0),(10,100,100),(11,0,0),(12,0,0),(24,3,0),(25,0,0),(26,0,0);
UNLOCK TABLES;
/*!40000 ALTER TABLE `payroll_sheet` ENABLE KEYS */;

--
-- Table structure for table `personal_information`
--

DROP TABLE IF EXISTS `personal_information`;
CREATE TABLE `personal_information` (
  `Count` int(11) unsigned NOT NULL auto_increment,
  `Employee_ID` int(11) NOT NULL default '0',
  `Username` varchar(50) default NULL,
  `Password` varchar(50) default NULL,
  `First_Name` varchar(50) default NULL,
  `Last_Name` varchar(50) default NULL,
  `Middle_Name` varchar(50) default NULL,
  `Age` int(11) default NULL,
  `Gender` varchar(5) default NULL,
  `Zip_Code` int(11) default NULL,
  `Email_Address` varchar(50) default NULL,
  `Contact_Number` int(11) default NULL,
  `Contact_Person_in_case_of_emergency` varchar(50) default NULL,
  `Employees_Contact_Person_Number` varchar(50) default NULL,
  `Highest_Educational_Attainment` varchar(50) default NULL,
  `College_University` varchar(50) default NULL,
  `Date_Graduated` varchar(50) default NULL,
  `Previous_Employment` varchar(50) default NULL,
  `Previous_Position` varchar(50) default NULL,
  `Employer_Contact_Number` int(11) default NULL,
  PRIMARY KEY  (`Count`,`Employee_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `personal_information`
--


/*!40000 ALTER TABLE `personal_information` DISABLE KEYS */;
LOCK TABLES `personal_information` WRITE;
INSERT INTO `personal_information` VALUES (1,1,'lol','lol','lol','lol','lol',1,'1',1,'lol',1,'lol','1','lol','lol','lol','lol','lol',1),(2,3,'be','be','be','be','be',0,'be',0,'be',0,'be','1','be','be','be','be','be',0),(3,0,'','','','','',0,'',0,'',0,'','','','','','','',0),(4,0,'','','','','',0,'',0,'',0,'','','','','','','',0),(5,0,'','','','','',0,'',0,'',0,'','','','','','','',0),(6,0,'','','','','',0,'',0,'',0,'','','','','','','',0),(7,0,'','','','','',0,'',0,'',0,'','','','','','','',0),(8,0,'','','','','',0,'',0,'',0,'','','','','','','',0),(9,0,'','','','','',0,'',0,'',0,'','','','','','','',0),(10,0,'','','','','',0,'',0,'',0,'','','','','','','',0),(11,0,'','','','','',0,'',0,'',0,'','','','','','','',0),(12,0,'','','','','',0,'',0,'',0,'','','','','','','',0),(13,0,'','','','','',0,'',0,'',0,'','','','','','','',0),(14,0,'','','','','',0,'',0,'',0,'','','','','','','',0),(15,0,'','','','','',0,'',0,'',0,'','','','','','','',0),(16,0,'','','','','',0,'',0,'',0,'','','','','','','',0),(17,10,'boom','boom','boom','boom','boom',1,'1',1234,'boom',3,'boom','3','boom','boom','boom','boom','boom',1),(18,0,'','','','','',0,'',0,'',0,'','','','','','','',0),(19,0,'','','','','',0,'',0,'',0,'','','','','','','',0),(20,4,'lele','lel','lel','lel','lel',4,'4',4343,'lel',43,'lel','0909','lel','lel','lel','lel','lel',909),(21,0,'','','','','',0,'',0,'',0,'','','','','','','',0),(22,0,'','','','','',0,'',0,'',0,'','','','','','','',0),(23,32,'hooo','hoo','hoo','hoo','hooo',1,'1',1,'ooo',1,'hoo','1','hooo','hoo','hoo','hoo','hooo',1),(24,0,'','','','','',0,'',0,'',0,'','','','','','','',0),(25,0,'','','','','',0,'',0,'',0,'','','','','','','',0),(26,0,'','','','','',0,'',0,'',0,'','','','','','','',0),(27,0,'','','','','',0,'',0,'',0,'','','','','','','',0),(28,0,'','','','','',0,'',0,'',0,'','','','','','','',0),(29,0,'','','','','',0,'',0,'',0,'','','','','','','',0),(30,0,'','','','','',0,'',0,'',0,'','','','','','','',0),(31,0,'','','','','',0,'',0,'',0,'','','','','','','',0),(32,0,'','','','','',0,'',0,'',0,'','','','','','','',0),(33,36,'hi','hi','hi','hi','hi',1,'hi',3,'hi',0,'hi','1','hi','hi','hi','hi','hi',3),(34,0,'','','','','',0,'',0,'',0,'','','','','','','',0),(35,0,'','','','','',0,'',0,'',0,'','','','','','','',0),(36,0,'','','','','',0,'',0,'',0,'','','','','','','',0),(37,0,'','','','','',0,'',0,'',0,'','','','','','','',0),(38,0,'','','','','',0,'',0,'',0,'','','','','','','',0),(39,0,'','','','','',0,'',0,'',0,'','','','','','','',0),(40,0,'','','','','',0,'',0,'',0,'','','','','','','',0),(41,0,'','','','','',0,'',0,'',0,'','','','','','','',0),(42,0,'','','','','',0,'',0,'',0,'','','','','','','',0),(43,0,'','','','','',0,'',0,'',0,'','','','','','','',0),(44,0,'','','','','',0,'',0,'',0,'','','','','','','',0),(45,0,'','','','','',0,'',0,'',0,'','','','','','','',0),(46,0,'','','','','',0,'',0,'',0,'','','','','','','',0),(47,0,'','','','','',0,'',0,'',0,'','','','','','','',0),(48,0,'','','','','',0,'',0,'',0,'','','','','','','',0),(49,0,'','','','','',0,'',0,'',0,'','','','','','','',0),(50,0,'','','','','',0,'',0,'',0,'','','','','','','',0),(51,0,'','','','','',0,'',0,'',0,'','','','','','','',0),(52,0,'','','','','',0,'',0,'',0,'','','','','','','',0),(53,0,'','','','','',0,'',0,'',0,'','','','','','','',0),(54,0,'','','','','',0,'',0,'',0,'','','','','','','',0),(55,0,'','','','','',0,'',0,'',0,'','','','','','','',0),(56,0,'','','','','',0,'',0,'',0,'','','','','','','',0),(57,0,'','','','','',0,'',0,'',0,'','','','','','','',0),(58,0,'','','','','',0,'',0,'',0,'','','','','','','',0),(59,0,'','','','','',0,'',0,'',0,'','','','','','','',0),(60,0,'','','','','',0,'',0,'',0,'','','','','','','',0),(61,0,'','','','','',0,'',0,'',0,'','','','','','','',0),(62,0,'','','','','',0,'',0,'',0,'','','','','','','',0),(63,0,'','','','','',0,'',0,'',0,'','','','','','','',0),(64,0,'','','','','',0,'',0,'',0,'','','','','','','',0),(65,0,'','','','','',0,'',0,'',0,'','','','','','','',0),(66,0,'','','','','',0,'',0,'',0,'','','','','','','',0),(67,0,'','','','','',0,'',0,'',0,'','','','','','','',0),(68,0,'','','','','',0,'',0,'',0,'','','','','','','',0),(69,0,'','','','','',0,'',0,'',0,'','','','','','','',0),(70,0,'','','','','',0,'',0,'',0,'','','','','','','',0),(71,0,'','','','','',0,'',0,'',0,'','','','','','','',0),(72,0,'','','','','',0,'',0,'',0,'','','','','','','',0),(73,0,'','','','','',0,'',0,'',0,'','','','','','','',0),(74,0,'','','','','',0,'',0,'',0,'','','','','','','',0),(75,0,'','','','','',0,'',0,'',0,'','','','','','','',0),(76,0,'','','','','',0,'',0,'',0,'','','','','','','',0),(77,0,'','','','','',0,'',0,'',0,'','','','','','','',0),(78,0,'','','','','',0,'',0,'',0,'','','','','','','',0),(79,0,'','','','','',0,'',0,'',0,'','','','','','','',0),(80,0,'','','','','',0,'',0,'',0,'','','','','','','',0),(81,0,'','','','','',0,'',0,'',0,'','','','','','','',0),(82,0,'','','','','',0,'',0,'',0,'','','','','','','',0),(83,0,'','','','','',0,'',0,'',0,'','','','','','','',0),(84,0,'','','','','',0,'',0,'',0,'','','','','','','',0),(85,0,'','','','','',0,'',0,'',0,'','','','','','','',0),(86,0,'','','','','',0,'',0,'',0,'','','','','','','',0),(87,0,'','','','','',0,'',0,'',0,'','','','','','','',0),(88,0,'','','','','',0,'',0,'',0,'','','','','','','',0),(89,0,'','','','','',0,'',0,'',0,'','','','','','','',0),(90,0,'','','','','',0,'',0,'',0,'','','','','','','',0),(94,0,'','','','','',0,'',0,'',0,'','','','','','','',0),(95,0,'','','','','',0,'',0,'',0,'','','','','','','',0),(96,0,'','','','','',0,'',0,'',0,'','','','','','','',0),(97,0,'','','','','',0,'',0,'',0,'','','','','','','',0),(98,0,'','','','','',0,'',0,'',0,'','','','','','','',0),(99,0,'','','','','',0,'',0,'',0,'','','','','','','',0),(100,0,'','','','','',0,'',0,'',0,'','','','','','','',0),(101,0,'','','','','',0,'',0,'',0,'','','','','','','',0),(102,0,'','','','','',0,'',0,'',0,'','','','','','','',0),(103,0,'','','','','',0,'',0,'',0,'','','','','','','',0),(104,0,'','','','','',0,'',0,'',0,'','','','','','','',0),(105,0,'','','','','',0,'',0,'',0,'','','','','','','',0),(106,0,'','','','','',0,'',0,'',0,'','','','','','','',0),(107,0,'','','','','',0,'',0,'',0,'','','','','','','',0),(108,0,'','','','','',0,'',0,'',0,'','','','','','','',0),(109,0,'','','','','',0,'',0,'',0,'','','','','','','',0),(110,0,'','','','','',0,'',0,'',0,'','','','','','','',0),(111,0,'','','','','',0,'',0,'',0,'','','','','','','',0),(112,0,'','','','','',0,'',0,'',0,'','','','','','','',0),(113,0,'','','','','',0,'',0,'',0,'','','','','','','',0),(114,0,'','','','','',0,'',0,'',0,'','','','','','','',0),(115,0,'','','','','',0,'',0,'',0,'','','','','','','',0),(116,0,'','','','','',0,'',0,'',0,'','','','','','','',0),(117,0,'','','','','',0,'',0,'',0,'','','','','','','',0),(118,0,'','','','','',0,'',0,'',0,'','','','','','','',0),(119,0,'','','','','',0,'',0,'',0,'','','','','','','',0),(120,0,'','','','','',0,'',0,'',0,'','','','','','','',0);
UNLOCK TABLES;
/*!40000 ALTER TABLE `personal_information` ENABLE KEYS */;

--
-- Table structure for table `project_report`
--

DROP TABLE IF EXISTS `project_report`;
CREATE TABLE `project_report` (
  `Date_Modified` varchar(50) NOT NULL default '',
  `Project_Title` varchar(50) default NULL,
  `Project_Number` int(11) default NULL,
  `Assigned_To` int(11) default NULL,
  `Status` varchar(50) default NULL,
  `Link` varchar(50) default NULL,
  `Reply_With_the_Client` varchar(50) default NULL,
  `What_have_you_Learned` varchar(50) default NULL,
  PRIMARY KEY  (`Date_Modified`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `project_report`
--


/*!40000 ALTER TABLE `project_report` DISABLE KEYS */;
LOCK TABLES `project_report` WRITE;
UNLOCK TABLES;
/*!40000 ALTER TABLE `project_report` ENABLE KEYS */;

--
-- Table structure for table `time_sheet`
--

DROP TABLE IF EXISTS `time_sheet`;
CREATE TABLE `time_sheet` (
  `count` int(11) unsigned NOT NULL auto_increment,
  `Employee_ID` int(11) default NULL,
  `Total_Hours_Required` int(11) default NULL,
  `Total_Hours_Left` int(11) default NULL,
  `Date` varchar(50) default NULL,
  `Time_In` varchar(50) default NULL,
  `Time_Out` varchar(50) default NULL,
  `Number_of_Hours` int(11) default NULL,
  PRIMARY KEY  (`count`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `time_sheet`
--


/*!40000 ALTER TABLE `time_sheet` DISABLE KEYS */;
LOCK TABLES `time_sheet` WRITE;
INSERT INTO `time_sheet` VALUES (1,2,100,50,'1','1','1',1),(4,3,200,150,'10/13/2015','8am','5pm',8),(5,4,300,200,'10/1/2015','8:30am','5pm',7),(6,5,100,50,'10/1/2015','8am','5pm',8);
UNLOCK TABLES;
/*!40000 ALTER TABLE `time_sheet` ENABLE KEYS */;

--
-- Table structure for table `user_login`
--

DROP TABLE IF EXISTS `user_login`;
CREATE TABLE `user_login` (
  `count` int(11) unsigned NOT NULL auto_increment,
  `Username` varchar(50) default NULL,
  `Date_Login` varchar(50) default NULL,
  `Password` varchar(50) default NULL,
  PRIMARY KEY  (`count`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `user_login`
--


/*!40000 ALTER TABLE `user_login` DISABLE KEYS */;
LOCK TABLES `user_login` WRITE;
INSERT INTO `user_login` VALUES (1,'admin','lol','admin'),(2,'admin','10/11/2015 8:21:10 AM','admin'),(3,'employee','10/11/2015 8:24:34 AM','employee'),(4,'employee','10/11/2015 8:25:55 AM','employee'),(5,'admin','10/11/2015 8:30:17 AM','admin'),(6,'admin','10/11/2015 8:32:25 AM','admin'),(7,'admin','10/11/2015 8:45:26 AM','admin'),(8,'employee','10/11/2015 9:24:56 PM','employee'),(9,'admin','10/11/2015 9:40:10 PM','admin'),(10,'employee','10/12/2015 12:24:35 AM','employee'),(11,'employee','10/12/2015 12:26:58 AM','employee'),(12,'employee','10/12/2015 12:51:50 AM','employee'),(13,'employee','10/12/2015 2:38:56 AM','employee'),(14,'employee','10/12/2015 2:42:09 AM','employee'),(15,'employee','10/12/2015 6:11:07 AM','employee'),(16,'admin','10/12/2015 6:22:33 AM','admin'),(17,'admin','10/12/2015 6:23:34 AM','admin'),(18,'admin','10/12/2015 6:24:04 AM','admin'),(19,'employee','10/12/2015 6:41:04 AM','employee'),(20,'employee','10/12/2015 6:43:42 AM','employee'),(21,'employee','10/12/2015 6:46:24 AM','employee'),(22,'employee','10/12/2015 6:48:54 AM','employee'),(23,'employee','10/12/2015 8:01:13 AM','employee'),(24,'employee','10/12/2015 8:02:24 AM','employee'),(25,'employee','10/12/2015 8:03:14 AM','employee'),(26,'employee','10/12/2015 8:04:49 AM','employee'),(27,'employee','10/12/2015 8:05:59 AM','employee'),(28,'employee','10/12/2015 8:07:12 AM','employee'),(29,'employee','10/12/2015 8:08:31 AM','employee'),(30,'admin','10/12/2015 8:16:07 AM','admin'),(31,'admin','10/12/2015 8:16:58 AM','admin'),(32,'admin','10/12/2015 8:18:54 AM','admin'),(33,'employee','10/12/2015 8:26:35 AM','employee'),(34,'employee','10/12/2015 8:29:16 AM','employee'),(35,'employee','10/12/2015 8:34:04 AM','employee'),(36,'employee','10/12/2015 8:36:43 AM','employee'),(37,'employee','10/12/2015 8:37:27 AM','employee'),(38,'employee','10/12/2015 8:44:11 AM','employee'),(39,'employee','10/12/2015 8:44:48 AM','employee'),(40,'employee','10/12/2015 8:46:38 AM','employee'),(41,'employee','10/12/2015 8:47:09 AM','employee'),(42,'admin','10/12/2015 9:03:30 AM','admin'),(43,'employee','10/12/2015 9:08:28 AM','employee'),(44,'admin','10/13/2015 8:50:02 AM','admin'),(45,'employee','10/13/2015 9:08:44 AM','employee'),(46,'employee','10/13/2015 11:07:57 AM','employee'),(47,'employee','10/13/2015 11:14:40 AM','employee'),(48,'employee','10/13/2015 11:59:49 AM','employee'),(49,'employee','10/13/2015 12:01:01 PM','employee'),(50,'employee','10/13/2015 12:02:49 PM','employee'),(51,'employee','10/13/2015 12:04:01 PM','employee'),(52,'employee','10/13/2015 12:04:56 PM','employee');
UNLOCK TABLES;
/*!40000 ALTER TABLE `user_login` ENABLE KEYS */;

--
-- Table structure for table `zip_code`
--

DROP TABLE IF EXISTS `zip_code`;
CREATE TABLE `zip_code` (
  `Zip_code` int(11) NOT NULL default '0',
  `Baranggay` varchar(50) default NULL,
  `Municipality` varchar(50) default NULL,
  `Region` varchar(50) default NULL,
  PRIMARY KEY  (`Zip_code`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `zip_code`
--


/*!40000 ALTER TABLE `zip_code` DISABLE KEYS */;
LOCK TABLES `zip_code` WRITE;
UNLOCK TABLES;
/*!40000 ALTER TABLE `zip_code` ENABLE KEYS */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

