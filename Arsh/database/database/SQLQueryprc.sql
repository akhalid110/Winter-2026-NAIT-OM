use Northwindtraders
go
select FirstName,LastName,Convert(varchar(10),HireDate,111),City
from Employees
order by City desc

select rand(), getdate(),286%69 'remaider',286/69 'division',286.0/69.0 'float division'

select top 5 with ties t.Lastname, t.Firstname ,convert(varchar(15),t.Hiredate,107) 'Hiredate'
from Employees t
order by month(hireDate),day(hireDate) desc

use Chinook 
go

select top 10 with ties trackId,cast(Name as varchar(20)),milliseconds/unitprice  'MPP'
from Track 
order by 'MPP'  desc

select distinct cast(Billingcity as varchar(15)) 'City', cast(BillingCountry as varchar (15)) 'Country'
from Invoice
--where total >= 15.24 and total < 17.98
where total between 15.24 and 17.98

use publishers 
go
select Title_id 'Title Id', left(Title ,40) 'Title' ,type, cast(coalesce(Price,'$99.99')as decimal(7,4)) 'Book Price'
from titles
where type in ('UNDECIDED', 'world_travel','leadership')
or title like '[YB]%' and title like '%_[!?]'
order by 'Book Price' asc