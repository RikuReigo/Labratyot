CREATE TABLE [dbo].[Asiakas] (
    [AsiakkaanID]   INT           NOT NULL,
    [AsiakkaanNimi] VARCHAR (120) NULL,
    [Asiakastyyppi] VARCHAR (120) NULL,
    [Tilaus]        VARCHAR (120) NULL,
    PRIMARY KEY CLUSTERED ([AsiakkaanID] ASC)
);

