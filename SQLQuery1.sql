

CREATE DATABASE BarinakYonetim;
GO
USE BarinakYonetim;
GO


CREATE TABLE Personel (
    PersonelID INT IDENTITY(1,1) PRIMARY KEY,
    Ad NVARCHAR(50),
    Soyad NVARCHAR(50),
    TCKimlikNo CHAR(11) UNIQUE,
    Pozisyon NVARCHAR(50),
    TelefonNo NVARCHAR(20),
    Eposta NVARCHAR(100),
    Adres NVARCHAR(255),
    Maas DECIMAL(10,2),
    IseGirisTarihi DATE,
    CalismaDurumu NVARCHAR(20),
    KullaniciAdi NVARCHAR(50),
    Parola NVARCHAR(100)
);
GO

INSERT INTO Personel (Ad, Soyad, TCKimlikNo, Pozisyon, TelefonNo, Eposta, Maas, IseGirisTarihi, CalismaDurumu, KullaniciAdi, Parola)
VALUES
('Ayşe', 'Kara', '12345678901', 'Veteriner', '05001234567', 'ayse.kara@barinak.com', 25000, '2023-05-12', 'Aktif', 'aysek', '1234'),
('Ali', 'Demir', '23456789012', 'Bakıcı', '05007654321', 'ali.demir@barinak.com', 18000, '2022-09-01', 'Aktif', 'alid', 'abcd');
GO


CREATE TABLE Stok (
    StokID INT IDENTITY(1,1) PRIMARY KEY,
    UrunAdi NVARCHAR(100),
    Kategori NVARCHAR(50),
    MevcutMiktar INT,
    Birim NVARCHAR(20),
    KritikSeviye INT,
    SonKullanmaTarihi DATE,
    Tedarikci NVARCHAR(100)
);
GO

INSERT INTO Stok (UrunAdi, Kategori, MevcutMiktar, Birim, KritikSeviye, SonKullanmaTarihi, Tedarikci)
VALUES
('Aşı A', 'Aşı', 100, 'Adet', 20, '2025-12-31', 'VetPharma'),
('Kedi Maması', 'Yem', 200, 'Kg', 50, '2026-06-30', 'PetFood Co.');
GO


CREATE TABLE Hayvanlar (
    HayvanID INT IDENTITY(1,1) PRIMARY KEY,
    PersonelID INT,
    Ad NVARCHAR(50),
    Tur NVARCHAR(30),
    Cinsiyet NVARCHAR(10),
    Irk NVARCHAR(50),
    DogumTarihi DATE,
    MikrocipNumarasi NVARCHAR(30),
    BarinakGirisTarihi DATE,
    MevcutDurum NVARCHAR(50),
    Agirlik DECIMAL(5,2),
    TahminiYas INT,
    KisirlastirmaDurumu BIT,
    Rengi NVARCHAR(30),
    FOREIGN KEY (PersonelID) REFERENCES Personel(PersonelID)
);
GO

INSERT INTO Hayvanlar (PersonelID, Ad, Tur, Cinsiyet, Irk, DogumTarihi, BarinakGirisTarihi, MevcutDurum, Agirlik, TahminiYas, KisirlastirmaDurumu, Rengi)
VALUES
(1, 'Boncuk', 'Kedi', 'Dişi', 'Tekir', '2021-04-10', '2023-10-01', 'Barınakta', 3.2, 4, 1, 'Gri'),
(2, 'Karabaş', 'Köpek', 'Erkek', 'Golden Retriever', '2020-06-15', '2023-07-22', 'Sahiplendirildi', 25.5, 5, 1, 'Sarı');
GO


CREATE TABLE KarantinaTakibi (
    KarantinaID INT IDENTITY(1,1) PRIMARY KEY,
    PersonelID INT,
    HayvanID INT,
    GirisTarihi DATE,
    CikisTarihi DATE,
    GirisNedeni NVARCHAR(100),
    CikisSonucu NVARCHAR(100),
    Gozlemler NVARCHAR(MAX),
    FOREIGN KEY (PersonelID) REFERENCES Personel(PersonelID),
    FOREIGN KEY (HayvanID) REFERENCES Hayvanlar(HayvanID)
);
GO

INSERT INTO KarantinaTakibi (PersonelID, HayvanID, GirisTarihi, CikisTarihi, GirisNedeni, CikisSonucu, Gozlemler)
VALUES
(1, 1, '2023-10-01', '2023-10-10', 'Parazit kontrolü', 'Sağlıklı', 'İlk 3 gün iştahsızdı, sonra toparladı.');
GO


CREATE TABLE Tibbi_Kayitlar (
    TibbiKayitID INT IDENTITY(1,1) PRIMARY KEY,
    HayvanID INT,
    PersonelID INT,
    StokID INT NULL,
    IslemTuru NVARCHAR(50),
    IslemTarihi DATE,
    Aciklama NVARCHAR(MAX),
    Sonuc NVARCHAR(100),
    RandevuTarihi DATE,
    FOREIGN KEY (HayvanID) REFERENCES Hayvanlar(HayvanID),
    FOREIGN KEY (PersonelID) REFERENCES Personel(PersonelID),
    FOREIGN KEY (StokID) REFERENCES Stok(StokID)
);
GO

