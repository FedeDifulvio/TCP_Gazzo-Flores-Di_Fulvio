Create database DiFulvio_Flores_Gazzo_DB

GO 
Use DiFulvio_Flores_Gazzo_DB
Go

Create Table ObraSocial(
    ID int primary key not null identity(1,1),
    Nombre varchar(50) not null,
)
Go
Create Table Especialidades(
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
IdObraSocial int not null foreign key references  ObraSocial (ID),
Estado bit default (1)
)
GO
create table Medicos(

ID int primary key not null identity (1,1),
Nombre varchar (50) not null,
Apellido varchar (50) not null,
Legajo varchar (5) not null unique,
Estado bit default (1),

)
GO
create table Dias  (

ID int primary key not null identity(1,1),
Nombre varchar(15) not null ,

)

GO
create table DiasPorMedico(

ID int primary key not null identity (1,1),
IdDia int not null foreign key references Dias(ID),
IdMedico int not null foreign key references Medicos(ID),
HoraInicio varchar(10) not null,
HoraFin varchar(10) not null
)
GO
create table EspecialidadesPorMedico(

ID int primary key not null identity (1,1),
IdEspecialidad int not null foreign key references Especialidades(ID),
IdMedicos int not null foreign key references Medicos(ID),

)
GO
create table ObraSocialesPorMedico(

ID int primary key not null identity (1,1),
IdObraSocial int not null foreign key references ObraSocial(ID),
IdMedicos int not null foreign key references Medicos(ID),

)


GO

create table turnos (

ID int primary key not null identity (1,1),
IdMedico int foreign key references Medicos(ID),
IdPaciente int foreign key references Pacientes(ID),
IdEspecialidad int foreign key references Especialidades(ID),
Fecha date not null,
Hora varchar(4) not null,
Observacion varchar(300) not null,
Estado varchar(20) not null,
)

SET IDENTITY_INSERT [dbo].[ObraSocial] ON 
INSERT [dbo].[ObraSocial] ([ID], [Nombre]) VALUES (1, N'OSDE')
INSERT [dbo].[ObraSocial] ([ID], [Nombre]) VALUES (2, N'Swiss Medical')
INSERT [dbo].[ObraSocial] ([ID], [Nombre]) VALUES (3, N'Omint')
INSERT [dbo].[ObraSocial] ([ID], [Nombre]) VALUES (4, N'Osecac')
INSERT [dbo].[ObraSocial] ([ID], [Nombre]) VALUES (5, N'Ioma')
SET IDENTITY_INSERT [dbo].[ObraSocial] OFF

SET IDENTITY_INSERT [dbo].[Especialidades] ON 
INSERT [dbo].[Especialidades] ([ID], [Nombre]) VALUES (1, N'Odontologia')
INSERT [dbo].[Especialidades] ([ID], [Nombre]) VALUES (2, N'Kinesiologia')
INSERT [dbo].[Especialidades] ([ID], [Nombre]) VALUES (3, N'Cardiologia')
INSERT [dbo].[Especialidades] ([ID], [Nombre]) VALUES (4, N'Urologia')
INSERT [dbo].[Especialidades] ([ID], [Nombre]) VALUES (5, N'Pediatria')
INSERT [dbo].[Especialidades] ([ID], [Nombre]) VALUES (6, N'Ginecologia')
INSERT [dbo].[Especialidades] ([ID], [Nombre]) VALUES (7, N'Dermatologia')
INSERT [dbo].[Especialidades] ([ID], [Nombre]) VALUES (8, N'Traumatologia')
INSERT [dbo].[Especialidades] ([ID], [Nombre]) VALUES (9, N'Otorrinolaringologia')
SET IDENTITY_INSERT [dbo].[Especialidades] OFF

SET IDENTITY_INSERT [dbo].[Pacientes] ON 

