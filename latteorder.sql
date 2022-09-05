-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: Mar 31, 2022 at 05:52 PM
-- Server version: 5.7.31
-- PHP Version: 7.3.21

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `latteorder`
--

-- --------------------------------------------------------

--
-- Table structure for table `customer`
--

DROP TABLE IF EXISTS `customer`;
CREATE TABLE IF NOT EXISTS `customer` (
  `Id` int(10) NOT NULL AUTO_INCREMENT,
  `Table_number` int(10) NOT NULL,
  `Vanilla` int(10) NOT NULL,
  `Peppermint` int(10) NOT NULL,
  `Caramel` int(10) NOT NULL,
  `Toffee` int(10) NOT NULL,
  `Orange` int(10) NOT NULL,
  `Raspberry` int(10) NOT NULL,
  `Butteredrum` int(10) NOT NULL,
  `Hazelnut` int(10) NOT NULL,
  `Cinnamon` int(10) NOT NULL,
  `Total` int(10) NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=MyISAM AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `customer`
--

INSERT INTO `customer` (`Id`, `Table_number`, `Vanilla`, `Peppermint`, `Caramel`, `Toffee`, `Orange`, `Raspberry`, `Butteredrum`, `Hazelnut`, `Cinnamon`, `Total`) VALUES
(1, 1, 2, 0, 0, 2, 0, 0, 0, 0, 0, 50000),
(2, 4, 0, 0, 1, 0, 0, 0, 0, 0, 0, 13000),
(3, 6, 2, 0, 0, 0, 0, 0, 0, 2, 1, 66000);

-- --------------------------------------------------------

--
-- Table structure for table `waiter`
--

DROP TABLE IF EXISTS `waiter`;
CREATE TABLE IF NOT EXISTS `waiter` (
  `ID` int(10) NOT NULL AUTO_INCREMENT,
  `TableNumber` int(10) NOT NULL,
  `Vanilla` int(10) NOT NULL,
  `Peppermint` int(10) NOT NULL,
  `Caramel` int(10) NOT NULL,
  `Toffee` int(10) NOT NULL,
  `Orange` int(10) NOT NULL,
  `Raspberry` int(10) NOT NULL,
  `Butteredrum` int(10) NOT NULL,
  `Hazelnut` int(10) NOT NULL,
  `Cinnamon` int(10) NOT NULL,
  `Amount` int(30) NOT NULL,
  `Status` varchar(20) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=MyISAM AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `waiter`
--

INSERT INTO `waiter` (`ID`, `TableNumber`, `Vanilla`, `Peppermint`, `Caramel`, `Toffee`, `Orange`, `Raspberry`, `Butteredrum`, `Hazelnut`, `Cinnamon`, `Amount`, `Status`) VALUES
(1, 1, 2, 0, 0, 2, 0, 0, 0, 0, 0, 50000, 'Paid');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
