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





----------------------------

create table Dias  (

ID int primary key not null identity(1,1),
Nombre varchar(15) not null ,

)

create table Medicos(

ID int primary key not null identity (1,1),
Nombre varchar (50) not null,
Apellido varchar (50) not null,
Legajo varchar (5) not null unique,
Estado bit default (1),

)



create table DiasPorMedico(

ID int primary key not null identity (1,1),
IdDia int not null foreign key references Dias(ID),
IdMedico int not null foreign key references Medicos(ID),

)

create table EspecialidadesPorMedico(

ID int primary key not null identity (1,1),
IdEspecialidad int not null foreign key references Especialidades(ID),
IdMedicos int not null foreign key references Medicos(ID),

)

create table ObraSocialesPorMedico(

ID int primary key not null identity (1,1),
IdObraSocial int not null foreign key references ObraSocial(ID),
IdMedicos int not null foreign key references Medicos(ID),

)