   SELECT SUM(CAST(INS.TIV_2012 AS DECIMAL(20,2)))
     FROM INSURANCE (NOLOCK) INS
     JOIN INSURANCE (NOLOCK) INSB ON INSB.TIV_2011 = INS.TIV_2011
	  AND INS.PID <> INSB.PID
	  AND (INSB.LAT = INS.LAT OR INSB.LON = INS.LON)
LEFT JOIN INSURANCE (NOLOCK) INSC ON INSC.TIV_2011 <> INS.TIV_2011
      AND (INSC.LAT = INS.LAT AND INSC.LON = INS.LON)
	  AND INSC.PID <> INS.PID
    WHERE INSC.PID IS NULL

  SELECT TOP 12 'INSERT INTO INSURANCE SELECT ' + CONVERT(VARCHAR(25), CAST(TIV_2011 AS DECIMAL(20,2))) + ', '+ CONVERT(VARCHAR(25), CAST(TIV_2012 AS DECIMAL(20,2))) + ', '+ CONVERT(VARCHAR(25), LAT) + ', '+ CONVERT(VARCHAR(25), LON) + '; '
    FROM INSURANCE
   WHERE PID > 0
ORDER BY PID;

SELECT * 
  FROM INSURANCE (NOLOCK) INS
  JOIN INSURANCE (NOLOCK) INSC ON INSC.TIV_2011 <> INS.TIV_2011
   AND (INSC.LAT = INS.LAT AND INSC.LON = INS.LON)
   AND (INSC.PID <> INS.PID)

DECLARE @NO_MATCH_TIV AS TABLE
(
	PID INT, 
	TIV_2011 FLOAT,
	TIV_2012 FLOAT,
	LAT FLOAT,
	LON FLOAT
);

INSERT INTO @NO_MATCH_TIV
     SELECT INS.*
       FROM INSURANCE (NOLOCK) INS
       JOIN INSURANCE (NOLOCK) INSB ON INS.TIV_2011 = INSB.TIV_2011 
        AND (INSB.LAT <> INS.LAT AND INSB.LON <> INS.LON)
        AND INS.PID <> INSB.PID

DELETE FROM @NO_MATCH_TIV
WHERE PID IN(
SELECT INS.PID  FROM INSURANCE (NOLOCK) INS
  JOIN INSURANCE (NOLOCK) INSC ON INSC.TIV_2011 <> INS.TIV_2011
   AND (INSC.LAT = INS.LAT AND INSC.LON = INS.LON)
   AND (INSC.PID <> INS.PID))

SELECT CAST(SUM(TIV_2012) AS DECIMAL(18,2)) FROM @NO_MATCH_TIV

SELECT * FROM INSURANCE

   AND ((INSB.TIV_2011 = INS.TIV_2011 AND (INSB.LAT <> INS.LAT AND INSB.LON <> INS.LON)) OR 
	   (INSB.TIV_2011 <> INS.TIV_2011 AND (INSB.LAT <> INS.LAT AND INSB.LON <> INS.LON)))
   
   AND 

SELECT SUM(TIV_2012) 
 FROM (    SELECT INS.PID, CAST(INS.TIV_2012 AS DECIMAL(20,2)) TIV_2012
             FROM INSURANCE (NOLOCK) INS
             JOIN INSURANCE (NOLOCK) INSB ON INSB.TIV_2011 = INS.TIV_2011
		      AND INS.PID <> INSB.PID
			  AND (INSB.LAT <> INS.LAT AND INSB.LON <> INS.LON)
	    LEFT JOIN INSURANCE (NOLOCK) INSC ON INSC.TIV_2011 <> INS.TIV_2011
              AND (INSC.LAT = INS.LAT AND INSC.LON = INS.LON)
	          AND (INSC.PID <> INS.PID AND INSC.PID <> INSB.PID)
            WHERE INSC.PID IS NULL
         GROUP BY INS.PID, INS.TIV_2012) T

--SELECT * FROM INSURANCE

  SELECT DISTINCT TIV_2011
    FROM INSURANCE
ORDER BY TIV_2011

-- PASS OK

SELECT CAST(SUM(TIV_2012) AS DECIMAL(20,2))
  FROM (
   SELECT INS.PID, INS.TIV_2011, INS.TIV_2012, INS.LAT, INS.LON
     FROM INSURANCE (NOLOCK) INS
     JOIN INSURANCE (NOLOCK) INSB ON INSB.TIV_2011 = INS.TIV_2011
	  AND INS.PID <> INSB.PID
	  AND (INSB.LAT <> INS.LAT OR INSB.LON <> INS.LON)
 GROUP BY INS.PID, INS.TIV_2011, INS.TIV_2012, INS.LAT, INS.LON
   HAVING (SELECT COUNT(0) 
			 FROM INSURANCE (NOLOCK) INSC
			WHERE INSC.TIV_2011 <> INS.TIV_2011
			  AND (INSC.LAT = INS.LAT AND INSC.LON = INS.LON)
			  AND INSC.PID <> INS.PID) <= 0) T

     SELECT CAST(SUM(INS.TIV_2012) AS DECIMAL(20,2))
       FROM INSURANCE (NOLOCK) INS
       JOIN INSURANCE (NOLOCK) INSB ON INSB.TIV_2011 = INS.TIV_2011
        AND INS.PID <> INSB.PID
        AND (INSB.LAT <> INS.LAT OR INSB.LON <> INS.LON)
OUTER APPLY (SELECT COUNT(0) Qty
			   FROM INSURANCE (NOLOCK) INSC
			  WHERE INSC.TIV_2011 <> INS.TIV_2011
			    AND (INSC.LAT = INS.LAT AND INSC.LON = INS.LON)
			    AND INSC.PID <> INS.PID) MT_LN_LO
WHERE ISNULL(MT_LN_LO.Qty,0) = 0