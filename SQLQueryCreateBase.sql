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
	moneyOfUser MONEY,
	age int ,
	nameOfUser nvarchar(20),
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
	Author NVARCHAR(20) REFERENCES Users(username),
	PowerOfPC int,
	icon VARBINARY(MAX),
	imageOfGame VARBINARY(MAX)
)

CREATE TABLE UsersListOfGames
(
	id INT IDENTITY  PRIMARY KEY,
	UserId INT REFERENCES Users(Id),
	GamesId INT REFERENCES Games(Id),
	CountOfHour INT,
	Progress INT CHECK (Progress>=0 AND Progress<=100),
	isLoaded BIT 
)

CREATE TABLE UsersListOfWanted
(
	id INT IDENTITY  PRIMARY KEY,
	UserId INT REFERENCES Users(Id),
	GamesId INT REFERENCES Games(Id),
)
CREATE TABLE UsersListBasket
(
	id INT IDENTITY  PRIMARY KEY,
	UserId INT REFERENCES Users(Id),
	GamesId INT REFERENCES Games(Id),
)

GO 

INSERT Users ( username, pasword, moneyOfUser,age, nameOfUser, PowerofPC) VALUES
('Optimus', 'prime', 1000000, 20, 'Илья', 60 ),
('Xelcon', 'miror', 300, 15, 'Илья', 30 ),
('Fossket', 'assket', 3000, 21, 'Вадим', 70 ),
('Persik', 'yalox', 1000, 21, 'Рафаэль', 50 );

INSERT Games( nameOfGame, price, rate, recAge, release, Author, PowerOfPC)VALUES
('Cvil War',200, 100, 18,'20/12/2026', 'Persik', 20 ),
('Anekdots',500, 90, 18,'20/12/2023', 'Persik', 59 );


GO
USE base;