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
	 ParentId int FOREIGN KEY REFERENCES Parent(id)
)
END

