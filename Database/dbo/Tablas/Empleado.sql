CREATE TABLE [dbo].[Empleado]
(
	IdEmpleado INT NOT NULL IDENTITY(1,1) CONSTRAINT PK_Empleado PRIMARY KEY CLUSTERED(IdEmpleado)
	,IdTipoIdentificacion INT NOT NULL CONSTRAINT FK_Empleado_TipoIdentificacion FOREIGN KEY (IdTipoIdentificacion)
	REFERENCES dbo.TipoIdentificacion(IdTipoIdentificacion)
	,Identificacion VARCHAR (50) NOT NULL
  , Nombre VARCHAR(50) NOT NULL 
  , PrimerApellido VARCHAR(50) NOT NULL
  , SegundoApellido VARCHAR(50) NOT NULL
  , Edad INT NOT NULL
  , FechaNacimiento DATETIME NOT NULL
  
  
)
WITH (DATA_COMPRESSION = PAGE)
GO
