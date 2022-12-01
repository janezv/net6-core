IF DB_ID('ParentChildren') IS NULL
BEGIN
	create database ParentChildren;
	print N'DataBase Created';
END

IF DB_ID('ParentChildren') IS not NULL
BEGIN
	use [ParentChildren]
END

IF OBJECT_ID('Parent', 'U') IS NOT NULL 
	DROP TABLE Parent
IF OBJECT_ID('Parent', 'U') IS NULL 
BEGIN
 create table Parent(
 id int NOT NULL PRIMARY KEY,
 firstName varchar(40),
 lastName varchar(40),
)
END

