CREATE PROCEDURE [dbo].[SP_ChtlePrj_AddSpecialisationParaMedical]
	@IntituleSpecialisation NVARCHAR(50)
As
Begin
	Begin Transaction
	Begin Try
	BEGIN
		Insert into SpecialisationParaMedical(IntituleSpecialisation)
		Output inserted.[Id]
		values (@IntituleSpecialisation);
		
		Commit;
		Return 0;
	END
	End Try
	Begin Catch
		Rollback;
		Return -1;
	End Catch
End