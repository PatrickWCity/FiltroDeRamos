Create Database [Ramito]
GO
USE [Ramito]
GO
/****** Object:  Table [dbo].[Carrera]    Script Date: 11/12/2017 10:08:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Carrera](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](60) NOT NULL,
	[descripcion] [varchar](255) NULL,
 CONSTRAINT [PK_Carrera] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Detalle]    Script Date: 11/12/2017 10:08:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Detalle](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[ramo] [int] NOT NULL,
	[semestre] [int] NOT NULL,
	[seccion] [int] NOT NULL,
	[sala] [int] NOT NULL,
	[escuela] [int] NOT NULL,
	[sede] [int] NOT NULL,
	[carrera] [int] NOT NULL,
 CONSTRAINT [PK_Detalle] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DetalleS]    Script Date: 11/12/2017 10:08:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetalleS](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[ramo] [varchar](60) NOT NULL,
	[semestre] [varchar](60) NOT NULL,
	[seccion] [varchar](60) NOT NULL,
	[sala] [varchar](60) NOT NULL,
	[escuela] [varchar](60) NOT NULL,
	[sede] [varchar](60) NOT NULL,
	[carrera] [varchar](60) NOT NULL,
 CONSTRAINT [PK_DetalleS] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Escuela]    Script Date: 11/12/2017 10:08:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Escuela](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](60) NOT NULL,
 CONSTRAINT [PK_Escuela] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ramo]    Script Date: 11/12/2017 10:08:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ramo](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](60) NOT NULL,
 CONSTRAINT [PK_Ramo] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sala]    Script Date: 11/12/2017 10:08:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sala](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[lugar] [varchar](60) NOT NULL,
 CONSTRAINT [PK_Sala] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Seccion]    Script Date: 11/12/2017 10:08:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Seccion](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[numero] [int] NULL,
 CONSTRAINT [PK_Seccion] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sede]    Script Date: 11/12/2017 10:08:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sede](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](60) NOT NULL,
 CONSTRAINT [PK_Sede] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Semestre]    Script Date: 11/12/2017 10:08:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Semestre](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[numero] [int] NOT NULL,
 CONSTRAINT [PK_Semestre] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Detalle]  WITH CHECK ADD  CONSTRAINT [FK_Detalle_Carrera] FOREIGN KEY([carrera])
REFERENCES [dbo].[Carrera] ([id])
GO
ALTER TABLE [dbo].[Detalle] CHECK CONSTRAINT [FK_Detalle_Carrera]
GO
ALTER TABLE [dbo].[Detalle]  WITH CHECK ADD  CONSTRAINT [FK_Detalle_Escuela] FOREIGN KEY([escuela])
REFERENCES [dbo].[Escuela] ([id])
GO
ALTER TABLE [dbo].[Detalle] CHECK CONSTRAINT [FK_Detalle_Escuela]
GO
ALTER TABLE [dbo].[Detalle]  WITH CHECK ADD  CONSTRAINT [FK_Detalle_Ramo] FOREIGN KEY([ramo])
REFERENCES [dbo].[Ramo] ([id])
GO
ALTER TABLE [dbo].[Detalle] CHECK CONSTRAINT [FK_Detalle_Ramo]
GO
ALTER TABLE [dbo].[Detalle]  WITH CHECK ADD  CONSTRAINT [FK_Detalle_Sala] FOREIGN KEY([sala])
REFERENCES [dbo].[Sala] ([id])
GO
ALTER TABLE [dbo].[Detalle] CHECK CONSTRAINT [FK_Detalle_Sala]
GO
ALTER TABLE [dbo].[Detalle]  WITH CHECK ADD  CONSTRAINT [FK_Detalle_Seccion] FOREIGN KEY([seccion])
REFERENCES [dbo].[Seccion] ([id])
GO
ALTER TABLE [dbo].[Detalle] CHECK CONSTRAINT [FK_Detalle_Seccion]
GO
ALTER TABLE [dbo].[Detalle]  WITH CHECK ADD  CONSTRAINT [FK_Detalle_Sede] FOREIGN KEY([sede])
REFERENCES [dbo].[Sede] ([id])
GO
ALTER TABLE [dbo].[Detalle] CHECK CONSTRAINT [FK_Detalle_Sede]
GO
ALTER TABLE [dbo].[Detalle]  WITH CHECK ADD  CONSTRAINT [FK_Detalle_Semestre] FOREIGN KEY([semestre])
REFERENCES [dbo].[Semestre] ([id])
GO
ALTER TABLE [dbo].[Detalle] CHECK CONSTRAINT [FK_Detalle_Semestre]
GO
/****** Object:  StoredProcedure [dbo].[sp_actualizarCarrera]    Script Date: 11/12/2017 10:08:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_actualizarCarrera]
@id int, @nombre varchar(60), @descripcion varchar(255)
as
begin
	begin try
		update Carrera set nombre=@nombre,descripcion=@descripcion where id = @id	
	end try
	begin catch
		print 'Actualizar Carrera Error';
	end catch
end;
GO
/****** Object:  StoredProcedure [dbo].[sp_actualizarDetalle]    Script Date: 11/12/2017 10:08:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_actualizarDetalle]
@id int, @ramo int, @semstre int, @seccion int, @sala int, @escuela int, @sede int, @carrera int
as
begin
	begin try
		update Detalle set ramo=@ramo,semestre=@semstre,seccion=@seccion,sala=@sala,escuela=escuela,sede=@sede,carrera=@carrera where id = @id
	end try
	begin catch
		print 'Actualizar Detalle Error';
	end catch
end;
GO
/****** Object:  StoredProcedure [dbo].[sp_actualizarDetalleS]    Script Date: 11/12/2017 10:08:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_actualizarDetalleS]
@id int, @ramo varchar(60), @semstre varchar(60), @seccion varchar(60), @sala varchar(60), @escuela varchar(60), @sede varchar(60), @carrera varchar(60)
as
begin
	begin try
		update DetalleS set ramo=@ramo,semestre=@semstre,seccion=@seccion,sala=@sala,escuela=escuela,sede=@sede,carrera=@carrera where id = @id
	end try
	begin catch
		print 'Actualizar DetalleS Error';
	end catch
end;
GO
/****** Object:  StoredProcedure [dbo].[sp_actualizarEscuela]    Script Date: 11/12/2017 10:08:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_actualizarEscuela]
@id int, @nombre varchar(60)
as
begin
	begin try
		update Escuela set nombre=@nombre where id = @id	
	end try
	begin catch
		print 'Actualizar Escuela Error';
	end catch
end;
GO
/****** Object:  StoredProcedure [dbo].[sp_actualizarRamo]    Script Date: 11/12/2017 10:08:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_actualizarRamo]
@id int, @nombre varchar(60)
as
begin
	begin try
		update Ramo set nombre=@nombre where id = @id	
	end try
	begin catch
		print 'Actualizar Ramo Error';
	end catch
end;
GO
/****** Object:  StoredProcedure [dbo].[sp_actualizarSala]    Script Date: 11/12/2017 10:08:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_actualizarSala]
@id int, @lugar varchar(60)
as
begin
	begin try
		update Sala set lugar=@lugar where id = @id	
	end try
	begin catch
		print 'Actualizar Sala Error';
	end catch
end;
GO
/****** Object:  StoredProcedure [dbo].[sp_actualizarSeccion]    Script Date: 11/12/2017 10:08:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_actualizarSeccion]
@id int, @numero int
as
begin
	begin try
		update Seccion set numero=@numero where id = @id
	end try
	begin catch
		print 'Actualizar Seccion Error';
	end catch
end;
GO
/****** Object:  StoredProcedure [dbo].[sp_actualizarSede]    Script Date: 11/12/2017 10:08:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_actualizarSede]
@id int, @nombre varchar(60)
as
begin
	begin try
		update Sede set nombre=@nombre where id = @id
	end try
	begin catch
		print 'Actualizar Sede Error';
	end catch
end;
GO
/****** Object:  StoredProcedure [dbo].[sp_actualizarSemestre]    Script Date: 11/12/2017 10:08:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_actualizarSemestre]
@id int, @numero int
as
begin
	begin try
		update Semestre set numero=@numero where id = @id
	end try
	begin catch
		print 'Actualizar Semestre Error';
	end catch
end;
GO
/****** Object:  StoredProcedure [dbo].[sp_agregarCarrera]    Script Date: 11/12/2017 10:08:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_agregarCarrera]
@id int output, @nombre varchar(60), @descripcion varchar(255)
as
begin
	begin try
		insert into Carrera values(@nombre, @descripcion);
		Select Cast (Scope_Identity() as int)
	end try
	begin catch
		print 'Agregar Carrera Error';
	end catch
end;
GO
/****** Object:  StoredProcedure [dbo].[sp_agregarDetalle]    Script Date: 11/12/2017 10:08:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_agregarDetalle]
@id int output, @ramo int, @semestre int, @seccion int, @sala int, @escuela int, @sede int, @carrera int
as
begin
	begin try
		insert into Detalle values(@ramo, @semestre, @seccion, @sala, @escuela, @sede, @carrera);
		Select Cast (Scope_Identity() as int)
	end try
	begin catch
		print 'Agregar Detalle Error';
	end catch
end;
GO
/****** Object:  StoredProcedure [dbo].[sp_agregarDetalleS]    Script Date: 11/12/2017 10:08:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_agregarDetalleS]
@id int output, @ramo varchar(60), @semestre varchar(60), @seccion varchar(60), @sala varchar(60), @escuela varchar(60), @sede varchar(60), @carrera varchar(60)
as
begin
	begin try
		insert into DetalleS values(@ramo, @semestre, @seccion, @sala, @escuela, @sede, @carrera);
		Select Cast (Scope_Identity() as int)
	end try
	begin catch
		print 'Agregar DetalleS Error';
	end catch
end;
GO
/****** Object:  StoredProcedure [dbo].[sp_agregarEscuela]    Script Date: 11/12/2017 10:08:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_agregarEscuela]
@id int output, @nombre varchar(60)
as
begin
	begin try
		insert into Escuela values(@nombre);
		Select Cast (Scope_Identity() as int)
	end try
	begin catch
		print 'Agregar Escuela Error';
	end catch
end;
GO
/****** Object:  StoredProcedure [dbo].[sp_agregarRamo]    Script Date: 11/12/2017 10:08:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_agregarRamo]
@id int output, @nombre varchar(60)
as
begin
	begin try
		insert into Ramo values(@nombre);
		Select Cast (Scope_Identity() as int)
	end try
	begin catch
		print 'Agregar Ramo Error';
	end catch
end;
GO
/****** Object:  StoredProcedure [dbo].[sp_agregarSala]    Script Date: 11/12/2017 10:08:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_agregarSala]
@id int output, @lugar varchar(60)
as
begin
	begin try
		insert into Sala values(@lugar);
		Select Cast (Scope_Identity() as int)
	end try
	begin catch
		print 'Agregar Sala Error';
	end catch
end;
GO
/****** Object:  StoredProcedure [dbo].[sp_agregarSeccion]    Script Date: 11/12/2017 10:08:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_agregarSeccion]
@id int output, @numero int
as
begin
	begin try
		insert into Seccion values(@numero);
		Select Cast (Scope_Identity() as int)
	end try
	begin catch
		print 'Agregar Seccion Error';
	end catch
end;
GO
/****** Object:  StoredProcedure [dbo].[sp_agregarSede]    Script Date: 11/12/2017 10:08:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_agregarSede]
@id int output, @nombre varchar(60)
as
begin
	begin try
		insert into Sede values(@nombre);
		Select Cast (Scope_Identity() as int)
	end try
	begin catch
		print 'Agregar Sede Error';
	end catch
end;
GO
/****** Object:  StoredProcedure [dbo].[sp_agregarSemestre]    Script Date: 11/12/2017 10:08:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_agregarSemestre]
@id int output, @numero int
as
begin
	begin try
		insert into Semestre values(@numero);
		Select Cast (Scope_Identity() as int)
	end try
	begin catch
		print 'Agregar Semestre Error';
	end catch
end;
GO
/****** Object:  StoredProcedure [dbo].[sp_consultarTodosCarrera]    Script Date: 11/12/2017 10:08:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_consultarTodosCarrera]
as
begin
	begin try
		Select * from Carrera
	end try
	begin catch
		print 'Consultar por todas las Carreras Error';
	end catch
end;
GO
/****** Object:  StoredProcedure [dbo].[sp_consultarTodosDetalle]    Script Date: 11/12/2017 10:08:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_consultarTodosDetalle]
as
begin
	begin try
		Select c.nombre from Detalle d, Carrera c
		where d.carrera=c.id
	end try
	begin catch
		print 'Consultar por todos los Detalles Error';
	end catch
end;
GO
/****** Object:  StoredProcedure [dbo].[sp_consultarTodosDetalleS]    Script Date: 11/12/2017 10:08:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_consultarTodosDetalleS]
as
begin
	begin try
		Select * from DetalleS
	end try
	begin catch
		print 'Consultar por todos los DetalleSs Error';
	end catch
end;
GO
/****** Object:  StoredProcedure [dbo].[sp_consultarTodosEscuela]    Script Date: 11/12/2017 10:08:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_consultarTodosEscuela]
as
begin
	begin try
		Select * from Escuela
	end try
	begin catch
		print 'Consultar por todas las Escuelas Error';
	end catch
end;
GO
/****** Object:  StoredProcedure [dbo].[sp_consultarTodosRamo]    Script Date: 11/12/2017 10:08:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_consultarTodosRamo]
as
begin
	begin try
		Select * from Ramo
	end try
	begin catch
		print 'Consultar por todos los Ramos Error';
	end catch
end;
GO
/****** Object:  StoredProcedure [dbo].[sp_consultarTodosSala]    Script Date: 11/12/2017 10:08:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_consultarTodosSala]
as
begin
	begin try
		Select * from Sala
	end try
	begin catch
		print 'Consultar por todas las Salas Error';
	end catch
end;
GO
/****** Object:  StoredProcedure [dbo].[sp_consultarTodosSeccion]    Script Date: 11/12/2017 10:08:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_consultarTodosSeccion]
as
begin
	begin try
		Select * from Seccion
	end try
	begin catch
		print 'Consultar por todas las Secciones Error';
	end catch
end;
GO
/****** Object:  StoredProcedure [dbo].[sp_consultarTodosSede]    Script Date: 11/12/2017 10:08:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_consultarTodosSede]
as
begin
	begin try
		Select * from Sede
	end try
	begin catch
		print 'Consultar por todas las Sedes Error';
	end catch
end;
GO
/****** Object:  StoredProcedure [dbo].[sp_consultarTodosSemestre]    Script Date: 11/12/2017 10:08:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_consultarTodosSemestre]
as
begin
	begin try
		Select * from Semestre
	end try
	begin catch
		print 'Consultar por todos los Semestres Error';
	end catch
end;
GO
/****** Object:  StoredProcedure [dbo].[sp_consultarUnCarrera]    Script Date: 11/12/2017 10:08:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_consultarUnCarrera]
@id int, @palabraClave varchar(60)
as
begin
	begin try
		Select * from Carrera
		Where id=@id OR
		nombre like'%'+@palabraClave+'%' OR
		descripcion like'%'+@palabraClave+'%'
	end try
	begin catch
		print 'Consultar por una Carrera Error';
	end catch
end;
GO
/****** Object:  StoredProcedure [dbo].[sp_consultarUnDetalle]    Script Date: 11/12/2017 10:08:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_consultarUnDetalle]
@id int
as
begin
	begin try
		Select * from Detalle
		where id=@id
	end try
	begin catch
		print 'Consultar por un Semestre Error';
	end catch
end;
GO
/****** Object:  StoredProcedure [dbo].[sp_consultarUnDetalleS]    Script Date: 11/12/2017 10:08:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_consultarUnDetalleS]
@id int
as
begin
	begin try
		Select * from DetalleS
		where id=@id
	end try
	begin catch
		print 'Consultar por un DetalleS Error';
	end catch
end;
GO
/****** Object:  StoredProcedure [dbo].[sp_consultarUnEscuela]    Script Date: 11/12/2017 10:08:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_consultarUnEscuela]
@id int, @palabraClave varchar(60)
as
begin
	begin try
		Select * from Escuela
		Where id=@id OR
		nombre like'%'+@palabraClave+'%'
	end try
	begin catch
		print 'Consultar por una Escuela Error';
	end catch
end;
GO
/****** Object:  StoredProcedure [dbo].[sp_consultarUnRamo]    Script Date: 11/12/2017 10:08:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_consultarUnRamo]
@id int, @palabraClave varchar(60)
as
begin
	begin try
		Select * from Ramo
		Where id=@id OR
		nombre like'%'+@palabraClave+'%'
	end try
	begin catch
		print 'Consultar por un Ramo Error';
	end catch
end;
GO
/****** Object:  StoredProcedure [dbo].[sp_consultarUnSala]    Script Date: 11/12/2017 10:08:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_consultarUnSala]
@id int, @palabraClave varchar(60)
as
begin
	begin try
		Select * from Sala
		Where id=@id OR
		lugar like'%'+@palabraClave+'%'
	end try
	begin catch
		print 'Consultar por una Sala Error';
	end catch
end;
GO
/****** Object:  StoredProcedure [dbo].[sp_consultarUnSeccion]    Script Date: 11/12/2017 10:08:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_consultarUnSeccion]
@id int
as
begin
	begin try
		Select * from Seccion
		Where id=@id OR
		numero=@id
	end try
	begin catch
		print 'Consultar por una Seccion Error';
	end catch
end;
GO
/****** Object:  StoredProcedure [dbo].[sp_consultarUnSede]    Script Date: 11/12/2017 10:08:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_consultarUnSede]
@id int, @palabraClave varchar(60)
as
begin
	begin try
		Select * from Sede
		Where id=@id OR
		nombre like'%'+@palabraClave+'%'
	end try
	begin catch
		print 'Consultar por una Sede Error';
	end catch
end;
GO
/****** Object:  StoredProcedure [dbo].[sp_consultarUnSemestre]    Script Date: 11/12/2017 10:08:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_consultarUnSemestre]
@id int
as
begin
	begin try
		Select * from Semestre
		Where id=@id OR
		numero=@id
	end try
	begin catch
		print 'Consultar por un Semestre Error';
	end catch
end;
GO
/****** Object:  StoredProcedure [dbo].[sp_eliminarCarrera]    Script Date: 11/12/2017 10:08:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_eliminarCarrera]
@id int
as
begin
	begin try
		delete from Carrera where id = @id;
	end try
	begin catch
		print 'Eliminar Carrera Error';
	end catch
end;
GO
/****** Object:  StoredProcedure [dbo].[sp_eliminarDetalle]    Script Date: 11/12/2017 10:08:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_eliminarDetalle]
@id int
as
begin
	begin try
		delete from Detalle where id = @id;
	end try
	begin catch
		print 'Eliminar Detalle Error';
	end catch
end;
GO
/****** Object:  StoredProcedure [dbo].[sp_eliminarDetalleS]    Script Date: 11/12/2017 10:08:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_eliminarDetalleS]
@id int
as
begin
	begin try
		delete from DetalleS where id = @id;
	end try
	begin catch
		print 'Eliminar DetalleS Error';
	end catch
end;
GO
/****** Object:  StoredProcedure [dbo].[sp_eliminarEscuela]    Script Date: 11/12/2017 10:08:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_eliminarEscuela]
@id int
as
begin
	begin try
		delete from Escuela where id = @id;
	end try
	begin catch
		print 'Eliminar Escuela Error';
	end catch
end;
GO
/****** Object:  StoredProcedure [dbo].[sp_eliminarRamo]    Script Date: 11/12/2017 10:08:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_eliminarRamo]
@id int
as
begin
	begin try
		delete from Ramo where id = @id;
	end try
	begin catch
		print 'Eliminar Ramo Error';
	end catch
end;
GO
/****** Object:  StoredProcedure [dbo].[sp_eliminarSala]    Script Date: 11/12/2017 10:08:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_eliminarSala]
@id int
as
begin
	begin try
		delete from Sala where id = @id;
	end try
	begin catch
		print 'Eliminar Sala Error';
	end catch
end;
GO
/****** Object:  StoredProcedure [dbo].[sp_eliminarSeccion]    Script Date: 11/12/2017 10:08:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_eliminarSeccion]
@id int
as
begin
	begin try
		delete from Seccion where id = @id;
	end try
	begin catch
		print 'Eliminar Seccion Error';
	end catch
end;
GO
/****** Object:  StoredProcedure [dbo].[sp_eliminarSede]    Script Date: 11/12/2017 10:08:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_eliminarSede]
@id int
as
begin
	begin try
		delete from Sede where id = @id;
	end try
	begin catch
		print 'Eliminar Sede Error';
	end catch
end;
GO
/****** Object:  StoredProcedure [dbo].[sp_eliminarSemestre]    Script Date: 11/12/2017 10:08:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_eliminarSemestre]
@id int
as
begin
	begin try
		delete from Semestre where id = @id;
	end try
	begin catch
		print 'Eliminar Semestre Error';
	end catch
end;
GO
Create PROCEDURE [dbo].[sp_Filtro]
	@ramo [varchar](60),
	@semestre [varchar](60),
	@seccion [varchar](60),
	@sala [varchar](60),
	@escuela [varchar](60),
	@sede [varchar](60),
	@carrera [varchar](60)
AS
begin
	begin try
		Select * 
		from DetalleS
		Where ramo like'%'+@ramo+'%' or
		semestre like'%'+@semestre+'%' or
		seccion like'%'+@seccion+'%' or
		sala like'%'+@sala+'%' or
		escuela like'%'+@escuela+'%' or
		sede like'%'+@sede+'%' or
		carrera like'%'+@carrera+'%';
	end try
	begin catch
		print '14';
	end catch
end;