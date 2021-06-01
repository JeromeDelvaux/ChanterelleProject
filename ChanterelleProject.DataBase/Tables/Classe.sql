CREATE TABLE [dbo].[Classe]
(
	[Id] INT NOT NULL IDENTITY,
	[Nom] NVARCHAR(50) NOT NULL,
	[NbEleveMax] INT NOT NULL DEFAULT 14,
	[Utilisateur_Id] INT NOT NULL,

	Constraint Pk_Classe Primary Key(Id),
	Constraint Fk_Classe_Utilisateur Foreign Key (Utilisateur_Id) References Utilisateur(Id)
)
