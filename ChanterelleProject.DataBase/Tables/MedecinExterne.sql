CREATE TABLE [dbo].[MedecinExterne]
(
	[Id] INT NOT NULL IDENTITY,
	[NumInami] NVARCHAR(50) NOT NULL,
	[Nom] NVARCHAR(50) NOT NULL,
	[Prenom] NVARCHAR(50) NOT NULL,
	[Adressse] NVARCHAR(250) NOT NULL,
	[Mail] NVARCHAR(350),
	[DateNaissance] DATE NOT NULL,
	[TelephonePerso] INT,
	[TelephoneCabinet] INT NOT NULL,
	[Actif] BIT NOT NULL DEFAULT 1,

	Constraint PK_MedecinExterne Primary Key (Id),
	Constraint Uk_MedecinExterne_NumInami Unique (NumInami),
	Constraint Uk_MedecinExterne_TelephonePerso Unique (TelephonePerso)
)