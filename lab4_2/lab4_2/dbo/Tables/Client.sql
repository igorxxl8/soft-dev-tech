﻿CREATE TABLE [dbo].[Client]
(
	[ClientID] UNIQUEIDENTIFIER NOT NULL, 
    [FirstName] VARCHAR(30) NOT NULL, 
    [LastName] VARCHAR(30) NOT NULL, 
    [PhoneNumber] VARCHAR(30) NOT NULL, 
    [Email] VARCHAR(30) NOT NULL, 
    [Photo] VARBINARY(MAX) NULL, 
    [Passowrd] VARCHAR(88) NOT NULL, 
    CONSTRAINT [PK_Client] PRIMARY KEY CLUSTERED ([ClientID] ASC)
)
