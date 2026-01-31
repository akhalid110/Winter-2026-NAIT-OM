use adhillon45
go

drop database if exists adhillon45_Restauraunt
go

create database adhillon45_Restauraunt
go

use adhillon45_Restauraunt
go


create table RestaurantServers
(
   ServerId int identity 
   constraint PK_ServerId
   primary key Clustered,
   FullName nvarchar(50) not null
)
create table Bills
(  
   BillId int identity Primary key,
   TableNum int not null,
   GuestCount int null,
   ServerId int not null
   constraint FK_ServerID_ServerID
   foreign key references RestaurantServers (ServerId),
   BillAmount money not null
   )