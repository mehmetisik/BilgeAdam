

create proc sp_MusteriSatis
as
select c.CompanyName,SUM(od.Quantity*od.UnitPrice) as Toplam
from [Order Details] od inner join Orders o
on od.OrderID=o.OrderID inner join Customers c
on c.CustomerID=o.CustomerID
group by c.CompanyName
