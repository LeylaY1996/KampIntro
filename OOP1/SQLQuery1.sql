--select
--Select ContactName from Customers;

--Select * from Customers where City = 'Berlin';

--Select * from Products where CategoryID=1 or CategoryID=3

--Select * from Products where CategoryID=1 and UnitPrice>10

--Select * from Products order by ProductName

--Select * from Products order by UnitPrice desc

--Select count(*) from Products
--Select count(*) from Products where CategoryID = 2


--Listeleyecek ama tekrarlamayacak 
--categorydeki ürün sayısını verir
--select CategoryID,count(*) from Products group by CategoryID

--ürün sayısı 10dan az olan kategorileri listele
--select CategoryID,count(*) from Products group by CategoryID having count(*)<10

--select * from Products inner join Categories on Products.CategoryID=Categories.CategoryID
	--where Products.UnitPrice>10


--Select * from Products p inner join [Order Details] od on p.ProductID = od.ProductID

--Solda olup sağda olmayanları getir
--Select * from Products p left join [Order Details] od on p.ProductID = od.ProductID

--Select * from Customers c left join Orders o
--on c.CustomerID = o.CustomerID

