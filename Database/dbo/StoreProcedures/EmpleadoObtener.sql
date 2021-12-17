CREATE PROCEDURE [dbo].[EmpleadoObtener]
      @IdEmpleado int= NULL
AS BEGIN
  SET NOCOUNT ON

  SELECT 
     E.IdEmpleado,
     E.Identificacion,
     E.Nombre,
     E.PrimerApellido,
     E.SegundoApellido,
     E.Edad,
     E.FechaNacimiento,
     
     T.IdTipoIdentificacion,
     T.Descripcion


    FROM dbo.Empleado E
    INNER JOIN dbo.TipoIdentificacion T
    ON E.IdTipoIdentificacion = T.IdTipoIdentificacion
    WHERE
    (@IdEmpleado IS NULL OR IdEmpleado=@IdEmpleado)

END