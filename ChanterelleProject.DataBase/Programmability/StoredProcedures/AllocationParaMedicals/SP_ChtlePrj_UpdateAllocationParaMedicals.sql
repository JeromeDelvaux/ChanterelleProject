CREATE PROCEDURE [dbo].[SP_ChtlePrj_UpdateAllocationParaMedicals]
	@Id INT,
	@ParaMedical_Id INT,
	@Classe_Id INT
As
Begin
	Begin Transaction
	Begin Try
		UPDATE AllocationParaMedicals
		SET ParaMedical_Id=@ParaMedical_Id,
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
