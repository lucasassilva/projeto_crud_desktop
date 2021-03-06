-- --------------------------------------------------------
-- Servidor:                     127.0.0.1
-- Versão do servidor:           10.1.30-MariaDB - mariadb.org binary distribution
-- OS do Servidor:               Win32
-- HeidiSQL Versão:              9.5.0.5261
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


-- Copiando estrutura do banco de dados para projeto_crud_java
CREATE DATABASE IF NOT EXISTS `projeto_crud_java` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `projeto_crud_java`;

-- Copiando estrutura para tabela projeto_crud_java.cad_aluno
CREATE TABLE IF NOT EXISTS `cad_aluno` (
  `id_alunos` int(11) NOT NULL AUTO_INCREMENT,
  `Nome` varchar(50) NOT NULL,
  `Endereco` varchar(50) DEFAULT NULL,
  `Cidade` varchar(50) DEFAULT NULL,
  `Bairro` varchar(50) DEFAULT NULL,
  `Estado` varchar(50) DEFAULT NULL,
  `Cep` varchar(50) DEFAULT NULL,
  `Fone` varchar(14) DEFAULT NULL,
  `Cel` varchar(14) DEFAULT NULL,
  `Estadocivil` varchar(20) DEFAULT NULL,
  `email` varchar(50) DEFAULT NULL,
  `obs` varchar(50) DEFAULT NULL,
  `Login` varchar(30) DEFAULT NULL,
  `Password` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`id_alunos`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=latin1;

-- Copiando dados para a tabela projeto_crud_java.cad_aluno: ~1 rows (aproximadamente)
/*!40000 ALTER TABLE `cad_aluno` DISABLE KEYS */;
INSERT INTO `cad_aluno` (`id_alunos`, `Nome`, `Endereco`, `Cidade`, `Bairro`, `Estado`, `Cep`, `Fone`, `Cel`, `Estadocivil`, `email`, `obs`, `Login`, `Password`) VALUES
	(7, 'Lucas Alves', 'Av:Eddy de Freitas Criciuma', 'Nova Odessa', 'Bela Vista', '             SP', '14360-000', '(49) 12481-414', '(11) 21212-414', '        Solteiro', 'lucasalves527@outlook.com', 'Cadastro', 'administrador', 'adm123');
/*!40000 ALTER TABLE `cad_aluno` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
