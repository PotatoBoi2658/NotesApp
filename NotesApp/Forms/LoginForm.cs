using NotesApp.Data;
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

namespace NotesApp.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
        private readonly UserService _userService;

        public LoginForm(UserService userService)
        {
            _userService = userService ?? throw new ArgumentNullException(nameof(userService));
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;

            using (var context = new NotesDbContext())
            {
                var user = context.Users
                    .FirstOrDefault(u => u.Email == email && u.Password == password);

                if (user != null)
                {
                    MessageBox.Show("Успешен вход!");
                    var mainForm = new MainForm(user); // Подай user към MainForm
                    this.Hide();
                    mainForm.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Невалидни данни за вход!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnTestLogin_Click(object sender, EventArgs e)
        {
            string email = "test@test.com";
            string password = "test";

            using (var context = new NotesDbContext())
            {
                var user = context.Users
                    .FirstOrDefault(u => u.Email == email && u.Password == password);


                if (user != null)
                {
                    MessageBox.Show("Успешен вход!");
                    var mainForm = new MainForm(user); // Подай user към MainForm
                    this.Hide();
                    mainForm.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Невалидни данни за вход!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form = new EditProfileForm(null, recoveryMode: true);
            form.ShowDialog();
        }
    }
}
