CREATE PROCEDURE [dbo].[SP_ChtlePrj_DeleteTraitement]
		@Id INT
As
Begin
	Begin Transaction
	Begin Try
		UPDATE Traitement
		SET [Actif]=0
			WHERE [Id] = @Id
			Commit;
			Return 0;
		End Try
	Begin Catch
		Rollback;
		Return -1;
	End Catch
End
