CREATE TABLE [dbo].[Inscription]
(
	[Id] INT NOT NULL IDENTITY,
	[DateDebut] DATE NOT NULL,
	[DateFin] DATE,
	[Eleve_Id] INT NOT NULL,
	[Utilisateur_Id] INT NOT NULL

	Constraint PK_Inscription Primary Key (Id),
	Constraint FK_INscription_Eleve Foreign Key (Eleve_Id) References Eleve(Id),
	Constraint FK_INscription_Utilisateur Foreign Key (Utilisateur_Id) References Utilisateur(Id)
)
