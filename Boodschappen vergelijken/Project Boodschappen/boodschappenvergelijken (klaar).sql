-- phpMyAdmin SQL Dump
-- version 5.0.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Gegenereerd op: 01 dec 2022 om 09:15
-- Serverversie: 10.4.17-MariaDB
-- PHP-versie: 8.0.1

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
-- Tabelstructuur voor tabel `product`
--

CREATE TABLE `product` (
  `id` int(11) NOT NULL,
  `naam` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Gegevens worden geëxporteerd voor tabel `product`
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
-- Tabelstructuur voor tabel `winkel`
--

CREATE TABLE `winkel` (
  `id` int(11) NOT NULL,
  `naam` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Gegevens worden geëxporteerd voor tabel `winkel`
--

INSERT INTO `winkel` (`id`, `naam`) VALUES
(1, 'Albert Heijn'),
(2, 'Plus\r\n'),
(3, 'Dekamarkt'),
(4, 'Jumbo\r\n'),
(5, 'Vomar');

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `winkelproduct`
--

CREATE TABLE `winkelproduct` (
  `id` int(11) NOT NULL,
  `product` int(11) NOT NULL,
  `winkel` int(11) NOT NULL,
  `prijs` decimal(65,2) NOT NULL,
  `vooraad` int(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Gegevens worden geëxporteerd voor tabel `winkelproduct`
--

INSERT INTO `winkelproduct` (`id`, `product`, `winkel`, `prijs`, `vooraad`) VALUES
(1, 1, 1, '2.39', 500),
(2, 2, 1, '2.15', 500),
(3, 3, 1, '9.35', 500),
(4, 4, 1, '1.39', 500),
(5, 5, 1, '2.49', 500),
(6, 6, 1, '2.38', 500),
(7, 7, 1, '2.49', 500),
(8, 8, 1, '3.19', 500),
(9, 9, 1, '2.99', 500),
(10, 10, 1, '1.79', 500),
(11, 11, 1, '1.99', 500),
(12, 12, 1, '1.65', 500),
(13, 13, 1, '2.59', 500),
(14, 14, 1, '8.75', 500),
(15, 15, 1, '2.79', 500),
(16, 16, 1, '2.49', 500),
(17, 17, 1, '3.49', 500),
(18, 18, 1, '6.69', 500),
(19, 19, 1, '1.39', 500),
(20, 20, 1, '3.29', 500),
(21, 1, 2, '3.79', 500),
(22, 2, 2, '2.15', 500),
(23, 3, 2, '6.19', 500),
(24, 4, 2, '1.69', 500),
(25, 5, 2, '2.49', 500),
(26, 6, 2, '1.00', 500),
(27, 7, 2, '2.49', 500),
(28, 8, 2, '2.06', 500),
(29, 9, 2, '2.96', 500),
(30, 10, 2, '1.19', 500),
(31, 11, 2, '1.89', 500),
(32, 12, 2, '1.86', 500),
(33, 13, 2, '2.33', 500),
(34, 14, 2, '8.49', 500),
(35, 15, 2, '4.99', 500),
(36, 16, 2, '2.69', 500),
(37, 17, 2, '3.79', 500),
(38, 18, 2, '4.19', 500),
(39, 19, 2, '1.99', 500),
(40, 20, 2, '3.49', 500),
(41, 1, 3, '3.99', 500),
(42, 2, 3, '1.79', 500),
(43, 3, 3, '8.39', 500),
(44, 4, 3, '1.09', 500),
(45, 5, 3, '2.35', 500),
(46, 6, 3, '1.05', 500),
(47, 7, 3, '3.79', 500),
(48, 8, 3, '1.00', 500),
(49, 9, 3, '2.89', 500),
(50, 10, 3, '1.49', 500),
(51, 11, 3, '1.55', 500),
(52, 12, 3, '1.25', 500),
(53, 13, 3, '2.89', 500),
(54, 14, 3, '8.80', 500),
(55, 15, 3, '2.99', 500),
(56, 16, 3, '2.99', 500),
(57, 17, 3, '6.98', 500),
(58, 18, 3, '6.74', 500),
(59, 19, 3, '1.89', 500),
(60, 20, 3, '1.65', 500),
(61, 1, 4, '4.39', 350),
(62, 2, 4, '1.57', 350),
(63, 3, 4, '9.93', 350),
(64, 4, 4, '1.39', 350),
(65, 5, 4, '2.42', 350),
(66, 6, 4, '0.96', 350),
(67, 7, 4, '2.49', 350),
(68, 8, 4, '2.00', 350),
(69, 9, 4, '3.45', 350),
(70, 10, 4, '1.79', 350),
(71, 11, 4, '1.69', 350),
(72, 12, 4, '1.59', 350),
(73, 13, 4, '2.59', 350),
(74, 14, 4, '9.49', 350),
(75, 15, 4, '2.99', 350),
(76, 16, 4, '3.19', 350),
(77, 17, 4, '3.99', 350),
(78, 18, 4, '8.50', 350),
(79, 19, 4, '1.69', 350),
(80, 20, 4, '1.65', 350),
(81, 1, 5, '3.79', 400),
(82, 2, 5, '1.49', 400),
(83, 3, 5, '9.59', 400),
(84, 4, 5, '1.79', 400),
(85, 5, 5, '2.25', 400),
(86, 6, 5, '0.97', 400),
(87, 7, 5, '3.69', 400),
(88, 8, 5, '2.25', 400),
(89, 9, 5, '2.55', 400),
(90, 10, 5, '0.95', 400),
(91, 11, 5, '1.83', 400),
(92, 12, 5, '1.68', 400),
(93, 13, 5, '2.09', 400),
(94, 14, 5, '9.99', 400),
(95, 15, 5, '4.89', 400),
(96, 16, 5, '2.30', 400),
(97, 17, 5, '2.46', 400),
(98, 18, 5, '7.49', 400),
(99, 19, 5, '1.29', 400),
(100, 20, 5, '1.95', 400);

--
-- Indexen voor geëxporteerde tabellen
--

--
-- Indexen voor tabel `product`
--
ALTER TABLE `product`
  ADD PRIMARY KEY (`id`);

--
-- Indexen voor tabel `winkel`
--
ALTER TABLE `winkel`
  ADD PRIMARY KEY (`id`);

--
-- Indexen voor tabel `winkelproduct`
--
ALTER TABLE `winkelproduct`
  ADD PRIMARY KEY (`id`),
  ADD KEY `product` (`product`),
  ADD KEY `winkel` (`winkel`);

--
-- AUTO_INCREMENT voor geëxporteerde tabellen
--

--
-- AUTO_INCREMENT voor een tabel `product`
--
ALTER TABLE `product`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;

--
-- AUTO_INCREMENT voor een tabel `winkel`
--
ALTER TABLE `winkel`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT voor een tabel `winkelproduct`
--
ALTER TABLE `winkelproduct`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=101;

--
-- Beperkingen voor geëxporteerde tabellen
--

--
-- Beperkingen voor tabel `winkelproduct`
--
ALTER TABLE `winkelproduct`
  ADD CONSTRAINT `winkelproduct_ibfk_1` FOREIGN KEY (`product`) REFERENCES `product` (`id`),
  ADD CONSTRAINT `winkelproduct_ibfk_2` FOREIGN KEY (`winkel`) REFERENCES `winkel` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
