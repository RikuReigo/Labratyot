--SELECT A.nimi, T.nimi
--FROM Asiakkaat A, Tuotteet T, Ostokset O
--WHERE A.id = O.asiakas_id AND T.id = O.tuote_id;

--SELECT A.nimi, COUNT(T.id), SUM(T.hinta)
--FROM Asiakkaat A, Tuotteet T, Ostokset O
--WHERE A.id = O.asiakas_id AND T.id = O.tuote_id
--GROUP BY A.id;

SELECT N.TilausID, T.TuoteNimi, A.AsiakkaanNimi
FROM Tilaukset N, Tuotteet T, TilausTuote M, Asiakas A
WHERE N.TilausID = M.Tilaus AND T.TuoteID = M.Tuote AND A.AsiakkaanID = N.AsiakasID

SELECT COUNT(N.AsiakasID) as Tilauksia, T.TuotteenHinta, A.AsiakkaanNimi, K.AHL*T.TuotteenHinta as Yhteensä
FROM Tilaukset N, Tuotteet T, Tilaustuote M, Asiakas A, AsiakasTyyppi K
WHERE N.TilausID = M.Tilaus AND T.TuoteID = M.Tuote AND A.AsiakkaanID = N.AsiakasID AND K.ID = A.Asiakastyyppi
GROUP BY N.TilausID, T.TuotteenHinta, A.AsiakkaanNimi, K.AHL, N.Tuotteet

--SELECT K.AHL*T.TuotteenHinta as Yhteensä
--Where T.TuoteID = M.Tuote