INSERT INTO Tibbi_Kayitlar (HayvanID, PersonelID, StokID, IslemTuru, IslemTarihi, Aciklama, Sonuc, RandevuTarihi)
VALUES
(1, 1, 1, 'Aşılama', '2025-10-30', 'Kuduz aşısı yapıldı.', 'Başarılı', NULL),
(1, 1, NULL, 'Muayene', '2025-10-29', 'Rutin kontrol yapıldı.', 'Sağlıklı', '2026-04-30');
GO


CREATE TABLE Asi_Programi (
    AsiProgramID INT IDENTITY(1,1) PRIMARY KEY,
    StokID INT,
    UygulananTur NVARCHAR(50),
    AsiAdi NVARCHAR(50),
    UygulamaAraligi NVARCHAR(50),
    IlkUygulamaYasi INT,
    AktifDurum BIT,
    FOREIGN KEY (StokID) REFERENCES Stok(StokID)
);
GO

INSERT INTO Asi_Programi (StokID, UygulananTur, AsiAdi, UygulamaAraligi, IlkUygulamaYasi, AktifDurum)
VALUES
(1, 'Kedi', 'Kuduz Aşısı', 'Yılda 1', 3, 1);
GO


CREATE TABLE KullanimMalzemeler (
    KullanimID INT IDENTITY(1,1) PRIMARY KEY,
    TibbiKayitID INT,
    StokID INT,
    KullanimMiktar INT,
    Birim NVARCHAR(20),
    FOREIGN KEY (TibbiKayitID) REFERENCES Tibbi_Kayitlar(TibbiKayitID),
    FOREIGN KEY (StokID) REFERENCES Stok(StokID)
);
GO

INSERT INTO KullanimMalzemeler (TibbiKayitID, StokID, KullanimMiktar, Birim)
VALUES
(1, 1, 1, 'Doz');
GO


CREATE TABLE Beslenme (
    BeslenmeID INT IDENTITY(1,1) PRIMARY KEY,
    HayvanID INT,
    StokID INT,
    BeslenmeSaati TIME,
    BeslenmeTarihi DATE,
    Miktar DECIMAL(5,2),
    MiktarBirim NVARCHAR(20),
    OgunAdi NVARCHAR(30),
    FOREIGN KEY (HayvanID) REFERENCES Hayvanlar(HayvanID),
    FOREIGN KEY (StokID) REFERENCES Stok(StokID)
);
GO

INSERT INTO Beslenme (HayvanID, StokID, BeslenmeSaati, BeslenmeTarihi, Miktar, MiktarBirim, OgunAdi)
VALUES
(1, 2, '08:00', '2025-10-30', 0.25, 'Kg', 'Sabah');
GO


CREATE TABLE Dis_Paydaslar (
    KisiID INT IDENTITY(1,1) PRIMARY KEY,
    Ad NVARCHAR(50),
    Soyad NVARCHAR(50),
    TCKimlikNo CHAR(11),
    Telefon NVARCHAR(20),
    Eposta NVARCHAR(100),
    Adres NVARCHAR(255),
    IletisimTercihi NVARCHAR(20),
    SahiplendirmeyeUygunluk BIT,
    DogrulamaDurumu BIT
);
GO

INSERT INTO Dis_Paydaslar (Ad, Soyad, TCKimlikNo, Telefon, Eposta, Adres, IletisimTercihi, SahiplendirmeyeUygunluk, DogrulamaDurumu)
VALUES
('Mehmet', 'Yıldız', '34567890123', '05321234567', 'mehmet.yildiz@gmail.com', 'Ankara', 'Telefon', 1, 1);
GO


CREATE TABLE Sahiplendirme (
    SahiplendirmeID INT IDENTITY(1,1) PRIMARY KEY,
    HayvanID INT,
    KisiID INT,
    SahiplendirmeTarihi DATE,
    SozlesmeNo NVARCHAR(50),
    TakipDurumu NVARCHAR(50),
    FOREIGN KEY (HayvanID) REFERENCES Hayvanlar(HayvanID),
    FOREIGN KEY (KisiID) REFERENCES Dis_Paydaslar(KisiID)
);
GO

INSERT INTO Sahiplendirme (HayvanID, KisiID, SahiplendirmeTarihi, SozlesmeNo, TakipDurumu)
VALUES
(2, 1, '2024-02-15', 'S-001', 'Takipte');
GO


CREATE TABLE Bagis (
    BagisID INT IDENTITY(1,1) PRIMARY KEY,
    KisiID INT,
    PersonelID INT,
    BagisTarihi DATE,
    BagisTuru NVARCHAR(50),
    Miktar DECIMAL(10,2),
    ParaBirimi NVARCHAR(10),
    Aciklama NVARCHAR(MAX),
    FOREIGN KEY (KisiID) REFERENCES Dis_Paydaslar(KisiID),
    FOREIGN KEY (PersonelID) REFERENCES Personel(PersonelID)
);
GO

INSERT INTO Bagis (KisiID, PersonelID, BagisTarihi, BagisTuru, Miktar, ParaBirimi, Aciklama)
VALUES
(1, 1, '2025-10-01', 'Mama Bağışı', 1000, 'TRY', 'Kedi mamaları için bağış yapıldı.');
GO
