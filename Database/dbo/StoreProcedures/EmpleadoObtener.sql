CREATE PROCEDURE [dbo].[EmpleadoObtener]
      @IdEmpleado int= NULL
AS BEGIN
  SET NOCOUNT ON

  SELECT 
     E.IdEmpleado,
     E.Nombre,
     E.PrimerApellido,
     E.SegundoApellido,
     E.Edad,
     E.FechaNacimiento    
    FROM dbo.Empleado E
    WHERE
    (@IdEmpleado IS NULL OR IdEmpleado=@IdEmpleado)

END