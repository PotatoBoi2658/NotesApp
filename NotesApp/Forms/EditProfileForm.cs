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

namespace NotesApp.Forms
{
    public partial class EditProfileForm : Form
    {
        private readonly User? _loggedInUser;
        private readonly NoteService _noteService = new NoteService();
        private readonly UserService _userService = new UserService();
        private readonly bool _isRecoveryMode;
        public EditProfileForm(User? user = null, bool recoveryMode = false)
        {
            InitializeComponent();
            _loggedInUser = user;
            _isRecoveryMode = recoveryMode;

            if (_isRecoveryMode)
            {
                Text = "Забравена парола";
                lblUserName.Visible = true;
                txtUserName.Visible = true;
                this.Text = "Забравена парола";
            }
            else
            {
                lblUserName.Visible = false;
                txtUserName.Visible = false;
                this.Text = "Редактиране на профил";
                if (_loggedInUser != null)
                {
                    txtEmail.Text = _loggedInUser.Email;
                    txtUserName.Text = _loggedInUser.Username;
                }
            }
        }

        private void EditProfileForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            User userToEdit;

            if (_isRecoveryMode)
            {
                string enteredUsername = txtUserName.Text.Trim();
                userToEdit = _userService.GetUserByUsername(enteredUsername);

                if (userToEdit == null)
                {
                    MessageBox.Show("Потребител не е намерен!", "Грешка");
                    return;
                }
            }
            else
            {
                userToEdit = _loggedInUser!;
            }

            var noteTitle = txtNoteTitle.Text.Trim();
            var userNotes = _noteService.GetNotesByUser(userToEdit.Id);

            if (!userNotes.Any(n => n.Title.Equals(noteTitle, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("Грешен отговор на въпроса за сигурност!", "Грешка");
                return;
            }

            // Променяме имейл и парола
            userToEdit.Email = txtEmail.Text.Trim();
            userToEdit.Password = txtNewPassword.Text;

            _userService.UpdateUser(userToEdit);

            MessageBox.Show("Профилът е обновен успешно!");
            Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}
