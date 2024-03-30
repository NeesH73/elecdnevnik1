-- phpMyAdmin SQL Dump
-- version 5.1.2
-- https://www.phpmyadmin.net/
--
-- Host: localhost:3306
-- Generation Time: Mar 30, 2024 at 01:38 PM
-- Server version: 5.7.24
-- PHP Version: 8.0.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `elecdnev`
--

-- --------------------------------------------------------

--
-- Table structure for table `admin`
--

CREATE TABLE `admin` (
  `id` int(11) UNSIGNED NOT NULL,
  `login` varchar(100) NOT NULL,
  `pass` varchar(32) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `admin`
--

INSERT INTO `admin` (`id`, `login`, `pass`) VALUES
(1, 'admin', '123');

-- --------------------------------------------------------

--
-- Table structure for table `exam`
--

CREATE TABLE `exam` (
  `id` int(10) UNSIGNED NOT NULL,
  `login` varchar(50) NOT NULL,
  `groupNumb` varchar(10) NOT NULL,
  `fullName` varchar(50) NOT NULL,
  `subject` varchar(50) NOT NULL,
  `date` varchar(50) NOT NULL,
  `examType` varchar(50) NOT NULL,
  `grade` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `exam`
--

INSERT INTO `exam` (`id`, `login`, `groupNumb`, `fullName`, `subject`, `date`, `examType`, `grade`) VALUES
(1, 'user', '09-322', 'ivan', 'english', '01.29.2024', 'Зачет', 'Зачёт'),
(2, 'user', '09-322', 'ivan', 'matan', '01.25.2024', 'Зачет', 'Зачёт');

-- --------------------------------------------------------

--
-- Table structure for table `friday`
--

CREATE TABLE `friday` (
  `id` int(10) UNSIGNED NOT NULL,
  `groupNumb` varchar(50) NOT NULL,
  `time` varchar(20) NOT NULL,
  `subject` varchar(32) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `friday`
--

INSERT INTO `friday` (`id`, `groupNumb`, `time`, `subject`) VALUES
(1, '09-322', '10:10-11:40', 'Физическая культура'),
(2, '09-322', '12:10-13:40', 'История России');

-- --------------------------------------------------------

--
-- Table structure for table `monday`
--

CREATE TABLE `monday` (
  `id` int(10) UNSIGNED NOT NULL,
  `groupNumb` varchar(50) NOT NULL,
  `time` varchar(20) NOT NULL,
  `subject` varchar(32) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `monday`
--

INSERT INTO `monday` (`id`, `groupNumb`, `time`, `subject`) VALUES
(1, '09-322', '10:10-11:40', 'Иностранный язык'),
(3, '09-322', '12:10-13:40', 'Математический анализ'),
(4, '09-322', '13:50-15:20', 'История России');

-- --------------------------------------------------------

--
-- Table structure for table `saturday`
--

CREATE TABLE `saturday` (
  `id` int(11) UNSIGNED NOT NULL,
  `groupNumb` varchar(50) NOT NULL,
  `time` varchar(32) NOT NULL,
  `subject` varchar(32) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `saturday`
--

INSERT INTO `saturday` (`id`, `groupNumb`, `time`, `subject`) VALUES
(1, '09-322', '12:10-13:40', 'Ознакомительная практика'),
(2, '09-322', '13:50-15:20', 'Разработка приложений на C#');

-- --------------------------------------------------------

--
-- Table structure for table `thursday`
--

CREATE TABLE `thursday` (
  `id` int(10) UNSIGNED NOT NULL,
  `groupNumb` varchar(50) NOT NULL,
  `time` varchar(20) NOT NULL,
  `subject` varchar(32) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `thursday`
--

INSERT INTO `thursday` (`id`, `groupNumb`, `time`, `subject`) VALUES
(1, '09-322', '8:30-10:00', 'Алгебра и геометрия'),
(2, '09-322', '10:10-11:40', 'Математический анализ'),
(3, '09-322', '12:10-13:40', 'Алгебра и геометрия');

-- --------------------------------------------------------

--
-- Table structure for table `tuesday`
--

CREATE TABLE `tuesday` (
  `id` int(10) UNSIGNED NOT NULL,
  `groupNumb` varchar(50) NOT NULL,
  `time` varchar(20) NOT NULL,
  `subject` varchar(32) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `tuesday`
--

INSERT INTO `tuesday` (`id`, `groupNumb`, `time`, `subject`) VALUES
(1, '09-322', '10:10-11:40', 'Физическая культура'),
(2, '09-322', '12:10-13:40', 'Русский язык'),
(3, '09-322', '13:50-15:20', 'Русский язык');

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE `user` (
  `id` int(11) UNSIGNED NOT NULL,
  `login` varchar(100) NOT NULL,
  `pass` varchar(32) NOT NULL,
  `groupNumb` varchar(50) NOT NULL,
  `fullName` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`id`, `login`, `pass`, `groupNumb`, `fullName`) VALUES
(1, 'user', '123', '09-322', 'Petrov Petr Petrovich'),
(3, 'user1', '123', '09-322', 'ivanov ivan ivanovich');

-- --------------------------------------------------------

--
-- Table structure for table `wednesday`
--

CREATE TABLE `wednesday` (
  `id` int(10) UNSIGNED NOT NULL,
  `groupNumb` varchar(50) NOT NULL,
  `time` varchar(20) NOT NULL,
  `subject` varchar(32) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `wednesday`
--

INSERT INTO `wednesday` (`id`, `groupNumb`, `time`, `subject`) VALUES
(1, '09-322', '10:10-11:40', 'Противодействия коррупции'),
(2, '09-322', '15:50-17:20', 'Математический анализ'),
(3, '09-322', '15:50-17:20', 'Математический анализ');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `admin`
--
ALTER TABLE `admin`
  ADD UNIQUE KEY `id` (`id`);

--
-- Indexes for table `exam`
--
ALTER TABLE `exam`
  ADD UNIQUE KEY `id` (`id`) USING BTREE;

--
-- Indexes for table `friday`
--
ALTER TABLE `friday`
  ADD UNIQUE KEY `id` (`id`);

--
-- Indexes for table `monday`
--
ALTER TABLE `monday`
  ADD UNIQUE KEY `id` (`id`);

--
-- Indexes for table `saturday`
--
ALTER TABLE `saturday`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `thursday`
--
ALTER TABLE `thursday`
  ADD UNIQUE KEY `id` (`id`);

--
-- Indexes for table `tuesday`
--
ALTER TABLE `tuesday`
  ADD UNIQUE KEY `id` (`id`);

--
-- Indexes for table `user`
--
ALTER TABLE `user`
  ADD UNIQUE KEY `login` (`login`),
  ADD UNIQUE KEY `id` (`id`) USING BTREE;

--
-- Indexes for table `wednesday`
--
ALTER TABLE `wednesday`
  ADD UNIQUE KEY `id` (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `admin`
--
ALTER TABLE `admin`
  MODIFY `id` int(11) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `exam`
--
ALTER TABLE `exam`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `friday`
--
ALTER TABLE `friday`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `monday`
--
ALTER TABLE `monday`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `saturday`
--
ALTER TABLE `saturday`
  MODIFY `id` int(11) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `thursday`
--
ALTER TABLE `thursday`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `tuesday`
--
ALTER TABLE `tuesday`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `user`
--
ALTER TABLE `user`
  MODIFY `id` int(11) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `wednesday`
--
ALTER TABLE `wednesday`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
