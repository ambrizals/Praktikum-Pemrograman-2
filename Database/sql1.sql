/*
SQLyog Ultimate - MySQL GUI v8.21 
MySQL - 5.6.11 : Database - toko
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`toko` /*!40100 DEFAULT CHARACTER SET latin1 */;

USE `toko`;

/*Table structure for table `tblbarang` */

DROP TABLE IF EXISTS `tblbarang`;

CREATE TABLE `tblbarang` (
  `Id_Barang` varchar(10) NOT NULL,
  `Nm_Barang` varchar(30) NOT NULL,
  `Merk_barang` varchar(10) NOT NULL,
  `Satuan` varchar(10) NOT NULL,
  `Hrg_beli` double DEFAULT NULL,
  `Hrg_jual` double DEFAULT NULL,
  `Stok` double DEFAULT NULL,
  PRIMARY KEY (`Id_Barang`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `tblbarang` */

insert  into `tblbarang`(`Id_Barang`,`Nm_Barang`,`Merk_barang`,`Satuan`,`Hrg_beli`,`Hrg_jual`,`Stok`) values ('BRG-001','Monitor','MRK-001','STN-001',300000,800000,10),('BRG-002','Printer','MRK-002','STN-002',420000,550000,20),('BRG-003','Mouse','MRK-003','STN-003',400000,800000,25),('BRG-004','Keyboard','MRK-004','STN-004',35000,60000,10),('BRG-005','Headset','MRK-005','STN-005',50000,100000,30),('BRG-006','Speaker','MRK-006','STN-006',120000,300000,15),('BRG-007','Flashdisk','MRK-007','STN-007',80000,120000,30),('BRG-008','Modem','MRK-008','STN-008',250000,400000,20),('BRG-009','Hardisk','MRK-009','STN-009',500000,850000,30);

/*Table structure for table `tblkaryawan` */

DROP TABLE IF EXISTS `tblkaryawan`;

CREATE TABLE `tblkaryawan` (
  `Id_Karyawan` varchar(10) NOT NULL,
  `Nama_karyawan` varchar(30) NOT NULL,
  `Alamat` text,
  `Telepon` decimal(15,0) DEFAULT NULL,
  PRIMARY KEY (`Id_Karyawan`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `tblkaryawan` */

insert  into `tblkaryawan`(`Id_Karyawan`,`Nama_karyawan`,`Alamat`,`Telepon`) values ('KRY-001','Putu Putra Astawa','Panjer','81338655720'),('KRY-002','Gede Suweca','Renon','82144877887'),('KRY-003','Gede Budayasa','Kebo Iwa','87861416272'),('KRY-004','Gede Sri Artha','Gunang','83117554823'),('KRY-005','Agus Sucipta','Sidakarya','85337625633');

/*Table structure for table `tbltransaksi_jual` */

DROP TABLE IF EXISTS `tbltransaksi_jual`;

CREATE TABLE `tbltransaksi_jual` (
  `No_Faktur` varchar(30) NOT NULL,
  `Tanggal` date NOT NULL,
  `Pembeli` varchar(30) NOT NULL,
  `TotalHarga` double DEFAULT NULL,
  PRIMARY KEY (`No_Faktur`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `tbltransaksi_jual` */

insert  into `tbltransaksi_jual`(`No_Faktur`,`Tanggal`,`Pembeli`,`TotalHarga`) values ('2014-03-02-001','2014-03-14','Sulis',1080000),('2014-03-02-002','2014-03-14','Bunga',9000000);

/*Table structure for table `tbltransaksi_jual_rinci` */

DROP TABLE IF EXISTS `tbltransaksi_jual_rinci`;

CREATE TABLE `tbltransaksi_jual_rinci` (
  `No_Faktur` varchar(30) NOT NULL,
  `ID` varchar(10) NOT NULL,
  `Nama` varchar(30) NOT NULL,
  `Harga_Jual` double DEFAULT NULL,
  `Jumlah` double DEFAULT NULL,
  `Sub_total` double DEFAULT NULL,
  KEY `FK_tbltransaksi_jual_rinci` (`ID`),
  CONSTRAINT `FK_tbltransaksi_jual_rinci` FOREIGN KEY (`ID`) REFERENCES `tblbarang` (`Id_Barang`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `tbltransaksi_jual_rinci` */

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
