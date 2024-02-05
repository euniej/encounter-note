using PatientMaintenance;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Windows.Forms;

namespace EncounterNote_EunheuiJo
{
    public partial class FrmEncounterNote : Form
    {
        public FrmEncounterNote()
        {
            InitializeComponent();
        }
        List<Patient> patientList = null;
        private void FrmEncounterNote_Load(object sender, EventArgs e)
        {
            PatientDB.ConnectDB();
            LoadPatientDB();
            AwaitingNoteMode();
        }

        private void FrmEncounterNote_FormClosing(object sender, FormClosingEventArgs e)
        {
            PatientDB.DisConnectDB();
        }
        private void LoadPatientDB()
        {
            patientList = PatientDB.ReadData();
            DisplayListPatient();
        }

        private void DisplayListPatient()
        {
            lstPatients.Items.Clear();
            foreach (Patient pat in patientList)
            {
                string name = pat.Name + "(Note " + pat.NoteID + ")";
                lstPatients.Items.Add(name);
            }

        }

        private void FillItemListBox(int id)
        {
            if (id < 0) { return; }

            txtboxNoteID.Text = patientList[id].NoteID;
            txtboxName.Text = patientList[id].Name;

            string[] savedNotes = patientList[id].Notes.Split(';');
            string printedNotes = "";
            foreach (var not in savedNotes)
            {
                printedNotes += not + "\n";

            }
            rtxtboxNotes.Text = printedNotes;


            lstProblem.Items.Clear();
            string[] problems = patientList[id].Problems.Split(';');
            foreach (string pob in problems)
            {
                lstProblem.Items.Add(pob);
            }

            ParsingVitals(rtxtboxNotes);

        }

        public void ParsingVitals(RichTextBox note)
        {
            VitalsParser vitalsParser = new VitalsParser();
            vitalsParser.ParsingVitals(rtxtboxNotes);

            string[] retVitals = vitalsParser.ParsingResults.Split(';');
            lstVirals.Items.Clear();

            foreach (string vital in retVitals)
            {
                lstVirals.Items.Add(vital);
            }
        }
        private void lstPatients_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = lstPatients.SelectedIndex;
            FillItemListBox(id);
            EditMode();
        }

        private void btnAddProblem_Click(object sender, EventArgs e)
        {

            if (Validator.IsPresent(txtboxNewProblem.Text))
            {
                string newProblem = txtboxNewProblem.Text;
                lstProblem.Items.Add(newProblem);
            }
            txtboxNewProblem.Clear();
            lstProblem.Focus();
        }

        private void btnRemoveProblem_Click(object sender, EventArgs e)
        {
            if (lstProblem.SelectedItems.Count <= 0)
            {
                lblMessages.ForeColor = Color.Red;
                lblMessages.Text = "Please select a problem to delete.";
            }

            while (lstProblem.SelectedItems.Count > 0)
            {
                lstProblem.Items.Remove(lstProblem.Items[lstProblem.SelectedIndex]);
            }

            lstProblem.Update();
        }

        private void btnStartNewNote_Click(object sender, EventArgs e)
        {
            ClearEncounterNote();
            txtboxNoteID.Text = GetNewID();
            AddMode();

        }

        private void ClearEncounterNote()
        {
            //txtboxNoteID.Clear();
            txtboxName.Clear();
            txtboxNewProblem.Clear();
            lstProblem.Items.Clear();
            lstVirals.Items.Clear();
            rtxtboxNotes.Clear();

        }

        private string GetNewID()
        {
            int cntPatient = patientList.Count;
            int newID = 1;
            if (cntPatient > 0)
            {
                newID = Convert.ToInt32(patientList[cntPatient - 1].NoteID);
                newID++;
            }

            return newID.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) { return; }
            Patient person = new Patient();
            GetPatientInfo(ref person);
            patientList.Add(person);

