CREATE TABLE [dbo].[Users] (
    [UserId]    INT           NOT NULL IDENTITY,
    [FirstName] NVARCHAR(50)    NOT NULL,
    [LastName]  NVARCHAR(50)    NOT NULL,
    [Email]     NVARCHAR (50) NOT NULL,
    [PasswordHash]  BINARY(500)           NOT NULL,
    [PasswordSalt] BINARY(500) NOT NULL, 
    [Status] BIT NOT NULL, 
    PRIMARY KEY CLUSTERED ([UserId] ASC)
);

