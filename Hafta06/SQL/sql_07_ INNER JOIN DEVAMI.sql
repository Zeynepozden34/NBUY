USE Northwind

--DISTINCT �STEN�LEN B�LG� KA� DEFA GE�ERSE GE�S�N B�R KERE B�ZE GET�R�R
--SELECT DISTINCT CategoryID FROM Products

--1)bug�ne kadar hangi �lkere kargo g�ndermi�iz
--SELECT DISTINCT ShipCountry FROM Orders
--ORDER BY ShipCountry

--2) hangi �lkeye ne kadar sat�� yapm���z.
--GROUP BY GRUPLAMA YAPAR.
--SELECT O.ShipCountry, SUM(OD.Quantity*OD.UnitPrice) as 'Toplam Tutar' FROM Orders O INNER JOIN [Order Details] OD
--ON O.OrderID=OD.OrderID
--GROUP BY O.ShipCountry
--ORDER BY 'Toplam Tutar' DESC

--3) EN�OK SATI� YAPILAN �� �LKE "top" ile blunur
--SELECT TOP(3)O.ShipCountry, SUM(OD.Quantity*OD.UnitPrice) as 'Toplam Tutar' FROM Orders O INNER JOIN [Order Details] OD
--ON O.OrderID=OD.OrderID
--GROUP BY O.ShipCountry
--ORDER BY 'Toplam Tutar' DESC


--4)elimizde en �ok sto�u bulunan ilk �� �r�n
--SELECT TOP(3)P.ProductName,P.UnitsInStock
--FROM Products P
--ORDER BY P.UnitsInStock DESC


-- 5)HANG� KATEGOR�DE KA� �R�N VAR
--SELECT C.CategoryName, COUNT(*) AS 'ADET'
--FROM Products P INNER JOIN Categories C
--ON C.CategoryID=P.CategoryID
--GROUP BY C.CategoryName
--ORDER BY 'ADET' DESC

-- 5)HANG� KATEGOR�DE 10'DAN FAZLA �R�N VAR 
--gruplama yapt���m�z yerde bunu hav�ng koutuyla yapar�z.
--SELECT C.CategoryName, COUNT(*) AS ADET
--FROM Products P INNER JOIN Categories C
--ON C.CategoryID=P.CategoryID 
--GROUP BY C.CategoryName
--HAVING COUNT(*)>10
--ORDER BY 'ADET' DESC


--6) hangi �r�nden ka� tane sat�lm��
--SELECT P.ProductName, COUNT(*) AS ADET
--FROM Products P INNER JOIN [Order Details] OD
--ON P.ProductID=OD.ProductID
--GROUP BY P.ProductName
--ORDER BY 'ADET' DESC

--7)en �ok kazand�ran ilk �� �r�n
--SELECT TOP(3) P.ProductName,SUM(OD.Quantity*OD.UnitPrice) AS TOPLAM
--FROM Products P INNER JOIN [Order Details] OD
--ON P.ProductID=OD.ProductID
--GROUP BY P.ProductName
--ORDER BY 'TOPLAM' DESC

--8)Hangi kargo �irketine ne kadar �deme yap�lm��t�r.
--SELECT S.CompanyName, SUM(O.Freight) AS TOTAL 
--FROM Shippers S INNER JOIN Orders O
--ON S.ShipperID=O.ShipVia
--GROUP BY S.CompanyName
--ORDER BY TOTAL DESC


--9)En az �deme yap�lm�� kargo �irketi
--SELECT TOP(1) S.CompanyName, SUM(O.Freight) AS TOTAL 
--FROM Shippers S INNER JOIN Orders O
--ON S.ShipperID=O.ShipVia
--GROUP BY S.CompanyName
--ORDER BY TOTAL 

--10)hangi m��teriye ne kadar tutar sat�� yap�lm��t�r.
--SELECT C.CompanyName, SUM(OD.Quantity*OD.UnitPrice) AS TOTAL
--FROM Customers C 
--INNER JOIN Orders O ON C.CustomerID=O.CustomerID 
--INNER JOIN [Order Details] OD ON O.OrderID=OD.OrderID
--GROUP BY C.CompanyName
--ORDER BY TOTAL DESC

--11)B�LGELERE G�RE SATI� TUTARI
--SELECT R.RegionDescription, SUM(OD.Quantity*OD.UnitPrice) AS TOTAL
--FROM Employees E 
--INNER JOIN EmployeeTerritories ET ON E.EmployeeID=ET.EmployeeID 
--INNER JOIN Territories T ON ET.TerritoryID=T.TerritoryID
--INNER JOIN Region R ON R.RegionID= T.RegionID
--INNER JOIN Orders O ON E.EmployeeID=O.EmployeeID
--INNER JOIN [Order Details] OD ON OD.OrderID=O.OrderID
--GROUP BY R.RegionDescription
--ORDER BY TOTAL DESC

--12) HANG� B�LDEGE HANG� �R�NDEN KA� SATI� YAPILMI�TIR.
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

