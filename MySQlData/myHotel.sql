-- MySQL dump 10.13  Distrib 8.0.18, for Win64 (x86_64)
--
-- Host: localhost    Database: hotel_db
-- ------------------------------------------------------
-- Server version	8.0.18

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
-- Table structure for table `admin`
--

DROP TABLE IF EXISTS `admin`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `admin` (
  `login_id` varchar(10) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `password` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  PRIMARY KEY (`login_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `admin`
--

LOCK TABLES `admin` WRITE;
/*!40000 ALTER TABLE `admin` DISABLE KEYS */;
INSERT INTO `admin` VALUES ('pan','202CB962AC59075B964B07152D234B');
/*!40000 ALTER TABLE `admin` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `dishlist`
--

DROP TABLE IF EXISTS `dishlist`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `dishlist` (
  `dish_id` int(11) NOT NULL AUTO_INCREMENT,
  `dish_name` varchar(10) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `unit` varchar(10) NOT NULL,
  `price` decimal(18,0) NOT NULL,
  PRIMARY KEY (`dish_id`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `dishlist`
--

LOCK TABLES `dishlist` WRITE;
/*!40000 ALTER TABLE `dishlist` DISABLE KEYS */;
INSERT INTO `dishlist` VALUES (1,'冷热牛奶','盒',15),(2,'炒饭','份',20),(3,'咖啡','杯',50),(4,'炸鸡','份',39),(5,'啤酒','瓶',8),(6,'鲜炸果汁','杯',20),(7,'冷热牛奶','盒',15);
/*!40000 ALTER TABLE `dishlist` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `guestrecord`
--

DROP TABLE IF EXISTS `guestrecord`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `guestrecord` (
  `guest_id` int(11) NOT NULL AUTO_INCREMENT,
  `guest_name` char(20) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `gender` varchar(1) NOT NULL,
  `identity_id` varchar(20) NOT NULL,
  `phone` varchar(11) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `room_id` int(11) NOT NULL,
  `reside_id` int(11) NOT NULL,
  `reside_date` date NOT NULL,
  `deposit` decimal(18,0) NOT NULL,
  `total_money` decimal(18,0) DEFAULT NULL,
  `dish_price` decimal(18,0) DEFAULT NULL,
  `leave_date` date DEFAULT NULL,
  `trade_no` varchar(10) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL,
  PRIMARY KEY (`guest_id`)
) ENGINE=InnoDB AUTO_INCREMENT=20 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `guestrecord`
--

LOCK TABLES `guestrecord` WRITE;
/*!40000 ALTER TABLE `guestrecord` DISABLE KEYS */;
INSERT INTO `guestrecord` VALUES (1,'张三','男','5227209','13330802831',1,1,'2023-08-01',100,120,88,'1900-01-01',''),(2,'李四','女','7069660','15242809707',2,1,'2023-08-02',50,112,99,'1900-01-01',''),(3,'王五','男','2843489','13863779668',2,2,'2023-01-03',100,112,77,'2023-07-12','41422'),(4,'戈辞','女','8256694','13139521147',4,2,'2023-05-07',80,100,50,'2023-08-01','76173'),(5,'刘大夫','男','6697480','17288126872',3,2,'2023-06-30',90,7040,75,'2023-09-26','1443276603'),(6,'温赛道','男','8978501','18432653172',1,2,'2023-03-16',77,110,55,'2023-05-08','37986'),(7,'黎得芳','女','9985502','18524147774',7,2,'2023-01-11',56,90,100,'2023-02-22',' 93609'),(8,'及开','男','8022270','18524491014',8,2,'2023-02-08',70,70,60,'2023-06-20','73677'),(9,'赵柳','女','4595614','15369271878',4,2,'2023-02-16',100,200,40,'2023-06-09','43482'),(10,'顿叶农','男','9205915','13994814301',1,2,'2023-02-28',95,150,10,'2023-06-26','63908'),(18,'pan','男','123','123',5,2,'2023-09-25',100,2000,0,'2023-09-25','855854660'),(19,'coco','男','111','222',5,2,'2023-09-25',100,2000,0,'2023-09-25','1945933255');
/*!40000 ALTER TABLE `guestrecord` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `residestate`
--

DROP TABLE IF EXISTS `residestate`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `residestate` (
  `reside_id` int(11) NOT NULL,
  `reside_name` varchar(45) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  PRIMARY KEY (`reside_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `residestate`
--

LOCK TABLES `residestate` WRITE;
/*!40000 ALTER TABLE `residestate` DISABLE KEYS */;
INSERT INTO `residestate` VALUES (1,'未结账'),(2,'已结账');
/*!40000 ALTER TABLE `residestate` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `room`
--

DROP TABLE IF EXISTS `room`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `room` (
  `room_id` int(11) NOT NULL AUTO_INCREMENT,
  `roomtype_id` int(11) NOT NULL,
  `roomstate_id` int(11) NOT NULL,
  `description` varchar(200) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `bed_num` int(11) NOT NULL,
  PRIMARY KEY (`room_id`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `room`
--

LOCK TABLES `room` WRITE;
/*!40000 ALTER TABLE `room` DISABLE KEYS */;
INSERT INTO `room` VALUES (1,1,1,'1号房间',1),(2,4,1,'2号房间',4),(3,3,2,'3号房间',2),(4,5,3,'4号房间',6),(5,2,2,'5号房间',3),(6,5,3,'6号房间',6),(7,3,2,'7号房间',1),(8,3,2,'8号房间',1),(9,1,2,'9号房间',1),(10,2,2,'10号房间',2);
/*!40000 ALTER TABLE `room` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `roomstate`
--

DROP TABLE IF EXISTS `roomstate`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `roomstate` (
  `roomstate_id` int(11) NOT NULL AUTO_INCREMENT,
  `roomstate_name` varchar(10) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  PRIMARY KEY (`roomstate_id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `roomstate`
--

LOCK TABLES `roomstate` WRITE;
/*!40000 ALTER TABLE `roomstate` DISABLE KEYS */;
INSERT INTO `roomstate` VALUES (1,'入住'),(2,'空闲'),(3,'维修');
/*!40000 ALTER TABLE `roomstate` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `roomtype`
--

DROP TABLE IF EXISTS `roomtype`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `roomtype` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `type_name` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `type_price` decimal(18,0) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `roomtype`
--

LOCK TABLES `roomtype` WRITE;
/*!40000 ALTER TABLE `roomtype` DISABLE KEYS */;
INSERT INTO `roomtype` VALUES (1,'标准房',120),(2,'长包房',90),(3,'日租房',80),(4,'小资客房',200),(5,'总统套房',2000),(6,'单人间',400),(7,'豪华间',800),(8,'经济适用房',100000);
/*!40000 ALTER TABLE `roomtype` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-09-26 10:24:18
