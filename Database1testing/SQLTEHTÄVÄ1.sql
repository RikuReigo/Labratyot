CREATE TABLE kaupungit (
  [ID] INT NOT NULL PRIMARY KEY,
  [NIMI] VARCHAR(120) NULL,
  [asukasluku] INT NULL,
  [PintaAla]INT NULL,
  PRIMARY KEY CLUSTERED ([ID] ASC)
)

INSERT INTO kaupungit (ID, NIMI, asukasluku, PintaAla)
VALUES(1, 'Helsinki', 550000, 184.5 ),
(2, 'Tampere', 280000, 523 ),
(3, 'Jyväskylä', 120000, 105 ),
(4, 'Oulu', 220000, 184.5 );

SELECT NIMI, PintaAla
FROM kaupungit
WHERE NIMI = Jyväskylä

SELECT asukasluku 
FROM kaupungit
WHERE asukasluku < 200000

UPDATE kaupungit
SET PintaAla = 340
WHERE NIMI = 'Tampere'