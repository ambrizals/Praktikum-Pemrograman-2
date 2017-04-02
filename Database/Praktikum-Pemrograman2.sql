-- MySQL dump 10.13  Distrib 5.7.12, for Win64 (x86_64)
--
-- Host: localhost    Database: toko
-- ------------------------------------------------------
-- Server version	5.7.15-log

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
-- Table structure for table `tblbarang`
--

DROP TABLE IF EXISTS `tblbarang`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tblbarang` (
  `ID_Barang` varchar(10) NOT NULL,
  `Nama_Barang` varchar(30) NOT NULL,
  `Merk_Barang` varchar(10) NOT NULL,
  `Satuan` varchar(10) NOT NULL,
  `Harga_Beli` double NOT NULL,
  `Harga_Jual` double NOT NULL,
  `Stok` double NOT NULL,
  PRIMARY KEY (`ID_Barang`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tblbarang`
--

LOCK TABLES `tblbarang` WRITE;
/*!40000 ALTER TABLE `tblbarang` DISABLE KEYS */;
INSERT INTO `tblbarang` VALUES ('BRG-001','Monitor','MRK-001','STN-001',300000,800000,10),('BRG-002','Printer','MRK-002','STN-002',420000,550000,20),('BRG-003','Mouse','MRK-003','STN-003',40000,80000,25),('BRG-004','Keyboard','MRK-004','STN-004',35000,60000,10),('BRG-005','Headset','MRK-005','STN-005',50000,100000,30),('BRG-006','Speaker','MRK-006','STN-006',120000,300000,15),('BRG-007','Flashdisk','MRK-007','STN-007',80000,120000,30),('BRG-008','Modem','MRK-008','STN-008',250000,400000,20),('BRG-009','Hardisk','MRK-009','STN-009',500000,850000,30);
/*!40000 ALTER TABLE `tblbarang` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tblkaryawan`
--

DROP TABLE IF EXISTS `tblkaryawan`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tblkaryawan` (
  `ID_Karyawan` varchar(10) NOT NULL,
  `Nama_Karyawan` varchar(30) NOT NULL,
  `Alamat` text NOT NULL,
  `Telepon` varchar(14) NOT NULL,
  PRIMARY KEY (`ID_Karyawan`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tblkaryawan`
--

LOCK TABLES `tblkaryawan` WRITE;
/*!40000 ALTER TABLE `tblkaryawan` DISABLE KEYS */;
INSERT INTO `tblkaryawan` VALUES ('KRY-001','Putu Putra Astawa','Panjer','081338655720'),('KRY-002','Gede Suweca','Renon','082144877887'),('KRY-003','Gede Budayasa','Kebo Iwa','087861416272'),('KRY-004','Gede Sri Artha','Gunang','083117554823'),('KRY-005','Agus Sucipta','Sidakarya','085337625633');
/*!40000 ALTER TABLE `tblkaryawan` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbltransaksi_jual`
--

DROP TABLE IF EXISTS `tbltransaksi_jual`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbltransaksi_jual` (
  `No_Faktur` varchar(30) NOT NULL,
  `Tanggal` date NOT NULL,
  `Pembeli` varchar(30) NOT NULL,
  `Total_Harga` double NOT NULL,
  PRIMARY KEY (`No_Faktur`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbltransaksi_jual`
--

LOCK TABLES `tbltransaksi_jual` WRITE;
/*!40000 ALTER TABLE `tbltransaksi_jual` DISABLE KEYS */;
INSERT INTO `tbltransaksi_jual` VALUES ('2014-03-02-001','2014-03-02','Sulis',1080000),('2014-03-02-002','2014-03-02','Bunga',9000000);
/*!40000 ALTER TABLE `tbltransaksi_jual` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbltransaksi_jual_rinci`
--

DROP TABLE IF EXISTS `tbltransaksi_jual_rinci`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbltransaksi_jual_rinci` (
  `No_Faktur` varchar(30) NOT NULL,
  `ID` varchar(10) NOT NULL,
  `Nama` varchar(30) NOT NULL,
  `Harga_jual` double NOT NULL,
  `Jumlah` double NOT NULL,
  `Subtotal` double NOT NULL,
  KEY `barang_rinci` (`ID`),
  KEY `faktur_rinci` (`No_Faktur`),
  CONSTRAINT `barang_rinci` FOREIGN KEY (`ID`) REFERENCES `tblbarang` (`ID_Barang`),
  CONSTRAINT `faktur_rinci` FOREIGN KEY (`No_Faktur`) REFERENCES `tbltransaksi_jual` (`No_Faktur`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbltransaksi_jual_rinci`
--

LOCK TABLES `tbltransaksi_jual_rinci` WRITE;
/*!40000 ALTER TABLE `tbltransaksi_jual_rinci` DISABLE KEYS */;
INSERT INTO `tbltransaksi_jual_rinci` VALUES ('2014-03-02-001','BRG-003','Mouse',80000,5,400000),('2014-03-02-001','BRG-004','Keyboard',60000,3,180000),('2014-03-02-001','BRG-005','Headset',100000,5,500000),('2014-03-02-002','BRG-003','Mouse',80000,5,400000),('2014-03-02-002','BRG-004','Keyboard',60000,10,600000);
/*!40000 ALTER TABLE `tbltransaksi_jual_rinci` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2017-04-02 11:34:12
