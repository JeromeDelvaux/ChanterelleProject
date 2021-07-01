CREATE PROCEDURE [dbo].[SP_ChtlePrj_GetTraitementByEleveId]
	@id INT
AS
	SELECT * FROM V_ChtlePrj_AllTraitement WHERE EleveId = @id
RETURN 0
