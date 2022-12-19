create database ClassWork12_16
use ClassWork12_16

create table Branches
(
	Id int identity primary key,
	Name nvarchar(20)
)

create table Positions
(	
	Id int identity primary key,
	Name nvarchar(20)
)
create table Products
(
	Id int identity primary key,
	Name nvarchar(20),
	PurchasePrice decimal(6,2),
	SalePrice decimal(6,2)
)
create table Employees
(
	Id int identity primary key,
	FullName nvarchar(20),
	Salary decimal(6,2),
	BranchId int references Branches(Id),
	PositionId int references Positions(Id)

)
create table Sales
(
	Id int identity primary key,
	SaleDate SmallDateTime,
	BranchId int references Branches(Id),
	EmployeeId int references Employees(Id),
	ProductId int references Products(Id)
)

--5-ci sorgu
select b.Name from(select s.BranchId,count(s.BranchId) as Counts from Sales as s
join Products as p
on s.ProductId=p.Id
where datediff(day, 1, getdate())<s.SaleDate
group by s.BranchId 
) as sp
join Branches as b
on sp.BranchId=b.Id
WHERE sp.Counts=(select max(Counts) from (select s.BranchId,count(s.BranchId) as Counts From Sales as s
join Products as p
on s.ProductId=p.Id
where datediff(day, 1, getdate())<s.SaleDate
group by s.BranchId 
) as sp)

--6-ci sorgu
select p.Name from(select s.ProductId,count(s.BranchId) as Counts from Sales as s
join Products as p
on s.ProductId=p.Id
where datediff(month, 1, getdate())<s.SaleDate
group by s.ProductId 
) as sp
join Products as p
on sp.ProductId=p.Id
WHERE sp.Counts=(select max(Counts) from (select s.ProductId,count(s.ProductId) as Counts From Sales as s
join Products as p
on s.ProductId=p.Id
where datediff(month, 1, getdate())<s.SaleDate
group by s.ProductId 
) as sp)








