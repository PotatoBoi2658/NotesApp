using NotesApp.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NotesApp.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
namespace NotesApp.Forms
{
    public partial class RegisterForm : Form
    {
        private readonly UserService _userService = new UserService();
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            var username = txtUsername.Text.Trim();
            var email = txtEmail.Text.Trim();
            var password = txtPassword.Text; // в реален проект трябва да се хешира

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Моля, попълнете всички полета.");
                return;
            }

            var existingUser = _userService.GetUserByUsername(username);
            if (existingUser != null)
            {
                MessageBox.Show("Потребителското име вече съществува.");
                return;
            }
            var existingEmail = _userService.GetUserByEmail(email);
            if (existingEmail != null)
            {
                MessageBox.Show("Имейлът вече съществува.");
                return;
            }
            var newUser = new User
            {
                Username = username,
                Email = email,
                Password = password
            };
            

            _userService.AddUser(username,email,password);
            MessageBox.Show("Регистрацията е успешна!");
            var startForm = new StartForm();
            startForm.Show();
            this.Hide();
        }
    }
}
