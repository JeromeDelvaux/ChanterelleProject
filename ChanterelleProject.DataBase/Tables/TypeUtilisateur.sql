CREATE TABLE [dbo].[TypeUtilisateur]
(
	[Id] INT NOT NULL IDENTITY,
	[IntituleTypeUtilisateur] NVARCHAR(50)

	Constraint Pk_TypeUtilisateur Primary Key ([Id]),
	Constraint Uk_TypeUtilisateur_Intitule Unique ([IntituleTypeUtilisateur])
)
