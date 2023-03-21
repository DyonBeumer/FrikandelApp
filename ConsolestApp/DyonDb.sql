use DBDB;

CREATE TABLE DBData(Id int, DataEntry varchar(max), EntryDate datetime);

Insert into DBData values (1, 'Dyon SQL Journey', CURRENT_TIMESTAMP);

Select * 
From DBData;