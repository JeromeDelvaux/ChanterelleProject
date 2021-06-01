CREATE TABLE [dbo].[Utilisateur]
(
	[Id] INT NOT NULL IDENTITY,
	[Nom] NVARCHAR(50) NOT NULL,
	[Prenom] NVARCHAR(50) NOT NULL,
	[Adressse] NVARCHAR(250) NOT NULL,
	[DateNaissance] DATE NOT NULL,
	[RegistreNational] CHAR(11) NOT NULL,
	[Sexe] NVARCHAR(5) NOT NULL,
	[DateDerniereModif] DATETIME2 NOT NULL,
	[DateDebutContrat] DATE NOT NULL,
	[Telephone] CHAR(12) NOT NULL,
	[Mail] NVARCHAR(350) NOT NULL,
	[MotDePasse] BINARY(64) NOT NULL,
	[Salage] UNIQUEIDENTIFIER NOT NULL,
	[Actif] BIT NOT NULL DEFAULT 1,
	[TypeUtilisateur_Id] INT NOT NULL,

	Constraint Pk_Utilisateur Primary Key (Id),
	Constraint Fk_Utilisateur_TypeUtilisateur Foreign Key (TypeUtilisateur_Id) References TypeUtilisateur(Id),
	Constraint Ck_Utilisateur_RegNational Check (ISNUMERIC([RegistreNational]) = 1), /*Renvoie une valeur booléenne indiquant si une expression peut être évaluée comme un nombre.*/
	Constraint Uk_Utilisateur_RegistreNational Unique ([RegistreNational])
)

