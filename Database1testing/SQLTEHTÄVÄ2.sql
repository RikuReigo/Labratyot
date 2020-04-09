CREATE TABLE Kirja (
ID INT NOT NULL PRIMARY KEY,
Kirjan_Nimi VARCHAR(120) NULL,
Kustantaja VARCHAR(120) NULL,
Vuosi INT NULL,
SivuMäärä INT NULL
)

SELECT *
FROM Kirja
Where Kustantaja = 'Docendo'

SELECT *
FROM Kirja
Where Kustantaja <> 'Docendo'

SELECT *
FROM Kirja
WHERE 200 < SivuMäärä AND SivuMäärä < 295

SELECT *
FROM Kirja
WHERE Kustantaja = 'Docendo' AND Vuosi = 2015

SELECT *
FROM Kirja
WHERE Vuosi <= 2015