--DROP DATABASE IF EXISTS TPOT -- Funciona solo en SQL 2016
--GO

-- PRIMERO BORRAR LA BASE DE DATOS Y LUEGO CORRER ESTO ENTERO DE UNA.

USE master
GO

CREATE DATABASE TPOT
GO

USE TPOT
GO

--Creo las tablas--
create table Usuario
(IdUsuario int identity,
Nombre varchar(50) not null,
Apellido varchar(50) not null,
Email varchar(50) not null,
Alias varchar (50) not null,
Clave varchar(50) not null,
TipoDeUsuario int not null,
Sector int not null,
Activo varchar(3) not null,
primary key (IdUsuario),
)
go


create table TipoDeUsuario
(IdTipo int identity,
Nombre varchar(50) not null,
primary key (IdTipo) 
)
go

create table Sector(
IdSector int identity,
Nombre varchar(50) not null,
Descripcion varchar(300) not null,
Activo Varchar(3) not null,
primary key (idSector)
)
go


create table OrdenDeTrabajo(
IdOrden int identity,
Descripcion Varchar(300) not null,
FechaCreacion date not null,
FechaLimite date,
Justificacion varchar(300),
FechaInicio date,
FechaFin date,
Estado int not null,
Sector int not null,
Creador int not null,
Activo varchar(3) not null,
primary key (idOrden),
)
go

create table EstadoOrden(
IdEstado int identity,
Nombre varchar(50) not null,
primary key (IdEstado)
)
go

create table UsuarioOrden(
PersonalMant int,
Orden int)
go


--Asigno las FK--
--alter table UsuarioOrden
--add constraint FK_Usuario
--	foreign key (PersonalMant)
--	references Usuario (IdUsuario);
--go
--alter table UsuarioOrden
--add constraint FK_Orden
--	foreign key (Orden)
--	references OrdenDeTrabajo (IdOrden);
--go

alter table Usuario
add constraint FK_Tipo
  foreign key (TipoDeUsuario)
  references TipoDeUsuario (IdTipo);

go

alter table Usuario
add constraint FK_Sector
  foreign key (Sector)
  references Sector (IdSector);

go

alter table OrdenDeTrabajo
add constraint FK_Estado
  foreign key (Estado)
  references EstadoOrden (IdEstado);
go


alter table OrdenDeTrabajo
add constraint FK_Sector_Orden
  foreign key (Sector)
  references Sector (IdSector);
go


alter table OrdenDeTrabajo
add constraint FK_Creador
  foreign key (Creador)
  references Usuario (IdUsuario);
go


/*
add constraint NOMBRERESTRICCION
  foreign key (CAMPOCLAVEFORANEA)
  references NOMBRETABLA2 (CAMPOCLAVEPRIMARIA);
*/

--Creo los SP
create proc SP_ALTA_USUARIO
(@Nombre varchar(50),
@Apellido varchar(50),
@Email varchar (50),
@Alias varchar (50),
@Clave varchar(50),
@TipoUsuario int,
@Sector int)
as
	insert into Usuario values(@Nombre,@Apellido,@Email,@Alias,@Clave,@TipoUsuario,@Sector,'Si')
go


create proc SP_INICIO_SESION
(@Alias varchar (50),
@Clave varchar (50))
as 
select Alias, IdUsuario from Usuario where  Alias = @Alias and Clave = @Clave and Activo = 'Si'
go

create proc SP_LISTAR_SECTORES
as
select * from Sector
where Activo = 'Si'
go

create proc SP_LISTAR_ESTADO
as
select * from EstadoOrden
go

create proc SP_LISTAR_TIPO_USUARIO
as
select * from TipoDeUsuario
go

create proc SP_NUEVO_SECTOR
(@Nombre varchar(50),
@Descripcion varchar(300))
as 
insert into Sector values(@Nombre,@Descripcion, 'Si')
go

