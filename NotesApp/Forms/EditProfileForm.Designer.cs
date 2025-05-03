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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditProfileForm));
            lblEmail = new Label();
            lblNewPassword = new Label();
            lblNoteTitle = new Label();
            btnSave = new Button();
            txtEmail = new TextBox();
            txtNewPassword = new TextBox();
            txtNoteTitle = new TextBox();
            txtUserName = new TextBox();
            lblUserName = new Label();
            btnBack = new Button();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            lblEmail.Location = new Point(66, 63);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(74, 25);
            lblEmail.TabIndex = 0;
            lblEmail.Text = "Имейл:";
            // 
            // lblNewPassword
            // 
            lblNewPassword.AutoSize = true;
            lblNewPassword.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            lblNewPassword.Location = new Point(66, 112);
            lblNewPassword.Name = "lblNewPassword";
            lblNewPassword.Size = new Size(125, 25);
            lblNewPassword.TabIndex = 1;
            lblNewPassword.Text = "Нова парола:";
            // 
            // lblNoteTitle
            // 
            lblNoteTitle.AutoSize = true;
            lblNoteTitle.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            lblNoteTitle.Location = new Point(106, 151);
            lblNoteTitle.Name = "lblNoteTitle";
            lblNoteTitle.Size = new Size(329, 25);
            lblNoteTitle.TabIndex = 2;
            lblNoteTitle.Text = "Потвърди едно заглавие на бележка:";
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.Control;
            btnSave.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            btnSave.Location = new Point(125, 216);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(134, 41);
            btnSave.TabIndex = 3;
            btnSave.Text = "Запази";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 13F);
            txtEmail.Location = new Point(142, 60);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(330, 31);
            txtEmail.TabIndex = 4;
            // 
            // txtNewPassword
            // 
            txtNewPassword.Font = new Font("Segoe UI", 13F);
            txtNewPassword.Location = new Point(200, 109);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(272, 31);
            txtNewPassword.TabIndex = 5;
            txtNewPassword.UseSystemPasswordChar = true;
            // 
            // txtNoteTitle
            // 
            txtNoteTitle.Font = new Font("Segoe UI", 13F);
            txtNoteTitle.Location = new Point(125, 179);
            txtNoteTitle.Name = "txtNoteTitle";
            txtNoteTitle.Size = new Size(274, 31);
            txtNoteTitle.TabIndex = 6;
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("Segoe UI", 13F);
            txtUserName.Location = new Point(252, 11);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(220, 31);
            txtUserName.TabIndex = 8;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            lblUserName.Location = new Point(66, 14);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(189, 25);
            lblUserName.TabIndex = 7;
            lblUserName.Text = "Потребителско Име:";
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.Control;
            btnBack.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            btnBack.Location = new Point(265, 216);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(134, 41);
            btnBack.TabIndex = 9;
            btnBack.Text = "Назад";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 7F);
            checkBox1.Location = new Point(353, 93);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(119, 16);
            checkBox1.TabIndex = 10;
            checkBox1.Text = "Проверка на парола";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // EditProfileForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            ClientSize = new Size(549, 313);
            Controls.Add(checkBox1);
            Controls.Add(btnBack);
            Controls.Add(txtUserName);
            Controls.Add(lblUserName);
            Controls.Add(txtNoteTitle);
            Controls.Add(txtNewPassword);
            Controls.Add(txtEmail);
            Controls.Add(btnSave);
            Controls.Add(lblNoteTitle);
            Controls.Add(lblNewPassword);
            Controls.Add(lblEmail);
            Icon = (Icon)resources.GetObject("$this.Icon");
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
        private Button btnBack;
        private CheckBox checkBox1;
    }
}