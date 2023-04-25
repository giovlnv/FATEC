-- phpMyAdmin SQL Dump
-- version 4.0.4.2
-- http://www.phpmyadmin.net
--
-- Máquina: localhost
-- Data de Criação: 25-Abr-2023 às 18:47
-- Versão do servidor: 5.6.13
-- versão do PHP: 5.4.17

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Base de Dados: `multimarcas`
--
CREATE DATABASE IF NOT EXISTS `multimarcas` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
USE `multimarcas`;

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_carros`
--

CREATE TABLE IF NOT EXISTS `tb_carros` (
  `renavam` int(12) NOT NULL,
  `model` varchar(20) NOT NULL,
  `monta` varchar(20) NOT NULL,
  `placa` varchar(7) NOT NULL,
  `ano` int(4) NOT NULL,
  `valor` float NOT NULL,
  `ipva` float NOT NULL,
  PRIMARY KEY (`renavam`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `tb_carros`
--

INSERT INTO `tb_carros` (`renavam`, `model`, `monta`, `placa`, `ano`, `valor`, `ipva`) VALUES
(11111111, 'Onix', 'Chevrolet', 'eqh1689', 2019, 50000, 2000),
(15151515, 'Renegade', 'Jeep', 'eqh1545', 2020, 65000, 2600),
(15151521, 'Onix', 'Fiat', 'qid5f72', 2005, 75000, 3000),
(22222222, 'Uno', 'Fiat', 'fgh4582', 2007, 7500, 300),
(55555555, 'Uno', 'Fiat', 'fds5225', 1994, 25000, 0);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
