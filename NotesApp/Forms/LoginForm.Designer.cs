namespace NotesApp.Forms
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            label1 = new Label();
            label2 = new Label();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            button1 = new Button();
            btnBack = new Button();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(74, 25);
            label1.TabIndex = 0;
            label1.Text = "Имейл:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            label2.Location = new Point(12, 62);
            label2.Name = "label2";
            label2.Size = new Size(79, 25);
            label2.TabIndex = 1;
            label2.Text = "Парола:";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 13F);
            txtEmail.Location = new Point(88, 9);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(303, 31);
            txtEmail.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 13F);
            txtPassword.Location = new Point(96, 59);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(295, 31);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            btnLogin.Location = new Point(115, 146);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(160, 33);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Вход";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            button1.Location = new Point(30, 104);
            button1.Name = "button1";
            button1.Size = new Size(211, 33);
            button1.TabIndex = 6;
            button1.Text = "Забравена Парола?";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            btnBack.Location = new Point(252, 104);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(118, 33);
            btnBack.TabIndex = 7;
            btnBack.Text = "Назад";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 7F);
            checkBox1.Location = new Point(272, 43);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(119, 16);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "Проверка на парола";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            ClientSize = new Size(412, 187);
            Controls.Add(checkBox1);
            Controls.Add(btnBack);
            Controls.Add(button1);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LoginForm";
            Text = "Вход";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private Button btnLogin;
        private Button button1;
        private Button btnBack;
        private CheckBox checkBox1;
    }
}