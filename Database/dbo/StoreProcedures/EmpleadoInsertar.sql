CREATE PROCEDURE [dbo].[EmpleadoInsertar]
	@Nombre varchar(50),
	@PrimerApellido varchar(50),
	@SegundoApellido varchar(50),
	@Edad int, 
	@FechaNacimiento Datetime,
	@TipoIdentificacion varchar(50),
	@Identificacion int


AS BEGIN
SET NOCOUNT ON

  BEGIN TRANSACTION TRASA

    BEGIN TRY
	
	INSERT INTO dbo.Empleado
	(Nombre,
	 PrimerApellido,
	 SegundoApellido,
	 Edad,
	 FechaNacimiento,
	 TipoIdentificacion,
	 Identificacion

	)
	VALUES
	(
	@Nombre,
	@PrimerApellido,
	@SegundoApellido,
	@Edad,
	@FechaNacimiento,
	@TipoIdentificacion,
	@Identificacion 
	)

  COMMIT TRANSACTION TRASA
  SELECT 0 AS CodeError, '' AS MsgError

  END TRY

  BEGIN CATCH

   SELECT 
         ERROR_NUMBER() AS CodeError,
		 ERROR_MESSAGE() AS MsgError
   
   ROLLBACK TRANSACTION TRASA

   END CATCH

 END



