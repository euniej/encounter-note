using MySql.Data.MySqlClient;
using Org.BouncyCastle.Ocsp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static Org.BouncyCastle.Math.EC.ECCurve;

namespace PatientMaintenance
{
    public class PatientDB
    {


        static SqlConnection connection;


        public static void ConnectDB()
        {



            string connectionString =
                "Server = tcp:eunie.database.windows.net,1433;" +
                "Database = EncounterNotesDB;" +
                "Persist Security Info = False;" +
                "User ID = eunie;" +
                "Password = password!2;" +
                "MultipleActiveResultSets = False;" +
                "Encrypt = True;" +
                "TrustServerCertificate = False;" +
                "Connection Timeout =30;";


            connection = new SqlConnection(connectionString);
            
            try
            {
                connection.Open();
                Console.WriteLine("Connected to the database.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }

        }

        public static void DisConnectDB()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public static void InsertData(List<Patient> items)
        {
            foreach (Patient person in items)
            {

                using var cmdPatient = new SqlCommand("INSERT INTO Patients (Name, DOB) VALUES (@Name, @DOB)", connection);
                cmdPatient.Parameters.AddWithValue("@Name", person.Name);
                cmdPatient.Parameters.AddWithValue("@DOB", person.Birthdate);
                cmdPatient.ExecuteNonQuery();

                long patientID = Convert.ToInt64(cmdPatient.ExecuteScalar());

                using var cmdEncounter = new SqlCommand("INSERT INTO Encounters (PatientID, EncounterDate, ChiefComplaint) VALUES (@PatientID, @EncounterDate, @ChiefComplaint)", connection);
                cmdEncounter.Parameters.AddWithValue("@PatientID", patientID);
                cmdEncounter.Parameters.AddWithValue("@EncounterDate", DateTime.Now);
                cmdEncounter.Parameters.AddWithValue("@ChiefComplaint", person.Problems);
                cmdEncounter.ExecuteNonQuery();

                long encounterID = Convert.ToInt64(cmdEncounter.ExecuteScalar());

                using var cmdNotes = new SqlCommand("INSERT INTO Notes (EncounterID, NoteDate, NoteText) VALUES (@EncounterID, @NoteDate, @NoteText)", connection);
                cmdNotes.Parameters.AddWithValue("@EncounterID", encounterID);
                cmdNotes.Parameters.AddWithValue("@NoteDate", DateTime.Now);
                cmdNotes.Parameters.AddWithValue("@NoteText", person.Notes);
                cmdNotes.ExecuteNonQuery();
            }

            Console.WriteLine("Data inserted successfully.");
        }

        public static List<Patient> ReadData()
        {
            // Create the list
            List<Patient> patients = new List<Patient>();

            string query = "SELECT Patients.Name, Patients.DOB, Encounters.EncounterID, Encounters.EncounterDate, Encounters.ChiefComplaint, Notes.NoteDate, Notes.NoteText " +
                            "FROM Patients " +
                            "JOIN Encounters ON Patients.PatientID = Encounters.PatientID " +
                            "JOIN Notes ON Encounters.EncounterID = Notes.EncounterID";

            using (var adapter = new SqlDataAdapter(query, connection))
            {
                var table = new DataTable();
                adapter.Fill(table);

                Console.WriteLine("\nData from the database:\n");
                foreach (DataRow row in table.Rows)
                {
                    Console.WriteLine($"Patient: {row["Name"]}, Encounter Date: {row["EncounterDate"]}, Chief Complaint: {row["ChiefComplaint"]}, Note Date: {row["NoteDate"]}, Note Text: {row["NoteText"]}");

                    Patient info = new Patient();
                    info.NoteID = row["EncounterID"].ToString();
                    info.Name = row["Name"].ToString();
                    info.Birthdate = Convert.ToDateTime(row["DOB"]);
                    info.Problems = row["ChiefComplaint"].ToString();
                    info.Notes = row["NoteText"].ToString();
                    patients.Add(info);
                }
            }

            return patients;

        }

    }


}
