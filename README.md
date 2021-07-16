# PhoneDictionary
Set the connection string in DBContext.cs based on your local sql server
in your sql server, create a table name Customer:
CREATE TABLE [dbo].[Customer] (
    [Id]          INT           IDENTITY (1, 1) NOT NULL,
    [Name]        NVARCHAR (50) NOT NULL,
    [Address]     NVARCHAR (50) NULL,
    [Email]       NVARCHAR (50) NULL,
    [PhoneNumber] NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED ([Id] ASC)
);
