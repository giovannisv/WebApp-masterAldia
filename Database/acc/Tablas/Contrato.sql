	CREATE TABLE [acc].[Contrato]
(
	IdContrato INT NOT NULL IDENTITY(1,1) CONSTRAINT PK_Contrato PRIMARY KEY CLUSTERED(IdContrato)
  , IdEmpleado INT NOT NULL CONSTRAINT FK_Empleado_Contrato FOREIGN KEY(IdEmpleado)
     REFERENCES dbo.Empleado(IdEmpleado)
  , TipoContrato VARCHAR(50) NOT NULL
  , FechaInicio DATETIME NOT NULL
  , FechaFin DATETIME NULL
)
WITH (DATA_COMPRESSION = PAGE)
GO

