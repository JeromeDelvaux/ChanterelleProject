CREATE PROCEDURE [dbo].[SP_ChtlePrj_DeleteAllocationClasses]
	@Id INT
As
Begin
	Begin Transaction
	Begin Try
		UPDATE AllocationClasses
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
