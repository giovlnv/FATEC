-- phpMyAdmin SQL Dump
-- version 4.0.4.2
-- http://www.phpmyadmin.net
--
-- Máquina: localhost
-- Data de Criação: 04-Set-2023 às 22:54
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
-- Estrutura da tabela `tb_carrinho`
--

CREATE TABLE IF NOT EXISTS `tb_carrinho` (
  `item` int(2) NOT NULL AUTO_INCREMENT,
  `email` varchar(60) NOT NULL,
  `cod_bolo` varchar(8) NOT NULL,
  `descricao` varchar(120) NOT NULL,
  `obs` varchar(120) NOT NULL,
  `preco` float NOT NULL,
  `quantidade` int(2) NOT NULL,
  PRIMARY KEY (`item`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=43 ;

--
-- Extraindo dados da tabela `tb_carrinho`
--

INSERT INTO `tb_carrinho` (`item`, `email`, `cod_bolo`, `descricao`, `obs`, `preco`, `quantidade`) VALUES
(31, 'betinho@gmail.com', 'Me09BaA4', 'Bolo Medio com massa sabor Baunilha, recheio sabor Frutas Vermelhas. Adicional: Morango', '', 28, 1),
(32, 'betinho@gmail.com', 'Me09BaA4', 'Bolo Medio com massa sabor Baunilha, recheio sabor Frutas Vermelhas. Adicional: Morango', '', 28, 1),
(33, 'betinho@gmail.com', 'Me09BaA4', 'Bolo Medio com massa sabor Baunilha, recheio sabor Frutas Vermelhas. Adicional: Morango', '', 28, 1),
(34, 'betinho@gmail.com', 'Gr01BaA1', 'Bolo Grande com massa sabor Baunilha, recheio sabor Abacaxi em Calda. Adicional: Ferrero Rocher', '', 33, 1),
(35, 'betinho@gmail.com', 'Gr01BaA1', 'Bolo Grande com massa sabor Baunilha, recheio sabor Abacaxi em Calda. Adicional: Ferrero Rocher', '', 33, 1),
(36, 'betinho@gmail.com', 'Gr01BaA1', 'Bolo Grande com massa sabor Baunilha, recheio sabor Abacaxi em Calda. Adicional: Ferrero Rocher', '', 33, 1),
(37, 'betinho@gmail.com', 'Gr01BaA1', 'Bolo Grande com massa sabor Baunilha, recheio sabor Abacaxi em Calda. Adicional: Ferrero Rocher', '', 33, 1);

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_ingredientes`
--

CREATE TABLE IF NOT EXISTS `tb_ingredientes` (
  `cd_ingrediente` varchar(2) NOT NULL,
  `categ_ingrediente` varchar(15) NOT NULL,
  `ds_ingrediente` varchar(50) NOT NULL,
  `preco_ingrediente` float NOT NULL,
  PRIMARY KEY (`cd_ingrediente`),
  UNIQUE KEY `cd_ingrediente` (`cd_ingrediente`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `tb_ingredientes`
--

INSERT INTO `tb_ingredientes` (`cd_ingrediente`, `categ_ingrediente`, `ds_ingrediente`, `preco_ingrediente`) VALUES
('01', 'Recheios', 'Abacaxi em Calda', 3),
('02', 'Recheios', 'Amendoim', 0),
('03', 'Recheios', 'Banoffee', 3),
('04', 'Recheios', 'Baunilha', 0),
('05', 'Recheios', 'Brigadeiro', 0),
('06', 'Recheios', 'Cream Cheese', 3),
('07', 'Recheios', 'Creme de Avelã', 3),
('08', 'Recheios', 'Coco', 0),
('09', 'Recheios', 'Frutas Vermelhas', 3),
('10', 'Recheios', 'Limão Siciliano', 3),
('11', 'Recheios', 'Leite em Pó', 0),
('12', 'Recheios', 'Morango', 3),
('A0', 'Adicionais', 'Nenhum', 0),
('A1', 'Adicionais', 'Ferrero Rocher', 5),
('A2', 'Adicionais', 'Kit Kat', 5),
('A3', 'Adicionais', 'M&M', 5),
('A4', 'Adicionais', 'Morango', 5),
('Ba', 'Massas', 'Baunilha', 0),
('Ch', 'Massas', 'Chocolate', 0),
('Gr', 'Tamanhos', 'Grande', 25),
('Me', 'Tamanhos', 'Médio', 20),
('Pe', 'Tamanhos', 'Pequeno', 15),
('Re', 'Massas', 'Red Velvet', 0),
('Su', 'Tamanhos', 'Super', 30);

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_pedidos`
--

CREATE TABLE IF NOT EXISTS `tb_pedidos` (
  `indice` int(11) NOT NULL AUTO_INCREMENT,
  `cod_bolo` varchar(8) NOT NULL,
  `num_pedido` varchar(12) NOT NULL,
  `descricao` varchar(120) NOT NULL,
  `email` varchar(60) NOT NULL,
  `obs` varchar(120) NOT NULL,
  `quantidade` int(2) NOT NULL,
  `preco` float NOT NULL,
  `ende` varchar(120) NOT NULL,
  `status_pdd` varchar(10) NOT NULL,
  PRIMARY KEY (`indice`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=26 ;

--
-- Extraindo dados da tabela `tb_pedidos`
--

INSERT INTO `tb_pedidos` (`indice`, `cod_bolo`, `num_pedido`, `descricao`, `email`, `obs`, `quantidade`, `preco`, `ende`, `status_pdd`) VALUES
(4, 'Gr07ChA1', '2147483647', 'Bolo Grande com massa sabor Chocolate, recheio sabor Creme de Avela. Adicional: Ferrero Rocher', 'gigio@gmail.com', '', 2, 66, 'jardins', 'Finalizado'),
(5, 'Me07ChA3', '2147483647', 'Bolo Medio com massa sabor Chocolate, recheio sabor Creme de Avela. Adicional: M&Ms', 'gigio@gmail.com', '', 1, 28, 'jardins', 'Finalizado'),
(10, 'Gr07ChA1', '230604082644', 'Bolo Grande com massa sabor Chocolate, recheio sabor Creme de Avela. Adicional: Ferrero Rocher', 'betinho@gmail.com', '', 2, 66, 'faffa', 'Cancelado'),
(11, 'Me07ChA3', '230604082644', 'Bolo Medio com massa sabor Chocolate, recheio sabor Creme de Avela. Adicional: M&Ms', 'betinho@gmail.com', '', 1, 28, 'faffa', 'Cancelado'),
(12, 'Gr07ChA1', '230605133434', 'Bolo Grande com massa sabor Chocolate, recheio sabor Creme de Avela. Adicional: Ferrero Rocher', 'betinho@gmail.com', '', 2, 66, 'fatec', 'Preparando'),
(13, 'Gr09BaA4', '230605133434', 'Bolo Grande com massa sabor Baunilha, recheio sabor Frutas Vermelhas. Adicional: Morango', 'betinho@gmail.com', '', 1, 33, 'fatec', 'Preparando'),
(14, 'Me07ChA3', '230605133434', 'Bolo Medio com massa sabor Chocolate, recheio sabor Creme de Avela. Adicional: M&Ms', 'betinho@gmail.com', '', 1, 28, 'fatec', 'Preparando'),
(15, 'Me07ChA2', '230605140604', 'Bolo Medio com massa sabor Chocolate, recheio sabor Creme de Avela. Adicional: Kit Kat', 'gigio@gmail.com', '', 3, 84, 'fatec', 'Finalizado'),
(16, 'Su07ChA1', '230605140604', 'Bolo Super com massa sabor Chocolate, recheio sabor Creme de Avela. Adicional: Ferrero Rocher', 'gigio@gmail.com', '', 1, 38, 'fatec', 'Finalizado'),
(18, 'Gr07ChA2', '230605143151', 'Bolo Grande com massa sabor Chocolate, recheio sabor Creme de Avela. Adicional: Kit Kat', 'gigio@gmail.com', '', 1, 33, 'maua', 'Realizado'),
(19, 'Gr09BaA4', '230605143151', 'Bolo Grande com massa sabor Baunilha, recheio sabor Frutas Vermelhas. Adicional: Morango', 'gigio@gmail.com', '', 1, 33, 'maua', 'Realizado'),
(20, 'Gr09BaA4', '230605192808', 'Bolo Grande com massa sabor Baunilha, recheio sabor Frutas Vermelhas. Adicional: Morango', 'anto@ny.com', '', 1, 33, 'fatec maua', 'Realizado'),
(21, 'Su01BaA2', '230605192808', 'Bolo Super com massa sabor Baunilha, recheio sabor Abacaxi em Calda. Adicional: Kit Kat', 'anto@ny.com', '', 2, 76, 'fatec maua', 'Realizado'),
(22, 'Pe03BaA0', '230605201744', 'Bolo Pequeno com massa sabor Baunilha, recheio sabor Banoffee. Adicional: Nenhum', 'aanthony@gmail.com', '', 1, 20, 'fstec maua', 'Realizado'),
(23, 'Gr07ChA2', '230904194632', 'Bolo Grande com massa sabor Chocolate, recheio sabor Creme de Avela. Adicional: Kit Kat', 'gigio@gmail.com', '', 1, 33, 'FATEC MAUÃ', 'Pronto'),
(24, 'Gr09BaA4', '230904194632', 'Bolo Grande com massa sabor Baunilha, recheio sabor Frutas Vermelhas. Adicional: Morango', 'gigio@gmail.com', '', 1, 33, 'FATEC MAUÃ', 'Pronto');

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_usuarios`
--

CREATE TABLE IF NOT EXISTS `tb_usuarios` (
  `index` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(60) NOT NULL,
  `email` varchar(60) NOT NULL,
  `senha` varchar(20) NOT NULL,
  `tel` int(11) NOT NULL,
  PRIMARY KEY (`index`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=24 ;

--
-- Extraindo dados da tabela `tb_usuarios`
--

INSERT INTO `tb_usuarios` (`index`, `nome`, `email`, `senha`, `tel`) VALUES
(1, 'gigio', 'gigio@gmail.com', '123', 0),
(2, 'admin', 'admin@admin', '1234', 0),
(3, 'gigigio', 'gio@gimail.com', '1212', 0),
(21, 'betinho', 'betinho@gmail.com', '1', 15234851),
(22, 'anthony', 'anto@ny.com', '1', 185128451),
(23, 'anthony', 'aanthony@gmail.com', '123', 12345666);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
