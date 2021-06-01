CREATE TABLE [dbo].[Eleve]
(
	[Id] INT NOT NULL IDENTITY,
	[Nom] NVARCHAR(50) NOT NULL,
	[Prenom] NVARCHAR(50) NOT NULL,
	[Adressse] NVARCHAR(250) NOT NULL,
	[DateNaissance] DATE NOT NULL,
	[RegistreNational] NVARCHAR(50) NOT NULL,
	[Sexe] NVARCHAR(5) NOT NULL,
	[DateDerniereModif] DATETIME2 NOT NULL,
	[Actif] BIT NOT NULL DEFAULT 1,
	[Classe_Id] INT NOT NULL,
	[MedecinExterne_Id] INT NOT NULL,

	Constraint PK_Eleve Primary Key (Id),
	Constraint Fk_Eleve_Classe Foreign Key (Classe_Id) References Classe(Id),
	Constraint Fk_Eleve_MedecinExterne Foreign Key (MedecinExterne_Id) References MedecinExterne(Id),
	Constraint Ck_Eleve_RegistreNational CHECK (ISNUMERIC([RegistreNational]) = 1),/*Renvoie une valeur booléenne indiquant si une expression peut être évaluée comme un nombre.*/
	Constraint Uk_Eleve_RegistreNational Unique  ([RegistreNational])
)
