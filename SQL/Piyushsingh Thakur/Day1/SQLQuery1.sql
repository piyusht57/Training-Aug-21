USE [Day-1]

CREATE TABLE COUNTRIES
(
countryId TINYINT  PRIMARY KEY IDENTITY(1,1),
countryName VARCHAR(10) NOT NULL UNIQUE CHECK ( countryName in('india','china','italy')),
regionalId TINYINT UNIQUE
)
INSERT INTO COUNTRIES VALUES ('china', 02)
INSERT INTO COUNTRIES VALUES ('india', 06)
INSERT INTO COUNTRIES VALUES ('japan', 10)
INSERT INTO COUNTRIES VALUES ('italy', 08)


SELECT * FROM COUNTRIES

