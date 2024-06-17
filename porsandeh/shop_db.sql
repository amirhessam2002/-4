 -- phpMyAdmin SQL Dump
-- version 4.9.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: Aug 21, 2020 at 10:34 AM
-- Server version: 10.4.10-MariaDB
-- PHP Version: 7.3.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `shop_db`
--

-- --------------------------------------------------------

--
-- Table structure for table `contact`
--

DROP TABLE IF EXISTS `contact`;
CREATE TABLE IF NOT EXISTS `contact` (
  `id` int(10) NOT NULL AUTO_INCREMENT,
  `username` varchar(30) COLLATE utf8_persian_ci NOT NULL,
  `detail` text COLLATE utf8_persian_ci NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=2 DEFAULT CHARSET=utf8 COLLATE=utf8_persian_ci;

-- --------------------------------------------------------

--
-- Table structure for table `orders`
--

DROP TABLE IF EXISTS `orders`;
CREATE TABLE IF NOT EXISTS `orders` (
  `id` int(10) NOT NULL AUTO_INCREMENT,
  `username` varchar(30) COLLATE utf8_persian_ci NOT NULL,
  `orderdate` date NOT NULL,
  `pro_code` int(10) NOT NULL,
  `pro_qty` int(10) NOT NULL,
  `pro_price` float NOT NULL,
  `mobile` varchar(11) COLLATE utf8_persian_ci NOT NULL,
  `address` varchar(400) COLLATE utf8_persian_ci NOT NULL,
  `trackcode` varchar(24) COLLATE utf8_persian_ci NOT NULL,
  `state` int(1) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=10 DEFAULT CHARSET=utf8 COLLATE=utf8_persian_ci;

--
-- Dumping data for table `orders`
--

INSERT INTO `orders` (`id`, `username`, `orderdate`, `pro_code`, `pro_qty`, `pro_price`, `mobile`, `address`, `trackcode`, `state`) VALUES
(8, 'admin', '2020-08-21', 1, 1, 35000, '09034581704', 'Ø§Ù‚Ù„ÛŒØ¯ ØŒ Ø® Ø§Ù…Ø§Ù… ØŒ Ø³Ù„Ø·Ø§Ù† Ø§Ø¨Ø±Ø§Ù‡ÛŒÙ… ØŒ Ù…Ù†Ø²Ù„ Ø¢Ù‚Ø§ÛŒ Ø±Ø¶Ø§ÛŒÛŒ', '000000000000000000000000', 2),
(9, 'porsandeh', '2020-08-21', 4, 100, 3000, '09034581705', 'Ø§Ù‚Ù„ÛŒØ¯ ØŒ Ø§Ø±Ø¬Ù…Ø§Ù† ØŒ Ø® Ø³Ø§Ø­Ù„ÛŒ ØŒ Ù¾Ù„Ø§Ú© 31', '000000000000000000000000', 0);

-- --------------------------------------------------------

--
-- Table structure for table `products`
--

DROP TABLE IF EXISTS `products`;
CREATE TABLE IF NOT EXISTS `products` (
  `pro_code` int(10) NOT NULL,
  `pro_name` varchar(200) COLLATE utf8_persian_ci NOT NULL,
  `pro_qty` int(10) NOT NULL,
  `pro_price` float NOT NULL,
  `pro_image` varchar(80) COLLATE utf8_persian_ci NOT NULL,
  `pro_detail` text COLLATE utf8_persian_ci NOT NULL,
  PRIMARY KEY (`pro_code`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_persian_ci;

--
-- Dumping data for table `products`
--

INSERT INTO `products` (`pro_code`, `pro_name`, `pro_qty`, `pro_price`, `pro_image`, `pro_detail`) VALUES
(1, 'Ù‚Ø·Ø§Ø¨', 118, 35000, 'case.jpg', 'Ù‚Ø·Ø§Ø¨ ÛŒØ²Ø¯ÛŒ'),
(2, 'Ù¾Ø±ØªÙ‚Ø§Ù„', 2000, 10000, 'eraser.jpg', 'Ù¾Ø±ØªÙ‚Ø§Ù„ Ø¬Ù‡ ÛŒÚ©\r\n'),
(3, 'Ú¯Ø²', 200, 90000, 'notebook.jpg', 'Ú¯Ø² Ø¨Ù„Ø¯Ø§Ø¬ÛŒ'),
(4, 'Ù¾Ø³ØªÙ‡', 1700, 3000, 'paper.jpg', 'Ù¾Ø³ØªÙ‡ Ø®Ù†Ø¯Ø§Ù†'),
(5, 'Ø²Ø¹ÙØ±Ø§Ù†', 595, 8000, 'pen.jpg', 'Ø²Ø¹ÙØ±Ø§Ù† Ø¯Ø±Ø¬Ù‡ ÛŒÚ©'),
(6, 'Ø®Ø±Ù…Ø§', 1800, 7000, 'pencil.jpg', 'Ø®Ø±Ù…Ø§ÛŒ ØµØ§Ø¯Ø±Ø§ØªÛŒ'),
(7, 'Ú¯Ù„ÛŒÙ…', 80, 20000, 'ruler.jpg', 'Ú¯Ù„ÛŒÙ… Ø¯Ø³ØªØ¨Ø§ÙØª'),
(8, 'Ø®Ø§ØªÙ…Ú©Ø§Ø±ÛŒ', 28, 12000, 'sharpener.jpg', 'Ø¬Ø¹Ø¨Ù‡ Ø®Ø§ØªÙ…');

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
CREATE TABLE IF NOT EXISTS `users` (
  `realname` varchar(80) COLLATE utf8_persian_ci NOT NULL,
  `username` varchar(30) COLLATE utf8_persian_ci NOT NULL,
  `password` varchar(20) COLLATE utf8_persian_ci NOT NULL,
  `email` varchar(60) COLLATE utf8_persian_ci NOT NULL,
  `type` tinyint(1) NOT NULL,
  PRIMARY KEY (`username`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_persian_ci;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`realname`, `username`, `password`, `email`, `type`) VALUES
('ahmadi', 'admin', 'admin', 'ahmadi@gmail.com', 1),
('porsandeh', 'porsandeh', '0000', 'porsandeh@gmail.com', 0);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
