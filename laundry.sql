-- phpMyAdmin SQL Dump
-- version 3.2.4
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Generation Time: Dec 15, 2017 at 02:16 PM
-- Server version: 5.1.41
-- PHP Version: 5.3.1

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `laundry`
--

-- --------------------------------------------------------

--
-- Table structure for table `order_pesanan`
--

CREATE TABLE IF NOT EXISTS `order_pesanan` (
  `No_Order` char(17) NOT NULL,
  `Tanggal_Order` varchar(30) DEFAULT NULL,
  `Nama_Order` varchar(30) DEFAULT NULL,
  `No_Telpon` varchar(12) DEFAULT NULL,
  `Alamat_Order` varchar(30) DEFAULT NULL,
  `Berat_Pakaian` float DEFAULT NULL,
  `Jumlah_Pakaian` int(11) DEFAULT NULL,
  `Nama_Paket` varchar(30) DEFAULT NULL,
  `Harga_Perkilo` int(11) DEFAULT NULL,
  `Total_Harga` int(11) DEFAULT NULL,
  PRIMARY KEY (`No_Order`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `order_pesanan`
--

INSERT INTO `order_pesanan` (`No_Order`, `Tanggal_Order`, `Nama_Order`, `No_Telpon`, `Alamat_Order`, `Berat_Pakaian`, `Jumlah_Pakaian`, `Nama_Paket`, `Harga_Perkilo`, `Total_Harga`) VALUES
('P02/13122017/0725', 'Rabu, 13 Desember 2017', 'IMAM RIFANDI', '081234521212', 'JL BUJANG', 12, 18, '1 HARI', 5000, 60000),
('P01/13122017/0652', 'Rabu, 13 Desember 2017', 'MAULANA SAROWIS', '081228411020', 'JL. HANDAYANI', 2, 6, '2 HARI', 4500, 9000),
('P03/14122017/0556', 'Kamis, 14 Desember 2017', 'RESTU SINGGIH', '081287112719', 'JL. KETAPANG', 5, 19, '1 HARI', 5000, 25000),
('P04/14122017/0558', 'Kamis, 14 Desember 2017', 'FERA ASYUNI', '082284110206', 'JL. DURIAN', 10, 40, '1 HARI', 5000, 50000);

-- --------------------------------------------------------

--
-- Table structure for table `paket`
--

CREATE TABLE IF NOT EXISTS `paket` (
  `Nama_Paket` varchar(25) DEFAULT NULL,
  `Harga_Perkilo` int(11) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `paket`
--

INSERT INTO `paket` (`Nama_Paket`, `Harga_Perkilo`) VALUES
('1 HARI', 5000),
('2 HARI', 4500),
('3 HARI', 4000),
('7 HARI', 2000);

-- --------------------------------------------------------

--
-- Table structure for table `transaksi`
--

CREATE TABLE IF NOT EXISTS `transaksi` (
  `No_Order` char(17) DEFAULT NULL,
  `No_Transaksi` char(15) DEFAULT NULL,
  `Bayar` int(11) DEFAULT NULL,
  `Kembalian` int(11) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `transaksi`
--

INSERT INTO `transaksi` (`No_Order`, `No_Transaksi`, `Bayar`, `Kembalian`) VALUES
('P01/13122017/0652', 'T01/151217/0210', 100000, 91000);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
