CREATE PROCEDURE [dbo].[SP_ChtlePrj_DeleteInscription]
	@Id INT
As
Begin
	Begin Transaction
	Begin Try
		UPDATE Inscription
		SET [DateFin] = SYSDATETIME()
			WHERE [Id] = @Id
			Commit;
			Return 0;
		End Try
	Begin Catch
		Rollback;
		Return -1;
	End Catch
End
