

use master;
go
drop database if exists probna;
go
create database probna;
go
use probna;
go


create table ispitnirok(
sifra int not null primary key identity(1,1),
predmet varchar(50) not null,
vrstaIspita varchar(50),
datum datetime,
pristupio bit not null
);

create table pristupnici(
ispitnirok int not null references ispitnirok(sifra),
student varchar(50) not null,
brojbodova int,
ocijena int
);