CREATE DATABASE StockManagementDB
--DROP DATABASE StockManagementDB

--USE StockManagementDB

CREATE TABLE Categories
(
ID int IDENTITY(1,1),
Name VARCHAR(25)
)

-- DROP TABLE Categories

SELECT * FROM Categories


--CREATE TABLE Companies
--(
--ID int IDENTITY(1,1),
--Name VARCHAR(25)
--)

SELECT * FROM Companies
GO
CREATE TABLE Item
(
	ID int IDENTITY(1,1),
	Name varchar(25),
	ReorderLevel int,
	CategoryID int,
	CompanyID int
)
GO

CREATE TABLE StockIn
(
ID int IDENTITY(1,1),
ItemID int,
InQty int,
Date varchar(20)
)
GO
select * from StockIn

GO

CREATE TABLE StockOut
(
ID int IDENTITY(1,1),
ItemID int,
Qty int,
Status varchar(20),
Date varchar(20)
)
GO