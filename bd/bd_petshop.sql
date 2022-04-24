SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `bd_petshop`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_animal`
--

CREATE TABLE `tb_animal` (
  `id` int(11) NOT NULL,
  `nome` varchar(45) NOT NULL,
  `tipo` smallint(1) NOT NULL,
  `id_petshop` int(11) NOT NULL,
  `id_cliente` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `tb_animal`
--

INSERT INTO `tb_animal` (`id`, `nome`, `tipo`, `id_petshop`, `id_cliente`) VALUES
(1, 'Marta', 1, 1, 1),
(2, 'Vilma', 1, 1, 3),
(3, 'Animal 1', 1, 1, 2),
(4, 'Valesca', 2, 1, 3),
(5, 'Maria', 2, 1, 1),
(6, 'Animal 2', 1, 1, 2),
(7, 'Animal 4', 2, 1, 2),
(8, 'Animal 5', 1, 1, 2),
(9, 'Animal 6', 1, 1, 2),
(10, 'Animal 7', 1, 1, 2),
(11, 'Vlader', 1, 1, 3),
(12, 'Animal 8', 2, 1, 2),
(13, 'Jobis', 1, 1, 4),
(14, 'Animal 2', 2, 1, 1),
(15, 'Teste', 1, 1, 3),
(16, 'Teste2', 2, 1, 1),
(17, 'asdsadsadasdas', 2, 1, 4);

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_atendimento`
--

