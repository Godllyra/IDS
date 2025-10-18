/*M!999999\- enable the sandbox mode */ 
-- MariaDB dump 10.19-11.8.3-MariaDB, for Linux (x86_64)
--
-- Host: localhost    Database: tiendasara
-- ------------------------------------------------------
-- Server version	11.8.3-MariaDB

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*M!100616 SET @OLD_NOTE_VERBOSITY=@@NOTE_VERBOSITY, NOTE_VERBOSITY=0 */;

--
-- Table structure for table `Carrito`
--

DROP TABLE IF EXISTS `Carrito`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8mb4 */;
CREATE TABLE `Carrito` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `TotalCompra` decimal(10,2) NOT NULL,
  `Estatus` enum('Completado','Pendiente') NOT NULL DEFAULT 'Pendiente',
  `Fecha` timestamp NOT NULL DEFAULT current_timestamp(),
  `FolioVenta` int(5) unsigned zerofill NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Carrito`
--

LOCK TABLES `Carrito` WRITE;
/*!40000 ALTER TABLE `Carrito` DISABLE KEYS */;
set autocommit=0;
INSERT INTO `Carrito` VALUES
(3,12000.00,'Pendiente','2025-10-18 18:33:11',90001),
(4,16700.00,'Completado','2025-10-18 18:34:02',90002),
(5,9200.00,'Pendiente','2025-10-18 18:40:04',90003),
(6,22200.00,'Completado','2025-10-18 18:40:57',90004),
(7,12200.00,'Completado','2025-10-18 18:41:07',90005),
(8,1000.00,'Pendiente','2025-10-18 18:41:22',90006);
/*!40000 ALTER TABLE `Carrito` ENABLE KEYS */;
UNLOCK TABLES;
commit;

--
-- Table structure for table `CarritoDetalle`
--

DROP TABLE IF EXISTS `CarritoDetalle`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8mb4 */;
CREATE TABLE `CarritoDetalle` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `idCarrito` int(11) NOT NULL,
  `idProducto` int(11) NOT NULL,
  `Cantidad` tinyint(3) unsigned NOT NULL,
  `Subtotal` decimal(10,2) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_detalle_carrito` (`idCarrito`),
  KEY `fk_producto_carrito` (`idProducto`),
  CONSTRAINT `fk_detalle_carrito` FOREIGN KEY (`idCarrito`) REFERENCES `Carrito` (`id`),
  CONSTRAINT `fk_producto_carrito` FOREIGN KEY (`idProducto`) REFERENCES `Productos` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `CarritoDetalle`
--

LOCK TABLES `CarritoDetalle` WRITE;
/*!40000 ALTER TABLE `CarritoDetalle` DISABLE KEYS */;
set autocommit=0;
INSERT INTO `CarritoDetalle` VALUES
(1,3,8,1,8000.00),
(2,3,15,1,3500.00),
(3,3,35,1,500.00),
(4,4,8,2,16000.00),
(5,4,48,1,200.00),
(6,4,35,1,500.00),
(7,5,48,1,200.00),
(9,5,34,1,1800.00),
(10,5,36,1,1200.00),
(11,5,16,1,6000.00),
(12,6,11,1,22000.00),
(13,6,26,1,200.00),
(14,7,10,1,12000.00),
(15,7,51,2,200.00),
(16,8,45,10,1000.00);
/*!40000 ALTER TABLE `CarritoDetalle` ENABLE KEYS */;
UNLOCK TABLES;
commit;

--
-- Table structure for table `Categoria`
--

DROP TABLE IF EXISTS `Categoria`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8mb4 */;
CREATE TABLE `Categoria` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `Descripcion` varchar(32) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Categoria`
--

LOCK TABLES `Categoria` WRITE;
/*!40000 ALTER TABLE `Categoria` DISABLE KEYS */;
set autocommit=0;
INSERT INTO `Categoria` VALUES
(1,'ROPA Y CALZADO'),
(2,'ELECTRONICA Y TECNOLOGIA'),
(3,'SALUD Y BELLEZA');
/*!40000 ALTER TABLE `Categoria` ENABLE KEYS */;
UNLOCK TABLES;
commit;

--
-- Table structure for table `Marcas`
--

DROP TABLE IF EXISTS `Marcas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8mb4 */;
CREATE TABLE `Marcas` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `Descripcion` varchar(32) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Marcas`
--

LOCK TABLES `Marcas` WRITE;
/*!40000 ALTER TABLE `Marcas` DISABLE KEYS */;
set autocommit=0;
INSERT INTO `Marcas` VALUES
(1,'LENOVO'),
(2,'APPLE'),
(3,'SAMSUNG'),
(4,'SONY'),
(5,'NIKE'),
(6,'ZARA'),
(7,'ADIDAS'),
(8,'LEVIS'),
(9,'LOREAL'),
(10,'NIVEA'),
(11,'NEUTROGENA'),
(12,'MAYBELLINE');
/*!40000 ALTER TABLE `Marcas` ENABLE KEYS */;
UNLOCK TABLES;
commit;

--
-- Table structure for table `Productos`
--

DROP TABLE IF EXISTS `Productos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8mb4 */;
CREATE TABLE `Productos` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `descripcion` varchar(32) NOT NULL,
  `precio` decimal(10,2) NOT NULL,
  `idCategoria` int(11) NOT NULL,
  `idMarca` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_productos_categoria` (`idCategoria`),
  KEY `fk_productos_marca` (`idMarca`),
  CONSTRAINT `fk_productos_categoria` FOREIGN KEY (`idCategoria`) REFERENCES `Categoria` (`id`) ON UPDATE CASCADE,
  CONSTRAINT `fk_productos_marca` FOREIGN KEY (`idMarca`) REFERENCES `Marcas` (`id`) ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=62 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Productos`
