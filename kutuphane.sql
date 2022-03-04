create database SKutuphane

use sKutuphane

create table tblTurlar(
ID int primary key identity (1,1) not null,
TurAd varchar(30) not null
)
insert into tblTurlar values('Basvuru'),('Bilgisayar'),('Edebiyat'),('Ders Kitabi')
go
create table tblYazaralr(
ID int primary key identity (1,1) not null,
AdSoyad varchar(30) not null,
Cinsiyet varchar(1),
DogumGunu date,
Tel varchar(11),
Mail varchar(50),
TurID int foreign key references tblTurlar(ID) on delete cascade
)

insert into tblYazaralr values
('Orhan Pamuk','E','1950-1-1','55555','Opamuk@com',1),
('Orhan Yamuk','E','1970-1-1','44444','Oyamuk777@com',2),
('Osman Pamuk','E','1960-1-1','48888','Opamuk777@com',3),
('Yasar Kemal','E','1980-1-1','87878','Kyasar777@com',4)



go
create table tblYayinevleri(
ID int primary key identity (1,1) not null,
Ad varchar(30) unique,
adres varchar(30),
Tel varchar(11),

)
insert into tblYayinevleri values
('Can YayinEvi','Beyoglu','178787'),
('YKY YayinEvi','Beyoglu','54541'),
('Nesin YayinEvi','Beyoglu','564554')


go
create table tblUyeler(
ID int primary key identity (1,1) not null,
AdSoyad varchar(30) ,
Cinsiyet varchar(1),
DogumTarihi date,
Tel varchar(11),
Mail varchar(50),
UyelikT date,
UyelikTipi int,
TcNo varchar(11),
Meslek varchar(30),
EDurumu int,
CDurumu bit
)
insert into tblUyeler (AdSoyad,Cinsiyet,UyelikTipi,EDurumu,CDurumu) values
('Ferhat Aldiverdi','E',1,3,0),
('Canan Gunacmaz','K',2,1,0),
('Ferhat Taygu','E',2,4,0),
('Sezen Aksu','E',2,4,0),
('Tarkan Tevedi','E',2,4,0)

go
create table tblKitaplar(
ISBN varchar(13) primary key  not null,

Ad varchar(30) ,
SayfaSayisi int,
StokSayisi int,
TurID int foreign key references tblTurlar(ID) on delete cascade,
YazarID int foreign key references tblYazaralr(ID),
YayinEviID int foreign key references tblYayinevleri(ID) on delete cascade

)
go
create table tblOdunc
(
ID int identity(1,1) primary key  not null,
UyeID int foreign key references tblUyeler(ID) on delete cascade,
 KitapISBN varchar(13) foreign key references tblKitaplar(ISBN) on delete cascade,
 VerilisTarihi date,
 TeslimTarihi date,
 Iptal bit
)
insert into tblKitaplar(ISBN,Ad,TurID,YazarID,YayinEviID) values
('1321','C# Programlamaya Giris',2,3,2),
('3243','Kara Kitap',3,1,2),
('1233','Vegan Olma Rehberi',4,2,1),
('1231','Göge Bakma',1,2,3),
('3233','E-Ticareti Kapilari',2,4,1)


go