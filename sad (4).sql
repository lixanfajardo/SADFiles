-- phpMyAdmin SQL Dump
-- version 4.7.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Oct 09, 2017 at 06:10 AM
-- Server version: 10.1.26-MariaDB
-- PHP Version: 7.1.8

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `sad`
--

-- --------------------------------------------------------

--
-- Table structure for table `tbl_accounts`
--

CREATE TABLE `tbl_accounts` (
  `account_id` int(11) NOT NULL,
  `account_name` varchar(100) DEFAULT NULL,
  `account_type` enum('Asset','Liability','Expense') DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 ROW_FORMAT=COMPACT;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_category`
--

CREATE TABLE `tbl_category` (
  `category_id` int(11) NOT NULL,
  `category_name` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 ROW_FORMAT=COMPACT;

--
-- Dumping data for table `tbl_category`
--

INSERT INTO `tbl_category` (`category_id`, `category_name`) VALUES
(5, 'Lixan Test'),
(1, 'Lixan Test Category'),
(4, 'Lixan Test Category 2');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_customers`
--

CREATE TABLE `tbl_customers` (
  `customer_id` int(11) NOT NULL,
  `customer_firstName` varchar(50) NOT NULL,
  `customer_middleName` varchar(50) NOT NULL,
  `customer_lastName` varchar(50) NOT NULL,
  `customer_address` varchar(200) DEFAULT 'Davao City',
  `customer_contactNumber` varchar(15) NOT NULL,
  `customer_gender` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 ROW_FORMAT=COMPACT;

--
-- Dumping data for table `tbl_customers`
--

INSERT INTO `tbl_customers` (`customer_id`, `customer_firstName`, `customer_middleName`, `customer_lastName`, `customer_address`, `customer_contactNumber`, `customer_gender`) VALUES
(1, 'Lixan', 'Dominise', 'Fajardo', 'Times Beach Davao City', '09487622322', 'MALE'),
(2, 'Walk-In Customers', 'Walk-In Customers', 'Walk-In Customers', 'Walk-In Customer', '09123456789', 'FEMALE');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_delivery`
--

CREATE TABLE `tbl_delivery` (
  `transaction_id` int(11) NOT NULL,
  `transaction_date` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `invoice_id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_description`
--

CREATE TABLE `tbl_description` (
  `description_id` int(11) NOT NULL,
  `description_name` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 ROW_FORMAT=COMPACT;

--
-- Dumping data for table `tbl_description`
--

INSERT INTO `tbl_description` (`description_id`, `description_name`) VALUES
(8, 'Acc Cable 6HH1'),
(9, 'Acc Cable 8DC9 L3500'),
(6, 'Acc Cable EH700'),
(7, 'Acc Cable HINO'),
(1, 'Charge Freight'),
(10, 'EA-A548'),
(11, 'Federal kia besta 2.7'),
(2, 'Fuel Waiv Rep'),
(3, 'Guko27 GMB'),
(12, 'Hi-Lex 120'),
(4, 'Hydraulic Jack 15 tons'),
(14, 'Lixan Test Item'),
(15, 'Lixan Test Item 2'),
(5, 'Spring Shackle');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_employees`
--

CREATE TABLE `tbl_employees` (
  `employee_id` int(11) NOT NULL,
  `employee_firstName` varchar(50) NOT NULL,
  `employee_middleName` varchar(50) NOT NULL,
  `employee_lastName` varchar(50) NOT NULL,
  `employee_gender` varchar(10) NOT NULL,
  `employee_position` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 ROW_FORMAT=COMPACT;

--
-- Dumping data for table `tbl_employees`
--

INSERT INTO `tbl_employees` (`employee_id`, `employee_firstName`, `employee_middleName`, `employee_lastName`, `employee_gender`, `employee_position`) VALUES
(1, 'admin', 'admin', 'admin', '', 'Owner'),
(2, 'Lixan', 'Dominise', 'Fajardo', 'MALE', 'Owner'),
(3, 'Gem Harvey', 'Test', 'Pedida', 'MALE', 'Owner'),
(4, 'Angelou', 'Buenaflor', 'Mendoza', 'FEMALE', 'Owner'),
(5, 'May Anne', 'Test', 'Test', 'FEMALE', 'Accounting Staff');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_inventory`
--

CREATE TABLE `tbl_inventory` (
  `inventory_id` int(11) NOT NULL,
  `item_name` varchar(100) DEFAULT NULL,
  `category_id` int(11) DEFAULT NULL,
  `description_id` int(11) DEFAULT NULL,
  `quantity` int(11) DEFAULT NULL,
  `inventory_price` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_inventory`
--

INSERT INTO `tbl_inventory` (`inventory_id`, `item_name`, `category_id`, `description_id`, `quantity`, `inventory_price`) VALUES
(1, 'Labidabs', 5, 15, 100, 777),
(2, 'Test', 5, 14, 10, 777),
(3, 'More test', 5, 15, 80, 777);

-- --------------------------------------------------------

--
-- Table structure for table `tbl_order`
--

CREATE TABLE `tbl_order` (
  `invoice_id` int(11) NOT NULL,
  `customer_id` int(11) DEFAULT NULL,
  `inventory_id` int(11) DEFAULT NULL,
  `quantity` int(11) DEFAULT NULL,
  `price` double DEFAULT NULL,
  `date_purchased` varchar(255) NOT NULL,
  `transaction_id` varchar(255) NOT NULL,
  `sales_VAT` double NOT NULL,
  `sales_grossTotal` double NOT NULL,
  `sales_netTotal` double NOT NULL,
  `purchase_type` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_order`
--

INSERT INTO `tbl_order` (`invoice_id`, `customer_id`, `inventory_id`, `quantity`, `price`, `date_purchased`, `transaction_id`, `sales_VAT`, `sales_grossTotal`, `sales_netTotal`, `purchase_type`) VALUES
(1, 1, 1, 7, 777, '0000-00-00 00:00:00', 'EIXFBR', 582.7499999999999, 5439, 4856.25, ''),
(2, 1, 2, 1, 777, '0000-00-00 00:00:00', 'PGLfIC', 83.24999999999999, 777, 693.75, ''),
(3, 1, 2, 0, 777, 'Tue, Oct/03/2017', 'rKEAUY', 83.24999999999999, 777, 693.75, ''),
(4, 1, 1, 0, 777, 'Tue, Oct/03/2017', '9wkhlZ', 83.24999999999999, 777, 693.75, ''),
(5, 1, 2, 1, 777, 'Tue, Oct/03/2017', 'ggHNWD', 83.24999999999999, 777, 693.75, ''),
(6, 1, 2, 2, 777, 'Tue, Oct/03/2017', 'bgr4Sp', 499.5, 4662, 4162.5, ''),
(7, 2, 3, 2, 777, 'Tue, Oct/03/2017', 'bgr4Sp', 499.5, 4662, 4162.5, ''),
(8, 1, 2, 2, 777, 'Tue, Oct/03/2017', 'pu0TId', 499.5, 4662, 4162.5, ''),
(9, 2, 1, 2, 777, 'Tue, Oct/03/2017', 'pu0TId', 499.5, 4662, 4162.5, ''),
(10, 1, 2, 4, 777, 'Tue, Oct/03/2017', 'ikJGjI', 665.9999999999999, 6216, 5550, ''),
(11, 2, 1, 2, 777, 'Tue, Oct/03/2017', 'ikJGjI', 665.9999999999999, 6216, 5550, ''),
(12, 1, 2, 1, 777, 'Tue, Oct/03/2017', '4e38g2', 665.9999999999999, 6216, 5550, ''),
(13, 1, 3, 2, 777, 'Tue, Oct/03/2017', '4e38g2', 665.9999999999999, 6216, 5550, ''),
(14, 1, 1, 5, 777, 'Tue, Oct/03/2017', '4e38g2', 665.9999999999999, 6216, 5550, ''),
(15, 1, 1, 2, 777, 'Tue, Oct/03/2017', 'gSE65p', 499.5, 4662, 4162.5, ''),
(16, 1, 2, 2, 777, 'Tue, Oct/03/2017', 'gSE65p', 499.5, 4662, 4162.5, ''),
(17, 1, 3, 2, 777, 'Tue, Oct/03/2017', 'gSE65p', 499.5, 4662, 4162.5, ''),
(18, 2, 1, 2, 777, 'Wed, Oct/04/2017', 'mKmd4D', 499.5, 4662, 4162.5, ''),
(19, 2, 2, 2, 777, 'Wed, Oct/04/2017', 'mKmd4D', 499.5, 4662, 4162.5, ''),
(20, 2, 3, 2, 777, 'Wed, Oct/04/2017', 'mKmd4D', 499.5, 4662, 4162.5, ''),
(21, 2, 1, 7, 777, 'Thu, Oct/05/2017', 'E9qnCy', 582.7499999999999, 5439, 4856.25, ''),
(22, 2, 1, 3, 777, 'Thu, Oct/05/2017', 'zRR497', 249.75, 2331, 2081.25, ''),
(23, 1, 1, 10, 777, '10-05-2017', 'JTOq10', 1664.9999999999998, 15540, 13875, ''),
(24, 1, 3, 10, 777, '10-05-2017', 'JTOq10', 1664.9999999999998, 15540, 13875, ''),
(25, 1, 3, 20, 777, '10-12-2017', 'lga6bO', 3329.9999999999995, 31080, 27750, ''),
(26, 2, 3, 10, 777, '10-05-2017', 'I6U0EO', 832.4999999999999, 7770, 6937.5, ''),
(27, 2, 2, 20, 777, '10-05-2017', 'fVm2ak', 3329.9999999999995, 31080, 27750, ''),
(28, 2, 3, 10, 777, '10-05-2017', 'fVm2ak', 3329.9999999999995, 31080, 27750, ''),
(29, 2, 2, 2, 777, '10-05-2017', 'eVUAQO', 166.49999999999997, 1554, 1387.5, ''),
(30, 1, 2, 20, 777, '10-05-2017', 'YOhfWu', 2497.4999999999995, 23310, 20812.5, ''),
(31, 1, 3, 10, 777, '10-05-2017', 'YOhfWu', 2497.4999999999995, 23310, 20812.5, ''),
(32, 1, 3, 8, 777, '10-09-2017', 'ckbSu6', 665.9999999999999, 6216, 5550, ''),
(33, 1, 2, 1, 777, '10-09-2017', 'h5oZm6', 83.24999999999999, 777, 693.75, 'Cash'),
(34, 1, 2, 1, 777, '10-09-2017', '3F78aF', 83.24999999999999, 777, 693.75, 'Charge');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_purchased`
--

CREATE TABLE `tbl_purchased` (
  `purchase_id` int(11) UNSIGNED ZEROFILL NOT NULL,
  `date_purchased` varchar(30) DEFAULT NULL,
  `inventory_id` int(11) NOT NULL,
  `supplier_id` int(11) NOT NULL,
  `purchase_quantity` varchar(30) NOT NULL,
  `purchase_code` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_purchased`
--

INSERT INTO `tbl_purchased` (`purchase_id`, `date_purchased`, `inventory_id`, `supplier_id`, `purchase_quantity`, `purchase_code`) VALUES
(00000000001, 'Mon, Oct/02/2017', 1, 1, '7', 'RRt482E/T28='),
(00000000002, 'Mon, Oct/02/2017', 2, 1, '7', 'RRt482E/T28='),
(00000000003, 'Mon, Oct/02/2017', 1, 2, '7', 'tOpblUESpew='),
(00000000004, 'Mon, Oct/02/2017', 2, 2, '7', 'tOpblUESpew='),
(00000000005, 'Mon, Oct/02/2017', 1, 1, '2', 'RRt482E/T28='),
(00000000006, 'Mon, Oct/02/2017', 2, 1, '2', 'RRt482E/T28='),
(00000000007, 'Mon, Oct/02/2017', 1, 2, '2', 'tOpblUESpew='),
(00000000008, 'Mon, Oct/02/2017', 2, 2, '2', 'tOpblUESpew='),
(00000000009, 'Mon, Oct/02/2017', 1, 1, '2', 'RRt482E/T28='),
(00000000010, 'Mon, Oct/02/2017', 2, 1, '2', 'RRt482E/T28='),
(00000000011, 'Mon, Oct/02/2017', 2, 2, '10', 'AssX7PlhhZs='),
(00000000012, 'Mon, Oct/02/2017', 2, 1, '10', 'B0L3Fbz+XeY='),
(00000000013, 'Mon, Oct/02/2017', 2, 2, '10', 'AssX7PlhhZs='),
(00000000014, 'Mon, Oct/02/2017', 1, 1, '2', 'RRt482E/T28='),
(00000000015, 'Mon, Oct/02/2017', 2, 1, '2', 'RRt482E/T28='),
(00000000016, 'Mon, Oct/02/2017', 2, 1, '10', 'AIo2z8QrsMLGiIc1TloDOMVdKYccoYUeoHS10xthjeUFCUfCE+RLWQ=='),
(00000000017, 'Mon, Oct/02/2017', 1, 1, '10', 'AIo2z8QrsMLGiIc1TloDOMVdKYccoYUeoHS10xthjeUFCUfCE+RLWQ=='),
(00000000018, 'Mon, Oct/02/2017', 2, 2, '10', 'AIo2z8QrsMLGiIc1TloDON/3DURQKETQDq+WIYRCYIK74PFf0r6zRA=='),
(00000000019, 'Mon, Oct/02/2017', 1, 2, '10', 'AIo2z8QrsMLGiIc1TloDON/3DURQKETQDq+WIYRCYIK74PFf0r6zRA=='),
(00000000020, 'Mon, Oct/02/2017', 1, 1, '2', 'tv/SQlYBRvfGiIc1TloDOMVdKYccoYUeoHS10xthjeUFCUfCE+RLWQ=='),
(00000000021, 'Mon, Oct/02/2017', 2, 1, '2', 'tv/SQlYBRvfGiIc1TloDOMVdKYccoYUeoHS10xthjeUFCUfCE+RLWQ=='),
(00000000022, 'Mon, Oct/02/2017', 1, 1, '10', 'tv/SQlYBRvfGiIc1TloDOMVdKYccoYUeoHS10xthjeUFCUfCE+RLWQ=='),
(00000000023, 'Mon, Oct/02/2017', 2, 1, '10', 'tv/SQlYBRvfGiIc1TloDOMVdKYccoYUeoHS10xthjeUFCUfCE+RLWQ=='),
(00000000024, 'Mon, Oct/02/2017', 1, 2, '10', 'tv/SQlYBRvfGiIc1TloDON/3DURQKETQDq+WIYRCYIK74PFf0r6zRA=='),
(00000000025, 'Mon, Oct/02/2017', 2, 2, '10', 'tv/SQlYBRvfGiIc1TloDON/3DURQKETQDq+WIYRCYIK74PFf0r6zRA=='),
(00000000026, 'Mon, Oct/02/2017', 2, 1, '10', 'AIo2z8QrsMLGiIc1TloDOMVdKYccoYUeoHS10xthjeUFCUfCE+RLWQ=='),
(00000000027, 'Mon, Oct/02/2017', 3, 1, '77', 'YdgxlMerPNnGiIc1TloDOMVdKYccoYUeoHS10xthjeUFCUfCE+RLWQ=='),
(00000000028, 'Wed, Oct/04/2017', 1, 2, '2', 'kqB5FKNqJmMoTtlteQSkBt/3DURQKETQDq+WIYRCYIK74PFf0r6zRA=='),
(00000000029, 'Wed, Oct/04/2017', 2, 2, '2', 'kqB5FKNqJmMoTtlteQSkBt/3DURQKETQDq+WIYRCYIK74PFf0r6zRA=='),
(00000000030, 'Wed, Oct/04/2017', 3, 2, '2', 'kqB5FKNqJmMoTtlteQSkBt/3DURQKETQDq+WIYRCYIK74PFf0r6zRA=='),
(00000000031, 'Thu, Oct/05/2017', 2, 1, '6', 'vz2hKt+Lxk20F2q7rpt3m8VdKYccoYUeoHS10xthjeUFCUfCE+RLWQ=='),
(00000000032, 'Thu, Oct/05/2017', 3, 1, '3', 'vz2hKt+Lxk20F2q7rpt3m8VdKYccoYUeoHS10xthjeUFCUfCE+RLWQ=='),
(00000000033, 'Thu, Oct/05/2017', 2, 1, '1', 'vz2hKt+Lxk20F2q7rpt3m8VdKYccoYUeoHS10xthjeUFCUfCE+RLWQ=='),
(00000000034, 'Thu, Oct/05/2017', 2, 1, '1', 'vz2hKt+Lxk20F2q7rpt3m8VdKYccoYUeoHS10xthjeUFCUfCE+RLWQ=='),
(00000000035, 'Thu, Oct/05/2017', 2, 1, '1', 'vz2hKt+Lxk20F2q7rpt3m8VdKYccoYUeoHS10xthjeUFCUfCE+RLWQ=='),
(00000000036, 'Thu, Oct/05/2017', 3, 1, '1', 'vz2hKt+Lxk20F2q7rpt3m8VdKYccoYUeoHS10xthjeUFCUfCE+RLWQ=='),
(00000000037, 'Thu, Oct/05/2017', 2, 1, '1', 'W3t87D'),
(00000000038, 'Thu, Oct/05/2017', 3, 1, '2', '1OW3aL'),
(00000000039, 'Thu, Oct/05/2017', 2, 1, '2', '1OW3aL'),
(00000000040, 'Thu, Oct/05/2017', 2, 1, '3', 'IPO4PV'),
(00000000041, 'Thu, Oct/05/2017', 3, 2, '3', 'oYgjcf'),
(00000000042, 'Thu, Oct/05/2017', 3, 1, '1', 'oiY0nB'),
(00000000043, 'Thu, Oct/05/2017', 3, 1, '1', 'y9MQZV'),
(00000000044, 'Thu, Oct/05/2017', 1, 1, '10', 'dkLcAg'),
(00000000045, '10-05-2017', 1, 1, '100', 'eNn7Qx'),
(00000000046, '10-05-2017', 1, 1, '90', 'FUO1tU'),
(00000000047, '10-05-2017', 3, 1, '50', '3zOPzH'),
(00000000048, '10-05-2017', 2, 1, '10', '3zOPzH'),
(00000000049, '10-09-2017', 2, 2, '4', 'lPdGUE');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_purchasedlist`
--

CREATE TABLE `tbl_purchasedlist` (
  `purchaselist_id` int(11) UNSIGNED ZEROFILL NOT NULL,
  `date_purchased` varchar(30) NOT NULL,
  `supplier_id` int(11) NOT NULL,
  `purchase_code` varchar(255) NOT NULL,
  `purchase_status` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_purchasedlist`
--

INSERT INTO `tbl_purchasedlist` (`purchaselist_id`, `date_purchased`, `supplier_id`, `purchase_code`, `purchase_status`) VALUES
(00000000001, 'Mon, Oct/02/2017', 1, 'RRt482E/T28=', 'CANCELED'),
(00000000002, 'Mon, Oct/02/2017', 2, 'tOpblUESpew=', 'DELIVERED'),
(00000000003, 'Mon, Oct/02/2017', 1, 'RRt482E/T28=', 'CANCELED'),
(00000000004, 'Mon, Oct/02/2017', 2, 'tOpblUESpew=', 'DELIVERED'),
(00000000005, 'Mon, Oct/02/2017', 1, 'RRt482E/T28=', 'CANCELED'),
(00000000006, 'Mon, Oct/02/2017', 2, 'AssX7PlhhZs=', 'DELIVERED'),
(00000000007, 'Mon, Oct/02/2017', 1, 'B0L3Fbz+XeY=', 'DELIVERED'),
(00000000008, 'Mon, Oct/02/2017', 2, 'AssX7PlhhZs=', 'DELIVERED'),
(00000000009, 'Mon, Oct/02/2017', 1, 'RRt482E/T28=', 'DELIVERED'),
(00000000010, 'Mon, Oct/02/2017', 1, 'AIo2z8QrsMLGiIc1TloDOMVdKYccoYUeoHS10xthjeUFCUfCE+RLWQ==', 'DELIVERED'),
(00000000011, 'Mon, Oct/02/2017', 2, 'AIo2z8QrsMLGiIc1TloDON/3DURQKETQDq+WIYRCYIK74PFf0r6zRA==', 'DELIVERED'),
(00000000012, 'Mon, Oct/02/2017', 1, 'tv/SQlYBRvfGiIc1TloDOMVdKYccoYUeoHS10xthjeUFCUfCE+RLWQ==', 'DELIVERED'),
(00000000013, 'Mon, Oct/02/2017', 1, 'tv/SQlYBRvfGiIc1TloDOMVdKYccoYUeoHS10xthjeUFCUfCE+RLWQ==', 'DELIVERED'),
(00000000014, 'Mon, Oct/02/2017', 2, 'tv/SQlYBRvfGiIc1TloDON/3DURQKETQDq+WIYRCYIK74PFf0r6zRA==', 'DELIVERED'),
(00000000015, 'Mon, Oct/02/2017', 1, 'AIo2z8QrsMLGiIc1TloDOMVdKYccoYUeoHS10xthjeUFCUfCE+RLWQ==', 'DELIVERED'),
(00000000016, 'Mon, Oct/02/2017', 1, 'YdgxlMerPNnGiIc1TloDOMVdKYccoYUeoHS10xthjeUFCUfCE+RLWQ==', 'DELIVERED'),
(00000000017, 'Wed, Oct/04/2017', 2, 'kqB5FKNqJmMoTtlteQSkBt/3DURQKETQDq+WIYRCYIK74PFf0r6zRA==', 'CANCELED'),
(00000000018, 'Thu, Oct/05/2017', 1, 'vz2hKt+Lxk20F2q7rpt3m8VdKYccoYUeoHS10xthjeUFCUfCE+RLWQ==', 'CANCELED'),
(00000000022, 'Thu, Oct/05/2017', 1, 'W3t87D', 'DELIVERED'),
(00000000023, 'Thu, Oct/05/2017', 1, '1OW3aL', 'CANCELED'),
(00000000024, 'Thu, Oct/05/2017', 1, 'IPO4PV', 'DELIVERED'),
(00000000025, 'Thu, Oct/05/2017', 2, 'oYgjcf', 'DELIVERED'),
(00000000026, 'Thu, Oct/05/2017', 1, 'oiY0nB', 'DELIVERED'),
(00000000027, 'Thu, Oct/05/2017', 1, 'y9MQZV', 'CANCELED'),
(00000000028, 'Thu, Oct/05/2017', 1, 'dkLcAg', 'DELIVERED'),
(00000000029, '10-05-2017', 1, 'eNn7Qx', 'CANCELED'),
(00000000030, '10-05-2017', 1, 'FUO1tU', 'DELIVERED'),
(00000000031, '10-05-2017', 1, '3zOPzH', 'DELIVERED'),
(00000000032, '10-09-2017', 2, 'lPdGUE', 'DELIVERED');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_reports`
--

CREATE TABLE `tbl_reports` (
  `report_id` int(11) NOT NULL,
  `check_no` int(11) UNSIGNED ZEROFILL DEFAULT NULL,
  `pay_to` int(11) DEFAULT NULL,
  `account_id` int(11) DEFAULT NULL,
  `amount` double DEFAULT NULL,
  `tax_percentage` int(11) DEFAULT NULL,
  `date_issued` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_suppliers`
--

CREATE TABLE `tbl_suppliers` (
  `supplier_id` int(11) NOT NULL,
  `supplier_name` varchar(200) NOT NULL,
  `supplier_address` longtext NOT NULL,
  `supplier_contactPerson` text NOT NULL,
  `supplier_contactNumber` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 ROW_FORMAT=COMPACT;

--
-- Dumping data for table `tbl_suppliers`
--

INSERT INTO `tbl_suppliers` (`supplier_id`, `supplier_name`, `supplier_address`, `supplier_contactPerson`, `supplier_contactNumber`) VALUES
(1, 'Lixan Gwapo Company', 'UM Matina Davao City', 'Lixan Fajardo', '09487622322'),
(2, 'Angelou Test Supplier', 'UM Matina Campus Davao City', 'Angelou', '1234567');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_user`
--

CREATE TABLE `tbl_user` (
  `user_id` int(11) NOT NULL,
  `user_userName` varchar(255) NOT NULL,
  `user_password` varchar(255) NOT NULL,
  `employee_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_user`
--

INSERT INTO `tbl_user` (`user_id`, `user_userName`, `user_password`, `employee_id`) VALUES
(1, 'admin', '3lHEFvgTfik=', 1),
(2, 'lixan', 'apAZaTFikIYRKNNrAf3fEA==', 2),
(3, 'gem', 'OGung2b4BmE=', 3),
(4, 'gelou', 'OGung2b4BmE=', 4),
(5, 'may_anne', 'OGung2b4BmE=', 5);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tbl_accounts`
--
ALTER TABLE `tbl_accounts`
  ADD PRIMARY KEY (`account_id`),
  ADD UNIQUE KEY `accountName` (`account_name`),
  ADD UNIQUE KEY `account_name` (`account_name`);

--
-- Indexes for table `tbl_category`
--
ALTER TABLE `tbl_category`
  ADD PRIMARY KEY (`category_id`),
  ADD UNIQUE KEY `name` (`category_name`);

--
-- Indexes for table `tbl_customers`
--
ALTER TABLE `tbl_customers`
  ADD PRIMARY KEY (`customer_id`);

--
-- Indexes for table `tbl_delivery`
--
ALTER TABLE `tbl_delivery`
  ADD PRIMARY KEY (`transaction_id`),
  ADD KEY `invoice_id` (`invoice_id`);

--
-- Indexes for table `tbl_description`
--
ALTER TABLE `tbl_description`
  ADD PRIMARY KEY (`description_id`),
  ADD UNIQUE KEY `name` (`description_name`);

--
-- Indexes for table `tbl_employees`
--
ALTER TABLE `tbl_employees`
  ADD PRIMARY KEY (`employee_id`);

--
-- Indexes for table `tbl_inventory`
--
ALTER TABLE `tbl_inventory`
  ADD PRIMARY KEY (`inventory_id`),
  ADD UNIQUE KEY `item_name` (`item_name`),
  ADD KEY `category_id` (`category_id`),
  ADD KEY `description_id` (`description_id`);

--
-- Indexes for table `tbl_order`
--
ALTER TABLE `tbl_order`
  ADD PRIMARY KEY (`invoice_id`),
  ADD KEY `inventory_id` (`inventory_id`),
  ADD KEY `customer_id` (`customer_id`);

--
-- Indexes for table `tbl_purchased`
--
ALTER TABLE `tbl_purchased`
  ADD PRIMARY KEY (`purchase_id`),
  ADD KEY `fk_inventory` (`inventory_id`),
  ADD KEY `fk_supplier` (`supplier_id`);

--
-- Indexes for table `tbl_purchasedlist`
--
ALTER TABLE `tbl_purchasedlist`
  ADD PRIMARY KEY (`purchaselist_id`),
  ADD KEY `supplier_id` (`supplier_id`);

--
-- Indexes for table `tbl_reports`
--
ALTER TABLE `tbl_reports`
  ADD PRIMARY KEY (`report_id`),
  ADD KEY `check_no` (`check_no`),
  ADD KEY `account_id` (`account_id`),
  ADD KEY `pay_to` (`pay_to`);

--
-- Indexes for table `tbl_suppliers`
--
ALTER TABLE `tbl_suppliers`
  ADD PRIMARY KEY (`supplier_id`);

--
-- Indexes for table `tbl_user`
--
ALTER TABLE `tbl_user`
  ADD PRIMARY KEY (`user_id`),
  ADD KEY `employee_id` (`employee_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tbl_category`
--
ALTER TABLE `tbl_category`
  MODIFY `category_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
--
-- AUTO_INCREMENT for table `tbl_customers`
--
ALTER TABLE `tbl_customers`
  MODIFY `customer_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT for table `tbl_delivery`
--
ALTER TABLE `tbl_delivery`
  MODIFY `transaction_id` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `tbl_description`
--
ALTER TABLE `tbl_description`
  MODIFY `description_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;
--
-- AUTO_INCREMENT for table `tbl_employees`
--
ALTER TABLE `tbl_employees`
  MODIFY `employee_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
--
-- AUTO_INCREMENT for table `tbl_inventory`
--
ALTER TABLE `tbl_inventory`
  MODIFY `inventory_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT for table `tbl_order`
--
ALTER TABLE `tbl_order`
  MODIFY `invoice_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=35;
--
-- AUTO_INCREMENT for table `tbl_purchased`
--
ALTER TABLE `tbl_purchased`
  MODIFY `purchase_id` int(11) UNSIGNED ZEROFILL NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=50;
--
-- AUTO_INCREMENT for table `tbl_purchasedlist`
--
ALTER TABLE `tbl_purchasedlist`
  MODIFY `purchaselist_id` int(11) UNSIGNED ZEROFILL NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=33;
--
-- AUTO_INCREMENT for table `tbl_reports`
--
ALTER TABLE `tbl_reports`
  MODIFY `report_id` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `tbl_suppliers`
--
ALTER TABLE `tbl_suppliers`
  MODIFY `supplier_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT for table `tbl_user`
--
ALTER TABLE `tbl_user`
  MODIFY `user_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
--
-- Constraints for dumped tables
--

--
-- Constraints for table `tbl_delivery`
--
ALTER TABLE `tbl_delivery`
  ADD CONSTRAINT `tbl_delivery_ibfk_1` FOREIGN KEY (`invoice_id`) REFERENCES `tbl_order` (`invoice_id`);

--
-- Constraints for table `tbl_inventory`
--
ALTER TABLE `tbl_inventory`
  ADD CONSTRAINT `tbl_inventory_ibfk_1` FOREIGN KEY (`category_id`) REFERENCES `tbl_category` (`category_id`),
  ADD CONSTRAINT `tbl_inventory_ibfk_2` FOREIGN KEY (`description_id`) REFERENCES `tbl_description` (`description_id`);

--
-- Constraints for table `tbl_order`
--
ALTER TABLE `tbl_order`
  ADD CONSTRAINT `tbl_order_ibfk_1` FOREIGN KEY (`inventory_id`) REFERENCES `tbl_inventory` (`inventory_id`),
  ADD CONSTRAINT `tbl_order_ibfk_2` FOREIGN KEY (`customer_id`) REFERENCES `tbl_customers` (`customer_id`);

--
-- Constraints for table `tbl_purchased`
--
ALTER TABLE `tbl_purchased`
  ADD CONSTRAINT `fk_inventory` FOREIGN KEY (`inventory_id`) REFERENCES `tbl_inventory` (`inventory_id`),
  ADD CONSTRAINT `fk_supplier` FOREIGN KEY (`supplier_id`) REFERENCES `tbl_suppliers` (`supplier_id`);

--
-- Constraints for table `tbl_purchasedlist`
--
ALTER TABLE `tbl_purchasedlist`
  ADD CONSTRAINT `tbl_purchasedlist_ibfk_1` FOREIGN KEY (`supplier_id`) REFERENCES `tbl_suppliers` (`supplier_id`) ON UPDATE CASCADE;

--
-- Constraints for table `tbl_user`
--
ALTER TABLE `tbl_user`
  ADD CONSTRAINT `tbl_user_ibfk_1` FOREIGN KEY (`employee_id`) REFERENCES `tbl_employees` (`employee_id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
