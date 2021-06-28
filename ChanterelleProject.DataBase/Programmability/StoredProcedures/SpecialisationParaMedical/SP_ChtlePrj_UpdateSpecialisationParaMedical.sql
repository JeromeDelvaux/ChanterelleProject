CREATE PROCEDURE [dbo].[SP_ChtlePrj_UpdateSpecialisationParaMedical]
	@Id INT,
	@IntituleSpecialisation NVARCHAR(50)
As
Begin
	Begin Transaction
	Begin Try
		UPDATE SpecialisationParaMedical
		SET IntituleSpecialisation = @IntituleSpecialisation	
		WHERE Id = @Id

			Commit;
			Return 0;
	End Try
	Begin Catch
		Rollback;
		Return -1;
	End Catch
End
