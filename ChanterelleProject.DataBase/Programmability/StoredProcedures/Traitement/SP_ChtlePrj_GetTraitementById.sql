CREATE PROCEDURE [dbo].[SP_ChtlePrj_GetTraitementById]
	@id INT
AS
	SELECT * FROM V_ChtlePrj_AllTraitement WHERE Id = @id
RETURN 0
