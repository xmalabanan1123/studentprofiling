CREATE TABLE [dbo].[Class] (
    [ID]       INT            IDENTITY (1, 1) NOT NULL,
    [Name]     NVARCHAR (MAX) NULL,
    [Birthday] DATETIME2 (7)  NOT NULL,
    [Gender]   NVARCHAR (MAX) NULL,
    [Address]  NVARCHAR (MAX) NULL,
    [Contact]  FLOAT (53)     NOT NULL,
    CONSTRAINT [PK_Class] PRIMARY KEY CLUSTERED ([ID] ASC)
);

