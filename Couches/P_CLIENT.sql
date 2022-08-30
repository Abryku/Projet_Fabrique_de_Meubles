CREATE PROCEDURE AjouterCLIENT
 @ID int OUTPUT,
 @Nom varchar(50),
 @Prénom varchar(50),
 @Téléphone varchar(50),
 @Mail varchar(50)
AS
 INSERT INTO CLIENT(Nom,Prénom,Téléphone,Mail)
  VALUES(@Nom,@Prénom,@Téléphone,@Mail)
 SET @ID=@@IDENTITY
RETURN
GO
CREATE PROCEDURE ModifierCLIENT
 @ID int,
 @Nom varchar(50),
 @Prénom varchar(50),
 @Téléphone varchar(50),
 @Mail varchar(50)
AS
 IF(@ID IS NULL OR @ID=0)
  RAISERROR('Identifiant requis !',16,1)
 ELSE  UPDATE CLIENT
        SET Nom=@Nom,Prénom=@Prénom,Téléphone=@Téléphone,Mail=@Mail
        WHERE ID=@ID
RETURN
GO
CREATE PROCEDURE SelectionnerCLIENT
 @Index VARCHAR(10)
AS
 IF(@Index='Nom') SELECT * FROM CLIENT ORDER BY Nom
 ELSE IF(@Index='Prénom') SELECT * FROM CLIENT ORDER BY Prénom
 ELSE IF(@Index='Téléphone') SELECT * FROM CLIENT ORDER BY Téléphone
 ELSE IF(@Index='Mail') SELECT * FROM CLIENT ORDER BY Mail
 ELSE SELECT * FROM CLIENT ORDER BY ID
RETURN
GO
CREATE PROCEDURE SelectionnerCLIENT_ID
 @ID int
AS
 IF(@ID IS NULL)
  RAISERROR('Identifiant requis !',16,1)
 ELSE
  SELECT ID,Nom,Prénom,Téléphone,Mail
  FROM CLIENT
  WHERE @ID=ID
RETURN
GO
CREATE PROCEDURE SupprimerCLIENT
 @ID int
AS
 IF(@ID IS NULL)
  RAISERROR('Identifiant requis !',16,1)
 ELSE
  DELETE FROM CLIENT WHERE @ID=ID
RETURN
GO
