CREATE PROCEDURE [dbo].[SP_ChtlePrj_UpdateAllocationClasses]
	@Id INT,
	@Utilisateur_Id INT,
	@Classe_Id INT
As
Begin
	Begin Transaction
	Begin Try
		UPDATE AllocationClasses
		SET Utilisateur_Id=@Utilisateur_Id,
			Classe_Id=@Classe_Id

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