create proc SP_LISTAR_SECTORES_FILTRO
(@Filtro varchar(150) =null,
@Activo varchar(3) )
as
select S.IdSector 'Codigo', S.Nombre, S.Descripcion, S.Activo--Tengo que poner como lo llamo en la grid en este caso solo es diferente el codigo
from Sector S 
where  S.Nombre  like '%' + isnull(@Filtro,S.Descripcion)  +'%' and S.Activo = @Activo
 or
 S.Descripcion  like '%' + isnull(@Filtro,S.Descripcion)  +'%' and S.Activo = @Activo
 or
 S.IdSector  like '%' + isnull(@Filtro,S.Descripcion)  +'%' and S.Activo = @Activo
go


create proc SP_LISTAR_USUARIOS_FILTRO
(@Filtro varchar(150) =null, 
@Activo varchar(3))
as
	select U.IdUsuario, U.Nombre, U.Apellido,  U.Email,  TU.Nombre as 'Tipo de usuario', S.Nombre as 'Sector',U.Activo
	from Usuario U left join TipoDeUsuario TU on (U.TipoDeUsuario = TU.IdTipo)
	left join Sector S on(U.Sector = S.IdSector)
	where  

	U.Nombre like '%' + isnull(@Filtro,U.Nombre)  +'%' and U.Activo = @Activo
	or
	U.Apellido  like '%' + isnull(@Filtro,U.Apellido)  +'%' and U.Activo = @Activo
	or
	U.Email  like '%' + isnull(@Filtro,U.Email)  +'%' and U.Activo = @Activo
	or
	TU.Nombre  like '%' + isnull(@Filtro,TU.Nombre)  +'%' and U.Activo = @Activo
	or
	S.Nombre  like '%' + isnull(@Filtro,S.Nombre)  +'%' and U.Activo = @Activo
go


create proc SP_LISTAR_PERSONAL_MANT
as
select U.IdUsuario, U.Nombre, U.Apellido, U.Email, TU.Nombre 'Tipo'
from Usuario U left join TipoDeUsuario TU on (U.TipoDeUsuario = TU.IdTipo)
where TU.Nombre like '%Mant%' and U.Activo = 'Si'
go


create proc SP_LISTAR_USUARIOS_MODIFICAR
(@id int)
as
select U.IdUsuario, U.Nombre, U.Apellido,  U.Email,  TU.Nombre as 'Tipo de usuario', S.Nombre as 'Sector'
from Usuario U left join TipoDeUsuario TU on (U.TipoDeUsuario = TU.IdTipo)
left join Sector S on(U.Sector = S.IdSector)
where 
U.IdUsuario = @id
go

create proc SP_MODIFICAR_USUARIO
(@id int,
@email varchar(150),
@sector int,
@tipoUsuario int)
as
update Usuario
set Email = @email, TipoDeUsuario = @tipoUsuario, Sector = @sector
where IdUsuario = @id
go

create proc SP_ELIMINAR_USUARIO
(@id int)
as
update Usuario
set Activo = 'No'
where IdUsuario = @id
go


create proc SP_LISTAR_SECTOR_MODIFICAR
(@id int)
as
select Nombre, Descripcion
from Sector 
where IdSector = @id
go

create proc SP_ELIMINAR_SECTOR
(@id int)
as
update Sector
set Activo = 'No'
where IdSector = @id
go

create proc SP_MODIFICAR_SECTOR
(@id int,
@desc varchar(150)
)
as
update Sector
set Descripcion = @desc
where IdSector= @id
go


create proc SP_CODIGO_ORDEN
AS
	Select isnull(max(IdOrden), 0) as 'id' from OrdenDeTrabajo
go

create proc SP_USUARIO_CREADOR
(@id int)
as
Select Nombre, Apellido from Usuario
where @id = IdUsuario
go

create proc SP_ALTA_ORDEN
(@Desc varchar(300),
@FechaCreac date,
@FechaLim date,
@Justif varchar(300),
@Estado int,
@Sector int,
@Creador int)
as
insert into OrdenDeTrabajo values(@Desc,@FechaCreac,@FechaLim,@Justif,null,null,@Estado,@Sector,@Creador,'Si')
go

create proc SP_ORDEN_PERSONAL
(@idO int,
@idP int)
as
insert into UsuarioOrden values(@idP,@idO)
go