            UpdateDB();
            EditMode();
        }

        private void btnDeleteNote_Click(object sender, EventArgs e)
        {
            int idx = lstPatients.SelectedIndex;
            patientList.RemoveAt(idx);
            UpdateDB();
            AwaitingNoteMode();
            lblMessages.ForeColor = Color.Black;
            lblMessages.Text = "a selected note is deleted sucessfully.";
        }

        private void GetPatientInfo(ref Patient person)
        {
            person.NoteID = txtboxNoteID.Text;
            person.Name = txtboxName.Text;
            person.Birthdate = dtpBirthDate.Value;

            string[] notes = rtxtboxNotes.Text.Split(new[] { '\r', '\n' });
            person.Notes = "";
            foreach (var item in notes)
            {
                person.Notes += item.ToString() + ";";

            }

            person.Problems = "";
            foreach (var item in lstProblem.Items)
            {
                person.Problems += item.ToString() + ";";

            }
        }
        private void UpdateDB()
        {
            PatientDB.InsertData(patientList);
            DisplayListPatient();
            lblMessages.ForeColor = Color.Black;
            lblMessages.Text = "New note was added.";

        }

        private void btnUpdateNote_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) { return; }

            int idx = lstPatients.SelectedIndex;
            Patient person = patientList[idx];
            GetPatientInfo(ref person);
            lblMessages.ForeColor = Color.Black;
            lblMessages.Text = "a selected note is updated sucessfully.";

            UpdateDB();
            AwaitingNoteMode();

        }

        private void rtxtboxNotes_TextChanged(object sender, EventArgs e)
        {
            ParsingVitals(rtxtboxNotes);
        }

        private bool ValidateInputs()
        {
            bool ret = true;
            lblMessages.Text = "";
            // Patient name is required
            if (!Validator.IsPresent(txtboxName.Text))
            {
                lblMessages.ForeColor = Color.Red;
                lblMessages.Text += "Patient name is a required field.\n";
                ret = false;
            }

            if (!Validator.IsPresent(rtxtboxNotes.Text))
            {
                lblMessages.ForeColor = Color.Red;
                lblMessages.Text += "Clinical note is a required field.\n";
                ret = false;
            }

            if (Validator.IsFuture(dtpBirthDate.Value))
            {
                lblMessages.ForeColor = Color.Red;
                lblMessages.Text += "Date of birth is required and cannot be in the future.\n";
                ret = false;

            }

            return ret;

        }

        // Set Form Mode(Add/Edit/Default)
        private void AddMode()
        {
            ClearEncounterNote();
            txtboxName.Enabled = true;
            dtpBirthDate.Enabled = true;
            txtboxNewProblem.Enabled = true;
            btnAddProblem.Enabled = true;
            rtxtboxNotes.Enabled = true;
            dtpBirthDate.Value = DateTime.Now.AddDays(1);
            btnAdd.Enabled = true;
            btnUpdateNote.Enabled = false;
            btnDeleteNote.Enabled = false;
        }

        //This loads the properties 
        //The “Update note?and “Delete note?buttons are enabled but the “Add note?button is disabled.
        private void EditMode()
        {
            txtboxName.Enabled = true;
            dtpBirthDate.Enabled = true;
            txtboxNewProblem.Enabled = true;
            btnAddProblem.Enabled = true;
            rtxtboxNotes.Enabled = true;

            btnAdd.Enabled = false;
            btnUpdateNote.Enabled = true;
            btnDeleteNote.Enabled = true;
        }

        //The "awaiting note mode?by disabling most of the controls.
        private void AwaitingNoteMode()
        {
            ClearEncounterNote();
            txtboxNoteID.Text = "";
            txtboxName.Enabled = false;
            dtpBirthDate.Enabled = false;
            txtboxNewProblem.Enabled = false;
            btnAddProblem.Enabled = false;
            rtxtboxNotes.Enabled = false;
            btnAdd.Enabled = false;
            btnUpdateNote.Enabled = false;
            btnDeleteNote.Enabled = false;
            btnStartNewNote.Focus();

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}