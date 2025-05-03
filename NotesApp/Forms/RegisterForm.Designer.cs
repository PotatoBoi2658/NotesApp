namespace NotesApp.Forms
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            btnRegister = new Button();
            btnBack = new Button();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(139, 19);
            label1.TabIndex = 0;
            label1.Text = "Потребителско име:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label2.Location = new Point(12, 65);
            label2.Name = "label2";
            label2.Size = new Size(56, 19);
            label2.TabIndex = 1;
            label2.Text = "Имейл:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label3.Location = new Point(12, 121);
            label3.Name = "label3";
            label3.Size = new Size(60, 19);
            label3.TabIndex = 2;
            label3.Text = "Парола:";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 13F);
            txtEmail.Location = new Point(12, 87);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(323, 31);
            txtEmail.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 13F);
            txtPassword.Location = new Point(12, 143);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(323, 31);
            txtPassword.TabIndex = 4;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 13F);
            txtUsername.Location = new Point(12, 31);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(323, 31);
            txtUsername.TabIndex = 5;
            // 
            // btnRegister
            // 
            btnRegister.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            btnRegister.Location = new Point(12, 190);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(177, 40);
            btnRegister.TabIndex = 6;
            btnRegister.Text = "Регистрация";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            btnBack.Location = new Point(195, 190);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(140, 40);
            btnBack.TabIndex = 7;
            btnBack.Text = "Назад";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 7F);
            checkBox1.Location = new Point(216, 126);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(119, 16);
            checkBox1.TabIndex = 11;
            checkBox1.Text = "Проверка на парола";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            ClientSize = new Size(345, 238);
            Controls.Add(checkBox1);
            Controls.Add(btnBack);
            Controls.Add(btnRegister);
            Controls.Add(txtUsername);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "RegisterForm";
            Text = "Регистрация";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Button btnRegister;
        private Button btnBack;
        private CheckBox checkBox1;
    }
}