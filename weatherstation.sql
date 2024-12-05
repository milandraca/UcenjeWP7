use master;
go

drop database if exists weatherstation;
go
create database weatherstation;
go
use weatherstation;
go


create table drzava(
sifra int not null primary key identity(1,1), -- ovo je primarni kljuc
naziv varchar(50) not null
);

create table regija(
sifra int not null primary key identity(1,1),
naziv varchar (50) not null ,
drzava int not null references drzava(sifra)
);

create table mjesto(
sifra int not null primary key identity(1,1),
naziv varchar(30) not null,
brojposte int,
regija int  not null references regija(sifra)
);

create table meteostanica( 
sifra int not null primary key identity(1,1),
naziv varchar (50) not null,
brzinavjetra int,
longitude DECIMAL(9,6),
latitude DECIMAL(9,6),
temperatura decimal(3,1) ,
relativnavlaga decimal(4,2),
kolicinapadalinadan decimal(4,2),
kolicinapadalinamjesec decimal(5,2),
mjesto int not null references mjesto(sifra)
);


-- 1 (Ovo je šifra koju je dodjelila baza)
insert into drzava 
(naziv) values
('Hrvatska');

insert into drzava(naziv) values
-- 2
('Srbija');



insert into regija (naziv, drzava) values
-- 1
('Osječko-baranjska županija',1 ),
-- 2
('Vojvodina',2 );

insert into mjesto(naziv, brojposte, regija) values
('Jagodnjak',null,1 ),
('Novi Sad',null, 2);


insert into meteostanica (naziv, brzinavjetra, longitude, latitude, temperatura, relativnavlaga, kolicinapadalinadan, kolicinapadalinamjesec, mjesto) 
values 
('GW1101', NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1),
('WH2650A', NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2),
('GW2001', NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1);


select * from meteostanica;

