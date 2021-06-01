CREATE TABLE [dbo].[Traitement]
(
	[Id] INT NOT NULL IDENTITY,
	[NomMedicament] NVARCHAR(50) NOT NULL,
	[Posologie] NVARCHAR(50) NOT NULL,
	[DateDebut] DATE NOT NULL,
	[DateFin] DATE NOT NULL,
	[NomCreateur] NVARCHAR(50) NOT NULL,
	[Objectif] NVARCHAR(1500) NOT NULL,
	[Actif] BIT NOT NULL DEFAULT 1,
	[TargetPieceJointe] NVARCHAR(250) NOT NULL,
	[Eleve_Id] INT NOT NULL,
	[Utilisateur_Id] INT NOT NULL,

	Constraint PK_Traitement Primary Key (Id),
	Constraint Fk_Traitement_Eleve Foreign Key (Eleve_Id) References Eleve(Id),
	Constraint Fk_Traitement_Utilisateur Foreign Key (Utilisateur_Id) References Utilisateur(Id),
	Constraint Uk_Traitement_TargetPieceJointe Unique (TargetPieceJointe)
)

