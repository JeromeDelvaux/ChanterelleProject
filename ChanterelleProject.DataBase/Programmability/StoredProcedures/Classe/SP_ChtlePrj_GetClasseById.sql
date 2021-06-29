CREATE PROCEDURE [dbo].[SP_ChtlePrj_GetClasseById]
@id INT
AS
	SELECT * FROM V_ChtlePrj_AllClasse WHERE Id = @id
RETURN 0
