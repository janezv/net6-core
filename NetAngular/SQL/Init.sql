IF DB_ID('ParentChildren') IS NULL
BEGIN
	create database ParentChildren;
	print N'DataBase Created';
END

IF DB_ID('ParentChildren') IS not NULL
BEGIN
	use [ParentChildren]
END

--****************************************************************************************
--	Create tables


IF OBJECT_ID('Parent', 'U') IS NOT NULL 
begin
	DROP TABLE Children;
	DROP TABLE Parent;
end
IF OBJECT_ID('Parent', 'U') IS NULL 
BEGIN
 create table Parent(
 id int NOT NULL PRIMARY KEY,
 firstName varchar(40),
 lastName varchar(40),
)
END

IF OBJECT_ID('Children', 'U') IS NULL 
BEGIN
	 create table Children(
	 id int NOT NULL PRIMARY KEY,
	 firstName varchar(40),
	 lastName varchar(40),
	 dateofBirth date,
	 ParentId int not null FOREIGN KEY REFERENCES Parent(id)
)
END


--****************************************************************************************
--	fill the table

IF(EXISTS(SELECT 1 FROM dbo.Parent))
BEGIN
	delete from dbo.Children;
	delete from dbo.Parent;
	print('tabela je pobrisana')
END
ELSE
BEGIN
	insert into Parent values
	(1,'Parent1 fName','Parent1 lName'),
	(2,'Parent2 fName','Parent2 lName'),
	(3,'Parent3 fName','Parent3 lName');
	print('tabela Parent je napolnjena')
END;

IF(EXISTS(SELECT 1 FROM dbo.Children))
BEGIN
	delete from dbo.Children;
	print('tabela Children je pobrisana')
END
ELSE
BEGIN
	insert into Children values
	(1,'Otrok1 Ime','Otrok1 Priiimek','01-09-2004',1)
	,(2,'Otrok2 Ime','Otrok2 Priiimek','01-09-1994',1)
	,(3,'Otrok1 Ime','Otrok1 Priiimek','01-09-1998',2)
	,(4,'Otrok2 Ime','Otrok2 Priiimek','01-09-1999',2)
	,(5,'Otrok3 Ime','Otrok3 Priiimek','01-09-2000',2)
	,(6,'Otrok3 Ime','Otrok3 Priiimek','01-09-2002',3)
	,(7,'Otrok3 Ime','Otrok3 Priiimek','01-09-2002',3)
	,(8,'Otrok3 Ime','Otrok3 Priiimek','01-09-2002',3)
	,(9,'Otrok3 Ime','Otrok3 Priiimek','01-09-2002',3)
	,(10,'Otrok3 Ime','Otrok3 Priiimek','01-09-2002',3)
	print('tabela Children je napolnjena')
END;




