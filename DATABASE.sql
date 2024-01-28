CREATE DATABASE PROJET
USE PROJET
create table client(
clientID INT IDENTITY(1,1) PRIMARY KEY,
NOM VARCHAR(200),
PRENOM VARCHAR(200),
ADRESS varchar(200),   
gender varchar(50), 
EMAIL varchar(200),
USERNAME varchar(200),
PWD varchar(200),
ROLE varchar(200),   
);
create table sport(
sportID INT IDENTITY(1,1)  PRIMARY KEY,
nom_sport varchar(200)    
);
INSERT INTO sport (nom_sport) VALUES ('Football');
INSERT INTO sport (nom_sport) VALUES ('Basketball');
INSERT INTO sport (nom_sport) VALUES ('Tennis');
INSERT INTO sport (nom_sport) VALUES ('Swimming');
INSERT INTO sport (nom_sport) VALUES ('Golf');
INSERT INTO sport (nom_sport) VALUES ('Athletics');
INSERT INTO sport (nom_sport) VALUES ('Volleyball');
INSERT INTO sport (nom_sport) VALUES ('Table Tennis');
INSERT INTO sport (nom_sport) VALUES ('Badminton');
INSERT INTO sport (nom_sport) VALUES ('Rugby');

create table stade(
stadiumID int  IDENTITY(1,1) PRIMARY KEY,
nb_places INT,
nom_stade VARCHAR(200)
);
insert into stade(nb_places,nom_stade) VALUES(50000,'Moulay Abdellah Rabat');
insert into stade(nb_places,nom_stade) VALUES(60000,'Mohamed V Casablanca');
INSERT INTO stade(nb_places, nom_stade) VALUES(52000, 'Stade Olympique de Sousse');
INSERT INTO stade(nb_places, nom_stade) VALUES(48000, 'Stade Mustapha Tchaker Blida');
INSERT INTO stade(nb_places, nom_stade) VALUES(60000, 'Stade 5 Juillet 1962 Algiers');
INSERT INTO stade(nb_places, nom_stade) VALUES(42000, 'Stade de Marrakech');
INSERT INTO stade(nb_places, nom_stade) VALUES(55000, 'Stade de la Méditerranée');
INSERT INTO stade(nb_places, nom_stade) VALUES(75000, 'Stade du 7 Novembre Rades');
INSERT INTO stade(nb_places, nom_stade) VALUES(35000, 'Stade Municipal Tunis');

create table evenement(
eventID INT IDENTITY(1,1) PRIMARY KEY,
sportID int,  
stadiumID int,  
nom_event varchar(200),
event_DATE DATE,
FOREIGN KEY (sportID) REFERENCES sport(sportID) ON DELETE CASCADE,
FOREIGN KEY (stadiumID) REFERENCES stade(stadiumID)
);
INSERT INTO client (NOM, PRENOM,ADRESS,gender,EMAIL,USERNAME,PWD,ROLE) VALUES ('admin', 'admin','admin','admin','admin','admin','admin','admin')
create table ticket(
ticketID INT IDENTITY(1,1) PRIMARY KEY,
clientID INT,
eventID INT,        
FOREIGN KEY (eventID) REFERENCES evenement(eventID),
FOREIGN KEY (clientID) REFERENCES client(clientID),
);
CREATE VIEW EventView AS
SELECT
    E.eventID,
    E.nom_event AS Event_Name,
    S.nom_sport AS Sport,
    ST.nom_stade AS Stadium,
    E.event_Date AS Event_Date
FROM
    sport S
    INNER JOIN evenement E ON S.sportID = E.sportID
    INNER JOIN stade ST ON ST.stadiumID = E.stadiumID;
CREATE PROCEDURE DeleteOldEvents
AS
BEGIN
    -- Set the current date
    DECLARE @current_date_var DATE;
    SET @current_date_var = GETDATE();

    -- Delete events where the event_date is less than the current date
    DELETE FROM evenement
    WHERE event_DATE < @current_date_var;
END;