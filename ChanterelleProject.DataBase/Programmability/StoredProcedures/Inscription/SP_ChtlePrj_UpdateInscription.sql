CREATE PROCEDURE [dbo].[SP_ChtlePrj_UpdateInscription]
	@Id INT,
	@Utilisateur_Id INT,
	@Eleve_Id INT
As
Begin
	Begin Transaction
	Begin Try
		UPDATE Inscription
		SET Utilisateur_Id=@Utilisateur_Id,
			Eleve_Id=@Eleve_Id

		WHERE Id = @id
			AND [DateFin] is null
			Commit;
			Return 0;
	End Try
	Begin Catch
		Rollback;
		Return -1;
	End Catch
End
