create database bdACME
go
use bdACME
go
exec sp_addType codigo, 'bigint', 'not null'
go
create table Departamentos(
	Id codigo primary key,
	NombreDepartamento Varchar(50) not null
)
go
create table Usuarios(
	Id codigo primary key,
	Agencia varchar(30) not null,
	NroUsuarios Varchar(30) not null,
	IdDepartamento codigo references Departamentos(Id)
)
go
create table Gerencias(
	Id codigo primary key,
	NombreGerencia Varchar(30) not null
)
go
create table Periodos(
	Id codigo primary key,
	Periodo date not null,
)
go
create table Servicios(
	Id codigo primary key,
	NombreServicios Varchar(30) not null
)
go
create table Oficinas(
	Id codigo primary key,
	NombreOficina Varchar(40) not null
)
go
Create table AplicacionServicios(
	Id codigo primary key,
	NombreAplicacion Varchar(100) null,
	IdUsuarios codigo references Usuarios(Id),
	IdGerencias codigo references Gerencias(Id),
	IdPeriodos codigo references Periodos(Id),
	IdServicios codigo references Servicios(Id),
	IdOficinas codigo references Oficinas(Id)
)
go
insert into Departamentos(Id, NombreDepartamento) Values ('1', 'Santa Cruz');
insert into Departamentos(Id, NombreDepartamento) Values ('2', 'La Paz');


insert into Usuarios(Id, Agencia, NroUsuarios, IdDepartamento) Values ('1', 'Norte', '>1000', '1');


insert into Gerencias(Id, NombreGerencia) Values ('1', 'RRHH');
insert into Gerencias(Id, NombreGerencia) Values ('2', 'IT');
insert into Gerencias(Id, NombreGerencia) Values ('3', 'COMERCIAL');


insert into Periodos(Id, Periodo) Values ('1', '2017');
insert into Periodos(Id, Periodo) Values ('2', '2018');
insert into Periodos(Id, Periodo) Values ('3', '2019');

insert into Servicios(Id, NombreServicios) Values ('1', 'Pago de Planilla');
insert into Servicios(Id, NombreServicios) Values ('2', 'Envío SMS');

insert into Oficinas(Id, NombreOficina) Values ('1', 'Central');
insert into Oficinas(Id, NombreOficina) Values ('2', 'Local');