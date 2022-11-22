-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 21, 2022 at 10:13 PM
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
-- Table structure for table `albert_heijn`
--

CREATE TABLE `albert_heijn` (
  `id` int(11) NOT NULL,
  `naam` varchar(255) NOT NULL,
  `prijs` double NOT NULL,
  `vooraad` int(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `dekamarkt`
--

CREATE TABLE `dekamarkt` (
  `id` int(11) NOT NULL,
  `naam` varchar(255) NOT NULL,
  `prijs` double NOT NULL,
  `vooraad` int(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `jumbo`
--

CREATE TABLE `jumbo` (
  `id` int(11) NOT NULL,
  `naam` varchar(255) NOT NULL,
  `prijs` double NOT NULL,
  `vooraad` int(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `plus`
--

CREATE TABLE `plus` (
  `id` int(11) NOT NULL,
  `naam` varchar(255) NOT NULL,
  `prijs` double NOT NULL,
  `vooraad` int(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `vomar`
--

CREATE TABLE `vomar` (
  `id` int(11) NOT NULL,
  `naam` varchar(255) NOT NULL,
  `prijs` double NOT NULL,
  `vooraad` int(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `albert_heijn`
--
ALTER TABLE `albert_heijn`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `dekamarkt`
--
ALTER TABLE `dekamarkt`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `jumbo`
--
ALTER TABLE `jumbo`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `plus`
--
ALTER TABLE `plus`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `vomar`
--
ALTER TABLE `vomar`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `albert_heijn`
--
ALTER TABLE `albert_heijn`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `dekamarkt`
--
ALTER TABLE `dekamarkt`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `jumbo`
--
ALTER TABLE `jumbo`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `plus`
--
ALTER TABLE `plus`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `vomar`
--
ALTER TABLE `vomar`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
