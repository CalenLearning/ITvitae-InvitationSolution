CREATE TABLE [dbo].[Table]
(
	[Person] INT NOT NULL PRIMARY KEY, 
    [FirstName] VARCHAR(50) NOT NULL, 
    [SurnamePrefix] VARCHAR(50) NULL, 
    [Surname] VARCHAR(50) NOT NULL, 
    [Gender] CHAR(10) NOT NULL, 
    [FirstContactMethod] CHAR(10) NOT NULL, 
    [SecondContactMethod] CHAR(10) NULL, 
    [ThirdContactMethod] CHAR(10) NULL, 
    [FourthContactMethod] CHAR(10) NULL
)
