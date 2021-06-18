Create database DiFulvio_Flores_Gazzo_DB

GO 
Use DiFulvio_Flores_Gazzo_DB
Go

Create Table ObraSocial(
	ID int primary key not null identity(1,1),
	Nombre varchar(50) not null,
)

Go

Create Table Pacientes(
ID int primary key not null identity (1,1),
Nombre varchar (30) not null,
Apellido varchar (30) not null,
DNI varchar (15) not null,
Direccion varchar (50) not null,
FechaNacimiento Date not null,
Mail varchar (50) not null,
Telefono varchar (20) not null,
IdObraSocial int not null foreign key references  ObraSocial (ID)
)


insert into ObraSocial values('OSDE')
insert into ObraSocial values('Swiss Medical')
insert into ObraSocial values('Omint')
insert into ObraSocial values('Osecac')
insert into ObraSocial values('Ioma')




insert into Pacientes values('Juan Cruz','Lopez','40033808','Av. Siempre Viva 401','1996-05-05','lopezjuan@gmail.com','1522232425',2)
insert into Pacientes values('Jorge Luis','Gutierrez','30033808','Av. Italia 1400','1980-06-10','jgutierrez@gmail.com','1533453628',3)
insert into Pacientes values('Martin','Rodriguez','43025507','Corrientes 401','2000-10-20','martin_rodriguez@gmail.com','1132233005',1)
select * from Pacientes




select P.ID,P.Nombre,P.Apellido, P.DNI, P.Direccion, P.FechaNacimiento, P.Mail, P.Telefono, O.Nombre as ObraSocial from Pacientes P
inner join ObraSocial O on P.IdObraSocial=O.ID
