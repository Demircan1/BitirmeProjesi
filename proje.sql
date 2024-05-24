-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Anamakine: 127.0.0.1
-- Üretim Zamanı: 16 May 2024, 10:06:38
-- Sunucu sürümü: 10.4.32-MariaDB
-- PHP Sürümü: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Veritabanı: `proje`
--

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `tblbilgiler`
--

CREATE TABLE `tblbilgiler` (
  `id` int(11) NOT NULL,
  `ogrenciNo` int(11) NOT NULL,
  `ad` text NOT NULL,
  `soyad` text NOT NULL,
  `mezuniyetTarihi` date NOT NULL,
  `cepTel` int(11) NOT NULL,
  `ePosta` text NOT NULL,
  `evTel` int(11) NOT NULL,
  `ulke` text NOT NULL,
  `sehir` text NOT NULL,
  `adres` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_turkish_ci;

--
-- Tablo döküm verisi `tblbilgiler`
--

INSERT INTO `tblbilgiler` (`id`, `ogrenciNo`, `ad`, `soyad`, `mezuniyetTarihi`, `cepTel`, `ePosta`, `evTel`, `ulke`, `sehir`, `adres`) VALUES
(1, 19913251, 'MELİH ÖNEM', 'AKSUS', '2002-01-11', 532521193, 'melihonem.aksu@gmail.com', 312442181, 'Türkiye', 'Ankara', 'park oran konutları c2 blok 48 oran Çankaya ANKARA'),
(2, 22295326, 'DENİZ EMİRCAN', 'ÇİFTÇİ', '2004-10-12', 1234512445, 'denizciftci@gmail.com', 1111111, 'Turkiye', 'Ankara', 'seğmenler mahallesi 927.cad Gölbaşı'),
(3, 19913344, 'AYKUT', 'AYDINLI', '1995-05-06', 532493979, 'aykutaydinli@gmail.com', 312266701, 'Türkiye', 'Ankara', 'Bilkent 2 Konutları E-3 Blok No:16 Bilkent ANKARA'),
(4, 19913426, 'EMRE', 'BİRHEKİMOĞLU', '1995-03-16', 532793812, 'birhekim@gmail.com', 212240106, 'Türkiye', 'İstanbul', 'Oyak 4 Sitesi 1. Giriş Kat:3 Daire:13 Çayyolu/ANKARA'),
(5, 98122001, 'BARIŞ', 'ERGÜLLÜ', '1995-05-17', 532686925, 'barisergullu@gmail.com', 232375026, 'Türkiye', 'İzmir', 'İzmir'),
(6, 98122002, 'BURCU', 'TAŞAN', '1996-03-19', 533542920, 'burcutasan@gmail.com', 312441601, 'Türkiye', 'Ankara', 'Sancak mah. Çankaya-ANKARA'),
(8, 9812200, 'EMRE', 'ERPUL', '1995-05-26', 536641342, 'emrpul@gmail.com', 312240040, 'Türkiye', 'Ankara', 'Mesa Koru Sit Gül Blok No:19 Çayyolu-ANKARA'),
(9, 98132008, 'MÜZEYYEN', 'EVRAN', '1995-12-13', 530976227, 'burcu_evran@gmail.com', 258216663, 'Türkiye', 'Denizli', 'Lise cad. 33/2 Denizli'),
(10, 98132012, 'GÖKÇEL', 'AYDOĞMUŞ', '2004-11-12', 533375788, 'gokcellayd@gmail.com', 322458733, 'Türkiye', 'Adana', 'Adana Merkez'),
(11, 98132016, 'ELİF', 'DEMİRBOLAT', '1993-05-26', 532512183, 'elifdemirbolat@gmail.com', 312213895, 'Türkiye', 'İstanbul', 'Çayır Sk. Acarlar Sit.A Blok No:9 Ortaköy-İSTANBUL'),
(12, 98132017, 'EMİNE İREM', 'İLDEŞ', '2012-05-17', 505759797, 'emineirem.ildes@gmail.com', 312213895, 'Türkiye', 'Ankara', 'Gayret Mh. Park Çiftlik Konutları Toki CK2 Blok No:6 Yenimahalle-ANKARA'),
(13, 98132022, 'MEHMET SALİH', 'ERHAN', '1997-03-12', 532297072, 'msalih@gmail.com', 532297072, 'Türkiye', 'Ankara', 'TBMM Loj. B/2 No:25 Oran-ANKARA'),
(14, 98132023, 'EMİNE ESRA', 'DOĞRUYOL', '1992-05-17', 212263855, 'esra1307@gmail.com', 212236436, 'Türkiye', 'İstanbul', 'Çitlebik Sok. Defne Apt. 11/1 Beşiktaş/İSTANBUL'),
(15, 98132024, 'ÖZGÜR', 'AYDIN', '1996-06-19', 524240217, 'o.aydin@gmail.com', 312240411, 'Türkiye', 'Ankara', 'Ankara-Yenimahalle'),
(16, 98132027, 'FATMA DİDEM', 'ÇELİK', '1995-05-25', 532625949, 'ddcelik@gmail.com', 312123245, 'Türkiye', 'Ankara', 'GOP-ANKARA'),
(17, 98132033, 'SELÇUK', 'ALKAŞ', '1996-08-19', 530548208, 'selcuk.alkas@gmail.com', 312266427, 'Türkiye', 'Ankara', 'Mamak'),
(18, 98452001, 'ALPER', 'ER', '2011-10-12', 532636925, 'bariserllu@gmail.com', 232375026, 'Türkiye', 'Adana', 'Adana');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `tblegitimbilgileri`
--

CREATE TABLE `tblegitimbilgileri` (
  `id` int(11) NOT NULL,
  `ogrenciNo` int(11) NOT NULL,
  `akademikEgitim` text NOT NULL,
  `baslangic` date NOT NULL,
  `bitis` date NOT NULL,
  `ulke` text NOT NULL,
  `sehir` text NOT NULL,
  `universite` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_turkish_ci;

--
-- Tablo döküm verisi `tblegitimbilgileri`
--

INSERT INTO `tblegitimbilgileri` (`id`, `ogrenciNo`, `akademikEgitim`, `baslangic`, `bitis`, `ulke`, `sehir`, `universite`) VALUES
(1, 19913251, 'Yüksek Lisans', '2000-05-12', '2002-05-12', 'Türkiye', 'Türkiye', 'Başkent Üniversitesi'),
(2, 22295326, 'Doktora', '2002-04-12', '2004-04-12', 'Türkiye', 'İstanbul', 'Yeditepe Üniversitesi'),
(3, 98132017, 'Doktora', '1996-07-16', '1999-07-16', 'Kanada', 'Toronto', 'Toronto Üniversitesi'),
(4, 98122002, 'Yüksek Lisans', '1983-07-09', '1989-07-09', 'Amerika', 'Florida', 'Güney Florida Üniversitesi');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `tblgiriş`
--

CREATE TABLE `tblgiriş` (
  `id` int(11) NOT NULL,
  `kullanici_adi` text NOT NULL,
  `sifre` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_turkish_ci;

--
-- Tablo döküm verisi `tblgiriş`
--

INSERT INTO `tblgiriş` (`id`, `kullanici_adi`, `sifre`) VALUES
(1, 'deniz', 123123);

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `tblisbilgileri`
--

CREATE TABLE `tblisbilgileri` (
  `id` int(11) NOT NULL,
  `GirisTarihi` date NOT NULL,
  `AyrilisTarihi` date NOT NULL,
  `kamuozel` text NOT NULL,
  `sektor` text NOT NULL,
  `unvan` text NOT NULL,
  `pozisyon` text NOT NULL,
  `ogrenciNo` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_turkish_ci;

--
-- Tablo döküm verisi `tblisbilgileri`
--

INSERT INTO `tblisbilgileri` (`id`, `GirisTarihi`, `AyrilisTarihi`, `kamuozel`, `sektor`, `unvan`, `pozisyon`, `ogrenciNo`) VALUES
(1, '2004-10-12', '2024-03-23', 'Ozel', 'Bilişim', 'Teknik Destek Uzmanı', 'Mühendis', 22295637),
(2, '2004-12-03', '2006-07-22', 'Kamu', 'Eğitim', 'Öğretmen', 'Müdür', 22295326);

--
-- Dökümü yapılmış tablolar için indeksler
--

--
-- Tablo için indeksler `tblbilgiler`
--
ALTER TABLE `tblbilgiler`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `tblegitimbilgileri`
--
ALTER TABLE `tblegitimbilgileri`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `tblgiriş`
--
ALTER TABLE `tblgiriş`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `tblisbilgileri`
--
ALTER TABLE `tblisbilgileri`
  ADD PRIMARY KEY (`id`);

--
-- Dökümü yapılmış tablolar için AUTO_INCREMENT değeri
--

--
-- Tablo için AUTO_INCREMENT değeri `tblbilgiler`
--
ALTER TABLE `tblbilgiler`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=19;

--
-- Tablo için AUTO_INCREMENT değeri `tblegitimbilgileri`
--
ALTER TABLE `tblegitimbilgileri`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- Tablo için AUTO_INCREMENT değeri `tblgiriş`
--
ALTER TABLE `tblgiriş`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- Tablo için AUTO_INCREMENT değeri `tblisbilgileri`
--
ALTER TABLE `tblisbilgileri`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
