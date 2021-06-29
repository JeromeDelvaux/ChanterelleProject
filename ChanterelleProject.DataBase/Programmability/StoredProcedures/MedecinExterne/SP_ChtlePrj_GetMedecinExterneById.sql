CREATE PROCEDURE [dbo].[SP_ChtlePrj_GetMedecinExterneById]
@id INT
AS
	SELECT * FROM V_ChtlePrj_AllMedecinExterne WHERE Id = @id
RETURN 0
