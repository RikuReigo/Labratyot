UPDATE elokuvat
SET Julkaisija = 'MTV3'
WHERE Julkaisija LIKE 'MTV%'

SELECT Julkaisija
FROM Elokuvat
WHERE Julkaisija LIKE 'MTV%'

CREATE TABLE Julkaisija
(
ID INT PRIMARY KEY, 
Julkaisija VARCHAR(120),
ElokuvaID INT FOREIGN KEY REFERENCES elokuvat(Id),
)

INSERT INTO Julkaisija
SELECT DISTINCT Julkaisija FROM elokuvat

UPDATE elokuvat
SET Julkaisija = Julkaisija.ID
FROM Julkaisija
WHERE elokuvat.julkaisija = Julkaisija.Julkaisija

UPDATE elokuvat
SET Julkaisuvuosi = 2011
WHERE ID = 7

SELECT Nimi
FROM Elokuvat
WHERE Julkaisuvuosi < 2007 AND Julkaisuvuosi > 1998

SELECT Nimi
FROM Elokuvat
ORDER BY Arvio DESC

SELECT Nimi
FROM Elokuvat
WHERE Julkaisuvuosi = 2020
ORDER BY Arvio DESC

SELECT Nimi
FROM Elokuvat
WHERE Nimi LIKE '% and %'

SELECT Nimi
FROM Elokuvat
WHERE Nimi LIKE 'K%'

SELECT Nimi
FROM Elokuvat
Where Julkaisija = "Yle"

SELECT
UPPER(Julkaisija)

SELECT Nimi
FROM Elokuvat
WHERE Kesto < 60 AND Julkaisuvuosi > 2000

SELECT Nimi
FROM Elokuvat
WHERE Kesto > 80 OR Nimi LIKE's%'

SELECT Nimi
FROM Elokuvat
WHERE Julkaisija <> 'Yle' OR Julkaisuvuosi > 2000

SELECT Nimi
FROM Elokuvat
WHERE Julkaisija IN ('Yle', 'BBC' ,'MTV3')

SELECT COUNT([ALL|DISTINCT])
FROM Elokuvat

SELECT AVG Kesto
FROM Elokuvat

SELECT MAX Kesto
FROM Elokuvat

SELECT MIN Julkaisuvuosi
FROM Elokuvat
