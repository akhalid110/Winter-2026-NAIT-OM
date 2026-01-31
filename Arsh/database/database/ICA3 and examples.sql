use adhillon45_Northwind
go

print 'hello world'

if 1=1
begin
print 'yes'
end
else
print 'no'

--BETWEEN
if '2026-01-20' between '2026-01-01' and '2026-01-20'
print 'in'
else 
print 'out'

if getdate() >=  '2026-01-01' and getdate()< '2026-01-22'
print 'in'
else 
print 'out'

print ('pi: '+3.14567)

print ('pi: ' + cast(3.14159 as varchar))


print ('pi: ' + Convert(char(9),3.1459625))

select min(orderDate) from orders

--orders from october 2019 through februry 2020
select OrderID,OrderDate
from Orders
where OrderDate between '2019-10-01' and '2020-03-01'
order by OrderDate

--Like
select SupplierID, CompanyName
from Suppliers
where CompanyName like '%[gd]%'

--in
select SupplierID, [Address],City, postalcode, Country
from Suppliers
where country in('USA' , 'Uk','Japan','Brazil')

select SupplierID, [Address],City, postalcode, Country
from Suppliers
where country not in(select distinct country from Employees
                   where Country like 'U%')

 
 select

    ProductID,

   ProductName,

   UnitPrice

from Products
where Discontinued != 1
   and UnitsInStock between 20 and 30

   select CategoryID,CategoryName,[Description]
   from Categories
   where CategoryName like '[SB]%'
 
 select CustomerID,ContactName,City,Region,Country
 from Customers
 where Fax is null
 and Region is not null
 order by Country ,City desc

 select OrderID, CustomerID, EmployeeID,ShipName,ShipCity,ShippedDate
 from Orders
 where (ShippedDate between '2019-06-30' and'2019-08-01'
 and ShipRegion is null
 and ShipCountry like 'F%')or ShipCity like '%[er]%'
 order by ShipCountry , EmployeeID desc 