CREATE TABLE [dbo].[Table]
(
	[Id] CHAR(10) NOT NULL PRIMARY KEY, 
    [Jobtitle_Id] CHAR(10) NOT NULL, 
    [Dept_Id] CHAR(10) NULL, 
    [Major_Id] CHAR(10) NULL, 
    [Name] VARCHAR(50) NOT NULL, 
    [PhoneNum] CHAR(12) NOT NULL, 
    [Address] VARCHAR(50) NULL, 
    [PlaceBirth] VARCHAR(50) NULL, 
    [BirthDate] DATE NULL, 
    [NIK] CHAR(10) NULL, 
    [Email] VARCHAR(30) NULL, 
    [Religion] VARCHAR(30) NULL, 
    [NPWP] VARCHAR(30) NOT NULL, 
    [Barchelor] VARCHAR(50) NULL, 
    [University] VARCHAR(50) NULL, 
    [JoinDate] DATE NULL
)
