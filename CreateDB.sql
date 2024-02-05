-- Create the database if it doesn't exist
IF NOT EXISTS (SELECT 1 FROM sys.databases WHERE name = 'EncounterNotesDB')
    CREATE DATABASE EncounterNotesDB;

-- Use the database
USE EncounterNotesDB;

-- Create the Patients table
IF NOT EXISTS (SELECT 1 FROM sys.tables WHERE name = 'Patients')
    CREATE TABLE Patients (
        PatientID INT IDENTITY(1,1) PRIMARY KEY,
        Name VARCHAR(255) NOT NULL,
        DOB DATE NOT NULL
    );

-- Create the Encounters table
IF NOT EXISTS (SELECT 1 FROM sys.tables WHERE name = 'Encounters')
    CREATE TABLE Encounters (
        EncounterID INT IDENTITY(1,1) PRIMARY KEY,
        PatientID INT,
        EncounterDate DATETIME NOT NULL,
        ChiefComplaint VARCHAR(255) NOT NULL,
        FOREIGN KEY (PatientID) REFERENCES Patients(PatientID)
    );

-- Create the Notes table
IF NOT EXISTS (SELECT 1 FROM sys.tables WHERE name = 'Notes')
    CREATE TABLE Notes (
        NoteID INT IDENTITY(1,1) PRIMARY KEY,
        EncounterID INT,
        NoteDate DATETIME NOT NULL,
        NoteText TEXT NOT NULL,
        FOREIGN KEY (EncounterID) REFERENCES Encounters(EncounterID)
    );
