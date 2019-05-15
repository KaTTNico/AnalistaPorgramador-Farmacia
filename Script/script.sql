use master
go

--drop database if exists
if exists(select * from SysDataBases where name='BiosFarma')
begin
	drop database BiosFarma
end
go

--create database
create database BiosFarma
on(
	name=BiosFarma, filename='C:\BiosFarma.mdf'
)
go

create database BiosFarma
go

use master
go

create login [IIS APPPOOL\DefaultAppPool] from windows with default_database = master
go

use BiosFarma
go

create user [IIS APPPOOL\DefaultAppPool] from login [IIS APPPOOL\DefaultAppPool]
go

grant execute to [IIS APPPOOL\DefaultAppPool]
go

--create tables
create table usuario(
documento int primary key not null,
nombreUsuario varchar(15) unique not null,
pass varchar(7) not null check(pass like '[a-zA-Z][a-zA-Z][a-zA-Z][a-zA-Z][a-zA-Z][0-9][0-9]'),
nombreCompleto varchar(25) not null
);
go

create table encargado(
documento int foreign key references usuario(documento) not null,
telefono varchar(10) not null
);
go

create table empleado(
documento int foreign key references usuario(documento) not null,
horaInicio varchar(5) not null,
horaFin varchar(5) not null
);