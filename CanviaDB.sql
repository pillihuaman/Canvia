CREATE DATABASE canviadb; 
go
USE canviadb
go
CREATE TABLE [dbo].[users]
  (
     IdUser     INT PRIMARY KEY IDENTITY(1, 1),
     LastName   VARCHAR(50) NULL,
     Name       VARCHAR(50) NULL,
     UserCode   VARCHAR(50) NOT NULL,
     Password   VARCHAR(500) NULL,
     Email      VARCHAR(500),
     Status int not null,
     IdSystem int null,
     CreateDate DATETIME,
  )
go
INSERT INTO [dbo].[users]
            (LastName,
             Name,
             UserCode,
             Password,
             Email ,Status,IdSystem,CreateDate)
VALUES      ('Pillihuaman',
             'Zarmir',
             '0001U',
             '12334598*k',
             'Pillihuamanhz@gmail.com',1,1,GETDATE())

go

create PROCEDURE Sp_listall_users
AS
  BEGIN
      SELECT IdUser,LastName,
             Name,
             UserCode,
             Password,
             Email,
             Status,IdSystem,
             CreateDate
      FROM   [dbo].[users]
  END

go
CREATE PROCEDURE Sp_insert_users (@LastName VARCHAR(50),
                                 @Name     VARCHAR(50),
                                 @UserCode VARCHAR(50),
                                 @Password VARCHAR(500),
                                 @Email    VARCHAR(500))
AS
  BEGIN
      INSERT INTO [dbo].[users]
                  (LastName,
                   Name,
                   UserCode,
                   Password,
                   Email,
                   Status,IdSystem,
                   CreateDate)
      VALUES     ( @LastName,
                   @Name,
                   @UserCode,
                   @Password,
                   @Email,1,
                   1,
                   Getdate() )
  END  