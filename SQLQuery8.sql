USE [pruebaJulian]
GO
/****** Object:  Table [dbo].[Calificaciones]    Script Date: 4/08/2023 4:58:02 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Calificaciones](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Notas] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Calificaciones] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cursos]    Script Date: 4/08/2023 4:58:02 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cursos](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Cursos] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Cursos] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Estudiantes]    Script Date: 4/08/2023 4:58:02 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Estudiantes](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Apellido] [varchar](50) NOT NULL,
	[Telefono] [varchar](50) NULL,
	[curso] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Estudiantes] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Profesores]    Script Date: 4/08/2023 4:58:02 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Profesores](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Apellido] [varchar](50) NULL,
	[Especialidad] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Profesores] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Estudiantes] ON 
GO
INSERT [dbo].[Estudiantes] ([ID], [Nombre], [Apellido], [Telefono], [curso]) VALUES (1, N'Julian', N'Julian', N'3193232', N'decimo')
GO
SET IDENTITY_INSERT [dbo].[Estudiantes] OFF
GO
/****** Object:  StoredProcedure [dbo].[ActualizarEstudiantes]    Script Date: 4/08/2023 4:58:03 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[ActualizarEstudiantes] 

@ID int,
@Nombre varchar(50),
@Apellido varchar(50),
@Telefono varchar(50),
@Curso varchar(50)

as 
begin 

update estudiantes set Nombre=@Nombre,Apellido=@Apellido,Telefono=@Telefono,Curso=@Curso
where ID =@ID
END;
GO
/****** Object:  StoredProcedure [dbo].[ActualizarProfesores]    Script Date: 4/08/2023 4:58:03 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[ActualizarProfesores] 

@ID int,
@Nombre varchar(50),
@Apellido varchar(50),
@Especialidad varchar(50)

as 
begin 

update Profesores set Nombre=@Nombre,Apellido=@Apellido,Especialidad=@Especialidad
where ID =@ID

END;
GO
/****** Object:  StoredProcedure [dbo].[BuscarEstudiante]    Script Date: 4/08/2023 4:58:03 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[BuscarEstudiante]

as 
begin 

select*from estudiantes

end;
GO
/****** Object:  StoredProcedure [dbo].[BuscarProfesor]    Script Date: 4/08/2023 4:58:03 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[BuscarProfesor]

as 
begin 

select*from Profesores

end;
GO
/****** Object:  StoredProcedure [dbo].[EliminarEstudiantes]    Script Date: 4/08/2023 4:58:03 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[EliminarEstudiantes]

@ID int 

as 
BEGIN
delete from estudiantes 
where ID=@ID

END;
GO
/****** Object:  StoredProcedure [dbo].[EliminarProfesores]    Script Date: 4/08/2023 4:58:03 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[EliminarProfesores]

@ID int 

as 
BEGIN
delete from Profesores 
where ID=@ID
END;
GO
/****** Object:  StoredProcedure [dbo].[InsertarEstudiantes]    Script Date: 4/08/2023 4:58:03 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[InsertarEstudiantes]


@Nombre varchar(50),
@Apellido varchar(50),
@Telefono varchar(50),
@Curso varchar(50)



as
begin

insert into estudiantes (Nombre,Apellido,Telefono,Curso) values (@Nombre,@Apellido,@Telefono,@Curso)
End;
GO
/****** Object:  StoredProcedure [dbo].[InsertarProfesores]    Script Date: 4/08/2023 4:58:03 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[InsertarProfesores]


@Nombre varchar(50),
@Apellido varchar(50),
@Especialidad varchar(50)

as
begin

insert into Profesores (Nombre,Apellido,Especialidad) values (@Nombre,@Apellido,@Especialidad)
End;
GO
