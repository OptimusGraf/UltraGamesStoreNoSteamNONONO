DROP DATABASE MyGameStore;
GO
CREATE DATABASE MyGameStore;
GO
USE MyGameStore;
GO

CREATE TABLE Users
(
	id INT IDENTITY  PRIMARY KEY,
	username nvarchar(20) UNIQUE,
	pasword nvarchar(20),
	moneyOfuser MONEY,
	age int ,
	PowerOfPC int,
	image VARBINARY(MAX)

)
CREATE TABLE Games
(
	id INT IDENTITY  PRIMARY KEY,
	nameOfGame nvarchar(20) UNIQUE,
	price MONEY,
	rate int,
	recAge int,
	release DATE ,
	author NVARCHAR(20) REFERENCES Users(username),
	powerOfPC INT,
	icon VARBINARY(MAX),
	imageOfGame VARBINARY(MAX)
)

CREATE TABLE UsersListOfGames
(
	id INT IDENTITY  PRIMARY KEY,
	UserId INT REFERENCES Users(Id),
	GamesId INT REFERENCES Games(Id),
	UNIQUE(UserId, GamesId),

	CountOfHour INT DEFAULT(0) ,
	Progress INT  DEFAULT(0) CHECK (Progress>=0 AND Progress<=100),
	isLoaded BIT  DEFAULT(0)
)

CREATE TABLE UsersListOfWanted
(
	UserId INT REFERENCES Users(Id),
	GamesId INT REFERENCES Games(Id),
	UNIQUE(UserId, GamesId)
)
CREATE TABLE UsersListBasket
(
	UserId INT REFERENCES Users(Id),
	GamesId INT REFERENCES Games(Id),
	UNIQUE(UserId, GamesId)
)
GO
INSERT Users (username,pasword,moneyOfUser,age,PowerOfPC) VALUES
('Optimus','prime',1000000, 20 ,60),
('xelcon','miror',300, 15,30),
('Fosker','assker',3000, 21,70),
('Persik','yalox',1000, 21,50);
INSERT Games (nameOfGame,price,rate,recAge,release,author,powerOfPc) VALUES
('Civil war',200,100,18,'2026-12-20','Persik',20),
('Anekdots',500,90,18,'2027-6-21','Persik',59),
('UltraAnektod',100,45,10,'2037-11-9','Persik',30),
('UltraMatan',200,70,16,'2017-6-11','Persik',50),
('Killeverehting',2000,20,18,'2047-2-11','Persik',90),
('gametop',1000,20,18,'2047-2-11','Persik',90);
GO
INSERT UsersListOfGames VALUES
(1,1,0,0,0)
USE master;