-- phpMyAdmin SQL Dump
-- version 4.3.11
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Oct 28, 2019 at 04:02 PM
-- Server version: 5.6.24
-- PHP Version: 5.5.24

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `mytest`
--

-- --------------------------------------------------------

--
-- Table structure for table `delete_table`
--

CREATE TABLE IF NOT EXISTS `delete_table` (
  `ID` int(11) NOT NULL,
  `NAME` varchar(50) NOT NULL,
  `MARK` double NOT NULL,
  `DEPART` int(11) NOT NULL,
  `date` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `delete_table`
--

INSERT INTO `delete_table` (`ID`, `NAME`, `MARK`, `DEPART`, `date`) VALUES
(123, 'Dimitri555', 10555, 1555, '0000-00-00 00:00:00'),
(231, 'Alex', 10, 2, '0000-00-00 00:00:00'),
(2, 'Steve', 0, 1, '0000-00-00 00:00:00'),
(123, 'Saddy', 22, 2, '0000-00-00 00:00:00'),
(145, 'abcd', 354, 1, '0000-00-00 00:00:00'),
(335, 'qwert', 22, 2, '0000-00-00 00:00:00'),
(553, 'asd', 1, 1, '2019-10-28 10:17:23'),
(676, 'TTTT', 12, 2, '2019-10-28 10:47:52');

-- --------------------------------------------------------

--
-- Table structure for table `student`
--

CREATE TABLE IF NOT EXISTS `student` (
  `ID` int(11) NOT NULL,
  `NAME` varchar(30) NOT NULL,
  `MARK` double NOT NULL,
  `DEPART` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `student`
--

INSERT INTO `student` (`ID`, `NAME`, `MARK`, `DEPART`) VALUES
(123, 'Dmitri', 55, 2),
(224, 'sumei', 15, 1),
(234, 'daniel', 10, 2),
(413, 'Linxin Su', 9, 1),
(456, 'acxc', 23, 1),
(555, 'Bryan', 10, 2),
(989, 'pop', 12, 1);

-- --------------------------------------------------------

--
-- Table structure for table `update_table`
--

CREATE TABLE IF NOT EXISTS `update_table` (
  `ID` int(11) NOT NULL,
  `NAME` varchar(50) NOT NULL,
  `MARK` double NOT NULL,
  `DEPART` int(11) NOT NULL,
  `date` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `update_table`
--

INSERT INTO `update_table` (`ID`, `NAME`, `MARK`, `DEPART`, `date`) VALUES
(123, 'Dimitri', 10, 1, '0000-00-00 00:00:00'),
(2, 'Steve', 0, 1, '0000-00-00 00:00:00'),
(224, 'sumei', 10, 1, '0000-00-00 00:00:00'),
(224, 'sumei', 12, 1, '0000-00-00 00:00:00'),
(224, 'sumei', 14, 1, '0000-00-00 00:00:00'),
(123, 'Saddy', 23, 2, '0000-00-00 00:00:00'),
(145, 'abc', 22, 1, '0000-00-00 00:00:00'),
(123, 'asd', 1, 1, '2019-10-28 10:19:26'),
(676, 'qwe', 12, 2, '2019-10-28 10:47:48');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `student`
--
ALTER TABLE `student`
  ADD PRIMARY KEY (`ID`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
