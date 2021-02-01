CREATE TABLE [dbo].[Tuotteet] (
    [TuoteNimi]     VARCHAR (120) NOT NULL,
    [TuoteTyyppi]   VARCHAR (120) NULL,
    [TuotteenHinta] VARCHAR (120) NULL,
    [PKTuotteenID] INT NOT NULL, 
    PRIMARY KEY CLUSTERED ([PKTuotteenID] ASC)
);

