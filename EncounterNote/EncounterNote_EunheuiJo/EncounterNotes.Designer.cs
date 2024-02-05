namespace EncounterNote_EunheuiJo
{
    partial class FrmEncounterNote
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnStartNewNote = new Button();
            lstPatients = new ListBox();
            groupBox1 = new GroupBox();
            btnAddProblem = new Button();
            btnDeleteNote = new Button();
            lstVirals = new ListBox();
            rtxtboxNotes = new RichTextBox();
            btnUpdateNote = new Button();
            lstProblem = new ListBox();
            btnAdd = new Button();
            dtpBirthDate = new DateTimePicker();
            txtboxNewProblem = new TextBox();
            btnRemoveProblem = new Button();
            txtboxName = new TextBox();
            label7 = new Label();
            txtboxNoteID = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lblMessages = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label8 = new Label();
            panel1 = new Panel();
            groupBox1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnStartNewNote
            // 
            btnStartNewNote.BackColor = Color.FloralWhite;
            btnStartNewNote.Location = new Point(24, 35);
            btnStartNewNote.Margin = new Padding(3, 4, 3, 4);
            btnStartNewNote.Name = "btnStartNewNote";
            btnStartNewNote.Size = new Size(164, 40);
            btnStartNewNote.TabIndex = 1;
            btnStartNewNote.Text = "Start new note";
            btnStartNewNote.UseVisualStyleBackColor = false;
            btnStartNewNote.Click += btnStartNewNote_Click;
            // 
            // lstPatients
            // 
            lstPatients.BackColor = Color.GhostWhite;
            lstPatients.FormattingEnabled = true;
            lstPatients.ItemHeight = 20;
            lstPatients.Location = new Point(24, 104);
            lstPatients.Margin = new Padding(3, 4, 3, 4);
            lstPatients.Name = "lstPatients";
            lstPatients.Size = new Size(164, 444);
            lstPatients.TabIndex = 2;
            lstPatients.SelectedIndexChanged += lstPatients_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAddProblem);
            groupBox1.Controls.Add(btnDeleteNote);
            groupBox1.Controls.Add(lstVirals);
            groupBox1.Controls.Add(rtxtboxNotes);
            groupBox1.Controls.Add(btnUpdateNote);
            groupBox1.Controls.Add(lstProblem);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(dtpBirthDate);
            groupBox1.Controls.Add(txtboxNewProblem);
            groupBox1.Controls.Add(btnRemoveProblem);
            groupBox1.Controls.Add(txtboxName);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtboxNoteID);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(234, 104);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(815, 505);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add/Edir/Delete Encounter Note";
            // 
            // btnAddProblem
            // 
            btnAddProblem.Location = new Point(266, 172);
            btnAddProblem.Margin = new Padding(3, 4, 3, 4);
            btnAddProblem.Name = "btnAddProblem";
            btnAddProblem.Size = new Size(62, 32);
            btnAddProblem.TabIndex = 16;
            btnAddProblem.Text = "Add";
            btnAddProblem.UseVisualStyleBackColor = true;
            btnAddProblem.Click += btnAddProblem_Click;
            // 
            // btnDeleteNote
            // 
            btnDeleteNote.Location = new Point(280, 440);
            btnDeleteNote.Margin = new Padding(3, 4, 3, 4);
            btnDeleteNote.Name = "btnDeleteNote";
            btnDeleteNote.Size = new Size(111, 39);
            btnDeleteNote.TabIndex = 11;
            btnDeleteNote.Text = "Delete note";
            btnDeleteNote.UseVisualStyleBackColor = true;
            btnDeleteNote.Click += btnDeleteNote_Click;
            // 
            // lstVirals
            // 
            lstVirals.FormattingEnabled = true;
            lstVirals.ItemHeight = 20;
            lstVirals.Location = new Point(544, 53);
            lstVirals.Margin = new Padding(3, 4, 3, 4);
            lstVirals.Name = "lstVirals";
            lstVirals.Size = new Size(229, 184);
            lstVirals.TabIndex = 15;
            // 
            // rtxtboxNotes
            // 
            rtxtboxNotes.Location = new Point(19, 276);
            rtxtboxNotes.Margin = new Padding(3, 4, 3, 4);
            rtxtboxNotes.Name = "rtxtboxNotes";
            rtxtboxNotes.Size = new Size(754, 149);
            rtxtboxNotes.TabIndex = 8;
            rtxtboxNotes.Text = "";
            rtxtboxNotes.TextChanged += rtxtboxNotes_TextChanged;
            // 
            // btnUpdateNote
            // 
            btnUpdateNote.Location = new Point(147, 440);
            btnUpdateNote.Margin = new Padding(3, 4, 3, 4);
            btnUpdateNote.Name = "btnUpdateNote";
            btnUpdateNote.Size = new Size(111, 39);
            btnUpdateNote.TabIndex = 12;
            btnUpdateNote.Text = "Update note";
            btnUpdateNote.UseVisualStyleBackColor = true;
            btnUpdateNote.Click += btnUpdateNote_Click;
            // 
            // lstProblem
            // 
            lstProblem.FormattingEnabled = true;
            lstProblem.ItemHeight = 20;
            lstProblem.Location = new Point(366, 53);
            lstProblem.Margin = new Padding(3, 4, 3, 4);
            lstProblem.Name = "lstProblem";
            lstProblem.Size = new Size(146, 144);
            lstProblem.TabIndex = 14;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(19, 440);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(111, 39);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "Add note";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.Location = new Point(120, 127);
            dtpBirthDate.Margin = new Padding(3, 4, 3, 4);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(191, 27);
            dtpBirthDate.TabIndex = 9;
            // 
            // txtboxNewProblem
            // 
            txtboxNewProblem.Location = new Point(120, 173);
            txtboxNewProblem.Margin = new Padding(3, 4, 3, 4);
            txtboxNewProblem.Name = "txtboxNewProblem";
            txtboxNewProblem.Size = new Size(138, 27);
            txtboxNewProblem.TabIndex = 7;
            // 
            // btnRemoveProblem
            // 
            btnRemoveProblem.Location = new Point(366, 207);
            btnRemoveProblem.Margin = new Padding(3, 4, 3, 4);
            btnRemoveProblem.Name = "btnRemoveProblem";
            btnRemoveProblem.Size = new Size(129, 31);
            btnRemoveProblem.TabIndex = 13;
            btnRemoveProblem.Text = "Remove problem";
            btnRemoveProblem.UseVisualStyleBackColor = true;
            btnRemoveProblem.Click += btnRemoveProblem_Click;
            // 
            // txtboxName
            // 
            txtboxName.Location = new Point(120, 81);
            txtboxName.Margin = new Padding(3, 4, 3, 4);
            txtboxName.Name = "txtboxName";
            txtboxName.Size = new Size(214, 27);
            txtboxName.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(544, 25);
            label7.Name = "label7";
            label7.Size = new Size(48, 20);
            label7.TabIndex = 5;
            label7.Text = "Virals:";
            // 
            // txtboxNoteID
            // 
            txtboxNoteID.Location = new Point(120, 37);
            txtboxNoteID.Margin = new Padding(3, 4, 3, 4);
            txtboxNoteID.Name = "txtboxNoteID";
            txtboxNoteID.ReadOnly = true;
            txtboxNoteID.Size = new Size(114, 27);
            txtboxNoteID.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(366, 25);
            label6.Name = "label6";
            label6.Size = new Size(74, 20);
            label6.TabIndex = 4;
            label6.Text = "Problems:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 252);
            label5.Name = "label5";
            label5.Size = new Size(51, 20);
            label5.TabIndex = 4;
            label5.Text = "Notes:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 179);
            label4.Name = "label4";
            label4.Size = new Size(103, 20);
            label4.TabIndex = 3;
            label4.Text = "New problem:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 132);
            label3.Name = "label3";
            label3.Size = new Size(97, 20);
            label3.TabIndex = 2;
            label3.Text = "Date of Birth:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 87);
            label2.Name = "label2";
            label2.Size = new Size(98, 20);
            label2.TabIndex = 1;
            label2.Text = "Patient name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 43);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 0;
            label1.Text = "Note ID:";
            // 
            // lblMessages
            // 
            lblMessages.AutoSize = true;
            lblMessages.Location = new Point(36, 682);
            lblMessages.Name = "lblMessages";
            lblMessages.Size = new Size(0, 20);
            lblMessages.TabIndex = 4;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = SystemColors.Highlight;
            flowLayoutPanel1.Controls.Add(label8);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(215, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(858, 75);
            flowLayoutPanel1.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 26F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.HighlightText;
            label8.Location = new Point(3, 0);
            label8.Name = "label8";
            label8.Size = new Size(339, 60);
            label8.TabIndex = 0;
            label8.Text = "Encounter Note";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(51, 51, 76);
            panel1.Controls.Add(btnStartNewNote);
            panel1.Controls.Add(lstPatients);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(215, 661);
            panel1.TabIndex = 6;
            // 
            // FrmEncounterNote
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1073, 661);
            Controls.Add(lblMessages);
            Controls.Add(groupBox1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmEncounterNote";
            FormClosing += FrmEncounterNote_FormClosing;
            Load += FrmEncounterNote_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnStartNewNote;
        private ListBox lstPatients;
        private GroupBox groupBox1;
        private RichTextBox rtxtboxNotes;
        private TextBox txtboxNewProblem;
        private TextBox txtboxName;
        private TextBox txtboxNoteID;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label6;
        private Label label7;
        private DateTimePicker dtpBirthDate;
        private Button btnAdd;
        private Button btnDeleteNote;
        private Button btnUpdateNote;
        private Button btnRemoveProblem;
        private ListBox lstProblem;
        private ListBox lstVirals;
        private Button btnAddProblem;
        private Label lblMessages;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label8;
        private Panel panel1;
    }
}