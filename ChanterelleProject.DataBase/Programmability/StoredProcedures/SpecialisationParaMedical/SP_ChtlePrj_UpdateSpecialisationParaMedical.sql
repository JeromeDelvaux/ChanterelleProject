CREATE PROCEDURE [dbo].[SP_ChtlePrj_UpdateSpecialisationParaMedical]
	@Id INT,
	@Intitule NVARCHAR(50)
As
Begin
	Begin Transaction
	Begin Try
		UPDATE SpecialisationParaMedical
		SET Intitule = @Intitule	
		WHERE Id = @Id

			Commit;
			Return 0;
	End Try
	Begin Catch
		Rollback;
		Return -1;
	End Catch
End
