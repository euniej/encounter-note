-- Insert data into Patients table
INSERT INTO Patients (Name, DOB)
VALUES
    ('Jane', '1990-01-01'),
    ('Kay', '1995-12-31');

-- Insert data into Encounters table
INSERT INTO Encounters (PatientID, EncounterDate, ChiefComplaint)
VALUES
    (1, '2023-04-04 22:29:46', 'Overweight'),
    (2, '2023-04-21 22:29:46', 'fever;soar throat;');

-- Insert data into Notes table
INSERT INTO Notes (EncounterID, NoteDate, NoteText)
VALUES
    (1, '2023-04-04 22:29:46', 'T: 38;BP: 120/70;;fever, need to consult with ....;;;;'),
    (2, '2023-04-21 22:29:46', 'He needs to take COVID test;;T 39;BP: 70/50;HR:14;;;');
