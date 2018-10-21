-- MySqlBackup.NET 2.0.9.2
-- Dump Time: 2018-10-21 22:52:16
-- --------------------------------------
-- Server version 5.7.11-log MySQL Community Server (GPL)


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- 
-- Definition of delivery
-- 

DROP TABLE IF EXISTS `delivery`;
CREATE TABLE IF NOT EXISTS `delivery` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `order` int(11) NOT NULL,
  `address` varchar(100) NOT NULL DEFAULT 'address',
  `contact` varchar(12) NOT NULL DEFAULT 'contact',
  `date` varchar(50) NOT NULL DEFAULT 'date',
  `status` int(11) NOT NULL DEFAULT '0',
  PRIMARY KEY (`id`,`order`)
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table delivery
-- 

/*!40000 ALTER TABLE `delivery` DISABLE KEYS */;
INSERT INTO `delivery`(`id`,`order`,`address`,`contact`,`date`,`status`) VALUES
(6,24,'Kaduwela','0711506979','16 January 2018 - 03:30 am',1),
(8,27,'Kandy','0711506979','17 January 2018 - 02:25 pm',0),
(9,28,'Waliweriya','0711506979','16 January 2018 - 05:25 am',0),
(14,39,'Kaduwela','0711506979','16 January 2018 - 05:25 am',0);
/*!40000 ALTER TABLE `delivery` ENABLE KEYS */;

-- 
-- Definition of order
-- 

DROP TABLE IF EXISTS `order`;
CREATE TABLE IF NOT EXISTS `order` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `product` int(11) NOT NULL,
  `user` varchar(100) NOT NULL,
  `type` varchar(45) NOT NULL DEFAULT 'Dine in',
  `status` int(11) NOT NULL DEFAULT '0',
  `datetime` datetime DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`),
  UNIQUE KEY `id_UNIQUE` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=42 DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table order
-- 

/*!40000 ALTER TABLE `order` DISABLE KEYS */;
INSERT INTO `order`(`id`,`product`,`user`,`type`,`status`,`datetime`) VALUES
(21,2,'udara@gmail.com','Dine in',1,'2018-10-21 07:16:33'),
(23,4,'udara@gmail.com','Dine in',0,'2018-10-21 07:16:38'),
(24,5,'udara@gmail.com','Delivery',0,'2018-10-21 07:16:43'),
(26,7,'udara@gmail.com','Dine in',0,'2018-10-21 07:17:42'),
(27,7,'udara@gmail.com','Delivery',0,'2018-10-21 07:17:47'),
(28,8,'udara@gmail.com','Delivery',0,'2018-10-21 07:18:10'),
(39,7,'udara@gmail.com','Delivery',0,'2018-10-21 18:41:04'),
(40,2,'udara@gmail.com','Dine in',0,'2018-10-21 18:46:20'),
(41,2,'udara@gmail.com','Pick up',0,'2018-10-21 19:01:47');
/*!40000 ALTER TABLE `order` ENABLE KEYS */;

-- 
-- Definition of product
-- 

DROP TABLE IF EXISTS `product`;
CREATE TABLE IF NOT EXISTS `product` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(100) NOT NULL,
  `desc` varchar(100) NOT NULL,
  `price` double NOT NULL DEFAULT '0',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table product
-- 

/*!40000 ALTER TABLE `product` DISABLE KEYS */;
INSERT INTO `product`(`id`,`name`,`desc`,`price`) VALUES
(1,'Fried rice','Chicken fried rice small',250),
(2,'Fried rice','Chicken fried rice medium',300),
(3,'Fried rice','Chicken fried rice large',350),
(4,'Biriyani','Chicken biriyani',400),
(5,'Noodles','Chicken noodles',250),
(6,'Noodles','Egg noodles',250),
(7,'Koththu','Chicken Koththu',250),
(8,'Koththu','Egg Koththu',180);
/*!40000 ALTER TABLE `product` ENABLE KEYS */;

-- 
-- Definition of user
-- 

DROP TABLE IF EXISTS `user`;
CREATE TABLE IF NOT EXISTS `user` (
  `fname` varchar(45) NOT NULL,
  `lname` varchar(45) NOT NULL,
  `mobile` varchar(12) NOT NULL,
  `address` varchar(45) NOT NULL,
  `email` varchar(100) NOT NULL,
  `password` varchar(100) NOT NULL,
  `type` int(11) NOT NULL DEFAULT '0',
  PRIMARY KEY (`email`),
  UNIQUE KEY `username_UNIQUE` (`email`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table user
-- 

/*!40000 ALTER TABLE `user` DISABLE KEYS */;
INSERT INTO `user`(`fname`,`lname`,`mobile`,`address`,`email`,`password`,`type`) VALUES
('Janith','Chirantha','0711506979','42/c, Korathota, Kaduwela.','jccandro@gmail.com','2c331b1ff5479bcc9c513f42de46a89cf0486725f87c1c495d01c4011de3b0ce',1),
('Udara','Abeythilake','0715552223','Kadawatha','udara@gmail.com','9288a9a0afd3714c2df4a770e3f8f790d8792b131d091fcff55e8b2addd334f0',0);
/*!40000 ALTER TABLE `user` ENABLE KEYS */;


/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;


-- Dump completed on 2018-10-21 22:52:16
-- Total time: 0:0:0:0:188 (d:h:m:s:ms)
