use master;
go
drop database if exists nogomet;
go
create database nogomet;
go
use nogomet;
go


create table klubovi(
sifra int not null primary key identity(1,1),
naziv varchar(50) not null,
osnovan date,
stadion varchar not null,
drzava varchar not null,
liga varchar not null
);

create table igraci(
sifra int not null ,
ime varchar(50) not null,
prezime varchar(50) not null,
datumrodjenja date not null,
pozicija varchar ,
brojdresa varchar not null,
klub int not null references klubovi(sifra)
);

create table treneri(
sifra int not null,
ime varchar(50) not null,
prezime varchar(50) not null,
klub int not null references klubovi(sifra),
nacionalnost varchar ,
iskustvogodina int
);

create table utakmice(
sifra int not null,
datum date not null,
vrijeme time not null,
lokacija varchar,
stadion varchar ,
domaci_klub int not null references klubovi(sifra),
gostujuci_klub int not null references klubovi(sifra),
);