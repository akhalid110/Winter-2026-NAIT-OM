--declare @min int = 6
--declare @max int = 7
select *
from Chinook.dbo.Track
where name = 'Innuendo'

declare @min int = 6
declare @max int = 7
select left(cast(TrackID as varchar(10)) + ': ' + [Name] + ' - ' +Composer,100) as 'Track Information' 
from Chinook.dbo.Track


