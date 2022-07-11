drop database MovieTicketBooking
Create database MovieTicketBooking

Create table Genre(
	GenreID int primary key,
	GenreName nvarchar(255)
)
Create table AgeLimit(
	AgeLimitID int primary key not null,
	Description nvarchar(255) not null
)
create table Movie(
	MovieID int primary key,
	Duration int not null,
	Actor nvarchar(255) not null,
	StartDate date not null,
	AgeLimit int references AgeLimit(AgeLimitID),
	Description nvarchar(255) not null,
	Trailer nvarchar(255) ,
	Status bit
)
create table GenreMovie(
	GenreID int  references Genre(GenreID),
	MovieID int references Movie(MovieID),
	primary key (GenreID, MovieID) 
)
Create table Role(
	RoleID int primary key not null,
	RoleName varchar(20)
)
create table Account(
	AccountID int primary key not null identity(1,1),
	Email nvarchar(255),
	Password varchar(255),
	RoleID int references Role(RoleID),
)


Create table Customer(
	CustomerID int references Account(AccountID) primary key,
	CustomerName nvarchar(255),
	BalanceInWallet int ,
	Phone varchar(20),
	TotalTrade int 
)
create table Rating(
	RateID int primary key,
	MovieID int references Movie(MovieID),
	CustomerID int references Customer(CustomerID),
	Star int ,
	ContentRate nvarchar(255)
)
Create table Room(
	RoomID int primary key,
	Description nvarchar 
)
Create table Employee(
	EmployeeID int primary key not null identity(1,1),
	Name nvarchar(255) not null,
	Phone varchar(20),
)
Create table Manager(
	ManagerID int primary key not null identity(1,1),
	Name nvarchar(255) not null,
	Phone varchar(20),
)
Create table FavouriteList(
	ID int primary key identity(1,1) not null,
	CustomerID int references Customer(CustomerID),
	MovieID int references Movie(MovieID)
)
Create table Showtime(
	ShowtimeID int primary key identity(1,1) not null,
	RoomID int references Room(RoomID),
	MovieID int references Movie(MovieID), 
	[Date] date ,
	TimeFrom float,
	Type int
)
Create table ShowtimeOrder(
	OrderID int primary key identity(1,1) not null,
	MovieID int references Movie(MovieID), 
	[Date] date,
	TimeFrom float,
	CustomerID int references Customer(CustomerID),
	TypeOrder int not null,
	IsApproved bit not null ,
)
Create table Ticket(
	TicketID int primary key not null identity(1,1),
	ShowtimeID int references Showtime(ShowtimeID),
	CustomerID int references Customer(CustomerID),
	TimeOrder datetime default(getdate()),
	Place varchar(20),
	IsSold bit,
	Code varchar(20),
	EmployeeID int references Employee(EmployeeID),
)
Create table [Print](
	PrintID int primary key identity(1,1) not null,
	TicketID int references Ticket(TicketID),
	EmployeeID int references Employee(EmployeeID),
	IsPrinted bit not null
)

------------------
Insert into AgeLimit values(1,N'P - PHIM DÀNH CHO MỌI ĐỐI TƯỢNG'),
(2,N'C18 - PHIM CẤM KHÁN GIẢ DƯỚI 18 TUỔI'),
(3,N'C16 - PHIM CẤM KHÁN GIẢ DƯỚI 16 TUỔI'),
(4,N'C13 - PHIM CẤM KHÁN GIẢ DƯỚI 13 TUỔI')