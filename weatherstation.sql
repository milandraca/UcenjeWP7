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
sifra int not null,
naziv int not null references drzava(sifra),
drzava varchar(50) not null
);

create table mjesto(
sifra int not null primary key identity(1,1),
naziv varchar(20) not null,
brojposte varchar not null ,
drzava varchar(50)  primary key identity(1,1),
regija varchar (50) references regija(sifra)
);
