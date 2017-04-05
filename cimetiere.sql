-- phpMyAdmin SQL Dump
-- version 4.1.14
-- http://www.phpmyadmin.net
--
-- Client :  127.0.0.1
-- G√©n√©r√© le :  Ven 03 F√©vrier 2017 √† 13:07
-- Version du serveur :  5.6.17
-- Version de PHP :  5.5.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Base de donn√©es :  `cimetiere`
--

-- --------------------------------------------------------

--
-- Structure de la table `beneficiaires`
--

CREATE TABLE IF NOT EXISTS `beneficiaires` (
  `ben_id` int(11) NOT NULL AUTO_INCREMENT,
  `ben_nom` varchar(255) DEFAULT NULL,
  `ben_prenom` varchar(255) DEFAULT NULL,
  `ben_date_naiss` date DEFAULT NULL,
  `ben_lien_parente` varchar(255) DEFAULT NULL,
  `ben_adresse` varchar(255) DEFAULT NULL,
  `ben_ville` varchar(255) DEFAULT NULL,
  `ben_cp` varchar(20) NOT NULL,
  `ben_pays` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`ben_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=9 ;

--
-- Contenu de la table `beneficiaires`
--

INSERT INTO `beneficiaires` (`ben_id`, `ben_nom`, `ben_prenom`, `ben_date_naiss`, `ben_lien_parente`, `ben_adresse`, `ben_ville`, `ben_cp`, `ben_pays`) VALUES
(1, 'benefun', 'prenombenefun', '2016-04-11', 'Clone', NULL, NULL, '', NULL),
(2, 'Van Pettegem', 'Viviane', '1957-11-10', 'grand-m√®re', NULL, NULL, '', NULL),
(3, 'Gugenheimen', 'Wilfried', '1965-04-04', 'fils', NULL, NULL, '', NULL),
(4, 'Herremans', 'Luciano', '1977-02-17', 'Grand-p√®re', NULL, NULL, '', NULL),
(5, 'Johannes', 'Kim', '1997-12-19', 'P√®re', NULL, NULL, '', NULL),
(6, 'Saint', 'T√ºr', '1950-03-16', 'Oncle', NULL, NULL, '', NULL),
(7, 'Ilien', 'Maxime', '1965-10-26', 'cousin', NULL, NULL, '', NULL),
(8, 'Teur', 'Radia', '1985-03-16', 'Ni√®ce', NULL, NULL, '', NULL);

-- --------------------------------------------------------

--
-- Structure de la table `concessionnaires`
--

CREATE TABLE IF NOT EXISTS `concessionnaires` (
  `csnr_id` int(11) NOT NULL AUTO_INCREMENT,
  `csnr_nom` varchar(255) DEFAULT NULL,
  `csnr_prenom` varchar(255) DEFAULT NULL,
  `csnr_date_naiss` date DEFAULT NULL,
  `csnr_adresse` varchar(255) DEFAULT NULL,
  `cnsr_ville` varchar(255) DEFAULT NULL,
  `csnr_cp` int(11) DEFAULT NULL,
  `csnr_pays` varchar(255) DEFAULT NULL,
  `csnr_no_registre` bigint(11) DEFAULT NULL,
  `csnr_tel` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`csnr_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=3 ;

--
-- Contenu de la table `concessionnaires`
--

INSERT INTO `concessionnaires` (`csnr_id`, `csnr_nom`, `csnr_prenom`, `csnr_date_naiss`, `csnr_adresse`, `cnsr_ville`, `csnr_cp`, `csnr_pays`, `csnr_no_registre`, `csnr_tel`) VALUES
(1, 'Pompe funebre', 'Verhaeghe', '1987-07-06', 'rue a la hulpe ', NULL, 1310, 'Belgique', 55151815, '026530000'),
(2, 'concessionaire2', 'prenom du cons2', '2016-12-01', 'rue du cons2', NULL, 2000, 'Croatie', 8282888, '25251888');

-- --------------------------------------------------------

--
-- Structure de la table `concessions`
--

CREATE TABLE IF NOT EXISTS `concessions` (
  `con_id` int(11) NOT NULL AUTO_INCREMENT,
  `con_numero` int(11) DEFAULT NULL,
  `con_date_debut` date DEFAULT NULL,
  `con_date_fin` date DEFAULT NULL,
  `con_nbre_renovations` int(11) DEFAULT '0',
  `con_montant_paye` decimal(7,2) DEFAULT NULL,
  `con_commentaire` text,
  `con_histoire` text,
  `con_fk_empl` int(11) DEFAULT NULL,
  `con_fk_csnr` int(11) NOT NULL,
  PRIMARY KEY (`con_id`),
  KEY `loc_fk_con` (`con_fk_empl`),
  KEY `loc_fk_csnr` (`con_fk_csnr`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=8 ;

--
-- Contenu de la table `concessions`
--

INSERT INTO `concessions` (`con_id`, `con_numero`, `con_date_debut`, `con_date_fin`, `con_nbre_renovations`, `con_montant_paye`, `con_commentaire`, `con_histoire`, `con_fk_empl`, `con_fk_csnr`) VALUES
(1, 68, '2016-12-01', '2026-12-02', 0, '1000.00', 'pas de com', 'pas d histoire', NULL, 1),
(2, 69, '2016-04-04', '2026-04-04', 0, '2500.00', 'un commentaire', 'une histoire :o', NULL, 1),
(3, 70, '2016-01-04', '2026-01-04', 0, '3500.00', 'commentaire 3', 'histoire 3', NULL, 2),
(4, 71, '2016-11-02', '2026-11-02', 0, '7000.00', 'commentaire 4', 'histoire 4', NULL, 2),
(5, 72, '2016-11-02', '2026-11-02', 0, '7000.00', 'commentaire 5', 'histoire 5', NULL, 2),
(6, 73, '2016-11-02', '2026-11-02', 0, '7000.00', 'commentaire 6', 'histoire 6', NULL, 2),
(7, 74, '2016-11-02', '2026-11-02', 0, '7000.00', 'commentaire 7', 'histoire 7', NULL, 1);

-- --------------------------------------------------------

--
-- Structure de la table `defunts`
--

CREATE TABLE IF NOT EXISTS `defunts` (
  `def_id` int(11) NOT NULL AUTO_INCREMENT,
  `def_numero_lh` int(11) DEFAULT NULL,
  `def_numero_annee` int(11) DEFAULT NULL,
  `def_prenom` varchar(255) DEFAULT NULL,
  `def_nom` varchar(255) DEFAULT NULL,
  `def_adresse` varchar(255) DEFAULT NULL,
  `def_ville` varchar(255) DEFAULT NULL,
  `def_cp` int(11) DEFAULT NULL,
  `def_pays` varchar(255) DEFAULT NULL,
  `def_etat_civil` enum('celibataire','epoux','veuf','divorce','enfant') DEFAULT NULL,
  `def_etat_civil_de` varchar(255) DEFAULT NULL,
  `def_date_naiss` date DEFAULT NULL,
  `def_lieu_naiss` varchar(255) DEFAULT NULL,
  `def_date_deces` date DEFAULT NULL,
  `def_lieu_deces` varchar(255) DEFAULT NULL,
  `def_fk_sej_actif` int(11) DEFAULT NULL,
  PRIMARY KEY (`def_id`),
  KEY `def_sej_actif` (`def_fk_sej_actif`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=96 ;

--
-- Contenu de la table `defunts`
--

INSERT INTO `defunts` (`def_id`, `def_numero_lh`, `def_numero_annee`, `def_prenom`, `def_nom`, `def_adresse`, `def_ville`, `def_cp`, `def_pays`, `def_etat_civil`, `def_etat_civil_de`, `def_date_naiss`, `def_lieu_naiss`, `def_date_deces`, `def_lieu_deces`, `def_fk_sej_actif`) VALUES
(11, NULL, NULL, 'St√©phanie', 'Destrebecq', NULL, NULL, NULL, NULL, NULL, NULL, '1889-01-01', NULL, '1971-01-01', NULL, 1),
(12, 323, NULL, 'Jean', 'Cule', NULL, NULL, NULL, NULL, NULL, NULL, '1998-12-02', NULL, '2014-04-30', NULL, NULL),
(15, NULL, NULL, 'Alfred', 'Duhain', NULL, NULL, NULL, NULL, NULL, NULL, '1891-01-01', NULL, '1972-01-01', NULL, 6),
(16, NULL, NULL, 'Omer', 'Thirion', NULL, NULL, NULL, NULL, NULL, NULL, '1894-01-01', NULL, '1971-01-01', NULL, 7),
(17, NULL, NULL, 'Stanislaw', 'Kubiak', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '1971-01-01', NULL, 8),
(18, NULL, NULL, 'Maurice', 'Vanheusden', NULL, NULL, NULL, NULL, NULL, NULL, '1902-01-01', NULL, '1971-01-01', NULL, 9),
(19, 6236, NULL, 'Ad', 'Duchateau', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '1999-01-01', NULL, 10),
(24, NULL, NULL, 'Louis', 'Balleux', NULL, NULL, NULL, NULL, NULL, NULL, '1918-01-01', NULL, '1971-01-01', NULL, 15),
(25, NULL, NULL, 'Guy', 'Balleux', NULL, NULL, NULL, NULL, NULL, NULL, '1953-01-01', NULL, '1974-01-01', NULL, 16),
(26, NULL, NULL, NULL, 'Balleux (', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 17),
(27, NULL, NULL, 'Simone', 'Tilmant', NULL, NULL, NULL, NULL, NULL, NULL, '1910-01-01', NULL, '1974-01-01', NULL, 18),
(28, NULL, NULL, 'Jean', 'Adriaens', NULL, NULL, NULL, NULL, NULL, NULL, '1908-01-01', NULL, '1981-01-01', NULL, 19),
(29, NULL, NULL, 'Pierre-Michel', 'Adriaens', NULL, NULL, NULL, NULL, NULL, NULL, '1980-01-01', NULL, '1982-01-01', NULL, 20),
(30, NULL, NULL, 'Marie', 'Strens', NULL, NULL, NULL, NULL, NULL, NULL, '1884-01-01', NULL, '1974-01-01', NULL, 21),
(31, 6014, NULL, 'Germaine', 'Dubois', NULL, NULL, NULL, NULL, NULL, NULL, '1907-01-01', NULL, '1995-01-01', NULL, 22),
(32, 6182, NULL, 'Pierre', 'Bulteel', NULL, NULL, NULL, NULL, NULL, NULL, '1906-01-01', NULL, '1998-01-01', NULL, 23),
(33, NULL, NULL, 'Augusta', 'Delbrassine', NULL, NULL, NULL, NULL, NULL, NULL, '1898-01-01', NULL, '1979-01-01', NULL, NULL),
(34, NULL, NULL, 'Albert', 'Semal', NULL, NULL, NULL, NULL, NULL, NULL, '1893-01-01', NULL, '1982-01-01', NULL, 24),
(35, NULL, NULL, 'F-C', 'Delbrassine', NULL, NULL, NULL, NULL, NULL, NULL, '1903-01-01', NULL, '1903-01-01', NULL, 25),
(36, 6025, NULL, 'Cl', 'Verdoodt', NULL, NULL, NULL, NULL, NULL, NULL, '1903-01-01', NULL, '1995-01-01', NULL, 26),
(37, NULL, NULL, 'Pierre', 'De Winter', NULL, NULL, NULL, NULL, NULL, NULL, '1904-01-01', NULL, '1974-01-01', NULL, 27),
(38, 6226, NULL, 'Germaine', 'Devos', NULL, NULL, NULL, NULL, NULL, NULL, '1906-01-01', NULL, '1999-01-01', NULL, 28),
(39, NULL, NULL, 'Charles', 'Nenin', NULL, NULL, NULL, NULL, NULL, NULL, '1910-01-01', NULL, '1974-01-01', NULL, 29),
(40, NULL, NULL, NULL, 'Dalez-Berlage (familles)', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 30),
(41, NULL, NULL, 'Fran', 'Doneux', NULL, NULL, NULL, NULL, NULL, NULL, '1952-01-01', NULL, '1975-01-01', NULL, 31),
(42, NULL, NULL, 'Jules', 'Doneux', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '1989-01-01', NULL, 32),
(43, 5926, NULL, 'Germaine', 'Coisman', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '1994-01-01', NULL, 33),
(44, 7122, NULL, 'Germaine', 'Br', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '2013-01-01', NULL, 34),
(45, NULL, NULL, 'Denise', 'Haudestaine', NULL, NULL, NULL, NULL, NULL, NULL, '1933-01-01', NULL, '1975-01-01', NULL, 35),
(46, 6080, NULL, 'Isidore', 'Somville', NULL, NULL, NULL, NULL, NULL, NULL, '1913-01-01', NULL, '1996-01-01', NULL, 36),
(47, NULL, NULL, 'H', 'Delarbre', NULL, NULL, NULL, NULL, NULL, NULL, '1905-01-01', NULL, '1990-01-01', NULL, 37),
(48, NULL, NULL, NULL, 'Claus', NULL, NULL, NULL, NULL, NULL, NULL, '1906-01-01', NULL, '1986-01-01', NULL, 38),
(49, NULL, NULL, NULL, 'Dumortier', NULL, NULL, NULL, NULL, NULL, NULL, '1909-01-01', NULL, '1984-01-01', NULL, 39),
(50, 7051, NULL, NULL, 'Vandiest', NULL, NULL, NULL, NULL, NULL, NULL, '1930-01-01', NULL, '2012-01-01', NULL, 40),
(51, NULL, NULL, NULL, 'Claus', NULL, NULL, NULL, NULL, NULL, NULL, '1936-01-01', NULL, NULL, NULL, 41),
(52, NULL, NULL, 'Victor', 'Vanderkelen', NULL, NULL, NULL, NULL, NULL, NULL, '1916-01-01', NULL, '1975-01-01', NULL, 42),
(53, 6870, NULL, 'Madeleine', 'Delpierre', NULL, NULL, NULL, NULL, NULL, NULL, '1919-01-01', NULL, '2009-01-01', NULL, 43),
(54, NULL, NULL, NULL, 'Boulanger', NULL, NULL, NULL, NULL, NULL, NULL, '1901-01-01', NULL, '1976-01-01', NULL, 44),
(55, 6176, NULL, NULL, 'Vrancaert', NULL, NULL, NULL, NULL, NULL, NULL, '1902-01-01', NULL, '1998-01-01', NULL, 45),
(56, NULL, NULL, 'Marcel', 'Bulteau', NULL, NULL, NULL, NULL, NULL, NULL, '1902-01-01', NULL, '1976-01-01', NULL, 46),
(57, 6033, NULL, 'Martha', 'Kerteux', NULL, NULL, NULL, NULL, NULL, NULL, '1900-01-01', NULL, '1996-01-01', NULL, 47),
(58, NULL, NULL, 'Germaine', 'Legrand', NULL, NULL, NULL, NULL, NULL, NULL, '1880-01-01', NULL, '1977-01-01', NULL, 48),
(59, NULL, NULL, 'M-Jos', 'Dumortier', NULL, NULL, NULL, NULL, NULL, NULL, '1910-01-01', NULL, '1992-01-01', NULL, 49),
(60, 5982, NULL, 'Joseph', 'Legrand', NULL, NULL, NULL, NULL, NULL, NULL, '1903-01-01', NULL, '1995-01-01', NULL, 50),
(61, 7187, NULL, 'Roger', 'Legrand', NULL, NULL, NULL, NULL, NULL, NULL, '1930-01-01', NULL, '2014-01-01', NULL, 51),
(62, NULL, NULL, NULL, 'de Bellefroid', NULL, NULL, NULL, NULL, NULL, NULL, '1919-01-01', NULL, '1976-01-01', NULL, 52),
(64, 5716, NULL, 'Solange', 'De Falque', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 53),
(65, 7228, NULL, 'J.', 'Kerckhove', NULL, NULL, NULL, NULL, NULL, NULL, '1939-01-01', NULL, '2014-01-01', NULL, 54),
(66, NULL, NULL, 'Michele', 'Brynart', NULL, NULL, NULL, NULL, NULL, NULL, '1940-01-01', NULL, '1976-01-01', NULL, 55),
(67, NULL, NULL, 'Odette', 'Roch', NULL, NULL, NULL, NULL, NULL, NULL, '1933-01-01', NULL, '1962-01-01', NULL, 56),
(68, NULL, NULL, 'Michel', 'Bernard', NULL, NULL, NULL, NULL, NULL, NULL, '1954-01-01', NULL, '1976-01-01', NULL, 57),
(69, NULL, NULL, 'Victor', 'Bernard', NULL, NULL, NULL, NULL, NULL, NULL, '1908-01-01', NULL, NULL, NULL, 58),
(70, 6076, NULL, 'Juliette', 'Van Hamme', NULL, NULL, NULL, NULL, NULL, NULL, '1912-01-01', NULL, '1996-01-01', NULL, 59),
(71, NULL, NULL, 'Joseph', 'Ziegler', NULL, NULL, NULL, NULL, NULL, NULL, '1890-01-01', NULL, '1979-01-01', NULL, 60),
(72, NULL, NULL, 'Germaine', 'de Ziegleck', NULL, NULL, NULL, NULL, NULL, NULL, '1901-01-01', NULL, '1984-01-01', NULL, 61),
(73, NULL, NULL, 'Marcel', 'Lorent', NULL, NULL, NULL, NULL, NULL, NULL, '1908-01-01', NULL, '1988-01-01', NULL, 62),
(74, 5958, NULL, 'Maria', 'Vandercruyssen', NULL, NULL, NULL, NULL, NULL, NULL, '1910-01-01', NULL, '1994-01-01', NULL, 63),
(75, 6631, NULL, 'Roger', 'Lorent', NULL, NULL, NULL, NULL, NULL, NULL, '1935-01-01', NULL, '2005-01-01', NULL, 64),
(76, NULL, NULL, 'Edgar', 'Rigaux', NULL, NULL, NULL, NULL, NULL, NULL, '1903-01-01', NULL, '1977-01-01', NULL, 65),
(77, NULL, NULL, 'Denise', 'Bertrand', NULL, NULL, NULL, NULL, NULL, NULL, '1903-01-01', NULL, '1977-01-01', NULL, 66),
(78, NULL, NULL, 'Denise', 'Rigaux', NULL, NULL, NULL, NULL, NULL, NULL, '1912-01-01', NULL, '1993-01-01', NULL, 67),
(79, NULL, NULL, 'Romaine', 'Bombaert', NULL, NULL, NULL, NULL, NULL, NULL, '1907-01-01', NULL, '1977-01-01', NULL, 68),
(80, NULL, NULL, 'Robert', 'Schodduyn', NULL, NULL, NULL, NULL, NULL, NULL, '1904-01-01', NULL, '1992-01-01', NULL, 69),
(81, 6952, NULL, 'Jean', 'Schodduyn', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '2010-01-01', NULL, 70),
(82, NULL, NULL, 'Ida', 'Van Cranenbroeck', NULL, NULL, NULL, NULL, NULL, NULL, '1907-01-01', NULL, '1977-01-01', NULL, 71),
(83, NULL, NULL, 'Isidore', 'Destrebecq', NULL, NULL, NULL, NULL, NULL, NULL, '1893-01-01', NULL, '1980-01-01', NULL, 72),
(84, 6009, NULL, 'Madeleine', 'Desplenter', NULL, NULL, NULL, NULL, NULL, NULL, '1894-01-01', NULL, '1995-01-01', NULL, 73),
(85, NULL, NULL, 'Auguste', 'Parys', NULL, NULL, NULL, NULL, NULL, NULL, '1917-01-01', NULL, '1978-01-01', NULL, 74),
(86, NULL, NULL, 'Augusta', 'Manandise', NULL, NULL, NULL, NULL, NULL, NULL, '1918-01-01', NULL, '1993-01-01', NULL, 75),
(87, NULL, NULL, 'Guy', 'Parys', NULL, NULL, NULL, NULL, NULL, NULL, '1953-01-01', NULL, '1992-01-01', NULL, 76),
(88, NULL, NULL, 'I.', 'Piens', NULL, NULL, NULL, NULL, NULL, NULL, '1914-01-01', NULL, '1991-01-01', NULL, 77),
(89, NULL, NULL, 'G.', 'Ancart', NULL, NULL, NULL, NULL, NULL, NULL, '1918-01-01', NULL, '1991-01-01', NULL, 78),
(90, NULL, NULL, 'Lucienne', 'Lizin', NULL, NULL, NULL, NULL, NULL, NULL, '1914-01-01', NULL, '1978-01-01', NULL, 79),
(91, 6227, NULL, 'Louis', 'Colmont', NULL, NULL, NULL, NULL, NULL, NULL, '1914-01-01', NULL, '1999-01-01', NULL, 80),
(92, NULL, NULL, 'Marcel', 'Le Goff', NULL, NULL, NULL, NULL, NULL, NULL, '1911-01-01', NULL, '1978-01-01', NULL, 81),
(93, NULL, NULL, 'Ad', 'Drez', NULL, NULL, NULL, NULL, NULL, NULL, '1913-01-01', NULL, '1979-01-01', NULL, 82),
(94, 6138, NULL, 'Roger', 'Taymans', NULL, NULL, NULL, NULL, NULL, NULL, '1927-01-01', NULL, '1997-01-01', NULL, NULL),
(95, NULL, NULL, 'H', 'Frans', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL);

-- --------------------------------------------------------

--
-- Structure de la table `demandeurs`
--

CREATE TABLE IF NOT EXISTS `demandeurs` (
  `dmdr_id` int(10) NOT NULL AUTO_INCREMENT,
  `dmdr_nom` varchar(255) DEFAULT NULL,
  `dmdr_prenom` varchar(255) DEFAULT NULL,
  `dmdr_date_naiss` date DEFAULT NULL,
  `dmdr_tel` varchar(255) DEFAULT NULL,
  `dmdr_adresse` varchar(255) DEFAULT NULL,
  `dmdr_ville` varchar(255) DEFAULT NULL,
  `dmdr_cp` int(11) DEFAULT NULL,
  `dmdr_pays` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`dmdr_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=5 ;

--
-- Contenu de la table `demandeurs`
--

INSERT INTO `demandeurs` (`dmdr_id`, `dmdr_nom`, `dmdr_prenom`, `dmdr_date_naiss`, `dmdr_tel`, `dmdr_adresse`, `dmdr_ville`, `dmdr_cp`, `dmdr_pays`) VALUES
(1, 'Terre', 'Jean', NULL, '026532849', '3 Rue Minant', NULL, 1310, 'Belgique'),
(2, 'Yvmijsdiv', 'Patrick', NULL, NULL, '1234 Rue Tabaga', 'Nazareth', NULL, ''),
(3, 'Fourne', 'Jean', NULL, NULL, NULL, 'Hersbruck', NULL, 'Allemagne'),
(4, 'Mathy', 'Olivier', NULL, '026534340', '26 Rue de Rosi√®res', 'Genval', 1332, 'Belgique');

-- --------------------------------------------------------

--
-- Structure de la table `emplacements`
--

CREATE TABLE IF NOT EXISTS `emplacements` (
  `empl_id` int(11) NOT NULL AUTO_INCREMENT,
  `empl_reference` varchar(255) DEFAULT NULL,
  `empl_type` enum('caveau','caveau_urne','concession','concession_urne','fosse','vide') DEFAULT NULL,
  `empl_nb_places` int(2) DEFAULT NULL,
  `empl_commentaire` text,
  `empl_monum_classe` tinyint(1) DEFAULT '0',
  `empl_coords` varbinary(2000) DEFAULT NULL,
  PRIMARY KEY (`empl_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=210 ;

--
-- Contenu de la table `emplacements`
--

INSERT INTO `emplacements` (`empl_id`, `empl_reference`, `empl_type`, `empl_nb_places`, `empl_commentaire`, `empl_monum_classe`, `empl_coords`) VALUES
(12, 'A3001', 'concession', NULL, '', 0, 'Ã\0&f&fı‘\0ÚÃ\0&'),
(13, 'A3002', 'concession', NULL, '', 0, 'Ã\0¿Ã\0Ì`„`¥Ã\0¿'),
(14, 'A3003', 'concession', NULL, '', 0, '—\0±f≠^Ç‘\0Ö—\0±'),
(15, 'A3004', 'concession', NULL, '', 0, '—\0Äc}`Pœ\0N—\0Ä'),
(16, 'A3005', 'concession', NULL, '', 0, '‘\0P^I^—\0‘\0P'),
(17, 'A3006', 'concession', NULL, '', 0, 'œ\0[VŸœ\0◊œ\0'),
(18, 'A3007', 'concession', NULL, '', 0, 'œ\0“[‘[†‘\0òœ\0“'),
(19, 'A3008', 'concession', NULL, '', 0, '‘\0ùYñYx‘\0v‘\0ù'),
(20, 'A3009', 'concession', NULL, '', 0, '◊\0nYnY?◊\0:◊\0n'),
(21, 'A3010', 'concession', NULL, '', 0, 'Ÿ\07Y2T¸Ã\0¸Ÿ\07'),
(22, 'A3011', 'concession', NULL, '', 0, '◊\0˘V˘V —\0¬◊\0˘'),
(23, 'A3012', 'concession', NULL, '', 0, '—\0«^¬Yñ‘\0é—\0«'),
(24, 'A3013', 'concession', NULL, '', 0, 'œ\0ñTåTU \0Pœ\0ñ'),
(25, 'A3014', 'concession', NULL, '', 0, 'œ\0ZYUY&Ã\0œ\0Z'),
(26, 'A3015', 'concession', NULL, '', 0, ' \0!V!VÌœ\0Ë \0!'),
(27, 'A3016', 'concession', NULL, '', 0, 'QÌV∏œ\0∏œ\0ËQÌ'),
(28, 'A3017', 'caveau', NULL, '', 0, 'k\0©\0)\0§\0.\0/\0s\04\0k\0©\0'),
(29, 'A3018', 'caveau', NULL, '', 0, 'f\0Æ\0¶\0∂\0∞\0H\0}\0<\0f\0Æ\0'),
(32, 'A3019', 'caveau', NULL, '', 0, '∏\0≥\0\0ª\0Û\0C\0µ\0>\0∏\0≥\0'),
(33, 'A3020', 'caveau', NULL, '', 0, '˝\0∂\03¿\0:>\0ˇ\0>\0˝\0∂\0'),
(34, 'A3021', 'caveau', NULL, '', 0, '?¿\0}¬\0M\0GK\0?¿\0'),
(35, 'A3022', 'caveau', NULL, '', 0, 'á¬\0º¿\0ºM\0åH\0á¬\0'),
(36, 'A3023', 'caveau', NULL, '', 0, 'ƒ¬\0≈\0	P\0…P\0ƒ¬\0'),
(37, 'A3024', 'caveau', NULL, '', 0, 'F…\0¬\0R\0FU\0F…\0'),
(38, 'A3025', 'caveau', NULL, '', 0, 'é—\0V≈\0QZ\0ìU\0é—\0'),
(39, 'A3026', 'caveau', NULL, '', 0, 'ò”\0À÷\0À\\\0ìU\0ò”\0'),
(40, 'A3027', 'caveau', NULL, '', 0, 'ÿ\0›—\0‡Z\0a\0ÿ\0'),
(41, 'A3028', 'caveau', NULL, '', 0, '”\0U”\0Pa\0_\0”\0'),
(42, 'A3029', 'caveau', NULL, '', 0, 'òÿ\0b—\0bh\0íh\0òÿ\0'),
(43, 'A3030', 'caveau', NULL, '', 0, '‚›\0§÷\0§h\0Áh\0‚›\0'),
(44, 'A3031', 'caveau', NULL, '', 0, 'È›\0\Z‚\0!h\0Óh\0È›\0'),
(45, 'A3032', 'caveau', NULL, '', 0, 'i€\0.€\0.f\0np\0i€\0'),
(46, 'A3033', 'caveau', NULL, '', 0, '¶Â\0q‡\0sp\0≥m\0¶Â\0'),
(47, 'A3034', 'caveau', NULL, '', 0, 'ÓÍ\0¶Â\0∂u\0Îr\0ÓÍ\0'),
(48, 'A3035', 'caveau', NULL, '', 0, '3Â\0‚\0Ûm\00p\03Â\0'),
(49, 'A3036', 'caveau', NULL, '', 0, 'z‚\0=‡\0=z\0p|\0z‚\0'),
(52, 'A3037', 'caveau', NULL, '', 0, 'µÙ\0}Í\0}w\0µu\0µÙ\0'),
(53, 'A3038', 'caveau', NULL, '', 0, '˜Ò\0∏Í\0øw\0ˇw\0˜Ò\0'),
(54, 'A3039', 'caveau', NULL, '', 0, '?Ò\0Á\0Ñ\0:Å\0?Ò\0'),
(55, 'A3040', 'caveau', NULL, '', 0, '|ˆ\0IÒ\0IÑ\0|Å\0|ˆ\0'),
(56, 'A3041', 'caveau', NULL, '', 0, '¡˚\0Üˆ\0â\0¡Å\0¡˚\0'),
(57, 'A3042', 'caveau', NULL, '', 0, '˘\0∆Ù\0∆Ü\0Ñ\0˘\0'),
(58, 'A3043', 'caveau', NULL, '', 0, 'ˆ\0FÙ\0IÅ\0Å\0ˆ\0'),
(59, 'A3044', 'caveau', NULL, '', 0, '∫Ñ∫ßP¨P}∫Ñ'),
(60, 'A3045', 'caveau', NULL, '', 0, 'N≥X‡ø‡øªN≥'),
(61, 'A3046', 'caveau', NULL, '', 0, 'ºÍºPPÔºÍ'),
(62, 'A3047', 'caveau', NULL, '', 0, '¥(ºSUPU!¥('),
(63, 'A3048', 'caveau', NULL, '', 0, 'NSUºâºZNS'),
(65, 'A3050', 'caveau', NULL, '', 0, 'S [Ôƒ˜∆ S '),
(68, 'A3049', 'caveau', NULL, '', 0, 'SìXΩ¡ª¡ìSì'),
(69, 'A3050', 'caveau', NULL, '', 0, 'P¿XÙ∆Ú∆œP¿'),
(70, 'A3051', 'caveau', NULL, '', 0, ']0]˛ø¸¡(]0'),
(71, 'A3052', 'caveau', NULL, '', 0, 'eb]7ƒ5ƒbeb'),
(72, 'A3053', 'caveau', NULL, '', 0, ']ùbl∆qÀò]ù'),
(73, 'A3054', 'caveau', NULL, '', 0, 'o‘l•…•∆‘o‘'),
(74, 'A3055', 'caveau', NULL, '', 0, 'l‹l\r……Ÿl‹'),
(75, 'A3056', 'caveau', NULL, '', 0, 'qDq—Œ?qD'),
(76, 'A3057', 'caveau', NULL, '', 0, 'qxqLÀLÀ{qx'),
(77, 'A3058', 'caveau', NULL, '', 0, 'l∂lÇŒÇ÷±l∂'),
(78, 'A3059', 'caveau', NULL, '', 0, 'tÊtæ÷π÷„tÊ'),
(80, 'A3060', 'caveau', NULL, '', 0, 'y\ZyÌ÷÷!y\Z'),
(81, 'A3061', 'caveau', NULL, '', 0, 'y[y$÷—[y['),
(82, 'A3062', 'caveau', NULL, '', 0, 'wåwXÿX›äwå'),
(83, 'A3063', 'caveau', NULL, '', 0, 'y»yôÿè›√y»'),
(84, 'A3064', 'caveau', NULL, '', 0, '~¸~Õ‡À‡¸~¸'),
(85, 'A3065', 'caveau', NULL, '', 0, 'y3y‚‚8y3'),
(86, 'A3066', 'caveau', NULL, '', 0, 'ÜjÅ@‚;‚oÜj'),
(87, 'A3067', 'caveau', NULL, '', 0, 'Ü°ÜvËqË®Ü°'),
(88, 'A3068', 'caveau', NULL, '', 0, 'àﬂà•Ë≠Ëﬂàﬂ'),
(89, 'A3069', 'caveau', NULL, '', 0, 'éà·Â·Íé'),
(90, 'A3070', 'caveau', NULL, '', 0, 'êJãÍ\ZÌOêJ'),
(91, 'A3072', 'concession', NULL, '', 0, 'N@N$€"€EN@'),
(92, 'A3073', 'concession', NULL, '', 0, 'L\ZLÊ‘È‘L\Z'),
(93, 'A3074', 'concession', NULL, '', 0, 'BD∑«≤…ÎB'),
(94, 'A3075', 'concession', NULL, '', 0, 'D∑By∞{≤∑D∑'),
(95, 'A3076', 'concession', NULL, '', 0, 'BbB3∏8∏`Bb'),
(96, 'A3077', 'concession', NULL, '', 0, '7,7˙≠¸µ67,'),
(97, 'A3078', 'concession', NULL, '', 0, '?˙5πø√«Ú?˙'),
(98, 'A3079', 'concession', NULL, '', 0, ':π:èΩè¬Ø:π'),
(99, 'A3080', 'concession', NULL, '', 0, 'G}BNøLΩ}G}'),
(100, 'A3071', 'concession', NULL, '', 0, 'ìîêQËQÍÖìî'),
(101, 'A3081', 'concession', NULL, '', 0, 'BNB∞ΩGBN'),
(102, 'A3082', 'concession', NULL, '', 0, 'B<·ΩﬁΩB'),
(103, 'A3083', 'concession', NULL, '', 0, 'B‹<≠Ω≠ΩŸB‹'),
(104, 'A3084', 'concession', NULL, '', 0, ':£:xΩqΩû:£'),
(105, 'A3085', 'concession', NULL, '', 0, '?lBBƒ?ƒn?l'),
(106, 'A3086', 'concession', NULL, '', 0, '<=<……G<='),
(107, 'A3087', 'concession', NULL, '', 0, '<<“°Ÿ°<'),
(108, '?3088', 'concession', NULL, '', 0, ':‘:¢ô•£ :‘'),
(109, 'A3089', 'concession', NULL, '', 0, '2ñ2UñUññ2ñ'),
(110, 'A3090', 'concession', NULL, '', 0, '5X-û\ZûX5X'),
(111, 'A3091', 'concession', NULL, '', 0, '˘«ñÃñ˘'),
(112, 'A3092', 'concession', NULL, '', 0, '±f°kú±±'),
(115, 'A3095', 'concession', NULL, '', 0, '˝Í\0ÇÇÂ˝Í'),
(116, 'A3096', 'concession', NULL, '', 0, '!\0UÇNÖ!'),
(117, 'A3097', 'concession', NULL, '', 0, 'äXåë\0â\\äX'),
(118, 'A3098', 'concession', NULL, '', 0, 'á¬äìõœá¬'),
(119, 'A3099', 'concession', NULL, '', 0, 'ä˛åÃ\n—\n¸ä˛'),
(120, 'A3100', 'concession', NULL, '', 0, 'å-å˛\0¸\n+å-'),
(121, 'A3101', 'concession', NULL, '', 0, 'iÇ07_i'),
(122, 'A3102', 'concession', NULL, '', 0, 'å†äqsñå†'),
(123, 'A3103', 'concession', NULL, '', 0, 'è“ëù¢“è“'),
(124, 'A3104', 'concession', NULL, '', 0, 'åë‘‘˛å'),
(125, 'A3105', 'concession', NULL, '', 0, 'å?å\r:å?'),
(126, 'A3106', 'concession', NULL, '', 0, 'ôqñ??xôq'),
(127, 'A3107', 'concession', NULL, '', 0, '£Ø£}{™£Ø'),
(128, 'A3108', 'concession', NULL, '', 0, 'ú·úØ™Ÿú·'),
(129, 'A3109', 'concession', NULL, '', 0, 'ûûÊÊû'),
(130, 'A3110', 'concession', NULL, '', 0, 'úLúGúL'),
(131, 'A3111', 'concession', NULL, '', 0, '°}°GBÄ°}'),
(132, 'A3112', 'concession', NULL, '', 0, '°º°áä¥°º'),
(133, 'A3113', 'concession', NULL, '', 0, 'ûÎ£æ¡„ûÎ'),
(134, 'A3114', 'concession', NULL, '', 0, 'ñ$ñı˜)ñ$'),
(135, 'A3115', 'concession', NULL, '', 0, 'ô[ô.,eô['),
(136, 'A3116', 'concession', NULL, '', 0, 'îèî[]íîè'),
(137, 'A3117', 'concession', NULL, '', 0, 'ô¡úó!ôÕô¡'),
(138, 'A3118', 'concession', NULL, '', 0, '´≠‹.·.´'),
(139, 'A3119', 'concession', NULL, '', 0, '´3´=	8=´3'),
(140, 'A3120', 'concession', NULL, '', 0, '≤{≤L5G5t≤{'),
(141, 'A3121', 'caveau', NULL, '', 0, 'îíîeÛ^Ûèîí'),
(142, 'A3122', 'caveau', NULL, '', 0, 'öOó''˚"˚VöO'),
(143, 'A3123', 'caveau', 3, '', 0, '˚\Zö''óÛÊ˚\Z'),
(144, 'A3124', 'caveau', NULL, '', 0, 'ˆÈˆºö∑úÈˆÈ'),
(145, 'A3125', 'caveau', NULL, '', 0, 'ú≤út˚{˘≤ú≤'),
(146, 'A3126', 'caveau', NULL, '', 0, 'úyúI˚B˚qúy'),
(147, 'A3127', 'caveau', 3, '', 0, 'üDü;üD'),
(148, 'A3128', 'caveau', NULL, '', 0, '°ü⁄˚’ˆ°'),
(149, 'A3129', 'caveau', NULL, '', 0, '°’°£˘ôˆ“°’'),
(150, 'A3130', 'caveau', NULL, '', 0, 'úõújˆe˛ñúõ'),
(151, 'A3131', 'caveau', NULL, '', 0, 'úXú$ˆ$ÛXúX'),
(152, 'A3132', 'caveau', NULL, '', 0, '˚$˚ËúÌö!˚$'),
(153, 'A3133', 'caveau', NULL, '', 0, 'óËó±˘¥˛ÎóË'),
(154, 'A3134', 'caveau', NULL, '', 0, 'ó±úxÛsÛ∂ó±'),
(155, 'A3135', 'caveau', NULL, '', 0, 'ó{ö?ˆ?˘só{'),
(156, 'A3136', 'vide', NULL, '', 0, 'îDóˆˆ5îD'),
(157, 'A3137', 'vide', NULL, '', 0, 'ööœˆÕˆ˛ö'),
(158, 'A3138', 'vide', NULL, '', 0, 'öœöìÓéÒ»öœ'),
(159, 'A3139', 'vide', NULL, '', 0, 'óëó]˘_˘éóë'),
(160, 'A3140', 'vide', NULL, '', 0, 'ódó(Ó#ÓZód'),
(161, 'A3141', 'vide', NULL, '', 0, '˚ˆÍöÂó˚'),
(162, 'A3142', 'vide', NULL, '', 0, 'ó‡è¥ˆ±ˆ‡ó‡'),
(163, 'A3143', 'vide', NULL, '', 0, 'ˆ™ÛxózóØˆ™'),
(164, 'A3144', 'vide', NULL, '', 0, 'ö}î?ˆ?ˆpö}'),
(165, 'A3145', 'vide', NULL, '', 0, 'íFíÓ\nÛAíF'),
(166, 'A3146', 'vide', NULL, '', 0, 'Ò Óèè—Ò '),
(167, 'A3147', 'vide', NULL, '', 0, '◊¨◊ﬁ6€,≥◊¨'),
(168, 'A3148', 'vide', NULL, '', 0, ',Ë4–’Â,Ë'),
(169, 'A3149', 'vide', NULL, '', 0, '''!''N⁄I◊''!'),
(170, 'A3150', 'vide', NULL, '', 0, '1U6Ç–Ñ“S1U'),
(171, 'A3151', 'vide', NULL, '', 0, '4«⁄Ω◊Ñ4å4«'),
(172, 'A3152', 'vide', NULL, '', 0, '“Ì“¿1Ω1˛“Ì'),
(173, 'A3153', 'vide', NULL, '', 0, '◊+’˘/˜4(◊+'),
(174, 'A3154', 'vide', NULL, '', 0, '’b’-101b’b'),
(175, 'A3155', 'vide', NULL, '', 0, '“õ“i4i9õ“õ'),
(176, 'A3156', 'vide', NULL, '', 0, '““’õ4ù4“““'),
(177, 'A3157', 'vide', NULL, '', 0, '““◊6◊4“'),
(178, 'A3158', 'vide', NULL, '', 0, '’5–11:’5'),
(179, 'A3159', 'vide', NULL, '', 0, '’v’G<D9q’v'),
(180, 'A3160', 'vide', NULL, '', 0, '’®’{/Ä1™’®'),
(181, 'A3161', 'vide', NULL, '', 0, '–Ë–∂4ª4Ê–Ë'),
(182, 'A3162', 'vide', NULL, '', 0, '◊›Ê<Î9◊'),
(183, 'A3163', 'vide', NULL, '', 0, '“Q“$6$6Q“Q'),
(184, 'A3164', 'vide', NULL, '', 0, '◊è◊[1V1å◊è'),
(185, 'A3165', 'vide', NULL, '', 0, '4ñ4∆◊¡◊î4ñ'),
(186, 'A3166', 'vide', NULL, '', 0, '“˙“À4À4˜“˙'),
(187, 'A3167', 'caveau', NULL, '', 0, '’;’ˇ/11’;'),
(188, 'A3168', 'caveau', NULL, '', 0, '’l’=<=<l’l'),
(189, 'A3169', 'caveau', NULL, '', 0, 'ﬂ£⁄l<q<•ﬂ£'),
(190, 'A3170', 'caveau', NULL, '', 0, '›·›≠6®6ﬂ›·'),
(191, 'A3171', 'caveau', NULL, '', 0, '⁄⁄Î1Ê6⁄'),
(192, 'A3172', 'caveau', NULL, '', 0, '‚V‚''H''HQ‚V'),
(193, 'A3173', 'caveau', NULL, '', 0, 'ÏîÏ`9`4èÏî'),
(194, 'A3174', 'concession', NULL, '', 0, 'e0eˇ¬ˇ¬5e0'),
(195, 'A3175', 'concession', NULL, '', 0, 'bˇhπø¥∑Úbˇ'),
(196, 'A3176', 'concession', NULL, '', 0, 'bÇb¥∫Ø∫ÖbÇ'),
(197, 'A3177', 'concession', NULL, '', 0, 'µXµ}`}bPµX'),
(198, 'A3178', 'concession', NULL, '', 0, 'eL`ººGeL'),
(199, 'A3179', 'concession', NULL, '', 0, 'ee„ø·ø\re'),
(200, 'A3180', 'concession', NULL, '', 0, '∞ﬁ∑Øjßh„∞ﬁ'),
(201, 'A3181', 'vide', NULL, '', 0, 'j¢hÇ∑{∫•j¢'),
(202, 'A3182', 'vide', NULL, '', 0, 'øIøxbqbNøI'),
(203, 'A3183', 'vide', NULL, '', 0, 'mjD«F¬\rm'),
(204, 'A3184', 'vide', NULL, '', 0, 'r r¸øº—r '),
(205, 'A3185', 'vide', NULL, '', 0, 'ƒñƒ t«oéƒñ'),
(206, 'A3186', 'vide', NULL, '', 0, 'rUrå…ì«arU'),
(207, 'A3187', 'vide', NULL, '', 0, 'rUr#ƒ!øXrU'),
(208, 'A3188', 'vide', NULL, '', 0, 'ooÙ∑Úø!o'),
(209, 'A3189', 'vide', NULL, '', 0, 'yªwÌ¬Ë«Ωyª');

-- --------------------------------------------------------

--
-- Structure de la table `forms_inhumation`
--

CREATE TABLE IF NOT EXISTS `forms_inhumation` (
  `finh_id` int(10) NOT NULL AUTO_INCREMENT,
  `finh_num_def_lh` int(11) DEFAULT NULL,
  `finh_num_def_annee` int(11) DEFAULT NULL,
  `finh_def_nom` varchar(255) DEFAULT NULL,
  `finh_def_prenom` varchar(255) DEFAULT NULL,
  `finh_def_adresse` varchar(255) DEFAULT NULL,
  `finh_def_cp` int(11) DEFAULT NULL,
  `finh_def_ville` varchar(255) DEFAULT NULL,
  `finh_def_pays` varchar(255) DEFAULT NULL,
  `finh_def_etat_civil` enum('celibataire','epoux','veuf','divorce','enfant') DEFAULT NULL,
  `finh_def_etat_civil_de` varchar(255) DEFAULT NULL,
  `finh_def_date_naiss` date DEFAULT NULL,
  `finh_def_lieu_naiss` varchar(255) DEFAULT NULL,
  `finh_def_date_deces` date DEFAULT NULL,
  `finh_def_lieu_deces` varchar(255) DEFAULT NULL,
  `finh_dmdr_nom` varchar(255) DEFAULT NULL,
  `finh_dmdr_prenom` varchar(255) DEFAULT NULL,
  `finh_dmdr_tel` varchar(255) DEFAULT NULL,
  `finh_dmdr_adresse` varchar(255) DEFAULT NULL,
  `finh_dmdr_ville` varchar(255) DEFAULT NULL,
  `finh_dmdr_cp` int(11) DEFAULT NULL,
  `finh_dmdr_pays` varchar(255) DEFAULT NULL,
  `finh_conc_sollic` enum('existante','nouvelle','sans_concession') DEFAULT NULL,
  `finh_typeempl` enum('caveau','caveau_urne','concession','concession_urne','fosse') DEFAULT NULL,
  `finh_ref_empl` varchar(25) DEFAULT NULL,
  `finh_ref_autres_def` varchar(255) DEFAULT NULL,
  `finh_date_sign` date DEFAULT NULL,
  `finh_avis_fossoy` tinyint(1) DEFAULT NULL,
  `finh_commentaire` text,
  `finh_fk_dmdr` int(11) DEFAULT NULL,
  `finh_fk_def` int(11) DEFAULT NULL,
  PRIMARY KEY (`finh_id`),
  KEY `fdec_fk_dmdr` (`finh_fk_dmdr`),
  KEY `finh_fk_defunt` (`finh_fk_def`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=44 ;

--
-- Contenu de la table `forms_inhumation`
--

INSERT INTO `forms_inhumation` (`finh_id`, `finh_num_def_lh`, `finh_num_def_annee`, `finh_def_nom`, `finh_def_prenom`, `finh_def_adresse`, `finh_def_cp`, `finh_def_ville`, `finh_def_pays`, `finh_def_etat_civil`, `finh_def_etat_civil_de`, `finh_def_date_naiss`, `finh_def_lieu_naiss`, `finh_def_date_deces`, `finh_def_lieu_deces`, `finh_dmdr_nom`, `finh_dmdr_prenom`, `finh_dmdr_tel`, `finh_dmdr_adresse`, `finh_dmdr_ville`, `finh_dmdr_cp`, `finh_dmdr_pays`, `finh_conc_sollic`, `finh_typeempl`, `finh_ref_empl`, `finh_ref_autres_def`, `finh_date_sign`, `finh_avis_fossoy`, `finh_commentaire`, `finh_fk_dmdr`, `finh_fk_def`) VALUES
(12, 14, 23, 'roezuh', 'Ceizjfe', 'ici rue du eifjo', 2339, 'La Hulpe', 'Belgique', 'epoux', 'Marie Kuchtwala', '1972-08-13', 'lalelu', '2017-07-01', 'dans la for√™t', 'Terre', 'Jean', '56789', '82b parc √† conteneurs', 'Meulin', 88282, 'Belgique', 'nouvelle', NULL, 'au fond √† gauche', 'aucune', '2017-08-01', 1, 'c''est un beau formulaire', NULL, NULL),
(13, 14, 23, 'oaarj', 'Ceizjfe', 'ici rue du eifjo', 2339, 'La Hulpe', 'Belgique', 'epoux', 'Marie Kuchtwala', '1972-08-13', 'lalelu', '2017-07-01', 'dans la for√™t', 'Terre', 'Jean', '56789', '82b parc √† conteneurs', 'Meulin', 88282, 'Belgique', 'nouvelle', NULL, 'au fond √† gauche', 'aucune', '2017-08-01', 1, 'c''est un beau formulaire', NULL, NULL),
(14, NULL, NULL, 'MacAbb√©', 'Barnab√©', 'Chez lui', 1234, 'Trou-les-bains', 'Belgique', 'veuf', 'Jeanne-Francine Ujihugy', '1925-09-04', 'Ho√ªt-Si-Plout', '2017-01-28', 'Bourg-la-Reine', 'Terre', 'Jean', '234567', '8 rue des bancs', 'La Huple', 1234, 'Belgique', 'existante', NULL, NULL, NULL, '2017-01-30', NULL, NULL, NULL, NULL),
(42, NULL, NULL, '', '', '', 12, '', '', '', '', '2017-02-02', '', '2017-02-02', '', '', '', '', '', '', 12, '', 'nouvelle', '', NULL, NULL, '2017-02-02', NULL, NULL, NULL, NULL),
(43, NULL, NULL, '', '', '', 23, '', '', '', '', '2017-02-02', '', '2017-02-02', '', '', '', '', '', '', 232, '', 'nouvelle', '', NULL, NULL, '2017-02-02', NULL, NULL, NULL, NULL);

-- --------------------------------------------------------

--
-- Structure de la table `forms_nouvelle_con`
--

CREATE TABLE IF NOT EXISTS `forms_nouvelle_con` (
  `fnvcon_id` int(11) NOT NULL AUTO_INCREMENT,
  `fnvcon_pmand_nom` varchar(255) DEFAULT NULL,
  `fnvcon_pmand_prenom` varchar(255) DEFAULT NULL,
  `fnvcon_pmand_date_naiss` date DEFAULT NULL,
  `fnvcon_pmand_tel` varchar(255) DEFAULT NULL,
  `fnvcon_pmand_adresse` varchar(255) DEFAULT NULL,
  `fnvcon_pmand_ville` varchar(255) DEFAULT NULL,
  `fnvcon_pmand_cp` int(11) DEFAULT NULL,
  `fnvcon_pmand_pays` varchar(255) DEFAULT NULL,
  `fnvcon_csnr_nom` varchar(255) DEFAULT NULL,
  `fnvcon_csnr_prenom` varchar(255) DEFAULT NULL,
  `fnvcon_csnr_date_naiss` date DEFAULT NULL,
  `fnvcon_csnr_no_national` varchar(11) DEFAULT NULL,
  `fnvcon_csnr_adresse` varchar(255) DEFAULT NULL,
  `fnvcon_csnr_ville` varchar(255) DEFAULT NULL,
  `fnvcon_csnr_cp` int(11) DEFAULT NULL,
  `fnvcon_csnr_pays` varchar(255) DEFAULT NULL,
  `fnvcon_csnr_tel` varchar(255) DEFAULT NULL,
  `fnvcon_typecon` enum('pl_ordinaire_cercueil','pl_ordinaire_urne','pl_1pers_15ans_cercueil','pl_1pers_15ans_urne','pl_2pers_15ans_cercueil','pl_2pers_15ans_urne','caveau_30ans_cercueil','caveau_30ans_cercueil_cavcom','caveau_30ans_urne','caveau_30ans_urne_cavcom','ouverture_caveau','urne_colomb_ordinaire','urne_colomb_15ans','urne_colomb_30ans','cavurne_communal','dispersion_cendres') DEFAULT NULL,
  `fnvcon_date_sign` date DEFAULT NULL,
  `fnvcon_demandeur_est` enum('pers_mand','concessionnaire') DEFAULT NULL,
  `fnvcon_commentaire` text,
  `fnvcon_fk_con` int(11) DEFAULT NULL,
  `fnvcon_fk_finh` int(11) DEFAULT NULL,
  PRIMARY KEY (`fnvcon_id`),
  KEY `fnvcon_fk_con` (`fnvcon_fk_con`),
  KEY `fnvcon_fk_finh` (`fnvcon_fk_finh`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=48 ;

--
-- Contenu de la table `forms_nouvelle_con`
--

INSERT INTO `forms_nouvelle_con` (`fnvcon_id`, `fnvcon_pmand_nom`, `fnvcon_pmand_prenom`, `fnvcon_pmand_date_naiss`, `fnvcon_pmand_tel`, `fnvcon_pmand_adresse`, `fnvcon_pmand_ville`, `fnvcon_pmand_cp`, `fnvcon_pmand_pays`, `fnvcon_csnr_nom`, `fnvcon_csnr_prenom`, `fnvcon_csnr_date_naiss`, `fnvcon_csnr_no_national`, `fnvcon_csnr_adresse`, `fnvcon_csnr_ville`, `fnvcon_csnr_cp`, `fnvcon_csnr_pays`, `fnvcon_csnr_tel`, `fnvcon_typecon`, `fnvcon_date_sign`, `fnvcon_demandeur_est`, `fnvcon_commentaire`, `fnvcon_fk_con`, `fnvcon_fk_finh`) VALUES
(16, 'Fourne', 'Jean', '0001-01-01', '56789', '82b parc √† conteneurs', 'Meulin', 88282, 'Belgique', 'Duschnock', 'Gontrand', '1922-04-29', '3', '28A clos ridride', 'anvers', 87234, 'Belgique', '6783', NULL, '2017-08-01', 'pers_mand', 'de pr√©f√©rence orient√© sud', NULL, NULL),
(17, 'Terre', 'Jean', '0001-01-01', '56789', '82b parc √† conteneurs', 'Meulin', 88282, 'Belgique', 'Duschnock', 'Gontrand', '1922-04-29', '3', '28A clos ridride', 'anvers', 87234, 'Belgique', '6783', NULL, '2017-08-01', 'pers_mand', 'de pr√©f√©rence orient√© sud', NULL, NULL),
(20, 'Tharo', 'Chufosp', NULL, NULL, NULL, NULL, NULL, NULL, 'Dupzceuezds', 'Rcidsjf√®ne', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
(21, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'Dupzceuezds', 'Rcidsjf√®ne', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
(22, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'Dupzceuezds', 'Rcidsjf√®ne', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
(23, 'Tombal', 'Pierre', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
(24, 'Tombal', 'Pierre', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
(25, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'ae', 'aze', '2017-01-30', '23', 'aze', 'aze', 22, 'aze', '23', 'urne_colomb_15ans', '2017-01-30', NULL, NULL, NULL, NULL),
(46, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '', '', '2017-02-02', '32', '', '', 232, '', '', '', '2017-02-02', NULL, NULL, NULL, 42),
(47, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '', '', '2017-02-02', '23', '', '', 23, '', '', '', '2017-02-02', NULL, NULL, NULL, 43);

-- --------------------------------------------------------

--
-- Structure de la table `form_nouvelle_con_beneficiaires`
--

CREATE TABLE IF NOT EXISTS `form_nouvelle_con_beneficiaires` (
  `fnvconben_id` int(11) NOT NULL AUTO_INCREMENT,
  `fnvconben_nom` varchar(255) DEFAULT NULL,
  `fnvconben_prenom` varchar(255) DEFAULT NULL,
  `fnvconben_date_naiss` date DEFAULT NULL,
  `fnvconben_lien_parente` varchar(255) DEFAULT NULL,
  `fnvconben_adresse` varchar(255) DEFAULT NULL,
  `fnvconben_ville` varchar(255) DEFAULT NULL,
  `fnvconben_cp` int(11) DEFAULT NULL,
  `fnvconben_pays` varchar(255) DEFAULT NULL,
  `fnvconben_fk_fnvcon` int(11) NOT NULL,
  PRIMARY KEY (`fnvconben_id`),
  KEY `fdecben_fk_fdec` (`fnvconben_fk_fnvcon`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=10 ;

--
-- Contenu de la table `form_nouvelle_con_beneficiaires`
--

INSERT INTO `form_nouvelle_con_beneficiaires` (`fnvconben_id`, `fnvconben_nom`, `fnvconben_prenom`, `fnvconben_date_naiss`, `fnvconben_lien_parente`, `fnvconben_adresse`, `fnvconben_ville`, `fnvconben_cp`, `fnvconben_pays`, `fnvconben_fk_fnvcon`) VALUES
(5, 'Kusp', 'Barnab√©', '1982-04-29', 'animal de compagnie', 'All√©e All√©allez', 'Berques', 1337, 'Belgique', 16),
(6, 'Van Beukelaer', 'Sandra', '1980-04-29', 'soeur', 'All√©e All√©allez', 'Berques', 1337, 'Belgique', 16),
(7, 'MacAbb√©', 'Barnab√©', '1982-04-29', 'animal de compagnie', 'All√©e All√©allez', 'Berques', 1337, 'Belgique', 17),
(8, 'Van Beukelaer', 'Sandra', '1980-04-29', 'soeur', 'All√©e All√©allez', 'Berques', 1337, 'Belgique', 17),
(9, 'toji', 'ukuai', NULL, NULL, NULL, NULL, NULL, NULL, 16);

-- --------------------------------------------------------

--
-- Structure de la table `jnt_ben_con`
--

CREATE TABLE IF NOT EXISTS `jnt_ben_con` (
  `jnt_ben_con_fk_ben` int(11) NOT NULL,
  `jnt_ben_con_fk_con` int(11) NOT NULL,
  PRIMARY KEY (`jnt_ben_con_fk_ben`,`jnt_ben_con_fk_con`),
  KEY `jnt_ben_con_fk_loc` (`jnt_ben_con_fk_con`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Contenu de la table `jnt_ben_con`
--

INSERT INTO `jnt_ben_con` (`jnt_ben_con_fk_ben`, `jnt_ben_con_fk_con`) VALUES
(1, 1),
(2, 1),
(3, 1),
(4, 2),
(5, 3),
(6, 4),
(7, 5),
(8, 6),
(8, 7);

-- --------------------------------------------------------

--
-- Structure de la table `personnes_contact`
--

CREATE TABLE IF NOT EXISTS `personnes_contact` (
  `pc_id` int(11) NOT NULL AUTO_INCREMENT,
  `pc_nom` varchar(255) DEFAULT NULL,
  `pc_prenom` varchar(255) DEFAULT NULL,
  `pc_tel` varchar(255) DEFAULT NULL,
  `pc_adresse` varchar(255) DEFAULT NULL,
  `pc_ville` varchar(255) NOT NULL,
  `pc_cp` int(11) DEFAULT NULL,
  `pc_pays` varchar(255) DEFAULT NULL,
  `pc_fk_con` int(11) NOT NULL,
  PRIMARY KEY (`pc_id`),
  KEY `pc_fk_loc` (`pc_fk_con`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=9 ;

--
-- Contenu de la table `personnes_contact`
--

INSERT INTO `personnes_contact` (`pc_id`, `pc_nom`, `pc_prenom`, `pc_tel`, `pc_adresse`, `pc_ville`, `pc_cp`, `pc_pays`, `pc_fk_con`) VALUES
(2, 'nom contact1', 'pren contact 1', '25452152', 'rue du contact 1', '', 1000, 'Belgique', 1),
(3, 'nom contact2', 'pren contact 2', '685878578', 'rue du contact 2', '', 2000, 'Belgique', 2),
(4, 'nom contact3', 'pren contact 3', '6858785', 'rue du contact 3', '', 3000, 'Belgique', 3),
(5, 'nom contact4', 'pren contact 4', '47587272', 'rue du contact 4', '', 4000, 'Belgique', 4),
(6, 'nom contact5', 'pren contact 5', '755424', 'rue du contact 5', '', 5000, 'Belgique', 5),
(7, 'nom contact6', 'pren contact 6', '142478', 'rue du contact 6', '', 6000, 'Belgique', 6),
(8, 'nom contact7', 'pren contact 7', '142478', 'rue du contact 7', '', 7000, 'Belgique', 7);

-- --------------------------------------------------------

--
-- Structure de la table `sejours`
--

CREATE TABLE IF NOT EXISTS `sejours` (
  `sej_id` int(10) NOT NULL AUTO_INCREMENT,
  `sej_date_debut` date DEFAULT NULL,
  `sej_date_fin` date DEFAULT NULL,
  `sej_fk_def` int(10) NOT NULL,
  `sej_fk_empl` int(10) NOT NULL,
  PRIMARY KEY (`sej_id`),
  KEY `sej_fk_def` (`sej_fk_def`),
  KEY `sej_fk_empl` (`sej_fk_empl`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=83 ;

--
-- Contenu de la table `sejours`
--

INSERT INTO `sejours` (`sej_id`, `sej_date_debut`, `sej_date_fin`, `sej_fk_def`, `sej_fk_empl`) VALUES
(1, NULL, NULL, 11, 16),
(6, NULL, NULL, 15, 17),
(7, NULL, NULL, 16, 18),
(8, NULL, NULL, 17, 19),
(9, NULL, NULL, 18, 20),
(10, NULL, NULL, 19, 21),
(15, NULL, NULL, 24, 22),
(16, NULL, NULL, 25, 23),
(17, NULL, NULL, 26, 23),
(18, NULL, NULL, 27, 28),
(19, NULL, NULL, 28, 29),
(20, NULL, NULL, 29, 29),
(21, NULL, NULL, 30, 32),
(22, NULL, NULL, 31, 32),
(23, NULL, NULL, 32, 32),
(24, NULL, NULL, 34, 34),
(25, NULL, NULL, 35, 34),
(26, NULL, NULL, 36, 34),
(27, NULL, NULL, 37, 35),
(28, NULL, NULL, 38, 35),
(29, NULL, NULL, 39, 36),
(30, NULL, NULL, 40, 37),
(31, NULL, NULL, 41, 38),
(32, NULL, NULL, 42, 38),
(33, NULL, NULL, 43, 38),
(34, NULL, NULL, 44, 38),
(35, NULL, NULL, 45, 39),
(36, NULL, NULL, 46, 39),
(37, NULL, NULL, 47, 39),
(38, NULL, NULL, 48, 40),
(39, NULL, NULL, 49, 41),
(40, NULL, NULL, 50, 41),
(41, NULL, NULL, 51, 41),
(42, NULL, NULL, 52, 42),
(43, NULL, NULL, 53, 42),
(44, NULL, NULL, 54, 43),
(45, NULL, NULL, 55, 43),
(46, NULL, NULL, 56, 44),
(47, NULL, NULL, 57, 44),
(48, NULL, NULL, 58, 45),
(49, NULL, NULL, 59, 45),
(50, NULL, NULL, 60, 45),
(51, NULL, NULL, 61, 45),
(52, NULL, NULL, 62, 46),
(53, NULL, NULL, 64, 47),
(54, NULL, NULL, 65, 47),
(55, NULL, NULL, 66, 48),
(56, NULL, NULL, 67, 49),
(57, NULL, NULL, 68, 52),
(58, NULL, NULL, 69, 52),
(59, NULL, NULL, 70, 52),
(60, NULL, NULL, 71, 53),
(61, NULL, NULL, 72, 54),
(62, NULL, NULL, 73, 55),
(63, NULL, NULL, 74, 56),
(64, NULL, NULL, 75, 56),
(65, NULL, NULL, 76, 57),
(66, NULL, NULL, 77, 57),
(67, NULL, NULL, 78, 57),
(68, NULL, NULL, 79, 58),
(69, NULL, NULL, 80, 58),
(70, NULL, NULL, 81, 58),
(71, NULL, NULL, 82, 59),
(72, NULL, NULL, 83, 60),
(73, NULL, NULL, 84, 60),
(74, NULL, NULL, 85, 61),
(75, NULL, NULL, 86, 61),
(76, NULL, NULL, 87, 61),
(77, NULL, NULL, 88, 62),
(78, NULL, NULL, 89, 62),
(79, NULL, NULL, 90, 63),
(80, NULL, NULL, 91, 63),
(81, NULL, NULL, 92, 68),
(82, NULL, NULL, 93, 68);

--
-- Contraintes pour les tables export√©es
--

--
-- Contraintes pour la table `concessions`
--
ALTER TABLE `concessions`
  ADD CONSTRAINT `concessions_ibfk_1` FOREIGN KEY (`con_fk_empl`) REFERENCES `emplacements` (`empl_id`) ON DELETE SET NULL ON UPDATE CASCADE,
  ADD CONSTRAINT `concessions_ibfk_2` FOREIGN KEY (`con_fk_csnr`) REFERENCES `concessionnaires` (`csnr_id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Contraintes pour la table `defunts`
--
ALTER TABLE `defunts`
  ADD CONSTRAINT `defunts_ibfk_1` FOREIGN KEY (`def_fk_sej_actif`) REFERENCES `sejours` (`sej_id`) ON DELETE SET NULL ON UPDATE CASCADE;

--
-- Contraintes pour la table `forms_inhumation`
--
ALTER TABLE `forms_inhumation`
  ADD CONSTRAINT `forms_inhumation_ibfk_1` FOREIGN KEY (`finh_fk_dmdr`) REFERENCES `demandeurs` (`dmdr_id`) ON DELETE SET NULL ON UPDATE CASCADE,
  ADD CONSTRAINT `forms_inhumation_ibfk_2` FOREIGN KEY (`finh_fk_def`) REFERENCES `defunts` (`def_id`) ON DELETE SET NULL ON UPDATE CASCADE;

--
-- Contraintes pour la table `forms_nouvelle_con`
--
ALTER TABLE `forms_nouvelle_con`
  ADD CONSTRAINT `forms_nouvelle_con_ibfk_1` FOREIGN KEY (`fnvcon_fk_con`) REFERENCES `concessions` (`con_id`) ON DELETE SET NULL ON UPDATE CASCADE,
  ADD CONSTRAINT `forms_nouvelle_con_ibfk_2` FOREIGN KEY (`fnvcon_fk_finh`) REFERENCES `forms_inhumation` (`finh_id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Contraintes pour la table `form_nouvelle_con_beneficiaires`
--
ALTER TABLE `form_nouvelle_con_beneficiaires`
  ADD CONSTRAINT `form_nouvelle_con_beneficiaires_ibfk_1` FOREIGN KEY (`fnvconben_fk_fnvcon`) REFERENCES `forms_nouvelle_con` (`fnvcon_id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Contraintes pour la table `jnt_ben_con`
--
ALTER TABLE `jnt_ben_con`
  ADD CONSTRAINT `jnt_ben_con_ibfk_1` FOREIGN KEY (`jnt_ben_con_fk_ben`) REFERENCES `beneficiaires` (`ben_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `jnt_ben_con_ibfk_2` FOREIGN KEY (`jnt_ben_con_fk_con`) REFERENCES `concessions` (`con_id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Contraintes pour la table `personnes_contact`
--
ALTER TABLE `personnes_contact`
  ADD CONSTRAINT `personnes_contact_ibfk_1` FOREIGN KEY (`pc_fk_con`) REFERENCES `concessions` (`con_id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Contraintes pour la table `sejours`
--
ALTER TABLE `sejours`
  ADD CONSTRAINT `sejours_ibfk_1` FOREIGN KEY (`sej_fk_def`) REFERENCES `defunts` (`def_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `sejours_ibfk_2` FOREIGN KEY (`sej_fk_empl`) REFERENCES `emplacements` (`empl_id`) ON DELETE CASCADE ON UPDATE CASCADE;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
