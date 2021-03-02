CREATE TABLE [dbo].[CarImages] (
    [CarImageId] INT            NULL,
    [CarId]      INT            NULL,
    [ImagePath]  NVARCHAR (MAX) NULL,
    [Date]       DATETIME       NULL,
    PRIMARY KEY CLUSTERED ([CarImageId] ASC)
);