INSERT [dbo].[Pacientes] ([ID], [Nombre], [Apellido], [DNI], [Direccion], [FechaNacimiento], [Mail], [Telefono], [IdObraSocial]) VALUES (18, N'Carlos', N'Lopez', N'39888777', N'Calle falsa 123', CAST(N'1998-09-09' AS Date), N'crodriguez@gmail.com', N'15342312', 1)
INSERT [dbo].[Pacientes] ([ID], [Nombre], [Apellido], [DNI], [Direccion], [FechaNacimiento], [Mail], [Telefono], [IdObraSocial]) VALUES (19, N'Sergio', N'Aguero', N'23456789', N'Independiente 77', CAST(N'1990-08-10' AS Date), N'aaguero@gmail.com', N'1135347689', 1)
INSERT [dbo].[Pacientes] ([ID], [Nombre], [Apellido], [DNI], [Direccion], [FechaNacimiento], [Mail], [Telefono], [IdObraSocial]) VALUES (21, N'Lionel', N'Messi', N'67894323', N'Barcelona 567', CAST(N'1987-08-24' AS Date), N'lmessi@gmal.com', N'15678909', 2)
INSERT [dbo].[Pacientes] ([ID], [Nombre], [Apellido], [DNI], [Direccion], [FechaNacimiento], [Mail], [Telefono], [IdObraSocial]) VALUES (22, N'Juan', N'Lopez', N'254534213', N'Av.Peron 22', CAST(N'1980-11-11' AS Date), N'jlopez@gmail.com', N'15345678', 2)
INSERT [dbo].[Pacientes] ([ID], [Nombre], [Apellido], [DNI], [Direccion], [FechaNacimiento], [Mail], [Telefono], [IdObraSocial]) VALUES (23, N'Tomas', N'Gonzalez', N'33445566', N'Gral Diaz 556', CAST(N'1998-08-08' AS Date), N'tgonzalez@gmail.com', N'11234569', 2)
INSERT [dbo].[Pacientes] ([ID], [Nombre], [Apellido], [DNI], [Direccion], [FechaNacimiento], [Mail], [Telefono], [IdObraSocial]) VALUES (25, N'Julio', N'Hernandez', N'15346787', N'siberia 445', CAST(N'1950-08-12' AS Date), N'juhernandez@yahoo.com', N'155555543', 1)
INSERT [dbo].[Pacientes] ([ID], [Nombre], [Apellido], [DNI], [Direccion], [FechaNacimiento], [Mail], [Telefono], [IdObraSocial]) VALUES (26, N'Anastasia', N'Gomez', N'1256532', N'Ramos 334', CAST(N'1980-08-05' AS Date), N'agomez@gmial.com', N'1155443221', 3)
INSERT [dbo].[Pacientes] ([ID], [Nombre], [Apellido], [DNI], [Direccion], [FechaNacimiento], [Mail], [Telefono], [IdObraSocial]) VALUES (27, N'Maria', N'Fernandez', N'1135213454', N'Av.Santa Fé 10', CAST(N'1995-09-05' AS Date), N'mFernandez@gmail.com', N'1122679854', 3)
INSERT [dbo].[Pacientes] ([ID], [Nombre], [Apellido], [DNI], [Direccion], [FechaNacimiento], [Mail], [Telefono], [IdObraSocial]) VALUES (29, N'Maria', N'Simon', N'39887766', N'Alvear 56', CAST(N'1998-07-09' AS Date), N'msimon@gmail.com', N'23452312', 3)
INSERT [dbo].[Pacientes] ([ID], [Nombre], [Apellido], [DNI], [Direccion], [FechaNacimiento], [Mail], [Telefono], [IdObraSocial]) VALUES (30, N'Julieta', N'Ayala', N'39921387', N'Marconi 3456', CAST(N'1997-09-09' AS Date), N'jayala@gmail.com', N'11225643', 2)
INSERT [dbo].[Pacientes] ([ID], [Nombre], [Apellido], [DNI], [Direccion], [FechaNacimiento], [Mail], [Telefono], [IdObraSocial]) VALUES (31, N'Angel', N'Lopez', N'20986745', N'Lonardi 34', CAST(N'1945-09-08' AS Date), N'alopez@yahoo.com', N'4745-7865', 1)
INSERT [dbo].[Pacientes] ([ID], [Nombre], [Apellido], [DNI], [Direccion], [FechaNacimiento], [Mail], [Telefono], [IdObraSocial]) VALUES (32, N'Maximiliano', N'Gonzalez', N'29875623', N'Sucre 3456', CAST(N'1976-09-08' AS Date), N'mgonzalez@yahoo.com', N'11239098', 1)
INSERT [dbo].[Pacientes] ([ID], [Nombre], [Apellido], [DNI], [Direccion], [FechaNacimiento], [Mail], [Telefono], [IdObraSocial]) VALUES (33, N'Elias', N'Valenzuela', N'38097654', N'Pacheco 23', CAST(N'1997-08-06' AS Date), N'evalenzuela@gmail.com', N'153421565', 3)
INSERT [dbo].[Pacientes] ([ID], [Nombre], [Apellido], [DNI], [Direccion], [FechaNacimiento], [Mail], [Telefono], [IdObraSocial]) VALUES (34, N'Jose', N'Fernandez', N'234512134', N'las Heras 15', CAST(N'1978-08-09' AS Date), N'jfernandez@gmail.com', N'1534126789', 1)
INSERT [dbo].[Pacientes] ([ID], [Nombre], [Apellido], [DNI], [Direccion], [FechaNacimiento], [Mail], [Telefono], [IdObraSocial]) VALUES (35, N'Pablo', N'Escobar', N'34567656', N'Colombia 2345', CAST(N'1984-02-01' AS Date), N'pescobar@gmail.com', N'11345678', 4)
SET IDENTITY_INSERT [dbo].[Pacientes] OFF



