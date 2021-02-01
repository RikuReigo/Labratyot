CREATE TABLE [dbo].[Tilaukset] (
    [TilausID]  INT           NOT NULL,
    [Tuotteet]  VARCHAR (120) NULL,
    [MaksuTapa] VARCHAR (120) NULL,
    [AsiakasID] INT           NULL,
    PRIMARY KEY CLUSTERED ([TilausID] ASC),
    CONSTRAINT [FK_Tilaukset_ToTable] FOREIGN KEY ([AsiakasID]) REFERENCES [dbo].[Asiakas] ([AsiakkaanID])
);

CREATE TABLE [dbo].[Asiakas] (
    [AsiakkaanID]   INT           NOT NULL,
    [AsiakkaanNimi] VARCHAR (120) NULL,
    [Asiakastyyppi] INT           NULL,
    PRIMARY KEY CLUSTERED ([AsiakkaanID] ASC),
    CONSTRAINT [FK_Asiakas_ToTable] FOREIGN KEY ([Asiakastyyppi]) REFERENCES [dbo].[AsiakasTyyppi] ([ID])
);

CREATE TABLE [dbo].[TilausTuote] (
    [TilausTuoteID] INT NOT NULL,
    [Tilaus]        INT NULL,
    [Tuote]         INT NULL,
    PRIMARY KEY CLUSTERED ([TilausTuoteID] ASC),
    CONSTRAINT [FK_TilausTuote_ToTable] FOREIGN KEY ([Tilaus]) REFERENCES [dbo].[Tilaukset] ([TilausID]),
    CONSTRAINT [FK_TilausTuote_ToTable_1] FOREIGN KEY ([Tuote]) REFERENCES [dbo].[Tuotteet] ([TuoteID])
);

CREATE TABLE [dbo].[AsiakasTyyppi] (
    [ID]            INT          NOT NULL,
    [Asiakastyyppi] VARCHAR (50) NULL,
    [AHL] DECIMAL(18, 2) NULL, 
    PRIMARY KEY CLUSTERED ([ID] ASC)
);

CREATE TABLE [dbo].[Tuotteet] (
    [TuoteNimi]     VARCHAR (120) NOT NULL,
    [TuoteTyyppi]   VARCHAR (120) NULL,
    [TuotteenHinta] DECIMAL(18, 2) NULL,
    [TuoteID]       INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([TuoteID] ASC)
);

SELECT N.TilausID, T.TuoteNimi, A.AsiakkaanNimi
FROM Tilaukset N, Tuotteet T, TilausTuote M, Asiakas A
WHERE N.TilausID = M.Tilaus AND T.TuoteID = M.Tuote AND A.AsiakkaanID = N.AsiakasID

SELECT COUNT(N.TilausID), T.TuotteenHinta, A.AsiakkaanNimi
FROM Tilaukset N, Tuotteet T, Tilaustuote M, Asiakas A
WHERE N.TilausID = M.Tilaus AND T.TuoteID = M.Tuote AND A.AsiakkaanID = N.AsiakasID
GROUP BY N.AsiakasID