CREATE TABLE `tb_atendimento` (
  `id_atendimento` int(11) NOT NULL,
  `data_atendimento` date NOT NULL,
  `valor` decimal(10,2) NOT NULL,
  `descricao` varchar(500) NOT NULL,
  `id_petshop` int(11) NOT NULL,
  `id_funcionario` int(11) NOT NULL,
  `animal_id` int(11) NOT NULL,
  `id_cliente` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `tb_atendimento`
--

INSERT INTO `tb_atendimento` (`id_atendimento`, `data_atendimento`, `valor`, `descricao`, `id_petshop`, `id_funcionario`, `animal_id`, `id_cliente`) VALUES
(1, '2022-04-05', '85.00', 'Teste', 1, 2, 5, 1),
(2, '2022-04-07', '120.00', 'teste', 1, 2, 16, 1),
(4, '2022-04-06', '12.00', 'Teste', 1, 1, 11, 3);

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_cidade`
--

CREATE TABLE `tb_cidade` (
  `id_cidade` int(11) NOT NULL,
  `nome_cidade` varchar(45) NOT NULL,
  `estado_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `tb_cidade`
--

INSERT INTO `tb_cidade` (`id_cidade`, `nome_cidade`, `estado_id`) VALUES
(1, 'Londrina', 1),
(2, 'Cambé', 1),
(3, 'Campinas', 2),
(4, 'Santos', 2);

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_cliente`
--

CREATE TABLE `tb_cliente` (
  `id_cliente` int(11) NOT NULL,
  `nome` varchar(45) NOT NULL,
  `telefone` varchar(11) NOT NULL,
  `id_petshop` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `tb_cliente`
--

INSERT INTO `tb_cliente` (`id_cliente`, `nome`, `telefone`, `id_petshop`) VALUES
(1, 'Ricieri', '434344', 1),
(2, 'Marli', '123', 1),
(3, 'Janael', '1234', 1),
(4, 'Vinicius Ariza', '43984487030', 1);

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_endereco`
--

CREATE TABLE `tb_endereco` (
  `ID` int(11) NOT NULL,
  `rua` varchar(45) NOT NULL,
  `bairro` varchar(45) NOT NULL,
  `complemento` varchar(100) NOT NULL,
  `cep` varchar(12) DEFAULT NULL,
  `cidade_id` int(11) NOT NULL,
  `id_funcionario` int(11) DEFAULT NULL,
  `id_cliente` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `tb_endereco`
--

INSERT INTO `tb_endereco` (`ID`, `rua`, `bairro`, `complemento`, `cep`, `cidade_id`, `id_funcionario`, `id_cliente`) VALUES
(1, 'rUA c#SDa', 'Bairro Java', 'Nda', '45455', 1, NULL, 1),
(2, 'Teste', 'Teste', 'qsadsad', '123', 1, NULL, 2),
(3, 'Teste', 'Teste', 'Teste', '1234', 4, NULL, 3),
(4, 'Joquim Pinheiro111', 'Ouro Verde11', '111', '86200000111', 3, NULL, 4),
(5, 'Rua Londrina', 'Teste', 'Teste', NULL, 1, 1, NULL),
(6, '123', '123aa', '123', NULL, 3, 2, NULL),
(7, '123', '123123', '123', NULL, 1, 3, NULL);

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_estado`
--

CREATE TABLE `tb_estado` (
  `id_estado` int(11) NOT NULL,
  `nome_estado` varchar(45) NOT NULL,
  `sigla_estado` varchar(2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `tb_estado`
--

INSERT INTO `tb_estado` (`id_estado`, `nome_estado`, `sigla_estado`) VALUES
(1, 'Paraná', 'PR'),
(2, 'São Paulo', 'SP');

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_funcionario`
--

CREATE TABLE `tb_funcionario` (
  `id_funcionario` int(11) NOT NULL,
  `nome` varchar(45) NOT NULL,
  `telefone` varchar(45) NOT NULL,
  `cpf` varchar(12) NOT NULL,
  `id_petshop` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `tb_funcionario`
--

INSERT INTO `tb_funcionario` (`id_funcionario`, `nome`, `telefone`, `cpf`, `id_petshop`) VALUES
(1, 'Baroni', '123456', '105151', 1),
(2, 'Mauricio', '123', '123', 1),
(3, 'Teste', '123', '123', 1);

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_petshop`
--

CREATE TABLE `tb_petshop` (
  `id_petshop` int(11) NOT NULL,
  `nome` varchar(45) NOT NULL,
  `login` varchar(20) NOT NULL,
  `senha` varchar(100) NOT NULL,
  `status` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `tb_petshop`
--

INSERT INTO `tb_petshop` (`id_petshop`, `nome`, `login`, `senha`, `status`) VALUES
(1, 'Admin', '123@123', '123', 1);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tb_animal`
--
ALTER TABLE `tb_animal`
  ADD PRIMARY KEY (`id`),
  ADD KEY `fk_tb_animal_tb_petshop1_idx` (`id_petshop`),
  ADD KEY `fk_tb_animal_tb_cliente1_idx` (`id_cliente`);

--
-- Indexes for table `tb_atendimento`
--
ALTER TABLE `tb_atendimento`
  ADD PRIMARY KEY (`id_atendimento`),
  ADD KEY `fk_tb_atendimento_tb_petshop1_idx` (`id_petshop`),
  ADD KEY `fk_tb_atendimento_tb_funcionario1_idx` (`id_funcionario`),
  ADD KEY `fk_tb_atendimento_tb_animal1_idx` (`animal_id`),
  ADD KEY `fk_tb_atendimento_tb_cliente1_idx` (`id_cliente`);

--
-- Indexes for table `tb_cidade`
--
ALTER TABLE `tb_cidade`
  ADD PRIMARY KEY (`id_cidade`),
  ADD KEY `fk_tb_cidade_tb_estado1_idx` (`estado_id`);

--
-- Indexes for table `tb_cliente`
--
ALTER TABLE `tb_cliente`
  ADD PRIMARY KEY (`id_cliente`),
  ADD KEY `fk_tb_cliente_tb_petshop1_idx` (`id_petshop`);

--
-- Indexes for table `tb_endereco`
--
ALTER TABLE `tb_endereco`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `fk_tb_endereco_tb_funcionario1_idx` (`id_funcionario`),
  ADD KEY `fk_tb_endereco_tb_cidade1_idx` (`cidade_id`),
  ADD KEY `fk_tb_endereco_tb_cliente1_idx` (`id_cliente`);

--
-- Indexes for table `tb_estado`
--
ALTER TABLE `tb_estado`
  ADD PRIMARY KEY (`id_estado`);

--
-- Indexes for table `tb_funcionario`
--
ALTER TABLE `tb_funcionario`
  ADD PRIMARY KEY (`id_funcionario`),
  ADD KEY `fk_tb_funcionario_tb_petshop_idx` (`id_petshop`);

--
-- Indexes for table `tb_petshop`
--
ALTER TABLE `tb_petshop`
  ADD PRIMARY KEY (`id_petshop`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tb_animal`
--
ALTER TABLE `tb_animal`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=18;

--
-- AUTO_INCREMENT for table `tb_atendimento`
--
ALTER TABLE `tb_atendimento`
  MODIFY `id_atendimento` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `tb_cidade`
--
ALTER TABLE `tb_cidade`
  MODIFY `id_cidade` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `tb_cliente`
--
ALTER TABLE `tb_cliente`
  MODIFY `id_cliente` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `tb_endereco`
--
ALTER TABLE `tb_endereco`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT for table `tb_estado`
--
ALTER TABLE `tb_estado`
  MODIFY `id_estado` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `tb_funcionario`
--
ALTER TABLE `tb_funcionario`
  MODIFY `id_funcionario` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- Constraints for dumped tables
--

--
-- Limitadores para a tabela `tb_animal`
--
ALTER TABLE `tb_animal`
  ADD CONSTRAINT `fk_tb_animal_tb_cliente1` FOREIGN KEY (`id_cliente`) REFERENCES `tb_cliente` (`id_cliente`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_tb_animal_tb_petshop1` FOREIGN KEY (`id_petshop`) REFERENCES `tb_petshop` (`id_petshop`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Limitadores para a tabela `tb_atendimento`
--
ALTER TABLE `tb_atendimento`
  ADD CONSTRAINT `fk_tb_atendimento_tb_animal1` FOREIGN KEY (`animal_id`) REFERENCES `tb_animal` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_tb_atendimento_tb_cliente1` FOREIGN KEY (`id_cliente`) REFERENCES `tb_cliente` (`id_cliente`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_tb_atendimento_tb_funcionario1` FOREIGN KEY (`id_funcionario`) REFERENCES `tb_funcionario` (`id_funcionario`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_tb_atendimento_tb_petshop1` FOREIGN KEY (`id_petshop`) REFERENCES `tb_petshop` (`id_petshop`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Limitadores para a tabela `tb_cidade`
--
ALTER TABLE `tb_cidade`
  ADD CONSTRAINT `fk_tb_cidade_tb_estado1` FOREIGN KEY (`estado_id`) REFERENCES `tb_estado` (`id_estado`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Limitadores para a tabela `tb_cliente`
--
ALTER TABLE `tb_cliente`
  ADD CONSTRAINT `fk_tb_cliente_tb_petshop1` FOREIGN KEY (`id_petshop`) REFERENCES `tb_petshop` (`id_petshop`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Limitadores para a tabela `tb_endereco`
--
ALTER TABLE `tb_endereco`
  ADD CONSTRAINT `fk_tb_endereco_tb_cidade1` FOREIGN KEY (`cidade_id`) REFERENCES `tb_cidade` (`id_cidade`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_tb_endereco_tb_cliente1` FOREIGN KEY (`id_cliente`) REFERENCES `tb_cliente` (`id_cliente`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_tb_endereco_tb_funcionario1` FOREIGN KEY (`id_funcionario`) REFERENCES `tb_funcionario` (`id_funcionario`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Limitadores para a tabela `tb_funcionario`
--
ALTER TABLE `tb_funcionario`
  ADD CONSTRAINT `fk_tb_funcionario_tb_petshop` FOREIGN KEY (`id_petshop`) REFERENCES `tb_petshop` (`id_petshop`) ON DELETE NO ACTION ON UPDATE NO ACTION;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
