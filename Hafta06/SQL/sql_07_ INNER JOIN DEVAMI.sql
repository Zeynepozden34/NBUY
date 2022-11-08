USE Northwind

--DISTINCT ÝSTENÝLEN BÝLGÝ KAÇ DEFA GEÇERSE GEÇSÝN BÝR KERE BÝZE GETÝRÝR
--SELECT DISTINCT CategoryID FROM Products

--1)bugüne kadar hangi ülkere kargo göndermiþiz
--SELECT DISTINCT ShipCountry FROM Orders
--ORDER BY ShipCountry

--2) hangi ülkeye ne kadar satýþ yapmýþýz.
--GROUP BY GRUPLAMA YAPAR.
--SELECT O.ShipCountry, SUM(OD.Quantity*OD.UnitPrice) as 'Toplam Tutar' FROM Orders O INNER JOIN [Order Details] OD
--ON O.OrderID=OD.OrderID
--GROUP BY O.ShipCountry
--ORDER BY 'Toplam Tutar' DESC

--3) ENÇOK SATIÞ YAPILAN ÜÇ ÜLKE "top" ile blunur
--SELECT TOP(3)O.ShipCountry, SUM(OD.Quantity*OD.UnitPrice) as 'Toplam Tutar' FROM Orders O INNER JOIN [Order Details] OD
--ON O.OrderID=OD.OrderID
--GROUP BY O.ShipCountry
--ORDER BY 'Toplam Tutar' DESC


--4)elimizde en çok stoðu bulunan ilk üç ürün
--SELECT TOP(3)P.ProductName,P.UnitsInStock
--FROM Products P
--ORDER BY P.UnitsInStock DESC


-- 5)HANGÝ KATEGORÝDE KAÇ ÜRÜN VAR
--SELECT C.CategoryName, COUNT(*) AS 'ADET'
--FROM Products P INNER JOIN Categories C
--ON C.CategoryID=P.CategoryID
--GROUP BY C.CategoryName
--ORDER BY 'ADET' DESC

-- 5)HANGÝ KATEGORÝDE 10'DAN FAZLA ÜRÜN VAR 
--gruplama yaptýðýmýz yerde bunu havýng koutuyla yaparýz.
--SELECT C.CategoryName, COUNT(*) AS ADET
--FROM Products P INNER JOIN Categories C
--ON C.CategoryID=P.CategoryID 
--GROUP BY C.CategoryName
--HAVING COUNT(*)>10
--ORDER BY 'ADET' DESC


--6) hangi üründen kaç tane satýlmýþ
--SELECT P.ProductName, COUNT(*) AS ADET
--FROM Products P INNER JOIN [Order Details] OD
--ON P.ProductID=OD.ProductID
--GROUP BY P.ProductName
--ORDER BY 'ADET' DESC

--7)en çok kazandýran ilk üç ürün
--SELECT TOP(3) P.ProductName,SUM(OD.Quantity*OD.UnitPrice) AS TOPLAM
--FROM Products P INNER JOIN [Order Details] OD
--ON P.ProductID=OD.ProductID
--GROUP BY P.ProductName
--ORDER BY 'TOPLAM' DESC

--8)Hangi kargo þirketine ne kadar ödeme yapýlmýþtýr.
--SELECT S.CompanyName, SUM(O.Freight) AS TOTAL 
--FROM Shippers S INNER JOIN Orders O
--ON S.ShipperID=O.ShipVia
--GROUP BY S.CompanyName
--ORDER BY TOTAL DESC


--9)En az ödeme yapýlmýþ kargo þirketi
--SELECT TOP(1) S.CompanyName, SUM(O.Freight) AS TOTAL 
--FROM Shippers S INNER JOIN Orders O
--ON S.ShipperID=O.ShipVia
--GROUP BY S.CompanyName
--ORDER BY TOTAL 

--10)hangi müþteriye ne kadar tutar satýþ yapýlmýþtýr.
--SELECT C.CompanyName, SUM(OD.Quantity*OD.UnitPrice) AS TOTAL
--FROM Customers C 
--INNER JOIN Orders O ON C.CustomerID=O.CustomerID 
--INNER JOIN [Order Details] OD ON O.OrderID=OD.OrderID
--GROUP BY C.CompanyName
--ORDER BY TOTAL DESC

--11)BÖLGELERE GÖRE SATIÞ TUTARI
--SELECT R.RegionDescription, SUM(OD.Quantity*OD.UnitPrice) AS TOTAL
--FROM Employees E 
--INNER JOIN EmployeeTerritories ET ON E.EmployeeID=ET.EmployeeID 
--INNER JOIN Territories T ON ET.TerritoryID=T.TerritoryID
--INNER JOIN Region R ON R.RegionID= T.RegionID
--INNER JOIN Orders O ON E.EmployeeID=O.EmployeeID
--INNER JOIN [Order Details] OD ON OD.OrderID=O.OrderID
--GROUP BY R.RegionDescription
--ORDER BY TOTAL DESC

--12) HANGÝ BÖLDEGE HANGÝ ÜRÜNDEN KAÇ SATIÞ YAPILMIÞTIR.
--SELECT R.RegionDescription, P.ProductName, SUM(OD.Quantity*OD.UnitPrice) AS TOTAL
--FROM Employees E 
--INNER JOIN EmployeeTerritories ET ON E.EmployeeID=ET.EmployeeID 
--INNER JOIN Territories T ON ET.TerritoryID=T.TerritoryID
--INNER JOIN Region R ON R.RegionID= T.RegionID
--INNER JOIN Orders O ON E.EmployeeID=O.EmployeeID
--INNER JOIN [Order Details] OD ON OD.OrderID=O.OrderID
--INNER JOIN Products P ON P.ProductID=OD.ProductID
--GROUP BY R.RegionDescription, P.ProductName
--ORDER BY R.RegionDescription, P.ProductName, TOTAL DESC

