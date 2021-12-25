CREATE TABLE [dbo].[Products] (
    [id]      INT          IDENTITY (1, 1) NOT NULL,
    [Ad]      VARCHAR (50) NOT NULL,
    [Stok]    INT          NOT NULL,
    [Fiyat]   MONEY        NOT NULL,
    [Agirlik] DECIMAL (18) NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
);

