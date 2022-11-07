-- Sat�� bilgilerini tutan tablo
USE SampleDb
CREATE TABLE Satislar(
		id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
		urunId INT NOT NULL,
		calisanId INT NOT NULL,
		adet INT NOT NULL,
		fiyat MONEY NOT NULL,
		tarih DATETIME NOT NULL,
		FOREIGN KEY(urunId) REFERENCES Urunler(id),
		FOREIGN KEY(calisanId) REFERENCES Calisanlar(id)
)

--DATET�ME  YYYY-AA-GG