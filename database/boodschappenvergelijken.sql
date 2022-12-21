-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 25, 2022 at 11:17 AM
-- Server version: 10.4.25-MariaDB
-- PHP Version: 8.1.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `boodschappenvergelijken`
--

-- --------------------------------------------------------

--
-- Table structure for table `product`
--

CREATE TABLE `product` (
  `id` int(11) NOT NULL,
  `naam` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `product`
--

INSERT INTO `product` (`id`, `naam`) VALUES
(1, 'eieren'),
(2, 'melk'),
(3, 'kaas'),
(4, 'brood'),
(5, 'cola'),
(6, 'water'),
(7, 'boter'),
(8, 'ham'),
(9, 'pindakaas'),
(10, 'stokbrood'),
(11, 'vla'),
(12, 'yoghurt'),
(13, 'nootjes'),
(14, 'kip'),
(15, 'meloen'),
(16, 'appel'),
(17, 'kiwi'),
(18, 'sushi'),
(19, 'banaan'),
(20, 'sap');

-- --------------------------------------------------------

--
-- Table structure for table `winkel`
--

CREATE TABLE `winkel` (
  `id` int(11) NOT NULL,
  `naam` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `winkel`
--

INSERT INTO `winkel` (`id`, `naam`) VALUES
(1, 'Albert Heijn'),
(2, 'Jumbo'),
(3, 'Plus'),
(4, 'Dekamarkt'),
(5, 'Vomar');

-- --------------------------------------------------------

--
-- Table structure for table `winkelproduct`
--

CREATE TABLE `winkelproduct` (
  `id` int(11) NOT NULL,
  `product` int(11) NOT NULL,
  `winkel` int(11) NOT NULL,
  `prijs` decimal(65,2) NOT NULL,
  `vooraad` int(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `product`
--
ALTER TABLE `product`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `winkel`
--
ALTER TABLE `winkel`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `winkelproduct`
--
ALTER TABLE `winkelproduct`
  ADD PRIMARY KEY (`id`),
  ADD KEY `product` (`product`),
  ADD KEY `winkel` (`winkel`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `product`
--
ALTER TABLE `product`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;

--
-- AUTO_INCREMENT for table `winkel`
--
ALTER TABLE `winkel`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `winkelproduct`
--
ALTER TABLE `winkelproduct`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `winkelproduct`
--
ALTER TABLE `winkelproduct`
  ADD CONSTRAINT `winkelproduct_ibfk_1` FOREIGN KEY (`product`) REFERENCES `product` (`id`),
  ADD CONSTRAINT `winkelproduct_ibfk_2` FOREIGN KEY (`winkel`) REFERENCES `winkel` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
