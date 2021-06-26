/*InsertionTypeUtilisateur*/
Insert into dbo.TypeUtilisateur(Intitule)
values ('Directrice')
Insert into dbo.TypeUtilisateur(Intitule)
values ('EquipePluridisciplinaire')
Insert into dbo.TypeUtilisateur(Intitule)
values ('AssistanteSocial')

/*InsertionUtilisateur1*/
Declare @Uid UNIQUEIDENTIFIER;
Declare @DateNow DATETIME2(7)=sysdatetime();
Set @Uid = NEWID();

Insert into dbo.Utilisateur(Nom,Prenom,Adressse,DateNaissance,DateDebutContrat,RegistreNational,Sexe,DateDerniereModif,Telephone,Mail,TypeUtilisateur_Id,MotDePasse,Salage)
values 
(
'Doe',
'John',
'Rue de morgue casier C',
'1970-01-01', 
@DateNow,
'10002928389',
'Homme',
@DateNow,
'0498567894',
'john.doe@unknow.com',
1,
[dbo].SF_ChtlePrj_SalageEtHash('Test1234=',@Uid),
@Uid);

/*InsertionUtilisateur2*/
SET @DateNow =sysdatetime();
Set @Uid = NEWID();

Insert into dbo.Utilisateur(Nom,Prenom,Adressse,DateNaissance,DateDebutContrat,RegistreNational,Sexe,DateDerniereModif,Telephone,Mail,TypeUtilisateur_Id,MotDePasse,Salage)
values 
(
'Mouse',
'Mickey',
'Rue de la souris verte, 15 , 15000 WaltDisney',
'1979-05-20', 
@DateNow,
'00012928389',
'Homme',
@DateNow,
'0476589546',
'mickey.mouse@waltdisney.com',
2,
[dbo].SF_ChtlePrj_SalageEtHash('Test1234=',@Uid),
@Uid);

/*InsertionUtilisateur3*/
SET @DateNow =sysdatetime();
Set @Uid = NEWID();

Insert into dbo.Utilisateur(Nom,Prenom,Adressse,DateNaissance,DateDebutContrat,RegistreNational,Sexe,DateDerniereModif,Telephone,Mail,TypeUtilisateur_Id,MotDePasse,Salage)
values 
(
'Donald',
'Duck',
'Rue de la tunne, 301 , 15000 WaltDisney',
'1986-06-25', 
@DateNow,
'00112928389',
'Homme',
@DateNow,
'0476589546',
'donald.duck@waltdisney.com',
3,
[dbo].SF_ChtlePrj_SalageEtHash('Test1234=',@Uid),
@Uid);