--

LOCK TABLES `Productos` WRITE;
/*!40000 ALTER TABLE `Productos` DISABLE KEYS */;
set autocommit=0;
INSERT INTO `Productos` VALUES
(1,'ThinkPad X1 Carbon',35000.00,2,1),
(2,'Yoga 9i',28000.00,2,1),
(3,'ThinkCentre M90a',20000.00,2,1),
(4,'Legion 5 Pro',32000.00,2,1),
(5,'Tab P11',6000.00,2,1),
(6,'iPhone 15 Pro',25000.00,2,2),
(7,'MacBook Air M3',27000.00,2,2),
(8,'Apple Watch Series 9',8000.00,2,2),
(9,'AirPods Pro',5000.00,2,2),
(10,'iPad Air',12000.00,2,2),
(11,'Galaxy S24 Ultra',22000.00,2,3),
(12,'Galaxy Z Fold5',35000.00,2,3),
(13,'Galaxy Watch6',5000.00,2,3),
(14,'QLED 4K TV',15000.00,2,3),
(15,'Galaxy Buds2 Pro',3500.00,2,3),
(16,'WH-1000XM5',6000.00,2,4),
(17,'PlayStation 5',12000.00,2,4),
(18,'Alpha 7 IV',45000.00,2,4),
(19,'Bravia XR',25000.00,2,4),
(20,'Walkman NW-A306',7000.00,2,4),
(21,'Air Force 1',1800.00,1,5),
(22,'Air Max 270',2200.00,1,5),
(23,'Dri-FIT Legend',400.00,1,5),
(24,'Pro Hyperwarm',900.00,1,5),
(25,'Jordan 1 Retro',2500.00,1,5),
(26,'Basic T-Shirt',200.00,1,6),
(27,'Balmacaan Coat',1500.00,1,6),
(28,'High Waist Jeans',800.00,1,6),
(29,'Trench Coat',1800.00,1,6),
(30,'Platform Sneakers',1200.00,1,6),
(31,'Ultraboost 5.0 DNA',1500.00,1,7),
(32,'Stan Smith',1500.00,1,7),
(33,'Tiro 23',600.00,1,7),
(34,'Gazelle',1800.00,1,7),
(35,'Adilette 22',500.00,1,7),
(36,'501 Original',1200.00,1,8),
(37,'511 Slim',1300.00,1,8),
(38,'Trucker Jacket',1500.00,1,8),
(39,'Ribcage Straight',1400.00,1,8),
(40,'Premium Trucker',1800.00,1,8),
(41,'Revitalift Serum',300.00,3,9),
(42,'Elvive Shampoo',120.00,3,9),
(43,'Infallible Foundation',250.00,3,9),
(44,'Color Riche Lipstick',180.00,3,9),
(45,'Men Expert Hydra',100.00,3,9),
(47,'Creme (lata azul)',60.00,3,10),
(48,'Q10 Plus Cream',200.00,3,10),
(49,'Protect & Care Spray',180.00,3,10),
(50,'MicellAIR Skin',130.00,3,10),
(51,'Men Sensitive After Shave',100.00,3,10),
(52,'Hydro Boost Gel',150.00,3,11),
(53,'Makeup Remover Wipes',80.00,3,11),
(54,'Oil-Free Acne Wash',120.00,3,11),
(55,'Norwegian Formula Hand Cream',70.00,3,11),
(56,'Ultra Sheer Sunscreen',150.00,3,11),
(57,'Superstay Matte Ink',180.00,3,12),
(58,'Fit Me! Foundation',150.00,3,12),
(59,'Lash Sensational Mascara',160.00,3,12),
(60,'Instant Age Rewind Concealer',140.00,3,12),
(61,'Color Sensational Lipstick',120.00,3,12);
/*!40000 ALTER TABLE `Productos` ENABLE KEYS */;
UNLOCK TABLES;
commit;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*M!100616 SET NOTE_VERBOSITY=@OLD_NOTE_VERBOSITY */;

-- Dump completed on 2025-10-18 15:55:38
