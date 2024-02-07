Clinical Encounter Notes Application







[Introduction] 

This project aims to develop a clinical encounter notes application that allows users to create, edit, read, and delete clinical encounter notes stored in a text file. 


[Core Functionality]
1. Load Past Notes:
   - Upon starting the application, load previously stored encounter notes from an Asure SQL database and display them in a listbox on the left-hand side, showing only the patient name and note ID.
   - Place the right-hand side (Add/Edit/Delete Encounter Note) in "awaiting note mode" by turning off most controls.

2. Edit/Delete Note:
   - Enable users to edit the fields of the selected Note and save changes using the "Update note" button.
   - The "Delete note" button lets users delete the selected Note.

3. Add New Note:
   - Enable users to start a new note by clicking the "Start new note" button.
   - Place the right-hand side in "add mode,"  insert a new note into the database by clicking the "Add note" button.

4. Manage Patient Problems:
   - Allow users to manage a list of patient problems separately from the Note.
   - Enable adding problems to the list and saving them to the database when a note is saved.
   - Allow deletion of problems from the list and update the stored Note when saved.

5. Extract Vitals:
   - Implement regular expressions to extract vitals (e.g., BP, HR) from the note content.
   - Display extracted vitals in the "Vitals" listbox, highlighting abnormal values.

6. Database Setup on Azure SQL:
 - Create a new Azure SQL Database instance.
 - Define the database schema including tables, columns, and relationships.
 - Set up appropriate user permissions and access control.
 - Load notes from the file at application startup.
 - Utilize a specific file format, e.g., one encounter note per line, with properties delimited by special characters.

7. Validation of User Input:
   - Validate input data for adding/editing an encounter note.
   - Ensure the note ID is unique and pre-assigned by the application.
   - Require patient name, date of birth (cannot be in the future), and clinical note content.

