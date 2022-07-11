create database Lab2

create table Major(
	[code] char(5) primary key not null,
	[title] nvarchar(100),
)


create table Students(
	[id] int identity not null primary key,
	[name] nvarchar(100),
	[gender] bit,
	[dob] date,
	[major] char(5) foreign key references Major([code]),
	[active] bit,
	[scholarship] float,
)
insert into Major values ('SE',N'Software Engineering'), ('MM',N'Marketing'), ('DD',N'Design');
insert into  Students values 
(N'Nguyen Dinh Thang', 0, '05-08-2001', 'SE', 1, 25.5), 
(N'Nguyen Quoc Anh', 0, '05-08-2001', 'MM', 1, 70), 
(N'Nguyen Quoc Anh', 0, '05-08-2001', 'DD', 1, 50);