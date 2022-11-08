USE Northwind

--SELECT *
--FROM Customers C INNER JOIN Orders O
--ON C.CustomerID=O.CustomerID

--LEFT JOIN MÜÞTERÝ TABLOSUNDA OLUP ORDER TABLOSUNDA OLMAYANLARI GETÝRÝR.

--SELECT C.CompanyName
--FROM Customers C LEFT JOIN Orders O
--ON C.CustomerID=O.CustomerID
--WHERE O.OrderID IS NULL

--Customersde olup orderda olmaynalarý getirir.
--SELECT C.CompanyName
--FROM Orders O RIGHT JOIN Customers C 
--ON C.CustomerID=O.CustomerID
--WHERE O.OrderID IS NULL --- IS NULL ORDERID BOÞ OLANLARI GETÝRÝR.


--SELECT P.ProductName, OD.OrderID
--FROM Products P LEFT JOIN [Order Details] OD
--ON P.ProductID=OD.ProductID
--WHERE OD.ProductID IS NULL

--SATIÞ YAPMAYAN ÇALIÞAN 
SELECT E.FirstName+ ' '+ E.LastName as 'Ad Soyad', O.EmployeeID
FROM Employees E LEFT JOIN Orders O
ON E.EmployeeID= O.EmployeeID
WHERE O.EmployeeID IS NULL