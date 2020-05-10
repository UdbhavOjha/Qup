CREATE TABLE [dbo].[UserLedger] (
	Id INT PRIMARY KEY IDENTITY(1,1),
	Name VARCHAR(50) NOT NULL,
	Email VARCHAR(50) NULL,
	PhoneNumber VARCHAR(15) NULL,
	BusinessId INT NOT NULL, 
	DateCreated DATETIME DEFAULT GETDATE()
)