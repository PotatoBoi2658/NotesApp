namespace NotesApp.Forms
{
    partial class EditProfileForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblEmail = new Label();
            lblNewPassword = new Label();
            lblNoteTitle = new Label();
            btnSave = new Button();
            txtEmail = new TextBox();
            txtNewPassword = new TextBox();
            txtNoteTitle = new TextBox();
            txtUserName = new TextBox();
            lblUserName = new Label();
            SuspendLayout();
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 13F);
            lblEmail.Location = new Point(66, 59);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(70, 25);
            lblEmail.TabIndex = 0;
            lblEmail.Text = "Имейл:";
            // 
            // lblNewPassword
            // 
            lblNewPassword.AutoSize = true;
            lblNewPassword.Font = new Font("Segoe UI", 13F);
            lblNewPassword.Location = new Point(66, 101);
            lblNewPassword.Name = "lblNewPassword";
            lblNewPassword.Size = new Size(123, 25);
            lblNewPassword.TabIndex = 1;
            lblNewPassword.Text = "Нова парола:";
            // 
            // lblNoteTitle
            // 
            lblNoteTitle.AutoSize = true;
            lblNoteTitle.Font = new Font("Segoe UI", 13F);
            lblNoteTitle.Location = new Point(106, 147);
            lblNoteTitle.Name = "lblNoteTitle";
            lblNoteTitle.Size = new Size(317, 25);
            lblNoteTitle.TabIndex = 2;
            lblNoteTitle.Text = "Потвърди едно заглавие на бележка:";
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 13F);
            btnSave.Location = new Point(200, 212);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(134, 41);
            btnSave.TabIndex = 3;
            btnSave.Text = "Запази";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 13F);
            txtEmail.Location = new Point(142, 56);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(330, 31);
            txtEmail.TabIndex = 4;
            // 
            // txtNewPassword
            // 
            txtNewPassword.Font = new Font("Segoe UI", 13F);
            txtNewPassword.Location = new Point(200, 101);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(272, 31);
            txtNewPassword.TabIndex = 5;
            // 
            // txtNoteTitle
            // 
            txtNoteTitle.Font = new Font("Segoe UI", 13F);
            txtNoteTitle.Location = new Point(128, 175);
            txtNoteTitle.Name = "txtNoteTitle";
            txtNoteTitle.Size = new Size(267, 31);
            txtNoteTitle.TabIndex = 6;
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("Segoe UI", 13F);
            txtUserName.Location = new Point(252, 12);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(220, 31);
            txtUserName.TabIndex = 8;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Segoe UI", 13F);
            lblUserName.Location = new Point(66, 15);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(180, 25);
            lblUserName.TabIndex = 7;
            lblUserName.Text = "Потребителско Име:";
            // 
            // EditProfileForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(549, 313);
            Controls.Add(txtUserName);
            Controls.Add(lblUserName);
            Controls.Add(txtNoteTitle);
            Controls.Add(txtNewPassword);
            Controls.Add(txtEmail);
            Controls.Add(btnSave);
            Controls.Add(lblNoteTitle);
            Controls.Add(lblNewPassword);
            Controls.Add(lblEmail);
            Name = "EditProfileForm";
            Text = "EditProfileForm";
            Load += EditProfileForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEmail;
        private Label lblNewPassword;
        private Label lblNoteTitle;
        private Button btnSave;
        private TextBox txtEmail;
        private TextBox txtNewPassword;
        private TextBox txtNoteTitle;
        private TextBox txtUserName;
        private Label lblUserName;
    }
}