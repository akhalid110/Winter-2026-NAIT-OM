use adhillon45_Northwind
go
--declare @maxorderID int 
--select @maxorderID = max(orderId) from Orders
----set @maxorderID %= 2
--select @maxorderID as 'Max Order ID'

--Give me orders with a even order ID


select *
from orders
where orderID % 2 = 0
order by orderID asc

--all orders with an order id that is a multiple of 7
---order by orderid desc
select *
from orders
where orderID % 7 = 0
order by orderID desc

--get me Customer ID , Address , city , region, country,
--from customer table
--order by CustomerID descending
-- if the region is null display 'Nait' instead
select CustomerID,Address,City, Coalesce(Region,'NAIT')as 'Region', Country
from Customers
order by customerID desc
