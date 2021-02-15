CREATE TABLE [dbo].[Customers] (
    [UserId]      INT           NOT NULL,
    [CompanyName] NVARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([UserId]), 
    CONSTRAINT [FK_Customers_Users] FOREIGN KEY ([UserId]) REFERENCES [Customers]([UserId])
);

