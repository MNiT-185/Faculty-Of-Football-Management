create database qlgbd
use qlgbd


create table  Account(
	username char(20) primary key,
	pwd char(20)
)

create table Doi(
	lop nvarchar(20) primary key,
	sovongthang int default 0,
	diem int default 0
)

select * from doi
create table Thanhvien(
	mssv nvarchar(20) primary key,
	ten nvarchar(50),
	lop nvarchar(20),
	foreign key (lop) REFERENCES Doi(lop)
)


create table vongdau(
	mavongdau int primary key identity,
	tenvongdau nvarchar(20),
	diem int default 0,
)

create table chitietvongdau(
	mavongdau int,
	doi1 nvarchar(20),
	doi2 nvarchar(20),
	tyso nvarchar(20),
	doithang nvarchar(20),
	san nvarchar(20),
	thoigian datetime,
	primary key(mavongdau,doi1 ,doi2),
	foreign key (doi1) REFERENCES Doi(lop),
	foreign key (doi2) REFERENCES Doi(lop),
	foreign key (mavongdau) REFERENCES vongdau(mavongdau),
)

create table doiDacBiet(
	mavongdau int,
	doi nvarchar(20),
	primary key(mavongdau,doi),
	foreign key (doi) REFERENCES Doi(lop),
	foreign key (mavongdau) REFERENCES vongdau(mavongdau),
)


SELECT TOP 1 lop from doi where diem = 0 ORDER BY NEWID() 

select top(50) * from Doi ORDER BY diem DESC


insert into Account values('admin','123')

insert into Doi values('17050201',0,0)
insert into Doi values('17050202',0,0)
insert into Doi values('17050203',0,0)
insert into Doi values('17050204',0,0)
insert into Doi values('17050205',0,0)
insert into Doi values('17050206',0,0)
insert into Doi values('17050207',0,0)
insert into Doi values('17050208',0,0)
insert into Doi values('17050209',0,0)
insert into Doi values('17050210',0,0)



insert into Thanhvien values('51702165',N'Trần Phú Quý','17050201')
insert into Thanhvien values('51702166',N'Lê Minh Hiếu','17050201')
insert into Thanhvien values('51702183',N'Nguyễn Phùng Thanh','17050201')
insert into Thanhvien values('51702026',N'Lưu Thụy Kỳ','17050201')
insert into Thanhvien values('51702016',N'Đào Gia Hiệp','17050201')
insert into Thanhvien values('51702180',N'Phạm Duy Thái','17050201')
insert into Thanhvien values('51702181',N'Nguyễn Thành Đạt','17050201')
insert into Thanhvien values('51702182',N'Nguyễn Hoàng Phúc','17050201')

insert into Thanhvien values('51702111',N'Lê Minh Tín','17050202')
insert into Thanhvien values('51702112',N'Nguyễn Văn Di','17050202')
insert into Thanhvien values('51702113',N'Trần Mỹ Dung','17050202')
insert into Thanhvien values('51702014',N'Trần Hoài Trọng','17050202')
insert into Thanhvien values('51702015',N'Đoàn Thị Đoan Trang','17050202')
insert into Thanhvien values('51702116',N'Nguyễn Hữu Khánh','17050202')
insert into Thanhvien values('51702117',N'Võ Huyền Trân','17050202')
insert into Thanhvien values('51702118',N'Vũ Ngọc Kim Chi','17050202')


insert into Thanhvien values('51702121',N'Huỳnh Thị Lâm','17050203')
insert into Thanhvien values('51702122',N'Nguyễn Văn Xệ','17050203')
insert into Thanhvien values('51702123',N'Trần Văn Bo','17050203')
insert into Thanhvien values('51702024',N'Nguyễn Ngọc Ngân','17050203')
insert into Thanhvien values('51702025',N'Trần Hồng Ngọc','17050203')
insert into Thanhvien values('51702126',N'Nguyễn Hoài Luân','17050203')
insert into Thanhvien values('51702127',N'Nguyễn Văn Kỳ','17050203')
insert into Thanhvien values('51702128',N'Hoàng Kim Mỹ Linh','17050203')


insert into Thanhvien values('51702131',N'Trần Việt Linh','17050204')
insert into Thanhvien values('51702132',N'Huỳnh Anh Tôi','17050204')
insert into Thanhvien values('51702133',N'Lê Thị Bích','17050204')
insert into Thanhvien values('51702034',N'Cẩm Lan','17050204')
insert into Thanhvien values('51702035',N'Đỗ Duy Hiệp','17050204')
insert into Thanhvien values('51702136',N'Lê Nguyễn Gia Huy','17050204')
insert into Thanhvien values('51702137',N'Trần Thị Châu','17050204')
insert into Thanhvien values('51702138',N'Kiều Anh Minh','17050204')


insert into Thanhvien values('51702141',N'Diễm Trang','17050205')
insert into Thanhvien values('51702142',N'Bùi Anh Sang','17050205')
insert into Thanhvien values('51702143',N'Lê Dương Trọng','17050205')
insert into Thanhvien values('51702044',N'Hoàng Văn Điền','17050205')
insert into Thanhvien values('51702045',N'Lý Chí Toàn','17050205')
insert into Thanhvien values('51702146',N'Nguyễn Minh Tiến','17050205')
insert into Thanhvien values('51702147',N'Đoàn Văn Bơ','17050205')
insert into Thanhvien values('51702148',N'Thanh Nhân','17050205')


insert into Thanhvien values('51702151',N'Nguyễn Hải','17050206')
insert into Thanhvien values('51702152',N'Nguyễn Dương','17050206')
insert into Thanhvien values('51702153',N'Lý Thành Đạt','17050206')
insert into Thanhvien values('51702054',N'Lê Ngọc Lan Vy','17050206')
insert into Thanhvien values('51702055',N'Công Phượng','17050206')
insert into Thanhvien values('51702156',N'Văn Đoàn','17050206')
insert into Thanhvien values('51702157',N'Thành Đạt','17050206')
insert into Thanhvien values('51702158',N'Quốc An','17050206')


insert into Thanhvien values('51702161',N'Khánh Duy','17050207')
insert into Thanhvien values('51702162',N'Thanh Ngân','17050207')
insert into Thanhvien values('51702163',N'Duy Khánh','17050207')
insert into Thanhvien values('51702064',N'Hoàng Phúc','17050207')
insert into Thanhvien values('51702065',N'Nguyễn Đức Thắng','17050207')
insert into Thanhvien values('51702166',N'Chung Quang Phương','17050207')
insert into Thanhvien values('51702167',N'Đào Duy Từ','17050207')
insert into Thanhvien values('51702168',N'Sư Vạn Hạnh','17050207')



insert into Thanhvien values('51702171',N'Nguyễn Huệ','17050208')
insert into Thanhvien values('51702172',N'An Dương Vương','17050208')
insert into Thanhvien values('51702173',N'Trần Khánh Duy','17050208')
insert into Thanhvien values('51702074',N'Lý Trọng Kiệt','17050208')
insert into Thanhvien values('51702075',N'Trần Bá Khá','17050208')
insert into Thanhvien values('51702176',N'Đặng Phúc','17050208')
insert into Thanhvien values('51702177',N'Phùng Thanh Độ','17050208')
insert into Thanhvien values('51702178',N'Lý Văn Song','17050208')