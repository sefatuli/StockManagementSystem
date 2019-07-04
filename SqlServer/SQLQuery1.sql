CREATE DATABASE StockManagementDB
--DROP DATABASE StockManagementDB

USE StockManagementDB

CREATE TABLE Categories
(
ID int IDENTITY(1,1),
Name VARCHAR(25)
)

-- DROP TABLE Categories

SELECT * FROM Categories

INSERT INTO Categories (Name)
VALUES ('Stationary')


CREATE TABLE Companies
(
ID int IDENTITY(1,1),
Name VARCHAR(25)
)

SELECT * FROM Companies