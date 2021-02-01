CREATE TABLE [dbo].[Tilaukset] (
    [AsiakasId] INT           NOT NULL,
    [Tuotteet]  VARCHAR (120) NULL,
    [MaksuTapa] VARCHAR (120) NULL,
    [Summa]     INT           NULL,
    PRIMARY KEY CLUSTERED ([AsiakasId] ASC)
);

