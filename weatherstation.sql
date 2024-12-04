use edunovawp7;

select * from smjerovi;
go
drop database if exists edunovawp7;
go
create database edunovawp7;
go
use edunovawp7;
go


create table drzava(
sifra int not null primary key identity(1,1), -- ovo je primarni kljuc
naziv varchar(50) not null
);

create table regija(
sifra int not null primary key identity(1,1),
naziv int not null references drzava(sifra),
drzava varchar(50) not null
);

create table mjesto(
sifra int not null primary key identity(1,1),
naziv varchar(20) not null,
brojposte varchar not null ,
drzava int not null references regija(sifra),
regija varchar (50)
);

create table meteostanica(
sifra int not null,
brzinavjetra int,
latitude DECIMAL(9,6),
longitude DECIMAL(9,6),
temperatura decimal(3,1) ,
relativnavlaga decimal(4,2),
kolicinapadalinadan decimal(4,2),
kolicinapadalinamjesec decimal(5,2),
mjesto int references mjesto(sifra)
);
