using NotesApp.Data;
using NotesApp.Forms;
using NotesApp.Services;
using NotesApp.Services;


namespace NotesApp
{
    public partial class MainForm : Form
    {
        private User _loggedInUser;

        public MainForm(User user)
        {
            InitializeComponent();
            _loggedInUser = user;
            lblCurrentUser.Text = $"Здравей {user.Username}! Това са вашите бележки:";
            LoadUserNotes(); // Зареждане само на неговите бележки
        }
        private readonly UserService _userService = new UserService();
        private readonly NoteService _noteService = new NoteService();
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadUserNotes();
            LoadNotes();
        }
        public void LoadUserNotes()
        {
            var notes = _noteService.GetNotesByUser(_loggedInUser.Id)
                .Select(n => new { n.Title, n.Content })
                .ToList();
            dgvNotes.DataSource = notes;
        }
        private void LoadNotes()
        {
            var notes = _noteService.GetNotesByUser(_loggedInUser.Id);
            dgvNotes.DataSource = notes.Select(n => new
            {
                n.Id,
                n.Title,
                n.Content,
                n.CreatedAt
            }).ToList();
            // Скриване на колоната Id
            if (dgvNotes.Columns.Contains("Id"))
            {
                dgvNotes.Columns["Id"].Visible = false;
            }
            // Настройка на ширината на колоните
            dgvNotes.Columns["Title"].Width = 150;
            dgvNotes.Columns["Content"].Width = 188;
            dgvNotes.Columns["CreatedAt"].Width = 130;
            // Настройка на заглавията на колоните
            dgvNotes.Columns["Title"].HeaderText = "Заглавие";
            dgvNotes.Columns["Content"].HeaderText = "Съдържание";
            dgvNotes.Columns["CreatedAt"].HeaderText = "Дата на създаване";

        }
        private void btnAddNote_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text) || string.IsNullOrWhiteSpace(txtContent.Text))
            {
                MessageBox.Show("Моля, попълнете заглавието и съдържанието на бележката!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                _noteService.AddNote(txtTitle.Text, txtContent.Text, _loggedInUser.Id);
                LoadNotes();
                txtTitle.Clear();
                txtContent.Clear();
                MessageBox.Show("Бележката е добавена успешно!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDeleteNote_Click(object sender, EventArgs e)
        {
            if (dgvNotes.CurrentRow != null)
            {
                int noteId = (int)dgvNotes.CurrentRow.Cells["Id"].Value;
                _noteService.DeleteNote(noteId);
                LoadNotes();
                MessageBox.Show("Бележката е изтрита успешно!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Моля, изберете бележка за изтриване!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditNote_Click(object sender, EventArgs e)
        {
            if (dgvNotes.CurrentRow != null)
            {
                if (string.IsNullOrWhiteSpace(txtTitle.Text) || string.IsNullOrWhiteSpace(txtContent.Text))
                {
                    MessageBox.Show("Моля, попълнете заглавието и съдържанието на бележката!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    int noteId = (int)dgvNotes.CurrentRow.Cells["Id"].Value;
                    string newTitle = txtTitle.Text;
                    string newContent = txtContent.Text;
                    _noteService.UpdateNote(noteId, newTitle, newContent);
                    LoadNotes();
                    MessageBox.Show("Бележката е променена успешно!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Моля, изберете бележка за редактиране!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvNotes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dgvNotes_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvNotes.CurrentRow != null)
            {
                var selectedRow = dgvNotes.CurrentRow;

                // Проверка дали колоните съществуват
                if (selectedRow.Cells["Title"].Value != null && selectedRow.Cells["Content"].Value != null)
                {
                    txtTitle.Text = selectedRow.Cells["Title"].Value.ToString();
                    txtContent.Text = selectedRow.Cells["Content"].Value.ToString();
                }
            }
        }

        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            var editForm = new EditProfileForm(_loggedInUser);
            editForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            var startForm = new StartForm();
            startForm.Show();
        }
    }
}
