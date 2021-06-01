CREATE PROCEDURE [dbo].[SP_ChtlePrj_CheckPassword]
	@Identifiant NVARCHAR(256),
	@MotDePasse NVARCHAR(32)
AS
	SELECT Id
		FROM Utilisateur
		WHERE [Mail] = @Identifiant
			AND [MotDePasse] = [dbo].SF_ChtlePrj_SalageEtHash(@MotDePasse,[Salage])
			AND [Actif] =1
RETURN 0
