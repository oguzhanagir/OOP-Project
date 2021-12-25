CREATE TABLE [dbo].[Users] (
    [Id]        INT          IDENTITY (1, 1) NOT NULL,
    [Ad]        VARCHAR (50) NOT NULL,
    [Soyad]     VARCHAR (50) NOT NULL,
    [ePosta]    VARCHAR (50) NOT NULL,
    [Sifre]     INT          NOT NULL,
    [TelefonNo] INT          NOT NULL,
    [İl]        VARCHAR (20) NOT NULL,
    [İlce]      VARCHAR (20) NOT NULL,
    [PostaKodu] INT          NOT NULL,
    [Adres]     VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

