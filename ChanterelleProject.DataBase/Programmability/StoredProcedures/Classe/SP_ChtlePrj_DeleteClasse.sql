CREATE PROCEDURE [dbo].[SP_ChtlePrj_DeleteClasse]
@Id INT
As
Begin
	Begin Transaction
	Begin Try
		DELETE FROM Classe
			WHERE [Id] = @Id
			Commit;
			Return 0;
		End Try
	Begin Catch
		Rollback;
		Return -1;
	End Catch
End
