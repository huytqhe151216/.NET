drop database MovieTicketBooking
Create database MovieTicketBooking
use MovieTicketBooking
Create table Genre(
	GenreID int primary key,
	GenreName nvarchar(255)
)
Create table AgeLimit(
	AgeLimitID int primary key not null,
	Description nvarchar(255) not null
)
create table Movie(
	MovieID int primary key identity(1,1) not null,
	MovieName nvarchar(255) not null,
	Duration int not null,
	Actor nvarchar(255) not null,
	StartDate date not null,
	AgeLimit int references AgeLimit(AgeLimitID),
	Description nvarchar(max) not null,
	Trailer nvarchar(255) ,
	Status bit,
	Img varchar(255),
	Price float
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
------------------
Insert into Genre values(1,N'Hài'),(2,N'Hoạt hình'),(3,N'Phiêu lưu'),(4,N' Hành Động')
,(5,N'Thần thoại'),(6,N'Kinh Dị'),(7,N'Tình cảm'),(8,N'Tâm Lý'),(9,N'Khoa Học Viễn Tưởng'),(10,N'Bí ẩn'),(11,N'Gia đình')
-----------------------
Insert into Role values(1,'Customer'), (2,'Employee'), (3,'Manager')
-------------------------
--delete from Movie
Insert into Movie(MovieName, Duration,Actor,StartDate,AgeLimit,Description,Trailer, Status,Img,Price) values 
(N'THOR: TÌNH YÊU VÀ SẤM SÉT',118,'Chris Hemsworth, Tessa Thompson, Natalie Portman, Chris Pratt','08/07/2022',
4,N'Vốn từng là một chiến binh hùng mạnh của Asgard, trải qua vô số trận chiến lớn nhỏ nhưng sau sự kiện trong Avengers:
Endgame (2019) cùng vô số mất mát, Thần Sấm không còn muốn theo đuổi con đường siêu anh hùng. Từ đây, anh lên đường tìm ra
ý nghĩa của cuộc sống và nhìn nhận lại bản thân mình.',
N'6_dk-s57jck',1,'https://www.cgv.vn/media/catalog/product/cache/1/thumbnail/190x260/2e2b8cd282892c71872b9e67d2cb5039/t/h/thor-main-poster_1_.jpg',70000)
Insert into GenreMovie(MovieID, GenreID) values(1,4),(1,3),(1,5)

Insert into Movie(MovieName, Duration,Actor,StartDate,AgeLimit,Description,Trailer, Status,Img,Price) 
values (N'MINIONS: SỰ TRỖI DẬY CỦA GRU',88,'Steve Carell, Lucy Lawless, Michelle Yeoh...',
'01/07/2022',1,N'Rất lâu trước khi trở thành một phản diện chuyên nghiệp, Gru chỉ là một cậu bé 12 tuổi sống ở vùng ngoại ô vào những năm 1970, với ước mơ một ngày sẽ làm “bá chủ” thế giới. Và 3 “quả chuối” vàng biết đi từ trên trời rơi xuống đã là những đồng đội đầu tiên của Gru, bên cạnh ủng hộ cậu bé, cùng nhau thiết kế những vũ khí đầu tiên, thực hiện những phi vụ đầu tiên.',
N'dTQXlDV16SY',1,'https://www.cgv.vn/media/catalog/product/cache/1/thumbnail/190x260/2e2b8cd282892c71872b9e67d2cb5039/m/i/minions_2_-_kc_01.7.22_1__1.jpg',70000)
Insert into GenreMovie(MovieID, GenreID) values(2,2)

Insert into Movie(MovieName, Duration,Actor,StartDate,AgeLimit,Description,Trailer, Status, Img,Price) 
values (N'ĐIỆN THOẠI ĐEN',102,N'Ethan Hawke, Mason Thames, Madeleine McGraw, Jeremy Davies','06/24/2022',2,N'Finney Shaw, một cậu bé 13 tuổi nhút nhát nhưng thông minh, bị một kẻ giết người tàn bạo bắt cóc và nhốt trong một tầng hầm cách âm, nơi tiếng la hét trở nên vô ích. Khi một chiếc điện thoại bị ngắt kết nối trên tường bắt đầu đổ chuông, Finney phát hiện ra rằng cậu có thể nghe thấy giọng nói từ những nạn nhân trước đây của kẻ giết người. Và họ đã cố gắng đảm bảo rằng những gì đã xảy ra với họ không xảy ra với Finney.',
N'oJr_dYFUaCM',1,'https://www.cgv.vn/media/catalog/product/cache/1/thumbnail/190x260/2e2b8cd282892c71872b9e67d2cb5039/_/i/_i_n_tho_i_en_-_24.06.2022_2.jpg',70000)
Insert into GenreMovie(MovieID, GenreID) values(3,6)

Insert into Movie(MovieName, Duration,Actor,StartDate,AgeLimit,Description,Trailer, Status,Img,Price) 
values(N'PORORO: CUỘC PHIÊU LƯU ĐẾN ĐẢO KHỦNG LONG',79,'N/A','07/15/2022',1,N'Pororo và những người bạn tìm thấy chú khủng long nhỏ Alo đang ngủ say trong chiếc phi thuyền hình quả trứng. Alo không nhớ gì ngoài tên của mình. Khi Pororo và bạn bè giúp Alo sửa phi thuyền thì phi thuyền vụt sáng và biến mất cùng Alo và người bạn của Pororo là Crong. Pororo đuổi theo chiếc phi thuyền đến Đảo Khủng Long và chạm trán với Mr.Y, kẻ chuyên bắt cóc khủng long để bán cho người ngoài hành tinh. Để giải cứu bạn của mình, Pororo phải vượt qua nỗi sợ khủng long để chiến đấu với người ngoài hành tinh và đội quân người máy của Mr.Y.',
'DAQEluzF_ns',1,'https://www.cgv.vn/media/catalog/product/cache/1/thumbnail/190x260/2e2b8cd282892c71872b9e67d2cb5039/p/o/pororo_dinosaur_island_adventure-_vietnamese_poster_1_.jpg',70000)
Insert into GenreMovie(MovieID, GenreID) values(4,2)

Insert into Movie(MovieName, Duration,Actor,StartDate,AgeLimit,Description,Trailer, Status,Img,Price) 
values(N'THÁM TỬ LỪNG DANH CONAN: NÀNG DÂU HALLOWEEN',111,N'Minami Takayama, Chafûrin, Tôru Furuya',
'07/22/2022',4,N'Tại Shibuya náo nhiệt mùa Halloween, Thiếu úy Sato Miwako khoác lên mình chiếc váy cưới tinh khôi trong tiệc cưới như cổ tích, và người đàn ông bên cạnh cô không ai khác ngoài Trung sĩ Takagi Wataru. Trong giây phút trọng đại, một nhóm người xấu ập vào tấn công, Trung sĩ Takagi liều mình bảo vệ Sato. Anh tai qua nạn khỏi, nhưng Sato chết lặng khi nhìn thấy bóng ma Thần Chết trong giây phút sinh tử của Takagi. Điều này khiến cô nhớ lại cái chết của đồng nghiệp, cũng là người cô từng yêu trước đây, Thanh tra Matsuda Jinpei. Cùng lúc này, hung thủ của vụ đánh bom liên tiếp mà Matsuda điều tra năm xưa đã vượt ngục thành công. Khi Conan tìm đến Furuya Rei (hay Amuro Toru), người bạn cùng khóa với Matsuda, cậu được nghe câu chuyện liên quan đến vụ đánh bom với kẻ thủ ác mang bí danh "Plamya". Hôn lễ nguy hiểm nhất thế giới, buổi dạ hành đẫm máu tại Shibuya vào đêm Halloween sắp sửa bắt đầu.',
'SqSJPzWvcLc',1,'https://www.cgv.vn/media/catalog/product/cache/1/thumbnail/190x260/2e2b8cd282892c71872b9e67d2cb5039/c/o/conan_movie_2022-_vnese_poster_1_.jpg',75000)
Insert into GenreMovie(MovieID, GenreID) values(5,2)

Insert into Movie(MovieName, Duration,Actor,StartDate,AgeLimit,Description,Trailer, Status,Img,Price) 
values(N'LIÊN MINH SIÊU THÚ DC',106,N'Dwayne Johnson, Kevin Hart, Keanu Reeves',
'07/29/2022',1,N'Trong “Liên Minh Siêu Thú DC”, Siêu Cún Krypto và Superman là cặp bài trùng không thể tách rời, cùng sở hữu những siêu năng lực tương tự và cùng nhau chiến đấu chống lại tội phạm tại thành phố Metropolis. Khi Superman và những thành viên của Liên Minh Công Lý bị bắt cóc, Krypto phải thuyết phục cậu chàng Ace luộm thuộm, nàng Heo PB, Rùa Merton và Sóc Chip khai phá những sức mạnh tiềm ẩn và cùng nhau giải cứu các siêu anh hùng. “Liên Minh Siêu Thú DC” có sự góp giọng của bộ đôi ngôi sao nổi tiếng bậc nhất Hollywood Dwayne Johnson (lồng tiếng cho Siêu cún Krypto) và Kevin Hart (Superman). Đặc biệt, tài tử Keanu Reeves sẽ đảm nhận những câu thoại chất lừ đến từ Batman.','GrBRGS6Z-jI',1,'https://www.cgv.vn/media/catalog/product/cache/1/thumbnail/190x260/2e2b8cd282892c71872b9e67d2cb5039/p/o/poster_lmst_3_no_qr_code_1_.jpg',65000)
Insert into GenreMovie(MovieID, GenreID) values(6,2)

Insert into Movie(MovieName, Duration,Actor,StartDate,AgeLimit,Description,Trailer, Status,Img,Price) 
values(N'DÂN CHƠI KHÔNG SỢ CON RƠI',100,N'Tiến Luật, bé Bảo Thi, Huỳnh Phương, Nguyên Thảo, Vân Trang, Ngô Kiến Huy, Lê Khánh,...',
'07/29/2022',3,N'Quân, một dân chơi miệt vườn với tài “sát gái” thượng hạng, bỗng một ngày phải gánh lấy "cục nợ con rơi" từ bạn gái cũ. Được sự trợ giúp "ba phần đắc lực bảy phần phá đám" của Tám Mánh, Quân dần mất hết hy vọng tìm lại mẹ cho đứa bé và dần trở thành người cha hoàn hảo trong mắt Bé Thỏ. Cuộc sống đầy sắc màu và tiếng cười của hai cha con bị đặt trước thử thách lớn lao khi người mẹ mà Bé Thỏ ngày đêm mong ngóng cuối cùng cũng xuất hiện…',
'A4mSS-xmiMM',1,'https://www.cgv.vn/media/catalog/product/cache/1/thumbnail/190x260/2e2b8cd282892c71872b9e67d2cb5039/d/c/dckscr_teaser_poster_resz.jpg',90000)
Insert into GenreMovie(MovieID, GenreID) values(7,1),(7,8)

Insert into Movie(MovieName, Duration,Actor,StartDate,AgeLimit,Description,Trailer, Status,Img,Price)
values(N'ĐIỀU ƯỚC CUỐI CỦA TÙ NHÂN 2037',99,N'Hong Je Yi, Kim Ji Young, Kim Mi Hwa, Hwang Seok Jeong, Shin Eun Hung, Jeon So Min',
'07/29/2022',3,N'Ở tuổi 19, thay vì đến trường như bao bạn bè đồng trang lứa, Yoon-yeong phải nỗ lực hết mình để đi làm thêm kiếm tiền. Khao khát một cuộc sống tốt đẹp hơn cho mình và người mẹ khiếm thính, Yoon-yeong đặt mục tiêu thi đỗ kỳ thi công chức lên trên hết. Bất ngờ và trớ trêu thay, một sự cố khủng khiếp xảy ra, biến Yoon-yeong từ nạn nhân đáng thương trở thành kẻ giết người. Trong thời điểm tuyệt vọng và bất lực nhất, Yoon-yeong đã gặp những người chị em trong phòng giam số 12. Đằng sau mỗi người là một câu chuyện khác nhau, nhưng họ đã trao nhau tình yêu thương và niềm hy vọng để cùng hướng về một tương lai tươi sáng ngoài song sắt nhà tù.',
'1AXeEfyTLKs',1,'https://www.cgv.vn/media/catalog/product/cache/1/thumbnail/190x260/2e2b8cd282892c71872b9e67d2cb5039/m/g/mg_main-poster_layered_1_.jpg',75000)
Insert into GenreMovie(MovieID, GenreID) values(8,8)