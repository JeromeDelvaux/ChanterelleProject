CREATE PROCEDURE [dbo].[SP_ChtlePrj_AddTypeUtilisateur]
	@IntituleTypeUtilisateur NVARCHAR(50)
As
Begin
	Begin Transaction
	Begin Try
	BEGIN
		Insert into TypeUtilisateur(IntituleTypeUtilisateur)
		Output inserted.[Id]
		values (@IntituleTypeUtilisateur);
		
		Commit;
		Return 0;
	END
	End Try
	Begin Catch
		Rollback;
		Return -1;
	End Catch
End