SET IDENTITY_INSERT [dbo].[Dias] ON 
INSERT [dbo].[Dias] ([ID], [Nombre]) VALUES (1, N'Lunes')
INSERT [dbo].[Dias] ([ID], [Nombre]) VALUES (2, N'Martes')
INSERT [dbo].[Dias] ([ID], [Nombre]) VALUES (3, N'Miercoles')
INSERT [dbo].[Dias] ([ID], [Nombre]) VALUES (4, N'Jueves')
INSERT [dbo].[Dias] ([ID], [Nombre]) VALUES (5, N'Viernes')
INSERT [dbo].[Dias] ([ID], [Nombre]) VALUES (6, N'Sabado')
SET IDENTITY_INSERT [dbo].[Dias] OFF


SET IDENTITY_INSERT [dbo].[Medicos] ON 
INSERT [dbo].[Medicos] ([ID], [Nombre],[Apellido],[Legajo]) VALUES (1, N'Hernan',N'Crespo',N'D1111')
INSERT [dbo].[Medicos] ([ID], [Nombre],[Apellido],[Legajo]) VALUES (2, N'Javier',N'Saviola',N'B1112')
INSERT [dbo].[Medicos] ([ID], [Nombre],[Apellido],[Legajo]) VALUES (3, N'Samuel',N'Etto',N'C1141')
INSERT [dbo].[Medicos] ([ID], [Nombre],[Apellido],[Legajo]) VALUES (4, N'Marcelo',N'Gallardo',N'A1512')
INSERT [dbo].[Medicos] ([ID], [Nombre],[Apellido],[Legajo]) VALUES (5, N'Enzo',N'Perez',N'P9128')
SET IDENTITY_INSERT [dbo].[Medicos] OFF

SET IDENTITY_INSERT [dbo].[DiasPorMedico] ON 
INSERT [dbo].[DiasPorMedico] ([ID], [IdDia],[IdMedico],[HoraInicio],[HoraFin]) VALUES (1,1,1,N'9',N'13')
INSERT [dbo].[DiasPorMedico] ([ID], [IdDia],[IdMedico],[HoraInicio],[HoraFin]) VALUES (2,2,1,N'15',N'18')
INSERT [dbo].[DiasPorMedico] ([ID], [IdDia],[IdMedico],[HoraInicio],[HoraFin]) VALUES (3,3,1,N'9',N'13')
INSERT [dbo].[DiasPorMedico] ([ID], [IdDia],[IdMedico],[HoraInicio],[HoraFin]) VALUES (4,4,1,N'13',N'16')
INSERT [dbo].[DiasPorMedico] ([ID], [IdDia],[IdMedico],[HoraInicio],[HoraFin]) VALUES (5,5,1,N'9',N'13')
INSERT [dbo].[DiasPorMedico] ([ID], [IdDia],[IdMedico],[HoraInicio],[HoraFin]) VALUES (6,6,1,N'9',N'13')
INSERT [dbo].[DiasPorMedico] ([ID], [IdDia],[IdMedico],[HoraInicio],[HoraFin]) VALUES (7,1,2,N'10',N'14')
INSERT [dbo].[DiasPorMedico] ([ID], [IdDia],[IdMedico],[HoraInicio],[HoraFin]) VALUES (8,2,2,N'14',N'18')
SET IDENTITY_INSERT [dbo].[DiasPorMedico] OFF


