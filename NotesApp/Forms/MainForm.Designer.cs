namespace NotesApp
{
    partial class MainForm
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
            txtTitle = new TextBox();
            txtContent = new TextBox();
            btnAddNote = new Button();
            dgvNotes = new DataGridView();
            btnEditNote = new Button();
            btnDeleteNote = new Button();
            lblCurrentUser = new Label();
            btnEditProfile = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvNotes).BeginInit();
            SuspendLayout();
            // 
            // txtTitle
            // 
            txtTitle.Font = new Font("Segoe UI", 13F);
            txtTitle.Location = new Point(529, 6);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(134, 31);
            txtTitle.TabIndex = 2;
            // 
            // txtContent
            // 
            txtContent.Font = new Font("Segoe UI", 10F);
            txtContent.Location = new Point(529, 41);
            txtContent.Multiline = true;
            txtContent.Name = "txtContent";
            txtContent.Size = new Size(377, 435);
            txtContent.TabIndex = 3;
            // 
            // btnAddNote
            // 
            btnAddNote.Font = new Font("Segoe UI", 10F);
            btnAddNote.Location = new Point(12, 444);
            btnAddNote.Name = "btnAddNote";
            btnAddNote.Size = new Size(134, 32);
            btnAddNote.TabIndex = 4;
            btnAddNote.Text = "Добави бележка";
            btnAddNote.UseVisualStyleBackColor = true;
            btnAddNote.Click += btnAddNote_Click;
            // 
            // dgvNotes
            // 
            dgvNotes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNotes.Location = new Point(12, 40);
            dgvNotes.Name = "dgvNotes";
            dgvNotes.Size = new Size(511, 398);
            dgvNotes.TabIndex = 5;
            dgvNotes.CellContentClick += dgvNotes_CellContentClick;
            dgvNotes.SelectionChanged += dgvNotes_SelectionChanged;
            // 
            // btnEditNote
            // 
            btnEditNote.Font = new Font("Segoe UI", 10F);
            btnEditNote.Location = new Point(152, 444);
            btnEditNote.Name = "btnEditNote";
            btnEditNote.Size = new Size(232, 32);
            btnEditNote.TabIndex = 6;
            btnEditNote.Text = "Промени селектирана бележка";
            btnEditNote.UseVisualStyleBackColor = true;
            btnEditNote.Click += btnEditNote_Click;
            // 
            // btnDeleteNote
            // 
            btnDeleteNote.Font = new Font("Segoe UI", 10F);
            btnDeleteNote.Location = new Point(390, 444);
            btnDeleteNote.Name = "btnDeleteNote";
            btnDeleteNote.Size = new Size(134, 32);
            btnDeleteNote.TabIndex = 7;
            btnDeleteNote.Text = "Изтрий бележка";
            btnDeleteNote.UseVisualStyleBackColor = true;
            btnDeleteNote.Click += btnDeleteNote_Click;
            // 
            // lblCurrentUser
            // 
            lblCurrentUser.AutoSize = true;
            lblCurrentUser.Font = new Font("Segoe UI", 13F);
            lblCurrentUser.Location = new Point(12, 9);
            lblCurrentUser.Name = "lblCurrentUser";
            lblCurrentUser.Size = new Size(59, 25);
            lblCurrentUser.TabIndex = 8;
            lblCurrentUser.Text = "Henlo";
            // 
            // btnEditProfile
            // 
            btnEditProfile.Font = new Font("Segoe UI", 10F);
            btnEditProfile.Location = new Point(737, 5);
            btnEditProfile.Name = "btnEditProfile";
            btnEditProfile.Size = new Size(169, 32);
            btnEditProfile.TabIndex = 9;
            btnEditProfile.Text = "Редактирай профила си";
            btnEditProfile.UseVisualStyleBackColor = true;
            btnEditProfile.Click += btnEditProfile_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(919, 487);
            Controls.Add(btnEditProfile);
            Controls.Add(lblCurrentUser);
            Controls.Add(btnDeleteNote);
            Controls.Add(btnEditNote);
            Controls.Add(dgvNotes);
            Controls.Add(btnAddNote);
            Controls.Add(txtContent);
            Controls.Add(txtTitle);
            Name = "MainForm";
            Text = "Бележки";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvNotes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtTitle;
        private TextBox txtContent;
        private Button btnAddNote;
        private DataGridView dgvNotes;
        private Button btnEditNote;
        private Button btnDeleteNote;
        private Label lblCurrentUser;
        private Button btnEditProfile;
    }
}
