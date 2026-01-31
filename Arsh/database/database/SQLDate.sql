use adhillon45_Northwind
go

-- in the customers table find all rows where companies ends in s

select *
from Customers 
where CompanyName like '%_s'

--Now 3rd last letter of CompanyName is 's'
select *
from Customers 
where CompanyName like '%s__'

--more about dates
select Orderdate,datediff(day, orderDate,GetDate()) as 'Date Diff'
from Orders 
order by OrderDate desc

select datepart(minute, getdate()) as 'minute'--this is an int
--Datename gives string  
select 'Minute:' + datename(minute, getdate()) as 'minute'

select 'Day of week:' + datename(weekday, getdate()) as 'DOW'

--Convert /cast one type into
select Cast(getDate() as Varchar (30)) as 'Today'

select 'PI: ' + Cast(PI() as varchar(10)) 'Number' 

select convert (varchar (30),GetDate ())'Today'

select UPPER('david') as 'name'
select LOWER ('DAVID') as 'name'

select left (Name, 10) as 'Short Name' from Chinook.dbo.Track
select right (Name, 10) as 'Short Name' from Chinook.dbo.Track

select LTRIM('  ' + Name) from Chinnok.dbo.Track
select RTRIM(Name + '     ') from Chinook.dbo.Track

--COALESCE: dealing with NULL values. i want to fallback to a nice value ->'N/A' , Null->0
select CustomerID, CompanyName, Coalesce(Region , 'No Region') as 'Region'
from adhillon45_Northwind.dbo.Customers

