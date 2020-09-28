-- phpMyAdmin SQL Dump
-- version 4.9.5
-- https://www.phpmyadmin.net/
--
-- Host: localhost:3306
-- Generation Time: Sep 28, 2020 at 04:11 AM
-- Server version: 10.4.14-MariaDB-log
-- PHP Version: 7.2.19

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `sistemfarmasi`
--
CREATE DATABASE IF NOT EXISTS `sistemfarmasi` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
USE `sistemfarmasi`;

-- --------------------------------------------------------

--
-- Table structure for table `invoice_table`
--

CREATE TABLE `invoice_table` (
  `invoice_id` varchar(12) NOT NULL,
  `membership_id` varchar(20) DEFAULT NULL,
  `totalAmount` double DEFAULT NULL,
  `invoice_date` timestamp NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `invoice_table`
--

INSERT INTO `invoice_table` (`invoice_id`, `membership_id`, `totalAmount`, `invoice_date`) VALUES
('SOVLOQ657455', NULL, 379.5, '2020-09-10 15:15:40'),
('YGWMMM828444', NULL, 506, '2020-09-11 04:29:21');

-- --------------------------------------------------------

--
-- Table structure for table `transaction_details_table`
--

CREATE TABLE `transaction_details_table` (
  `id` int(11) NOT NULL,
  `ubat_id` varchar(12) NOT NULL,
  `quantity` int(11) NOT NULL,
  `price` float NOT NULL,
  `totalAmount` float NOT NULL,
  `invoice_id` varchar(12) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `transaction_details_table`
--

INSERT INTO `transaction_details_table` (`id`, `ubat_id`, `quantity`, `price`, `totalAmount`, `invoice_id`) VALUES
(46, 'PND-001-5211', 11, 11.5, 126.5, 'SOVLOQ657455'),
(47, 'PND-001-5211', 11, 11.5, 126.5, 'SOVLOQ657455'),
(48, 'PND-001-5211', 11, 11.5, 126.5, 'SOVLOQ657455'),
(49, 'PND-001-5211', 11, 11.5, 126.5, 'YGWMMM828444'),
(50, 'PND-001-5211', 11, 11.5, 126.5, 'YGWMMM828444'),
(51, 'PND-001-5211', 11, 11.5, 126.5, 'YGWMMM828444'),
(52, 'PND-001-5211', 11, 11.5, 126.5, 'YGWMMM828444');

-- --------------------------------------------------------

--
-- Table structure for table `ubat_table`
--

CREATE TABLE `ubat_table` (
  `id_ubat` varchar(12) NOT NULL,
  `quantity` int(4) NOT NULL,
  `nama_ubat` varchar(35) NOT NULL,
  `harga_ubat` float NOT NULL,
  `pembekal` varchar(30) NOT NULL,
  `alamat_pembekal` varchar(199) NOT NULL,
  `no_telefon` varchar(15) NOT NULL,
  `modified_at` date DEFAULT NULL,
  `created_at` timestamp NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `ubat_table`
--

INSERT INTO `ubat_table` (`id_ubat`, `quantity`, `nama_ubat`, `harga_ubat`, `pembekal`, `alamat_pembekal`, `no_telefon`, `modified_at`, `created_at`) VALUES
('PND-001-5211', 22, 'PANADOL ACTIFAST', 11.5, 'GSK', 'GlaxoSmithKline Pharmaceutical Sdn Bhd\r\nLevel 6, Quill 9\r\n112, Jalan Professor Khoo Kay Kim\r\n46300 Petaling Jaya\r\nSelangor\r\nMalaysia', '603-76289000', NULL, '2020-09-08 02:23:40');

-- --------------------------------------------------------

--
-- Table structure for table `user_table`
--

CREATE TABLE `user_table` (
  `kad_pengenalan` varchar(16) NOT NULL,
  `umur` int(2) NOT NULL,
  `nama_pekerja` varchar(45) NOT NULL,
  `alamat` varchar(65) NOT NULL,
  `nombor_telefon` varchar(15) NOT NULL,
  `username` varchar(16) NOT NULL,
  `password` varchar(16) NOT NULL,
  `created_at` timestamp NOT NULL DEFAULT current_timestamp(),
  `modified_at` date DEFAULT NULL,
  `rank` int(2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `user_table`
--

INSERT INTO `user_table` (`kad_pengenalan`, `umur`, `nama_pekerja`, `alamat`, `nombor_telefon`, `username`, `password`, `created_at`, `modified_at`, `rank`) VALUES
('000000-00-0000', 20, 'SISTEM FARMASI RADJA SDN BHD', 'ALAMAT SISTEM FARMASI RAJDA SDN BHD', '011-33457990', 'admin', 'admin', '2020-09-06 14:50:31', NULL, 2),
('000306-01-1651', 20, 'AMMAR YASIR BIN ABD SAMAD', 'NO.74 KAMPUNG PULAI, 81550 GELANG PATAH, JOHOR BAHRU, JOHOR', '011-33457990', 'RADJASTAFF002', '000306011651', '2020-09-06 14:53:33', '2020-09-11', 1);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `invoice_table`
--
ALTER TABLE `invoice_table`
  ADD PRIMARY KEY (`invoice_id`);

--
-- Indexes for table `transaction_details_table`
--
ALTER TABLE `transaction_details_table`
  ADD PRIMARY KEY (`id`),
  ADD KEY `invoice_id` (`invoice_id`);

--
-- Indexes for table `ubat_table`
--
ALTER TABLE `ubat_table`
  ADD PRIMARY KEY (`id_ubat`);

--
-- Indexes for table `user_table`
--
ALTER TABLE `user_table`
  ADD PRIMARY KEY (`kad_pengenalan`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `transaction_details_table`
--
ALTER TABLE `transaction_details_table`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=53;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `invoice_table`
--
ALTER TABLE `invoice_table`
  ADD CONSTRAINT `invoice_table_ibfk_1` FOREIGN KEY (`invoice_id`) REFERENCES `transaction_details_table` (`invoice_id`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
