CREATE TABLE [dbo].[Customers] (
    [CustomerId]      INT           NOT NULL,
    [CompanyName] NVARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([CustomerId]),
    CONSTRAINT [FK_Customers_Users] FOREIGN KEY ([CustomerId]) REFERENCES [dbo].[Customers] ([CustomerId])
);

