/****** Script para el comando SelectTopNRows de SSMS  ******/
/*SELECT TOP 1000 [id]
      ,[nombre]
      ,[apellido]
      ,[edad]
  FROM [Padron].[dbo].[Personas]*/

SELECT 
id,nombre,apellido,edad

FROM Padron.dbo.Personas

/*INSERT INTO Padron.dbo.Personas

(nombre,apellido,edad)

values

('Jose', 'Hernandez', 46)
*/
/*UPDATE Padron.dbo.Personas

SET nombre = 'Alan'

WHERE nombre = 'Matias'
*/

DELETE Padron.dbo.Personas


WHERE id = 18