
use DB_A1FE94_BdHumanResources

--***********************************************************
--***********************************************************
--delete data of tables
delete from tblCities
delete from tblProvinces
delete from tblCountries
delete from tblDepartments
delete from tblPositions
delete from tblTitles
delete from tblEmployees
GO
--***********************************************************
--***********************************************************



--***********************************************************
--***********************************************************
--initial sequence of identity fields
DBCC checkident ('tblCities', reseed, 0)
GO
DBCC checkident ('tblProvinces', reseed, 0)
GO
DBCC checkident ('tblCountries', reseed, 0)
GO
DBCC checkident ('tblDepartments', reseed, 0)
GO
DBCC checkident ('tblPositions', reseed, 0)
GO
DBCC checkident ('tblTitles', reseed, 0)
GO
DBCC checkident ('tblEmployees', reseed, 0)
GO

--***********************************************************
--***********************************************************



--select * from tblCountries
insert into tblCountries values ('Canada');
insert into tblCountries values ('Usa');
GO

--select * from tblProvinces
insert into tblProvinces values ('Quebec', 1);
insert into tblProvinces values ('Ontario', 1);
insert into tblProvinces values ('New York', 2);
insert into tblProvinces values ('California', 2);
GO


--select * from tblCities
insert into tblCities values ('Montreal', 1);
insert into tblCities values ('Quebec city', 1);
insert into tblCities values ('Toronto', 2);
insert into tblCities values ('Otawa', 2);
insert into tblCities values ('New York city', 3);
insert into tblCities values ('Los Angeles', 4);
GO


--select * from tblDepartments
insert into tblDepartments values ('IT');
insert into tblDepartments values ('Accounting');
insert into tblDepartments values ('Finantial');
GO

--select * from tblPositions
insert into tblPositions values ('Junior Programer');
insert into tblPositions values ('CEO');
insert into tblPositions values ('Secretary');
GO

--select * from tblTitles
insert into tblTitles values ('Mr.');
insert into tblTitles values ('Miss');
insert into tblTitles values ('Mrs.');
GO


