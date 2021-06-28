CREATE TABLE [dbo].[SpecialisationParaMedical]
(
	[Id] INT NOT NULL IDENTITY,
	[IntituleSpecialisation] NVARCHAR(50) NOT NULL,

	Constraint Pk_SpecialisationParaMedical Primary Key ([Id]),
	Constraint Uk_SpecialisationParaMedical_Intitule Unique ([IntituleSpecialisation])
)
