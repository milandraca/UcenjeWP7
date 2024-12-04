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
naziv int not null references drzava(sifra),
drzava int not null references drzava(sifra)
);

create table mjesto(
sifra int not null primary key identity(1,1),
naziv varchar(30) not null,
brojposte int not null ,
regija varchar (50)
);

create table meteostanica( 
sifra int not null,
naziv varchar (50),
brzinavjetra int,
longitude DECIMAL(9,6),
temperatura decimal(3,1) ,
relativnavlaga decimal(4,2),
kolicinapadalinadan decimal(4,2),
kolicinapadalinamjesec decimal(5,2),
mjesto int references mjesto(sifra)
);
