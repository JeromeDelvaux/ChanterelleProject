CREATE PROCEDURE [dbo].[SP_ChtlePrj_DeleteUtilisateur]
	@Id INT
As
Begin
	Begin Transaction
	Begin Try
		UPDATE Utilisateur
		SET [Actif]=0,
			[DateDerniereModif] = SYSDATETIME()
			WHERE [Id] = @Id
			Commit;
			Return 0;
		End Try
	Begin Catch
		Rollback;
		Return -1;
	End Catch
End
