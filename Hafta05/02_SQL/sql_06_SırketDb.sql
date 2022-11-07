CREATE DATABASE SirketDb2
GO
USE SirketDb2
CREATE TABLE Departmanlar(
		id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
		ad NVARCHAR(MAX) NOT NULL,
) 

INSERT INTO Departmanlar(ad) VALUES
	('Muhasebe'),
	('Teknik'),
	('Satýþ'),
    ('ÝK'),
    ('Yönetim')	

	USE SirketDb2
	CREATE TABLE Unvanlar(
	id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	ad NVARCHAR(MAX) NOT NULL,
	)

	INSERT INTO Unvanlar(ad) VALUES
	('Ýþçi'),
	('Muhasebe Uzmaný'),
	('Satýþcý'),
	('ÝK Uzmaný'),
	('ÝK Stajyeri'),
	('Yönetici'),
	('Yönetici Yardýmcýsý')

	USE SirketDb2
	CREATE TABLE Iller(
	id CHAR(2) NOT NULL PRIMARY KEY,
	ad NVARCHAR(30) NOT NULL,
	)

	INSERT INTO Iller(id, ad) VALUES
	('34', 'Ýstanbul'),
	('06', 'Ankara'),
	('35', 'Ýzmir'),	
	('58', 'Sivas'),
	('41', 'Ýzmit')

	USE SirketDb2
	CREATE TABLE Ilceler(
	id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	ad NVARCHAR(30) NOT NULL,
	ilId Char(2) NOT NULL,
	FOREIGN KEY(ilId) REFERENCES Iller(id)
	)

	INSERT INTO Ilceler(ad, ilId) VALUES
	('Kadýköy', '34'),
	('Beþiktaþ', '34'),
	('Avcýlar', '34'),
	('Konak', '35'),
	('Yeni Mahalle', '06'),
	('Çankaya', '06'),
	('Suþehri', '58')

	USE SirketDb2

	CREATE TABLE Personeller(
	id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	ad NVARCHAR(25) NOT NULL,
	soyad NVARCHAR(25) NOT NULL,
	cinsiyet BIT NOT NULL,
	dogumTarihi DATE NOT NULL,
	ikametgahIlceId INT NOT NULL,
	iseBaslamaTarihi DATE NOT NULL,
	departmanId INT NOT NULL,
	unvanId INT NOT NULL,
	maas MONEY NOT NULL,
	FOREIGN KEY(ikametgahIlceId) REFERENCES Ilceler(id),
	FOREIGN KEY(departmanId) REFERENCES Departmanlar(id),
	FOREIGN KEY(unvanId) REFERENCES Unvanlar(id),
	)

	INSERT INTO Personeller(ad, soyad,cinsiyet,dogumTarihi, ikametgahIlceId, iseBaslamaTarihi,
	departmanId, unvanId, maas) VALUES
	('Alican', 'Kabak', 0, '1999-05-15',1,'2021-11-10',1,1,12500),
	('Merve', 'Sevgi', 1, '1999-05-15',2,'2021-11-10',2,2,8500),
	('Defne', 'Dertli', 1, '1999-05-15',3,'2021-11-10',3,3,9500),
	('Baran', 'Gören',0, '1999-05-15',4,'2021-11-10',4,4,1200),
	('Arda', 'Seven', 0, '1999-05-15',5,'2021-11-10',5,5,25500),
	('Hazal', 'Kaya', 1, '1999-05-15',6,'2021-11-10',1,6,82500),
	('Derya', 'Topal', 1, '1999-05-15',7,'2021-11-10',2,7,75500),
	('Emre', 'Ýnan', 0, '1999-05-15',1,'2021-11-10',3,1,1240),
	('Ahmet', 'Kiraz', 0, '1999-05-15',2,'2021-11-10',4,2,500),
	('Günay', 'Gelen', 0, '1999-05-15',3,'2021-11-10',5,3,6500),
	('Kiraz', 'Gören', 1, '1999-05-15',4,'2021-11-10',1,4,3500)

	USE SirketDb2
	CREATE TABLE Projeler(
	id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	ad NVARCHAR(50) NOT NULL,
	baslamaTarihi DATE NOT NULL,
	planlananBitisTarihi DATE NOT NULL
	)
	INSERT INTO Projeler(ad, baslamaTarihi, planlananBitisTarihi) VALUES
	('Mutlu Çocuklar', '2022-5-5','2022-5-5'),
	('Temiz Üsküdar', '2022-5-5','2022-5-5'),
	('Haydi Çocuklar', '2022-5-5','2022-5-5'),
	('Kirli Kadýköy', '2022-5-5','2022-5-5')
	