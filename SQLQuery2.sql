--select
--ANSII
--select ContactName Adi,CompanyName SirketAdi,City Sehir from Customers
--select * from Customers where City = 'Berlin'
--case insensitive
--Select * from Products where CategoryID=1 or CategoryID=3
--Select * from Products where CategoryID=1 and UnitPrice>=10

--select * from Products where CategoryID=1 order by UnitPrice desc --ascending artan anlamında --descending
--select count(*) from Products where CategoryID=2
--select categoryId,count(*) from Products where UnitPrice>20 group by CategoryID having count(*)<10

--select Products.ProductId, Products.ProductName, Products.ProductName, Products.UnitPrice, Categories.CategoryName
--from Products inner join Categories
--on Products.CategoryID = Categories.CategoryID
--where Products.UnitPrice>10

--DTO Fata Transformation Object

--select * from Products p inner join [Order Details] od
--on p.ProductID = od.ProductID

--select * from Products p left inner join [Order Details] od
--on p.ProductID = od.ProductID

--select * from Customers c left join Orders o    -- c ile o arasındaki tabloların left join yazıldığında solda olan sağda olmayanları getirir
--on o.CustomerID = c.CustomerID
--where o.CustomerID is null         --Hiç ürün almayanların listelenmesi

--select * from Customers c left join Orders o    
--on o.CustomerID = c.CustomerID
--where o.CustomerID is null

select * from Products p inner join [Order Details] od
on p.ProductID = od.ProductID
inner join orders o
on o.OrderID = od.OrderID
