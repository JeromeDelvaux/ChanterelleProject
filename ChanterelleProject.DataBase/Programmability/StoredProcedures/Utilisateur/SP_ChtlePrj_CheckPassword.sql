CREATE PROCEDURE [dbo].[SP_ChtlePrj_CheckPassword]
	@Identifiant NVARCHAR(256),
	@MotDePasse NVARCHAR(32)
AS
Begin
	Begin Transaction
	Begin Try

	IF EXISTS(SELECT Id FROM Utilisateur
			  WHERE [Mail] = @Identifiant
			  AND [MotDePasse] = [dbo].SF_ChtlePrj_SalageEtHash(@MotDePasse,[Salage])
			  AND [Actif] =1)
	BEGIN
		SELECT * FROM V_ChtlePrj_AllUtilisateurs WHERE Mail = @Identifiant
	END
	ELSE
	BEGIN
	Rollback;
		Return -2;
	END
	End Try
	Begin Catch
		Rollback;
		Return -1;
	End Catch
End