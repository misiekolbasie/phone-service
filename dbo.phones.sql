CREATE TABLE [dbo].[phones] (
    [id]    BIGINT         IDENTITY (1, 1) NOT NULL,
    [name]  NVARCHAR (MAX) NULL,
    [Model] NVARCHAR (MAX) NULL,
    [Price] DECIMAL NULL, 
    CONSTRAINT [PK_phones] PRIMARY KEY CLUSTERED ([id] ASC)
);

