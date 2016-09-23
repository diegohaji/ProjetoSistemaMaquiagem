-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: 23-Set-2016 às 19:56
-- Versão do servidor: 10.1.8-MariaDB
-- PHP Version: 5.6.14

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `bd_lmds`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_cliente`
--

CREATE TABLE `tb_cliente` (
  `cd_cliente` int(10) UNSIGNED NOT NULL,
  `nm_cliente` varchar(127) DEFAULT NULL,
  `cpf_cliente` varchar(11) DEFAULT NULL,
  `rg_cliente` varchar(8) NOT NULL,
  `email_cliente` varchar(127) DEFAULT NULL,
  `cep_cliente` varchar(8) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `tb_cliente`
--

INSERT INTO `tb_cliente` (`cd_cliente`, `nm_cliente`, `cpf_cliente`, `rg_cliente`, `email_cliente`, `cep_cliente`) VALUES
(666, 'CAPIROSCO', '10035965607', '', 'capeta@paunoseucu.com', ''),
(667, 'Matheus Teles', '12,345,680', '110,359,', 'matheus.teles221@outlook.com', '');

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_endereco`
--

CREATE TABLE `tb_endereco` (
  `cep` varchar(8) NOT NULL,
  `cidade` varchar(127) NOT NULL,
  `bairro` varchar(127) NOT NULL,
  `logradouro` varchar(127) NOT NULL,
  `num` int(10) UNSIGNED NOT NULL,
  `complemento` varchar(10) DEFAULT NULL,
  `cd_cliente` int(10) UNSIGNED NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_estoque_produto`
--

CREATE TABLE `tb_estoque_produto` (
  `cd_estoque` int(10) UNSIGNED NOT NULL,
  `cd_produto` int(10) UNSIGNED NOT NULL,
  `tipo` varchar(127) DEFAULT NULL,
  `qte_minima` int(10) UNSIGNED NOT NULL,
  `qte_atual` int(10) UNSIGNED NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_fones_cliente`
--

CREATE TABLE `tb_fones_cliente` (
  `fone` int(10) UNSIGNED NOT NULL,
  `cd_cliente` int(10) UNSIGNED NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_fones_funcionario`
--

CREATE TABLE `tb_fones_funcionario` (
  `fone` int(10) UNSIGNED NOT NULL,
  `cd_funcionario` int(10) UNSIGNED NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_funcionario`
--

CREATE TABLE `tb_funcionario` (
  `cd_funcionario` int(10) UNSIGNED NOT NULL,
  `nm_funcionario` varchar(127) DEFAULT NULL,
  `cpf_funcionario` varchar(11) DEFAULT NULL,
  `rg_funcionario` varchar(8) NOT NULL,
  `email_funcionario` varchar(127) DEFAULT NULL,
  `login_funcionario` varchar(255) NOT NULL,
  `senha_funcionario` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `tb_funcionario`
--

INSERT INTO `tb_funcionario` (`cd_funcionario`, `nm_funcionario`, `cpf_funcionario`, `rg_funcionario`, `email_funcionario`, `login_funcionario`, `senha_funcionario`) VALUES
(1, 'Cuzão', '66666666666', '', 'cuzao@gmail.com', 'Cuzao666', 'suamae'),
(2, 'Cuzão', '66666666666', '', 'cuzao@gmail.com', 'Cuzao666', 'suamae');

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_horario_func`
--

CREATE TABLE `tb_horario_func` (
  `cd_funcionario` int(10) UNSIGNED NOT NULL,
  `horarios` text
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_prestacao_servico`
--

CREATE TABLE `tb_prestacao_servico` (
  `cd_funcionario` int(10) UNSIGNED NOT NULL,
  `cd_cliente` int(10) UNSIGNED NOT NULL,
  `cd_servico` int(10) UNSIGNED NOT NULL,
  `status_prestacao` varchar(127) DEFAULT NULL,
  `data_prestacao` date NOT NULL,
  `vl_total` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_produto`
--

CREATE TABLE `tb_produto` (
  `cd_produto` int(10) UNSIGNED NOT NULL,
  `nm_produto` varchar(127) DEFAULT NULL,
  `vl_produto` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_produtos_venda`
--

CREATE TABLE `tb_produtos_venda` (
  `cd_venda` int(10) UNSIGNED NOT NULL,
  `cd_produto` int(10) UNSIGNED NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_servico`
--

CREATE TABLE `tb_servico` (
  `cd_servico` int(10) UNSIGNED NOT NULL,
  `nm_servico` varchar(127) DEFAULT NULL,
  `vl_servico` double DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_venda`
--

CREATE TABLE `tb_venda` (
  `cd_venda` int(10) UNSIGNED NOT NULL,
  `cd_cliente` int(10) UNSIGNED NOT NULL,
  `cd_funcionario` int(10) UNSIGNED NOT NULL,
  `vl_total` double DEFAULT NULL,
  `desconto` double DEFAULT NULL,
  `dt_venda` double DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--

CREATE TABLE `tb_usuario` (
  `cd_usuario` int(10) UNSIGNED NOT NULL,
  `cd_funcionario` int(10) UNSIGNED NOT NULL,
  `nome_usuario` varchar(40) DEFAULT NULL,
  `senha_usuario` varchar(40) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

ALTER TABLE `tb_usuario`
  ADD PRIMARY KEY (`cd_usuario`);
  
 ALTER TABLE `tb_usuario` 
 ADD FOREIGN KEY (`cd_usuario`) REFERENCES `tb_funcionario` (`cd_funcionario`);

-- Indexes for dumped tables
--

--
-- Indexes for table `tb_cliente`
--
ALTER TABLE `tb_cliente`
  ADD PRIMARY KEY (`cd_cliente`);

--
-- Indexes for table `tb_endereco`
--
ALTER TABLE `tb_endereco`
  ADD PRIMARY KEY (`cep`),
  ADD UNIQUE KEY `cep` (`cep`),
  ADD KEY `cd_cliente` (`cd_cliente`);

--
-- Indexes for table `tb_estoque_produto`
--
ALTER TABLE `tb_estoque_produto`
  ADD PRIMARY KEY (`cd_estoque`),
  ADD KEY `cd_produto` (`cd_produto`);

--
-- Indexes for table `tb_fones_cliente`
--
ALTER TABLE `tb_fones_cliente`
  ADD PRIMARY KEY (`cd_cliente`,`fone`);

--
-- Indexes for table `tb_fones_funcionario`
--
ALTER TABLE `tb_fones_funcionario`
  ADD PRIMARY KEY (`cd_funcionario`,`fone`);

--
-- Indexes for table `tb_funcionario`
--
ALTER TABLE `tb_funcionario`
  ADD PRIMARY KEY (`cd_funcionario`);

--
-- Indexes for table `tb_horario_func`
--
ALTER TABLE `tb_horario_func`
  ADD PRIMARY KEY (`cd_funcionario`);

--
-- Indexes for table `tb_prestacao_servico`
--
ALTER TABLE `tb_prestacao_servico`
  ADD PRIMARY KEY (`cd_funcionario`,`cd_cliente`,`cd_servico`,`data_prestacao`,`vl_total`),
  ADD KEY `cd_cliente` (`cd_cliente`),
  ADD KEY `cd_servico` (`cd_servico`);

--
-- Indexes for table `tb_produto`
--
ALTER TABLE `tb_produto`
  ADD PRIMARY KEY (`cd_produto`);

--
-- Indexes for table `tb_produtos_venda`
--
ALTER TABLE `tb_produtos_venda`
  ADD PRIMARY KEY (`cd_venda`,`cd_produto`),
  ADD KEY `cd_produto` (`cd_produto`);

--
-- Indexes for table `tb_servico`
--
ALTER TABLE `tb_servico`
  ADD PRIMARY KEY (`cd_servico`);

--
-- Indexes for table `tb_venda`
--
ALTER TABLE `tb_venda`
  ADD PRIMARY KEY (`cd_venda`),
  ADD KEY `cd_cliente` (`cd_cliente`),
  ADD KEY `cd_funcionario` (`cd_funcionario`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tb_cliente`
--
ALTER TABLE `tb_cliente`
  MODIFY `cd_cliente` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=668;
--
-- AUTO_INCREMENT for table `tb_estoque_produto`
--
ALTER TABLE `tb_estoque_produto`
  MODIFY `cd_estoque` int(10) UNSIGNED NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `tb_funcionario`
--
ALTER TABLE `tb_funcionario`
  MODIFY `cd_funcionario` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT for table `tb_produto`
--
ALTER TABLE `tb_produto`
  MODIFY `cd_produto` int(10) UNSIGNED NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `tb_servico`
--
ALTER TABLE `tb_servico`
  MODIFY `cd_servico` int(10) UNSIGNED NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `tb_venda`
--
ALTER TABLE `tb_venda`
  MODIFY `cd_venda` int(10) UNSIGNED NOT NULL AUTO_INCREMENT;
--
-- Constraints for dumped tables
--

--
-- Limitadores para a tabela `tb_endereco`
--
ALTER TABLE `tb_endereco`
  ADD CONSTRAINT `tb_endereco_ibfk_1` FOREIGN KEY (`cd_cliente`) REFERENCES `tb_cliente` (`cd_cliente`);

--
-- Limitadores para a tabela `tb_estoque_produto`
--
ALTER TABLE `tb_estoque_produto`
  ADD CONSTRAINT `tb_estoque_produto_ibfk_1` FOREIGN KEY (`cd_produto`) REFERENCES `tb_produto` (`cd_produto`);

--
-- Limitadores para a tabela `tb_fones_cliente`
--
ALTER TABLE `tb_fones_cliente`
  ADD CONSTRAINT `tb_fones_cliente_ibfk_1` FOREIGN KEY (`cd_cliente`) REFERENCES `tb_cliente` (`cd_cliente`);

--
-- Limitadores para a tabela `tb_fones_funcionario`
--
ALTER TABLE `tb_fones_funcionario`
  ADD CONSTRAINT `tb_fones_funcionario_ibfk_1` FOREIGN KEY (`cd_funcionario`) REFERENCES `tb_funcionario` (`cd_funcionario`);

--
-- Limitadores para a tabela `tb_horario_func`
--
ALTER TABLE `tb_horario_func`
  ADD CONSTRAINT `tb_horario_func_ibfk_1` FOREIGN KEY (`cd_funcionario`) REFERENCES `tb_funcionario` (`cd_funcionario`);

--
-- Limitadores para a tabela `tb_prestacao_servico`
--
ALTER TABLE `tb_prestacao_servico`
  ADD CONSTRAINT `tb_prestacao_servico_ibfk_1` FOREIGN KEY (`cd_funcionario`) REFERENCES `tb_funcionario` (`cd_funcionario`),
  ADD CONSTRAINT `tb_prestacao_servico_ibfk_2` FOREIGN KEY (`cd_cliente`) REFERENCES `tb_cliente` (`cd_cliente`),
  ADD CONSTRAINT `tb_prestacao_servico_ibfk_3` FOREIGN KEY (`cd_servico`) REFERENCES `tb_servico` (`cd_servico`);

--
-- Limitadores para a tabela `tb_produtos_venda`
--
ALTER TABLE `tb_produtos_venda`
  ADD CONSTRAINT `tb_produtos_venda_ibfk_1` FOREIGN KEY (`cd_venda`) REFERENCES `tb_venda` (`cd_venda`),
  ADD CONSTRAINT `tb_produtos_venda_ibfk_2` FOREIGN KEY (`cd_produto`) REFERENCES `tb_produto` (`cd_produto`);

--
-- Limitadores para a tabela `tb_venda`
--
ALTER TABLE `tb_venda`
  ADD CONSTRAINT `tb_venda_ibfk_1` FOREIGN KEY (`cd_cliente`) REFERENCES `tb_cliente` (`cd_cliente`),
  ADD CONSTRAINT `tb_venda_ibfk_2` FOREIGN KEY (`cd_funcionario`) REFERENCES `tb_funcionario` (`cd_funcionario`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
