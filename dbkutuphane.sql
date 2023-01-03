-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Anamakine: 127.0.0.1:3306
-- Üretim Zamanı: 03 Oca 2023, 17:40:47
-- Sunucu sürümü: 5.7.36
-- PHP Sürümü: 7.4.26

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Veritabanı: `dbkutuphane`
--

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `kisiler`
--

DROP TABLE IF EXISTS `kisiler`;
CREATE TABLE IF NOT EXISTS `kisiler` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `ad` varchar(200) COLLATE utf8mb4_turkish_ci NOT NULL,
  `soyad` varchar(200) COLLATE utf8mb4_turkish_ci NOT NULL,
  `dogum_tarih` varchar(100) COLLATE utf8mb4_turkish_ci NOT NULL,
  `tc` char(13) COLLATE utf8mb4_turkish_ci NOT NULL,
  `tel` varchar(30) COLLATE utf8mb4_turkish_ci NOT NULL,
  `mail` varchar(100) COLLATE utf8mb4_turkish_ci NOT NULL,
  `uye_tarih` varchar(100) COLLATE utf8mb4_turkish_ci NOT NULL,
  `adres` varchar(200) COLLATE utf8mb4_turkish_ci NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_turkish_ci;

--
-- Tablo döküm verisi `kisiler`
--

INSERT INTO `kisiler` (`id`, `ad`, `soyad`, `dogum_tarih`, `tc`, `tel`, `mail`, `uye_tarih`, `adres`) VALUES
(1, 'Umahan', 'Kablan', '12.12.1998', '12332112331', '(123) 123-1312', 'umahan@gmail.com', '02.01.2023', 'Kütahya'),
(9, 'Ahmet ', 'Kablan', '01.01.1955', '33333333333', '(274) 223-8869', 'ahmet@gmail.com', '01.01.1955', 'kütahya'),
(6, 'Emine ', 'Kablan', '01.01.1955', '33333333333', '(333) 333-3333', 'emine@gmail.com', '01.01.1990', 'Yıldırım beyazıt Mh.');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `kitaplar`
--

DROP TABLE IF EXISTS `kitaplar`;
CREATE TABLE IF NOT EXISTS `kitaplar` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `ad` varchar(250) COLLATE utf8mb4_turkish_ci NOT NULL,
  `yazar` varchar(250) COLLATE utf8mb4_turkish_ci NOT NULL,
  `sayfa` int(11) NOT NULL,
  `tür` varchar(200) COLLATE utf8mb4_turkish_ci NOT NULL,
  `yayin_evi` varchar(200) COLLATE utf8mb4_turkish_ci NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_turkish_ci;

--
-- Tablo döküm verisi `kitaplar`
--

INSERT INTO `kitaplar` (`id`, `ad`, `yazar`, `sayfa`, `tür`, `yayin_evi`) VALUES
(1, 'Tutunamayanlar', 'Oğuz Atay', 500, 'Roman', 'yılmaz'),
(2, 'Tehlikeli Oyunlar', 'Oguz atay', 123, 'hikaye', 'gonca'),
(7, 'Kürk Mantolu Kadınlar', 'Sebattin Ali', 175, 'roman', 'D&R');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `tbl_admin`
--

DROP TABLE IF EXISTS `tbl_admin`;
CREATE TABLE IF NOT EXISTS `tbl_admin` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `kullanici_adi` varchar(100) COLLATE utf8mb4_turkish_ci NOT NULL,
  `sifre` varchar(12) COLLATE utf8mb4_turkish_ci NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_turkish_ci;

--
-- Tablo döküm verisi `tbl_admin`
--

INSERT INTO `tbl_admin` (`id`, `kullanici_adi`, `sifre`) VALUES
(1, 'admin', '1234');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
