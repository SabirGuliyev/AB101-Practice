create database spotify
use spotify

create table Roles
(
	Id int identity primary key,
	Type nvarchar(25) Not Null check(len(Type)>0)
)

Insert into Roles Values
(N'Admin'),
(N'Superadmin'),
(N'Moderator')

create table Users
(
	Id int identity primary key,
	Name nvarchar(25) Not Null check(len(Name)>2),
	Surname nvarchar(25) Not Null check(len(Surname)>5),
	Username nvarchar(35) Not Null unique check(len(Username)>5) ,
	Password nvarchar(35) Not Null  check(len(Password)>5),
	Gender nvarchar(15) Not Null  check(len(Gender)>3),
	RoleId int references Roles(Id)

)



create table Artists
(
	Id int identity primary key,
	Name nvarchar(25) Not Null check(len(Name)>2),
	Surname nvarchar(25) Not Null check(len(Surname)>5),
	Birthday date,
	Gender nvarchar(15) Not Null  check(len(Gender)>3)
	
)

create table Categories
(
	Id int identity primary key,
	Name nvarchar(25) Not Null unique check(len(Name)>0)
)

create table Musics
(
	Id int identity primary key,
	Name nvarchar(25) Not Null  check(len(Name)>0),
	Duration int ,
	CategoryId int references Categories(Id)
)

create table Playlists
(
	Id int identity primary key,
	Name nvarchar(25) not null Check(len(Name)>0),
	UserId int references Users(Id)
)

create table MusicPlaylists
(
	Id int identity primary key,
	MusicId int references Musics(Id),
	PlaylistId int references Playlists(Id)
)

create table MusicArtists
(
	Id int identity primary key,
	MusicId int references Musics(Id),
	ArtistId int references Artists(Id)
)


---Query 1---
create view vw_MusicInfo
as
select msc.Name [Music Name], ctg.Name [Category], msc.Duration, art.Name from MusicArtists as mscart
Join Musics as msc
on mscart.MusicId = msc.Id
Join Artists as art
on mscart.ArtistId = art.Id
Join Categories as ctg
on msc.CategoryId = ctg.Id

select * from vw_MusicInfo

--- Query 2 ---
Select u.Username, mcs.name, pl.Name [PlayList] from MusicPlaylists as mpl
join Musics as mcs
On mpl.MusicId=mcs.Id
join Playlists as pl
On mpl.PlaylistId=pl.Id
join Users as u
On pl.UserId=u.Id





