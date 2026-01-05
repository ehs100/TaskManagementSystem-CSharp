using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskManager.WinForm.Domain;
using TaskManager.WinForm.Data;
using TaskManager.WinForm.Service;



namespace TaskManager.WinForm
{
    public partial class MainForm : Form
    {
        private readonly User _currentUser;

        private readonly TaskService _taskService;
        private List<TaskItem> _tasks = new List<TaskItem>();

        // 🔹 Neuer Konstruktor mit Benutzer-Parameter

        private void StyleDataGrid()
        {
            dataGridViewTasks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewTasks.DefaultCellStyle.BackColor = Color.White;
            dataGridViewTasks.DefaultCellStyle.ForeColor = Color.Black;
            dataGridViewTasks.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dataGridViewTasks.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dataGridViewTasks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewTasks.MultiSelect = false;
        }


        public MainForm(User currentUser)
        {
            InitializeComponent();

            var repo = new TaskRepository("tasks.json");
            _taskService = new TaskService(repo);

            // Zeigt den Benutzernamen im Titel
            if (currentUser != null)
            {
                this.Text = $"Aufgabenverwaltung – Willkommen, {currentUser.Username}!";
            }
            else
            {
                this.Text = "Aufgabenverwaltung";
            }
        }


        private void dataGridViewTasks_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            var row = dataGridViewTasks.Rows[e.RowIndex];
            if (row.DataBoundItem is TaskItem task && task.IsDone)
            {
                row.DefaultCellStyle.BackColor = Color.LightGray;
                row.DefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Italic);
            }
            else
            {
                row.DefaultCellStyle.BackColor = Color.White;
                row.DefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            }
        }


        public MainForm() : this(null) // Ruft den Konstruktor mit null als Argument auf
        {
        }



        // 🔹 Alter Standard-Konstruktor (für Designer)
        // public MainForm() : this(null)
        // {
        //}


        private void MainForm_Load(object sender, EventArgs e)
        {
            StyleDataGrid();
            LoadTasks();
        }

        private void LoadTasks()
        {
            _tasks = _taskService.GetAll();
            dataGridViewTasks.DataSource = null;
            dataGridViewTasks.DataSource = _tasks;
        }

        

        

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            // Holen der Eingabewerte
            var title = txtTitel.Text.Trim();
            var description = txtDescription.Text.Trim();
            var dueDate = dtpDueDate.Value;
            var isDone = chkIsDone.Checked;

            // Überprüfen, ob alle Felder ausgefüllt sind
            if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(description))
            {
                MessageBox.Show("Bitte Titel und Beschreibung eingeben.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Neue Aufgabe erstellen
            var newTask = new TaskItem
            {
                Title = title,
                Description = description,
                DueDate = dueDate,
                IsDone = isDone
            };

            // Aufgabe über TaskService hinzufügen
            _taskService.Add(newTask);

            // Aufgaben neu laden, um die Liste zu aktualisieren
            LoadTasks();

            // Bestätigung anzeigen
            MessageBox.Show("Aufgabe wurde hinzugefügt.", "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Eingabefelder zurücksetzen
            txtTitel.Clear();
            txtDescription.Clear();
            chkIsDone.Checked = false;
        }

        private void dataGridViewTasks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void btnNew_Click(object sender, EventArgs e)
        {
            // Eingabefelder auslesen
            var title = txtTitel.Text.Trim();
            var description = txtDescription.Text.Trim();
            var dueDate = dtpDueDate.Value;
            var isDone = chkIsDone.Checked;

            // Validierung
            if (string.IsNullOrEmpty(title))
            {
                MessageBox.Show("Bitte einen Titel eingeben.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Neue Aufgabe erstellen
            var newTask = new TaskItem
            {
                Title = title,
                Description = description,
                DueDate = dueDate,
                IsDone = isDone
            };

            // In Datei speichern
            _taskService.Add(newTask);

            // Aktualisieren
            LoadTasks();

            // Eingabefelder leeren
            txtTitel.Clear();
            txtDescription.Clear();
            chkIsDone.Checked = false;

            MessageBox.Show("Aufgabe wurde erfolgreich hinzugefügt.", "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewTasks.SelectedRows.Count == 0)
            {
                MessageBox.Show("Bitte eine Aufgabe auswählen.", "Hinweis", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var selectedTask = (TaskItem)dataGridViewTasks.SelectedRows[0].DataBoundItem;

            var result = MessageBox.Show(
                $"Möchten Sie die Aufgabe '{selectedTask.Title}' wirklich löschen?",
                "Löschen bestätigen",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                _taskService.Delete(selectedTask.Id);
                LoadTasks();
                MessageBox.Show("Aufgabe wurde gelöscht.", "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewTasks.SelectedRows.Count == 0)
            {
                MessageBox.Show("Bitte eine Aufgabe auswählen.", "Hinweis", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Ausgewählte Aufgabe holen
            var selected = dataGridViewTasks.SelectedRows[0].DataBoundItem as TaskItem;
            if (selected == null)
            {
                MessageBox.Show("Fehler: Keine gültige Aufgabe ausgewählt.");
                return;
            }

            // Änderungen übernehmen
            selected.Title = txtTitel.Text.Trim();
            selected.Description = txtDescription.Text.Trim();
            selected.DueDate = dtpDueDate.Value;
            selected.IsDone = chkIsDone.Checked;

            // Speichern über TaskService
            _taskService.Update(selected);

            LoadTasks();
            MessageBox.Show("Aufgabe wurde aktualisiert.", "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnToggleDone_Click(object sender, EventArgs e)
        {
            if (dataGridViewTasks.SelectedRows.Count == 0)
            {
                MessageBox.Show("Bitte eine Aufgabe auswählen.", "Hinweis", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var selected = dataGridViewTasks.SelectedRows[0].DataBoundItem as TaskItem;
            if (selected == null)
                return;

            selected.IsDone = !selected.IsDone;
            _taskService.Update(selected);
            LoadTasks();

            string status = selected.IsDone ? "erledigt" : "unerledigt";
            MessageBox.Show($"Aufgabe wurde als {status} markiert.", "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadTasks();
            MessageBox.Show("Liste wurde aktualisiert.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Login-Form öffnen
            var loginForm = new LoginForm();
            loginForm.Show();

            // Dieses Fenster schließen
            this.Close();
        }

    }
}
