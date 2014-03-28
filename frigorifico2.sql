-- phpMyAdmin SQL Dump
-- version 3.3.9
-- http://www.phpmyadmin.net
--
-- Servidor: localhost
-- Tempo de Geração: Fev 17, 2014 as 02:40 PM
-- Versão do Servidor: 5.5.8
-- Versão do PHP: 5.3.5

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Banco de Dados: `frigorifico2`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `animal`
--

CREATE TABLE IF NOT EXISTS `animal` (
  `id_animal` int(11) NOT NULL AUTO_INCREMENT,
  `peso` float NOT NULL,
  `preco` double NOT NULL,
  `quantidade` int(11) NOT NULL,
  `id_fornecedor` int(11) NOT NULL,
  `id_tipo` int(11) NOT NULL,
  PRIMARY KEY (`id_animal`),
  KEY `id_fornecedor` (`id_fornecedor`),
  KEY `id_tipo` (`id_tipo`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

--
-- Extraindo dados da tabela `animal`
--


-- --------------------------------------------------------

--
-- Estrutura da tabela `compra`
--

CREATE TABLE IF NOT EXISTS `compra` (
  `id_compra` int(11) NOT NULL AUTO_INCREMENT,
  `valor_total` double NOT NULL,
  PRIMARY KEY (`id_compra`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

--
-- Extraindo dados da tabela `compra`
--


-- --------------------------------------------------------

--
-- Estrutura da tabela `fisica`
--

CREATE TABLE IF NOT EXISTS `fisica` (
  `cpf` varchar(12) NOT NULL,
  `nome` varchar(120) NOT NULL,
  `codigo` int(11) NOT NULL,
  `sexo` char(1) NOT NULL,
  `nascimento` date DEFAULT NULL,
  UNIQUE KEY `cpf` (`cpf`),
  KEY `codigo` (`codigo`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `fisica`
--


-- --------------------------------------------------------

--
-- Estrutura da tabela `fornecedor`
--

CREATE TABLE IF NOT EXISTS `fornecedor` (
  `nome` varchar(120) DEFAULT NULL,
  `cnpj` varchar(10) DEFAULT NULL,
  `nome_fantasia` varchar(10) DEFAULT NULL,
  `razao_social` varchar(10) DEFAULT NULL,
  `senha` varchar(10) NOT NULL,
  `id_fornecedor` int(11) NOT NULL AUTO_INCREMENT,
  `id_pessoa` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_fornecedor`),
  KEY `id_pessoa` (`id_pessoa`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

--
-- Extraindo dados da tabela `fornecedor`
--


-- --------------------------------------------------------

--
-- Estrutura da tabela `itens_compra`
--

CREATE TABLE IF NOT EXISTS `itens_compra` (
  `id_itens` int(11) NOT NULL AUTO_INCREMENT,
  `quantidade` int(11) NOT NULL,
  `valor_unidade` double DEFAULT NULL,
  `id_compra` int(11) NOT NULL,
  `id_produto` int(11) NOT NULL,
  PRIMARY KEY (`id_itens`),
  KEY `id_compra` (`id_compra`),
  KEY `id_produto` (`id_produto`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

--
-- Extraindo dados da tabela `itens_compra`
--


-- --------------------------------------------------------

--
-- Estrutura da tabela `juridica`
--

CREATE TABLE IF NOT EXISTS `juridica` (
  `cnpj` varchar(12) NOT NULL,
  `nome_fantasia` varchar(120) NOT NULL,
  `razao_social` varchar(120) DEFAULT NULL,
  `codigo` int(11) NOT NULL,
  `responsavel` varchar(120) NOT NULL,
  UNIQUE KEY `cnpj` (`cnpj`),
  KEY `codigo` (`codigo`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `juridica`
--


-- --------------------------------------------------------

--
-- Estrutura da tabela `pessoa`
--

CREATE TABLE IF NOT EXISTS `pessoa` (
  `codigo` int(11) NOT NULL AUTO_INCREMENT,
  `telefone` varchar(12) DEFAULT NULL,
  `celular` varchar(12) NOT NULL,
  `email` varchar(20) NOT NULL,
  `estado` varchar(12) NOT NULL,
  `cep` varchar(12) NOT NULL,
  `municipio` varchar(12) NOT NULL,
  `complemento` varchar(12) NOT NULL,
  `numero` varchar(3) NOT NULL,
  `senha` varchar(10) NOT NULL,
  PRIMARY KEY (`codigo`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=6 ;

--
-- Extraindo dados da tabela `pessoa`
--

INSERT INTO `pessoa` (`codigo`, `telefone`, `celular`, `email`, `estado`, `cep`, `municipio`, `complemento`, `numero`, `senha`) VALUES
(1, '587135873', '5381458', 'hadfhd@hotmail.com', 'hdkgdhfgdak', 'gdakfgkdag', 'gakdgfkag', 'tetdayiftdi', '67', 'gdkadkfgka'),
(2, '587135873', '5381458', 'hadfhd@hotmail.com', 'hdkgdhfgdak', 'gdakfgkdag', 'gakdgfkag', 'tetdayiftdi', '67', 'gdkadkfgka'),
(3, '20', '20', 'fellypeavelino@hotma', 'Acre', '600000000000', 'recife', '20', '20', 'nirvana'),
(4, '11111111', '1111111111', '111111111111111', 'Acre', '111111111', '111111111', '1111111111', '111', '11111111'),
(5, '2', '2', '2', 'Acre', '2', '22222', '2', '21', '222222222');

-- --------------------------------------------------------

--
-- Estrutura da tabela `produto`
--

CREATE TABLE IF NOT EXISTS `produto` (
  `id_produto` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(10) NOT NULL,
  `peso` float NOT NULL,
  `preco` double NOT NULL,
  PRIMARY KEY (`id_produto`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

--
-- Extraindo dados da tabela `produto`
--


-- --------------------------------------------------------

--
-- Estrutura da tabela `tipo`
--

CREATE TABLE IF NOT EXISTS `tipo` (
  `id_tipo` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(10) NOT NULL,
  PRIMARY KEY (`id_tipo`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

--
-- Extraindo dados da tabela `tipo`
--


--
-- Restrições para as tabelas dumpadas
--

--
-- Restrições para a tabela `animal`
--
ALTER TABLE `animal`
  ADD CONSTRAINT `animal_ibfk_1` FOREIGN KEY (`id_fornecedor`) REFERENCES `fornecedor` (`id_fornecedor`),
  ADD CONSTRAINT `animal_ibfk_2` FOREIGN KEY (`id_tipo`) REFERENCES `tipo` (`id_tipo`);

--
-- Restrições para a tabela `fisica`
--
ALTER TABLE `fisica`
  ADD CONSTRAINT `fisica_ibfk_1` FOREIGN KEY (`codigo`) REFERENCES `pessoa` (`codigo`);

--
-- Restrições para a tabela `fornecedor`
--
ALTER TABLE `fornecedor`
  ADD CONSTRAINT `fornecedor_ibfk_1` FOREIGN KEY (`id_pessoa`) REFERENCES `pessoa` (`codigo`);

--
-- Restrições para a tabela `itens_compra`
--
ALTER TABLE `itens_compra`
  ADD CONSTRAINT `itens_compra_ibfk_1` FOREIGN KEY (`id_compra`) REFERENCES `compra` (`id_compra`),
  ADD CONSTRAINT `itens_compra_ibfk_2` FOREIGN KEY (`id_produto`) REFERENCES `produto` (`id_produto`);

--
-- Restrições para a tabela `juridica`
--
ALTER TABLE `juridica`
  ADD CONSTRAINT `juridica_ibfk_1` FOREIGN KEY (`codigo`) REFERENCES `pessoa` (`codigo`);
