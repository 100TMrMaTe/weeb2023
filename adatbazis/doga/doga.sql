CREATE DATABASE gyumolcsok DEFAULT charset=utf8 COLLATE=utf8_HUNGARIAN_CI;

USE gyumolcsok;

CREATE TABLE datum(
	datum VARCHAR(20),
	lada int,
	kg int,
	tipus VARCHAR(20)
	)
	
	
INSERT INTO gyumolcsok(datum,lada,kg,tipus) VALUE(2011.07.08,5,502,alma);
INSERT INTO gyumolcsok(datum,lada,kg,tipus) VALUE(2011.07.09,7,710,alma);
INSERT INTO gyumolcsok(datum,lada,kg,tipus) VALUE(2011.07.10,3,304,alma);
INSERT INTO gyumolcsok(datum,lada,kg,tipus) VALUE(2011.07.08,5,503,körte);
INSERT INTO gyumolcsok(datum,lada,kg,tipus) VALUE(2011.07.09,7,710,körte);
INSERT INTO gyumolcsok(datum,lada,kg,tipus) VALUE(2011.07.10,3,301,körte);
INSERT INTO gyumolcsok(datum,lada,kg,tipus) VALUE(2011.07.08,1,105,barack);
INSERT INTO gyumolcsok(datum,lada,kg,tipus) VALUE(2011.07.09,4,408,barack);
INSERT INTO gyumolcsok(datum,lada,kg,tipus) VALUE(2011.07.10,1,101,barack);

DROP DATABASE gyumolcsok