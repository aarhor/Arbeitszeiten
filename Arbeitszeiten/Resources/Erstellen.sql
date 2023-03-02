CREATE TABLE Taetigkeiten (_id INTEGER PRIMARY KEY AUTOINCREMENT, Datum date, Uhrzeit datetime, Tätigkeit TEXT);
CREATE TABLE Zeiten (_id INTEGER PRIMARY KEY AUTOINCREMENT, Datum DATE, Start DATETIME, Ende DATETIME, Differenz DOUBLE, MehrMinder_Stunden DOUBLE, Bemerkung TEXT
default NULL);
CREATE VIEW 'geordnet' AS select * from "Zeiten" order by Datum, Start;
CREATE VIEW 'Überstunden' AS select round(sum(MehrMinder_Stunden), 2) as Überstunden from "Zeiten";