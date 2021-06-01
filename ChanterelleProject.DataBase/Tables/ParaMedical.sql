CREATE TABLE [dbo].[ParaMedical]
(
	[Id] INT NOT NULL,
	[NumInami] nvarchar(50) NOT NULL,
	[Specialisation_Id] INT NOT NULL,

	Constraint Pk_ParaMedical Primary Key (Id),
	Constraint Fk_ParaMedical_Utilisateur Foreign Key (Id) References Utilisateur(Id),
	Constraint Fk_ParaMedical_SpecialisationParaMedical Foreign Key (Specialisation_Id) References SpecialisationParaMedical(Id),
	Constraint Uk_ParaMedical_NumInami Unique (NumInami)
	
	/*
	L'entité "ParaMedical" est une spécialisation de l'entité "Utilisateur".
	Par conséquent, l'attribut "Id" de l'entité "ParaMedical" est la clé primaire de son entité 
	mais également  la clé étrangère de l'entité "Utilisateur".
	*/
)