create proc SP_PERSONAL_ASIGNADO
(@idO int)
as
select U.IdUsuario, U.Nombre, U.Apellido, U.Email, TU.Nombre 'Tipo'
from Usuario U left join TipoDeUsuario TU on (U.TipoDeUsuario = TU.IdTipo)
left join UsuarioOrden UO on (U.IdUsuario = UO.PersonalMant)
where UO.Orden = @idO
go

create proc SP_CANCELAR_ORDEN
(@idO int)
as
delete from UsuarioOrden 
where @idO = Orden
go

create proc SP_LISTAR_ORDENES_FILTRO
(@Filtro varchar(150) = null,
@Activo varchar(3))
as
select O.IdOrden, O.Descripcion,O.FechaCreacion,O.FechaLimite,E.Nombre 'Estado', O.Activo
from OrdenDeTrabajo O left join EstadoOrden E on (O.Estado = E.IdEstado)
where 
O.IdOrden like '%' + isnull(@Filtro,O.IdOrden)  +'%' and O.Activo = @Activo
or
O.Descripcion like'%' + isnull(@Filtro,O.Descripcion)  +'%' and O.Activo = @Activo
or
O.FechaCreacion like'%' + isnull(@Filtro,O.FechaCreacion)  +'%' and O.Activo = @Activo
or
O.FechaLimite like'%' + isnull(@Filtro,O.FechaLimite)  +'%' and O.Activo = @Activo
or
E.Nombre like'%' + isnull(@Filtro,E.Nombre)  +'%' and O.Activo = @Activo
go

create proc SP_LISTAR_ORDEN_MODIFICAR
(@id int)
as
select * from OrdenDeTrabajo where IdOrden = @id
go

create proc SP_ESTADO_ORDEN
(@id int)
as
select * from EstadoOrden where IdEstado = @id
go

create proc SP_SECTOR_ORDEN	
(@id int)
as
select * from Sector where IdSector = @id
go


create proc SP_MODIFICAR_ORDEN
(@Id int,
@FechaIni date,
@FechaFin date,
@Estado int)
as
update OrdenDeTrabajo set 
FechaInicio= @FechaIni,
FechaFin= @FechaFin,
Estado= @Estado
where IdOrden = @Id
go

create proc SP_QUITAR_PERSONAL
(@id int)
as
delete from UsuarioOrden where PersonalMant = @id
go

create proc SP_ACTUALIZAR_PRINCIPAL
(@parametro varchar(50))
as
select isnull(Count(O.Estado),0) 'Cantidad'
from OrdenDeTrabajo O left join EstadoOrden E on(O.Estado = E.IdEstado)
where E.Nombre = @parametro and O.Activo = 'Si'
go

create proc SP_ELIMINAR_ORDEN
(@id int)
as
update OrdenDeTrabajo
set Activo = 'No'
where IdOrden = @id
go


--Cargamos datos en algunas tablas--
insert into TipoDeUsuario values ('Usuario')
go
insert into TipoDeUsuario values ('Administrador')
go
insert into TipoDeUsuario values ('Mantenimiento')
go


insert into Sector values ('Administracion', 'Sector de administracion de OT','Si')
Go

insert into Usuario values ('Juan', 'Perez','asd@mail.com','admin','admin',2,1,'Si')
Go
insert into Usuario values ('Manuel','Gonzalez','Man@mail.com','manuel','manuel',3,1,'Si')
go

insert into EstadoOrden values('Sin asignar')
insert into EstadoOrden values('Pendiente')
insert into EstadoOrden values('En curso')
insert into EstadoOrden values('Finalizada')
insert into EstadoOrden values('Rechazada')


/*create proc SP_INICIO_SESION_ALIAS
(@Alias varchar (50))
as 
select * from Usuario where  Alias = @Alias
go

create proc SP_INICIO_SESION_CLAVE
(@Clave varchar (50))
as 
select * from Usuario where  Clave = @Clave
go*/


/*drop table EstadoOrden
go
drop table OrdenDeTrabajo
go
drop table Sector
go
drop table TipoDeUsuario
go
drop table Usuario
go*/