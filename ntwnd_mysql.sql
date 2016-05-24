/*
SQLyog Community v8.6 RC3
MySQL - 5.1.36-community-log : Database - northwind
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`northwind` /*!40100 DEFAULT CHARACTER SET utf8 COLLATE utf8_turkish_ci */;

USE `northwind`;

/*Table structure for table `categories` */

DROP TABLE IF EXISTS `categories`;

CREATE TABLE `categories` (
  `CategoryId` int(11) NOT NULL AUTO_INCREMENT,
  `CategoryName` char(50) COLLATE utf8_turkish_ci NOT NULL,
  `Description` char(100) COLLATE utf8_turkish_ci DEFAULT NULL,
  PRIMARY KEY (`CategoryId`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

/*Data for the table `categories` */

insert  into `categories`(`CategoryId`,`CategoryName`,`Description`) values (1,'Beverages','Soft drinks'),(2,'Condiments','Selami artık sevmiyor bunu'),(3,'Confections','Tekstil ürünleri');

/*Table structure for table `customers` */

DROP TABLE IF EXISTS `customers`;

CREATE TABLE `customers` (
  `CustomerId` int(11) NOT NULL AUTO_INCREMENT,
  `CompanyName` char(50) COLLATE utf8_turkish_ci DEFAULT NULL,
  `ContactName` char(50) COLLATE utf8_turkish_ci DEFAULT NULL,
  `City` char(20) COLLATE utf8_turkish_ci DEFAULT NULL,
  `Country` char(40) COLLATE utf8_turkish_ci DEFAULT NULL,
  PRIMARY KEY (`CustomerId`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

/*Data for the table `customers` */

insert  into `customers`(`CustomerId`,`CompanyName`,`ContactName`,`City`,`Country`) values (1,'Arcelik','Burak Olgac','stanbul','Türkiye');

/*Table structure for table `employees` */

DROP TABLE IF EXISTS `employees`;

CREATE TABLE `employees` (
  `EmployeeId` int(11) NOT NULL AUTO_INCREMENT,
  `FirstName` char(50) COLLATE utf8_turkish_ci NOT NULL,
  `LastName` char(50) COLLATE utf8_turkish_ci NOT NULL,
  `Title` char(20) COLLATE utf8_turkish_ci DEFAULT NULL,
  `ReportsTo` int(11) DEFAULT NULL,
  `Region` char(20) COLLATE utf8_turkish_ci DEFAULT NULL,
  `Notes` text COLLATE utf8_turkish_ci,
  PRIMARY KEY (`EmployeeId`),
  KEY `FK_employees` (`ReportsTo`),
  CONSTRAINT `FK_employees` FOREIGN KEY (`ReportsTo`) REFERENCES `employees` (`EmployeeId`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

/*Data for the table `employees` */

insert  into `employees`(`EmployeeId`,`FirstName`,`LastName`,`Title`,`ReportsTo`,`Region`,`Notes`) values (1,'Nancy','Davoilo','Ms.',NULL,NULL,'Yigiti cok sever..'),(2,'Yigit','Davolio','Mr.',1,NULL,NULL);

/*Table structure for table `orderdetails` */

DROP TABLE IF EXISTS `orderdetails`;

CREATE TABLE `orderdetails` (
  `OrderId` int(11) NOT NULL,
  `ProductId` int(11) NOT NULL,
  `UnitPrice` decimal(10,0) DEFAULT NULL,
  `Quantity` int(11) DEFAULT NULL,
  `Discount` double DEFAULT NULL,
  PRIMARY KEY (`OrderId`,`ProductId`),
  KEY `FK_orderdetails_products` (`ProductId`),
  CONSTRAINT `FK_orderdetails_orders` FOREIGN KEY (`OrderId`) REFERENCES `orders` (`OrderId`),
  CONSTRAINT `FK_orderdetails_products` FOREIGN KEY (`ProductId`) REFERENCES `products` (`ProductId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

/*Data for the table `orderdetails` */

insert  into `orderdetails`(`OrderId`,`ProductId`,`UnitPrice`,`Quantity`,`Discount`) values (1,1,'100',2,0),(1,3,'200',3,0.1);

/*Table structure for table `orders` */

DROP TABLE IF EXISTS `orders`;

CREATE TABLE `orders` (
  `OrderId` int(11) NOT NULL AUTO_INCREMENT,
  `OrderDate` datetime DEFAULT NULL,
  `EmployeeId` int(11) DEFAULT NULL,
  `CustomerId` int(11) DEFAULT NULL,
  PRIMARY KEY (`OrderId`),
  KEY `FK_orders_customers` (`CustomerId`),
  KEY `FK_orders_employees` (`EmployeeId`),
  CONSTRAINT `FK_orders_customers` FOREIGN KEY (`CustomerId`) REFERENCES `customers` (`CustomerId`),
  CONSTRAINT `FK_orders_employees` FOREIGN KEY (`EmployeeId`) REFERENCES `employees` (`EmployeeId`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

/*Data for the table `orders` */

insert  into `orders`(`OrderId`,`OrderDate`,`EmployeeId`,`CustomerId`) values (1,'2028-12-20 11:00:00',1,1);

/*Table structure for table `products` */

DROP TABLE IF EXISTS `products`;

CREATE TABLE `products` (
  `ProductId` int(11) NOT NULL AUTO_INCREMENT,
  `ProductName` char(50) COLLATE utf8_turkish_ci NOT NULL,
  `UnitPrice` decimal(10,0) DEFAULT NULL,
  `CategoryId` int(11) DEFAULT NULL,
  PRIMARY KEY (`ProductId`),
  KEY `FK_products` (`CategoryId`),
  CONSTRAINT `FK_products` FOREIGN KEY (`CategoryId`) REFERENCES `categories` (`CategoryId`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

/*Data for the table `products` */

insert  into `products`(`ProductId`,`ProductName`,`UnitPrice`,`CategoryId`) values (1,'Chai','18',1),(3,'Cote De Blaye','20',3),(4,'Chang','24',1);

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
