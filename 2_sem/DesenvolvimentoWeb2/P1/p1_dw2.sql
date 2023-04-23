-- phpMyAdmin SQL Dump
-- version 4.0.4.2
-- http://www.phpmyadmin.net
--
-- Máquina: localhost
-- Data de Criação: 10-Abr-2023 às 01:30
-- Versão do servidor: 5.6.13
-- versão do PHP: 5.4.17

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Base de Dados: `p1_dw2`
--
CREATE DATABASE IF NOT EXISTS `p1_dw2` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
USE `p1_dw2`;

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_pedidos`
--

CREATE TABLE IF NOT EXISTS `tb_pedidos` (
  `indice` int(5) NOT NULL AUTO_INCREMENT,
  `nome` varchar(60) NOT NULL,
  `email` varchar(60) NOT NULL,
  `telefone` int(11) NOT NULL,
  `massa` varchar(30) NOT NULL,
  `recheio` varchar(30) NOT NULL,
  `tam` char(1) NOT NULL,
  `obs` varchar(120) NOT NULL,
  `ende` varchar(120) NOT NULL,
  PRIMARY KEY (`indice`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=16 ;

--
-- Extraindo dados da tabela `tb_pedidos`
--

INSERT INTO `tb_pedidos` (`indice`, `nome`, `email`, `telefone`, `massa`, `recheio`, `tam`, `obs`, `ende`) VALUES
(14, 'gigio', 'gigio@gmail.com', 2147483647, 'Chocolate', 'Frutas Vermelhas', 'S', '', 'rua nilza miranda avis de carvalho, 145'),
(15, 'mariana', 'mari@marimari.com', 2147483647, 'Baunilha', 'Cream Cheese', 'S', 'massa azul por favor', 'avenida orlando grecco 1000');

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_usuarios`
--

CREATE TABLE IF NOT EXISTS `tb_usuarios` (
  `indice` int(5) NOT NULL AUTO_INCREMENT,
  `nome` varchar(60) NOT NULL,
  `email` varchar(60) NOT NULL,
  `senha` varchar(20) NOT NULL,
  PRIMARY KEY (`indice`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=12 ;

--
-- Extraindo dados da tabela `tb_usuarios`
--

INSERT INTO `tb_usuarios` (`indice`, `nome`, `email`, `senha`) VALUES
(1, 'gigio', 'gigio@gmail.com', '123'),
(5, 'admin', 'admin@admin', '1234'),
(7, 'gigigio', 'gio@gimail.com', '1212'),
(8, 'giulia', 'giugiu@gmail.com', '123'),
(10, 'giolinda', 'giolinda@gmail.com', '12121'),
(11, 'mariana', 'mari@marimari.com', '12345');

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
