﻿CREATE TABLE Taetigkeiten (
    _id INTEGER PRIMARY KEY AUTOINCREMENT,
    Datum date,
    Uhrzeit datetime,
    Tätigkeit TEXT
);

CREATE TABLE "Zeiten" (
    "_id" INTEGER,
    "Datum" DATE,
    "Start" DATETIME,
    "Ende" DATETIME,
    "Differenz" DOUBLE,
    "MehrMinder_Stunden" DOUBLE,
    "Bemerkung" TEXT DEFAULT NULL,
    "Metadaten" TEXT DEFAULT NULL,
    PRIMARY KEY("_id" AUTOINCREMENT)
);

CREATE VIEW 'view_geordnet' AS
select
    *
from
    "Zeiten"
order by
    Datum,
    Start;

CREATE VIEW 'view_überstunden' AS
select
    round(sum(MehrMinder_Stunden), 2) as Überstunden
from
    "Zeiten";