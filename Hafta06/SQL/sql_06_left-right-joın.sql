USE Northwind

--SELECT *
--FROM Customers C INNER JOIN Orders O
--ON C.CustomerID=O.CustomerID

--LEFT JOIN M��TER� TABLOSUNDA OLUP ORDER TABLOSUNDA OLMAYANLARI GET�R�R.

--SELECT C.CompanyName
--FROM Customers C LEFT JOIN Orders O
--ON C.CustomerID=O.CustomerID
--WHERE O.OrderID IS NULL

--Customersde olup orderda olmaynalar� getirir.
--SELECT C.CompanyName
--FROM Orders O RIGHT JOIN Customers C 
--ON C.CustomerID=O.CustomerID
--WHERE O.OrderID IS NULL --- IS NULL ORDERID BO� OLANLARI GET�R�R.


--SELECT P.ProductName, OD.OrderID
--FROM Products P LEFT JOIN [Order Details] OD
--ON P.ProductID=OD.ProductID
--WHERE OD.ProductID IS NULL

--SATI� YAPMAYAN �ALI�AN 
SELECT E.FirstName+ ' '+ E.LastName as 'Ad Soyad', O.EmployeeID
FROM Employees E LEFT JOIN Orders O
ON E.EmployeeID= O.EmployeeID
WHERE O.EmployeeID IS NULL