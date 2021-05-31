Create Table Person
(
	Id int not null identity,
	LastName Nvarchar(50) not null,
	FirstName Nvarchar(50) not null,
	Constraint PK_Person Primary Key (Id)
);

Create Table ParaMedic
(
	Id int not null,
	InamiNumber nvarchar(20) not null,
	Constraint Pk_ParaMedic Primary Key (Id),
	Constraint Pk_ParaMedic_InamiNumber Unique (InamiNumber),
	Constraint Fk_ParaMedic_Person Foreign Key (Id)
		References Person(Id)
);

Go

Create Procedure AddParaMedic
	@LastName Nvarchar(50),
	@FirstName Nvarchar(50),
	@InamiNumber Nvarchar(250)
As
Begin
	Begin Transaction
	Begin Try
		Declare @Id int;
		Insert into Person (LastName, FirstName) values (@LastName, @FirstName);
		set @Id = SCOPE_IDENTITY();
		Insert into ParaMedic (Id, InamiNumber) values (@Id, @InamiNumber);
		Commit;
		return 0;
	End Try
	Begin Catch
		Rollback;
		return -1;
	End Catch
End