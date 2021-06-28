CREATE PROCEDURE [dbo].[SP_ChtlePrj_UpdateTypeUtilisateur]
	@Id INT,
	@IntituleTypeUtilisateur NVARCHAR(50)
As
Begin
	Begin Transaction
	Begin Try
		UPDATE TypeUtilisateur
		SET IntituleTypeUtilisateur = @IntituleTypeUtilisateur	
		WHERE Id = @Id

			Commit;
			Return 0;
	End Try
	Begin Catch
		Rollback;
		Return -1;
	End Catch
End
