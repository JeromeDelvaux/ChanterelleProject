CREATE PROCEDURE [dbo].[SP_ChtlePrj_DeleteAllocationParaMedicals]
@Id INT
As
Begin
	Begin Transaction
	Begin Try
		UPDATE AllocationParaMedicals
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
