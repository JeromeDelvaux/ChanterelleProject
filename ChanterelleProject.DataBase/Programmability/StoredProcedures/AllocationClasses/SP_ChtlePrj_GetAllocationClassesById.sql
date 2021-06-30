CREATE PROCEDURE [dbo].[SP_ChtlePrj_GetAllocationClassesById]
	@id INT
AS
	SELECT * FROM V_ChtlePrj_AllAllocationClasses WHERE Id = @id
RETURN 0
