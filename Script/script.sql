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
documento int primary key,
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
horaInicio date not null,
horaFin date not null
);
go

create table horasExtraEmpleado(
documento int foreign key references empleado(documento) not null,
minutos int not null
);
go

create table farmaceutica(
nombre varchar(50) primary key,
direccionFiscal varchar(100) not null,
telefono varchar(7) not null,
correoElectronico varchar(25) not null
);
go

create table medicamento(
codigo varchar(50) primary key,
nombreFarmaceutica foreign key references farmaceutica(nombre) not null,
nombre varchar(8) not null,
descripcion varchar(100) not null,
precio money not null,
tipo varchar(13) not null check(UPPER(tipo)='CARDIOLOGICO' or UPPER(tipo)='DIABETICOS' or UPPER(tipo)='OTROS'),
stock int not null
);
go

create table pedido(
numero int primary key,
fechaRealizado date not null,
direccionEntrega varchar(100) not null,
estado int not null
);
go

create table medicamentosPedido(
numeroPedido int foreign key references pedido(numero) not null,
codigoMedicamento varchar(50) foreign key references medicamento(codigo) not null,
cantidad int not null
);