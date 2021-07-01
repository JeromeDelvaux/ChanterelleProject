CREATE PROCEDURE [dbo].[SP_ChtlePrj_GetEleveById]
	@id int
AS
	SELECT * from V_ChtlePrj_AllEleve where Id=@id
RETURN 0
