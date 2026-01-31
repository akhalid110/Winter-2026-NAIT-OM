use publishers
go

select title_id, title,type,price,royalty
from titles
where royalty >10

use northwindtraders 
go
select top 5 with ties*
from [Order Details]
order by  Discount desc,UnitPrice desc

--Null
--Unknown value never specified a value for the column
--use is /is not
select * from Chinook.dbo.Track where Composer is Null or Milliseconds/60000.0 <1

--How do we find latest date?
select max(Orderdate) as 'latest date'
from NorthwindTraders.dbo.Orders

select top 1 Orderdate as 'latest date'
from NorthwindTraders.dbo.Orders
order by Orderdate desc
--hardcoding like this is obviously bad , DATA ChANGES!!
select orderId,orderDate
from NorthwindTraders.dbo.Orders
where datediff(day,Orderdate,'2021-05-06')=0



declare @maxDate date
select @maxDate= max(OrderDate) from NorthwindTraders.dbo.Orders
go 
select orderId,OrderDate
from NorthwindTraders.dbo.Orders
where datediff(d,OrderDate,@maxDate)=0



--subquery
select orderId,OrderDate
from NorthwindTraders.dbo.Orders
where datediff(d,OrderDate,(select max(orderdate) from NorthwindTraders.dbo.Orders))=0

select getdate()
--how  many months away is 2027
select datediff(month, getdate(),'2027-01-01') 'Months away'

--add 525600 minutes to todays date
--bad example (adding int to a date defaults to days)
select getdate()+525600

select dateadd(minute,525600, getdate())

--what day is 85 days from now
select dateadd(day,85,getdate()),getdate() +85 --equilvant

--what day was 964 hours before now 
select dateadd(hour,-964,getdate())

--which order were shipped on the first day the warehouse was open?
--not quite right
select top 1 with ties o.shipCountry,o.Orderdate,o.OrderId
from NorthwindTraders.dbo.Orders o
where o.ShipCountry ='USA' 
order by OrderDate asc

select  top 1 with ties o.shipCountry,o.Orderdate,o.OrderId
from NorthwindTraders.dbo.Orders o
where o.ShipCountry ='USA' 
order by Year(Orderdate),month(orderdate),day(orderdate)

--chinook database
--get Invoice ID,Customerid, and datefor invoice that occured on the 5th day of the month
select InvoiceId, CustomerId,InvoiceDate
from Chinook.dbo.Invoice
where day(InvoiceDate) =5

--fetch invoice id , customer id , and billing city for invoices ,from finland with null billing state
select InvoiceId, CustomerId,BillingCity
from Chinook.dbo.Invoice
where BillingCountry='FinLand' and BillingState is null
--challenge: Get Invoice id, customer id , and date for invoices that occured on the last day of the month
select InvoiceId, CustomerId, invoicedate
from Chinook.dbo.Invoice
--where invoicedate = EOMONTH(Invoicedate)
where datediff(day,invoicedate,EOMONTH(Invoicedate))=0

