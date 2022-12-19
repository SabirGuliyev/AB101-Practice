CREATE DATABASE AB101Test
USE AB101Test

CREATE TABLE Groups
(
 Id int identity primary key,
 Name nvarchar(10)
)

CREATE TABLE Students
(
 Id int identity primary key,
 Name nvarchar(15),
 GroupId int references Groups(Id) 
)

SELECT s.Id, s.Name,g.Name as 'Group Name' FROM Students as s
inner join Groups as g
on s.GroupId=g.Id