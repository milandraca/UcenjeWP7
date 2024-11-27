

use master;
go
drop database if exists probna;
go
create database probna;
go
use probna;
go


create table ispitnirok(
sifra int,
predmet varchar(50),
vrstaIspita varchar(50),
datum datetime,
pristupio bit
);

create table pristupnici(
ispitnirok bit,
student varchar(50),
brojbodova int,
ocijena int
);