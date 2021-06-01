CREATE TABLE [dbo].[AllocationParaMedicals]
(
	[Id] INT NOT NULL IDENTITY,
	[DateDebut] DATE NOT NULL,
	[DateFin] DATE,
	[Classe_Id] INT NOT NULL,
	[ParaMedical_Id] INT NOT NULL,

	Constraint PK_AllocationParaMedicals Primary Key (Id),
	Constraint Fk_AllocationParaMedicals_Classe Foreign Key (Classe_Id) References Classe(Id),
	Constraint Fk_AllocationParaMedicals_Paramedical Foreign Key (ParaMedical_Id) References ParaMedical(Id)
)
