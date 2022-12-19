--create database Task12_16
--use Task12_16



--create table Roles
--(
--	Id int identity primary key,
--	Name nvarchar(20) unique not null check(len(Name) > 3 and len(Name) < 18)
--)
--create table Users
--(
--	Id int identity primary key,
--	Username nvarchar(18) not null unique,
--	Password nvarchar(20) check(len(Password) > 3),
--	RoleId int references Roles(Id)
--)

--insert into Users values (N'Seyid',N'4145',3)
--insert into Roles values (N'Moderator')

--select Users.Id,Roles.Name [Role Name],Users.Username,Users.Password from Users, Roles
--where Users.RoleId = Roles.Id

--select Users.Id,Roles.Name [Role Name],Users.Username,Users.Password from Users join Roles
--on Users.RoleId = Roles.Id

--delete from Users where Id = 3


--CREATE DATABASE Market
--USE Market
--CREATE TABLE Categories
--(
--ID int identity primary key,
--Name nvarchar(25) CHECK(len(Name)>3) UNIQUE,
--SubcategoryID int 
--)
--INSERT INTO Categories VALUES
--(N'Un məmulatları',null),
--(N'Şirniyyatlar',1)

--SELECT Categories.Name as category,Subcategory.Name as subcategory FROM Categories
--JOIN Categories as Subcategory 
--on Categories.ID=Subcategory.SubcategoryID


create table Exams
(
  Id int identity primary key,
  Name nvarchar(20),
  MinPoint int,
)
create table Students
(
  Id int identity primary key,
  Name nvarchar(20),
  Result int,
)


select s.Name,e.Name from Exams as e, Students as s
