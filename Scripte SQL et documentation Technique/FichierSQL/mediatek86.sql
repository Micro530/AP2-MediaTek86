-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le : mer. 02 juin 2021 à 13:00
-- Version du serveur :  5.7.31
-- Version de PHP : 7.3.21

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `mediatek86`
--

-- --------------------------------------------------------

--
-- Structure de la table `absence`
--

DROP TABLE IF EXISTS `absence`;
CREATE TABLE IF NOT EXISTS `absence` (
  `IDPERSONNEL` int(2) NOT NULL,
  `DATEDEBUT` datetime NOT NULL,
  `IDMOTIF` int(2) NOT NULL,
  `DATEFIN` datetime DEFAULT NULL,
  PRIMARY KEY (`IDPERSONNEL`,`DATEDEBUT`),
  KEY `FK_ABSENCE_MOTIF` (`IDMOTIF`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `absence`
--

INSERT INTO `absence` (`IDPERSONNEL`, `DATEDEBUT`, `IDMOTIF`, `DATEFIN`) VALUES
(2, '2020-05-15 05:54:33', 3, '2020-06-25 20:48:10'),
(1, '2020-05-07 10:49:35', 3, '2020-06-08 11:22:56'),
(3, '2020-05-07 11:46:50', 3, '2020-06-12 23:08:04'),
(4, '2020-05-08 11:53:14', 1, '2020-06-14 18:43:16'),
(9, '2020-05-03 01:53:39', 2, '2020-06-25 21:55:56'),
(1, '2020-05-04 00:29:04', 2, '2020-06-27 09:50:07'),
(2, '2020-05-11 01:28:18', 3, '2020-06-08 10:22:45'),
(10, '2020-05-11 20:21:15', 4, '2020-06-25 11:55:19'),
(1, '2020-05-15 10:52:48', 3, '2020-06-21 23:53:10'),
(8, '2020-05-02 16:21:29', 4, '2020-06-01 18:51:49'),
(1, '2020-05-09 07:51:32', 3, '2020-06-06 16:11:51'),
(5, '2020-05-22 19:58:31', 1, '2020-06-04 17:51:10'),
(7, '2020-05-06 08:12:43', 2, '2020-06-21 22:16:02'),
(9, '2020-05-18 11:38:30', 1, '2020-06-28 11:45:34'),
(8, '2020-05-03 06:02:01', 4, '2020-06-14 09:04:00'),
(4, '2020-05-18 10:31:44', 4, '2020-06-19 15:29:33'),
(7, '2020-05-31 17:13:56', 4, '2020-06-22 21:58:40'),
(3, '2020-05-09 11:06:46', 2, '2020-06-05 23:57:12'),
(9, '2020-05-17 00:27:34', 2, '2020-06-19 16:18:36'),
(5, '2020-05-01 17:25:45', 1, '2020-06-07 19:35:04'),
(1, '2020-05-11 00:16:47', 2, '2020-06-20 14:22:29'),
(7, '2020-05-22 08:16:34', 3, '2020-06-10 03:42:13'),
(9, '2020-05-06 09:19:46', 3, '2020-06-23 16:27:49'),
(9, '2020-05-28 10:16:44', 2, '2020-06-22 12:35:30'),
(3, '2020-05-02 19:08:44', 1, '2020-06-24 17:37:11'),
(9, '2020-05-18 07:32:18', 2, '2020-06-20 22:04:24'),
(6, '2020-05-22 02:31:39', 1, '2020-06-21 12:25:22'),
(1, '2020-05-23 21:20:27', 3, '2020-06-07 04:35:40'),
(5, '2020-05-28 09:10:04', 1, '2020-06-26 08:31:56'),
(6, '2020-05-18 20:03:26', 2, '2020-06-17 05:14:13'),
(6, '2020-05-31 13:39:58', 2, '2020-06-12 06:23:37'),
(8, '2020-05-08 21:06:47', 4, '2020-06-06 07:47:59'),
(9, '2020-05-06 15:03:40', 4, '2020-06-25 20:53:08'),
(3, '2020-05-10 03:22:25', 2, '2020-06-02 17:59:34'),
(8, '2020-05-17 22:22:56', 2, '2020-06-21 19:22:25'),
(5, '2020-05-02 21:55:32', 4, '2020-06-28 13:54:40'),
(6, '2020-05-27 16:26:52', 2, '2020-06-24 02:53:41'),
(9, '2020-05-24 06:51:03', 3, '2020-06-22 20:05:56'),
(8, '2020-05-29 20:17:18', 2, '2020-06-21 23:52:38'),
(1, '2020-05-27 15:47:43', 1, '2020-06-01 09:41:52'),
(7, '2020-05-22 00:48:24', 4, '2020-06-21 03:50:51'),
(6, '2020-05-08 18:00:26', 3, '2020-06-22 19:10:10'),
(6, '2020-05-07 04:23:20', 4, '2020-06-16 16:25:03'),
(10, '2020-05-15 03:16:28', 2, '2020-06-13 00:35:07'),
(7, '2020-05-06 01:36:52', 1, '2020-06-11 13:20:01'),
(2, '2020-05-25 02:03:23', 1, '2020-06-18 22:03:27'),
(6, '2020-05-08 01:28:27', 1, '2020-06-12 18:31:07'),
(5, '2020-05-05 11:59:05', 4, '2020-06-04 22:17:00'),
(9, '2020-05-24 03:06:19', 3, '2020-06-07 12:19:31'),
(10, '2021-06-02 11:11:17', 4, '2021-06-03 11:11:17'),
(10, '2021-06-02 11:11:04', 4, '2021-06-03 11:11:03'),
(10, '2021-06-02 10:28:33', 3, '2021-06-04 10:28:33'),
(11, '2021-06-02 10:51:39', 2, '2021-06-03 10:51:38'),
(10, '2021-06-02 11:10:12', 3, '2021-06-02 11:10:12'),
(23, '2021-06-02 13:44:11', 4, '2021-06-02 13:44:11'),
(1, '2021-06-01 10:18:04', 4, '2021-06-02 10:18:05'),
(10, '2021-06-02 11:11:42', 3, '2021-06-04 11:11:41'),
(11, '2021-06-02 12:02:48', 4, '2021-06-03 12:02:47'),
(10, '2021-06-02 12:13:03', 1, '2021-06-02 12:13:03'),
(11, '2021-06-01 12:06:18', 3, '2021-06-03 12:06:18'),
(10, '2021-06-02 12:13:29', 1, '2021-06-02 12:13:29'),
(10, '2021-06-02 12:42:16', 4, '2021-06-02 12:42:16'),
(10, '2021-06-02 12:54:03', 4, '2021-06-02 12:54:03'),
(4, '2021-06-16 14:08:24', 4, '2021-06-19 14:08:24'),
(7, '2021-06-02 13:51:13', 4, '2021-06-02 13:51:13'),
(27, '2021-06-14 14:59:27', 1, '2021-07-31 14:59:27');

-- --------------------------------------------------------

--
-- Structure de la table `motif`
--

DROP TABLE IF EXISTS `motif`;
CREATE TABLE IF NOT EXISTS `motif` (
  `IDMOTIF` int(2) NOT NULL AUTO_INCREMENT,
  `LIBELLE` varchar(128) DEFAULT NULL,
  PRIMARY KEY (`IDMOTIF`)
) ENGINE=MyISAM AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `motif`
--

INSERT INTO `motif` (`IDMOTIF`, `LIBELLE`) VALUES
(1, 'vacances'),
(2, 'maladie'),
(3, 'motif familial'),
(4, 'congé parental');

-- --------------------------------------------------------

--
-- Structure de la table `personnel`
--

DROP TABLE IF EXISTS `personnel`;
CREATE TABLE IF NOT EXISTS `personnel` (
  `IDPERSONNEL` int(2) NOT NULL AUTO_INCREMENT,
  `IDSERVICE` int(2) NOT NULL,
  `NOM` varchar(50) DEFAULT NULL,
  `PRENOM` varchar(50) DEFAULT NULL,
  `TEL` varchar(15) DEFAULT NULL,
  `MAIL` varchar(128) DEFAULT NULL,
  PRIMARY KEY (`IDPERSONNEL`),
  KEY `FK_PERSONNEL_SERVICE` (`IDSERVICE`)
) ENGINE=MyISAM AUTO_INCREMENT=28 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `personnel`
--

INSERT INTO `personnel` (`IDPERSONNEL`, `IDSERVICE`, `NOM`, `PRENOM`, `TEL`, `MAIL`) VALUES
(1, 2, 'Tobias', 'Wall', '04 02 84 08 67', 'rutrum@adlitoratorq'),
(2, 3, 'Brock', 'Pope', '01 89 83 22 70', 'vitae.nibh@anteblandit.edu'),
(3, 1, 'Slade', 'George', '02 69 07 01 57', 'gravida.mauris.ut@Suspendisse.co.uk'),
(4, 1, 'Jermaine', 'Cervantes', '07 92 90 62 95', 'metus.Aliquam.erat@quam.com'),
(5, 1, 'Russell', 'Acevedo', '03 63 77 91 77', 'id.mollis@tempor.edu'),
(6, 3, 'Armand', 'Campbell', '04 21 34 52 44', 'convallis.dolor.Quisque@magnaNam.net'),
(7, 1, 'Amery', 'Hardy', '06 52 92 44 17', 'tincidunt.congue@mollis.org'),
(8, 3, 'Gabriel', 'Bush', '06 18 55 88 05', 'mauris.ut@lobortismaurisSuspendisse.com'),
(9, 1, 'Tyler', 'Walter', '02 79 62 16 29', 'Cum.sociis@sagittisplacerat.com'),
(10, 3, 'Allistair', 'Goodwin', '09 94 41 79 08', 'Donec@magnaDuisdignissim.ca'),
(27, 1, 'Stachowiak', 'Quentin', '0606060606', 'quentin.stac@live.fr');

-- --------------------------------------------------------

--
-- Structure de la table `responsable`
--

DROP TABLE IF EXISTS `responsable`;
CREATE TABLE IF NOT EXISTS `responsable` (
  `login` varchar(64) NOT NULL,
  `pwd` varchar(64) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1 COMMENT='Contient l''identifiant et le mot de passe du responsable';

--
-- Déchargement des données de la table `responsable`
--

INSERT INTO `responsable` (`login`, `pwd`) VALUES
('responsable', 'a1159e9df3670d549d04524532629f5477ceb7deec9b45e47e8c009506ecb2c8');

-- --------------------------------------------------------

--
-- Structure de la table `service`
--

DROP TABLE IF EXISTS `service`;
CREATE TABLE IF NOT EXISTS `service` (
  `IDSERVICE` int(2) NOT NULL AUTO_INCREMENT,
  `NOM` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`IDSERVICE`)
) ENGINE=MyISAM AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `service`
--

INSERT INTO `service` (`IDSERVICE`, `NOM`) VALUES
(1, 'administratif'),
(2, 'médiation'),
(3, 'culturelle'),
(4, 'prêt');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