SET IDENTITY_INSERT [dbo].[EspecialidadesPorMedico] ON 
INSERT [dbo].[EspecialidadesPorMedico] ([ID], [idEspecialidad], [idMedicos]) VALUES (1, 1,1)
INSERT [dbo].[EspecialidadesPorMedico] ([ID], [idEspecialidad], [idMedicos]) VALUES (2, 1,3)
INSERT [dbo].[EspecialidadesPorMedico] ([ID], [idEspecialidad], [idMedicos]) VALUES (3, 1,4)
INSERT [dbo].[EspecialidadesPorMedico] ([ID], [idEspecialidad], [idMedicos]) VALUES (4, 2,2)
INSERT [dbo].[EspecialidadesPorMedico] ([ID], [idEspecialidad], [idMedicos]) VALUES (5, 2,5)
INSERT [dbo].[EspecialidadesPorMedico] ([ID], [idEspecialidad], [idMedicos]) VALUES (6, 2,1)
INSERT [dbo].[EspecialidadesPorMedico] ([ID], [idEspecialidad], [idMedicos]) VALUES (7, 3,3)
INSERT [dbo].[EspecialidadesPorMedico] ([ID], [idEspecialidad], [idMedicos]) VALUES (8, 4,5)
INSERT [dbo].[EspecialidadesPorMedico] ([ID], [idEspecialidad], [idMedicos]) VALUES (9, 5,4)
SET IDENTITY_INSERT [dbo].[EspecialidadesPorMedico] OFF


SET IDENTITY_INSERT [dbo].[ObraSocialesPorMedico] ON 
INSERT [dbo].[ObraSocialesPorMedico] ([ID], [idObraSocial], [idMedicos]) VALUES (1, 1,1)
INSERT [dbo].[ObraSocialesPorMedico] ([ID], [idObraSocial], [idMedicos]) VALUES (2, 1,3)
INSERT [dbo].[ObraSocialesPorMedico] ([ID], [idObraSocial], [idMedicos]) VALUES (3, 2,2)
INSERT [dbo].[ObraSocialesPorMedico] ([ID], [idObraSocial], [idMedicos]) VALUES (4, 2,4)
INSERT [dbo].[ObraSocialesPorMedico] ([ID], [idObraSocial], [idMedicos]) VALUES (5, 3,3)
INSERT [dbo].[ObraSocialesPorMedico] ([ID], [idObraSocial], [idMedicos]) VALUES (6, 4,5)
INSERT [dbo].[ObraSocialesPorMedico] ([ID], [idObraSocial], [idMedicos]) VALUES (7, 5,1)
SET IDENTITY_INSERT [dbo].[ObraSocialesPorMedico] OFF

SET IDENTITY_INSERT [dbo].[turnos] ON 
INSERT [dbo].[Turnos] ([ID], [IdMedico],[IdPaciente],[IdEspecialidad],[Fecha],[Hora],[Observacion],[Estado]) VALUES (1,1,18,1,CAST(N'2021-07-15' AS Date),N'13',N'Solicitud de Turno',N'Asignado')
INSERT [dbo].[Turnos] ([ID], [IdMedico],[IdPaciente],[IdEspecialidad],[Fecha],[Hora],[Observacion],[Estado]) VALUES (2,1,19,1,CAST(N'1998-07-16' AS Date),N'13',N'Turno Urgente',N'Asignado')
INSERT [dbo].[Turnos] ([ID], [IdMedico],[IdPaciente],[IdEspecialidad],[Fecha],[Hora],[Observacion],[Estado]) VALUES (3,1,32,1,CAST(N'1998-07-23' AS Date),N'10',N'Lo mas pronto posible',N'Asignado')
INSERT [dbo].[Turnos] ([ID], [IdMedico],[IdPaciente],[IdEspecialidad],[Fecha],[Hora],[Observacion],[Estado]) VALUES (4,1,32,1,CAST(N'1998-07-24' AS Date),N'11',N'Sin Comentarios',N'Asignado')
INSERT [dbo].[Turnos] ([ID], [IdMedico],[IdPaciente],[IdEspecialidad],[Fecha],[Hora],[Observacion],[Estado]) VALUES (5,1,19,1,CAST(N'1998-07-17' AS Date),N'9' ,N'Solicito este turno',N'Asignado')
SET IDENTITY_INSERT [dbo].[turnos] OFF
