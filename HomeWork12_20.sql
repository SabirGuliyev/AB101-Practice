CREATE DATABASE Spotifyshahnaz
--USE Spotifyshahnaz
CREATE TABLE Roles
(
	ID int identity primary key,
	Type varchar(40) CHECK(Len(Type)>2) 
)
CREATE TABLE Users
(
	ID int identity primary key,
	Name varchar(20) CHECK(len(Name)>=2) NOT NULL,
	Surname varchar(30) CHECK(len(Surname)>=3) Default 'XXX',
	Username varchar(30) CHECK(len(Username)>=6) NOT NULL UNIQUE,
	Password varchar(30) CHECK(len(Password)>=8) NOT NULL,
	Gender varchar(5),
	RolesId int REFERENCES Roles(ID)
)
CREATE TABLE Artists
(
	ID int identity primary key,
	Name nvarchar(20) CHECK(len(Name)>=2) Default 'unknown',
	Surname nvarchar(30) CHECK(len(Surname)>=3),
	Birthday datetime,
	Gender nvarchar(5)
)
CREATE TABLE Playlists
(
	ID int identity primary key,
	Name varchar(25) CHECK(len(Name)>=1) NOT NULL,
	UsersID int REFERENCES Users(ID)
)
CREATE TABLE Categories
(
	ID int identity primary key,
	Name nvarchar(20) CHECK(len(Name)>=2) UNIQUE
)
CREATE TABLE Musics
(
	ID int identity primary key,
	Name nvarchar(20) CHECK(len(Name)>=2),
	Duration int CHECK(Duration>1),
	CategoriesId int REFERENCES Categories(ID)
)
CREATE TABLE Allmusics
(
	ID int identity primary key,
	MusicsID int REFERENCES Musics(ID),
	ArtistsID int REFERENCES Artists(ID)
)
CREATE TABLE PlaylistMusics
(
	ID int identity primary key,
	PlaylistsID int REFERENCES Playlists(ID),
	AllmusicsID int REFERENCES Allmusics(ID)
)

INSERT INTO Roles Values
(N'admin'),
(N'user'),
(N'premium user')

INSERT INTO Users VALUES
('Shahnaz','Mammadova','Shahnazmmmdva','Shahnaz123','woman',1),
('Ulviyya','Naghizada','Ulviyyanagh','32747781','woman',2),
('Asmar','Cafarova','asmar2003','83984127','woman',3),
('Ehtiram','Shukurov','Etikosh20','EhtiCPU2020','man',3),
('Fateh','Aliverdiyev','aliverdifateh','99483748973','man',2),
('Elxan','Mammadli','ElxanPasha','elish28832','man',2),
('Shamil','Omarov','Shamil_omarov','3y872892','man',2)

INSERT INTO Artists VALUES
('Ariana','Grande',26/06/1993,'woman'),
('Taylor','Swift',13/12/1989,'woman'),
('Shawn','Mendes',08/08/1998,'man'),
('Dua','Lipa',22/08/1995,'woman'),
('Rihanna',Null,20/02/1988,'woman'),
('The Weeknd',NULL,16/02/1990,'man')

INSERT INTO Categories VALUES
('Rock'),
('Jazz'),
('Classical music'),
('Blues'),
('Pop music')

INSERT INTO Musics VALUES
('7 rings',185,1),
('Save your Tears',205,4),
('Save your Tears',249,2),
('Smells Like Spirit',250,3),
('As It Was',227,3),
('Billie Jean',184,5),
('Stayin’ Alive',221,2),
('I Will Survive',312,4),
('Sweet Child O’Mine',287,5),
('Scream And Shout',304,1),
('Santeria',263,3),
('Alright',234,4),
('Blurred Lines',410,5)

INSERT INTO Allmusics VALUES
(13,7),
(11,3),
(14,5),
(17,3),
(9,2),
(7,5),
(6,3),
(10,4),
(8,7),
(12,7),
(13,3)

INSERT INTO Playlists VALUES
('my favorites',5),
('best musics',7)

INSERT INTO PlaylistMusics VALUES
(2,2),
(2,2),
(2,2),
(2,2),
(2,2),
(2,2)

1. Mahnını adını, uzunluğunu, kateqoriyasını, hansı ifaçı tərəfindən
 oxunulduğunu bildirən sorğunu özündə saxlayan uptadeable view yazın
CREATE VIEW vw_musics as 
SELECT m.Name Music,m.Duration,c.Name Category,a.Name Artist FROM Allmusics as allm
JOIN Musics as m 
on allm.MusicsID=m.ID
JOIN Artists as a
on allm.ArtistsID=a.ID
JOIN Categories as c
on m.CategoriesId=c.ID

2.Verilmiş istifadəçinin playlistinə əlavə etdiyi mahnıların siyahısını çıxarın
SELECT Users.Username,Playlists.Name,Musics.Name FROM PlaylistMusics as pm
JOIN Playlists on pm.PlaylistsID=Playlists.ID
JOIN Allmusics on pm.AllmusicsID=Allmusics.ID
JOIN Musics on Allmusics.MusicsID=Musics.ID
JOIN Users on Playlists.UsersID=Users.ID


3. Mahnıları uzunluğuna görə sıralayın

SELECT m.Name,m.Duration FROM Musics as m
ORDER BY Duration

--4.Saytda ən çox mahnı çıxaran ifaçını(ları) seçin

CREATE PROCEDURE  usp_CreateMusic (@Name nvarchar(25),@Duration int,@CategoriesID int) 
AS
BEGIN
	INSERT INTO Musics VALUES (@Name,@Duration,@CategoriesID)
END
EXEC usp_CreateMusic 'ahajhga',123,3

CREATE PROCEDURE usp_CreateCategory(@Name nvarchar(20))
AS
BEGIN
	INSERT INTO Categories VALUES (@Name)
END
EXEC usp_CreateCategory 'Classic music'

ALTER TABLE Musics ADD DeleteTime datetime

CREATE TRIGGER UpdateInsteadOfDelete 
on Musics
INSTEAD OF DELETE
AS
BEGIN
	DECLARE @Id int,@DateTime datetime
	SELECT @Id = ID, @DateTime = DeleteTime from deleted
	IF  @DateTime IS NULL
		UPDATE Musics
		SET DeleteTime = getutcdate()
		WHERE ID = @Id
	ELSE
		DELETE Musics
		WHERE ID = @Id
END

DELETE Musics 
WHERE ID = 2
SELECT * FROM Musics


create procedure usp_CreateUser (@Name varchar(20),
@Surname varchar(30),@Username varchar(30),
@Password varchar(30),@Gender varchar(5),@RolesId int)
as
begin
	if @Name is not null
		insert into Users values  (@Name,@Surname,@Username,@Password,@Gender,@RolesId)
	select * from Users
end

exec usp_CreateUser 'Ruslan','Rzayev','dfdfdfdf','1234byyg5','Kisi',1
