create database sRehber


create table tblKisiler
(
ID int identity(1,1) not null,
Ad varchar(20) not null,
Soyad varchar(20) not null,
Cinsiyet char(1) not null,
Telefon nchar(11) not null,
primary key(ID)
)
use sRehber
insert into tblKisiler
values
('Haluk','Levent','E','05527402035'),
('Seren','Günacti','K','05527402075'),
('Kemal','Levent','E','05527402735'),
('Saide','Kül','K','05527402055'),
('Mahir','Cakmak','E','05527402095'),
('Canan','Solak','K','05527402035')

