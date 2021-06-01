CREATE TABLE [dbo].[AllocationClasses]
(
	[Id] INT NOT NULL IDENTITY,
	[DateDebut] DATE NOT NULL,
	[DateFin] DATE,
	[Classe_Id] INT NOT NULL,
	[Utilisateur_Id] INT NOT NULL,

	Constraint PK_AllocationClasses Primary Key (Id),
	Constraint Fk_AllocationClasses_Classe Foreign Key (Classe_Id) References Classe(Id),
	Constraint Fk_AllocationClasses_Paramedical Foreign Key (Utilisateur_Id) References Utilisateur(Id)
)
