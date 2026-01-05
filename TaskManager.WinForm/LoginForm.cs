using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskManager.WinForm.Service;

using TaskManager.WinForm.Domain;
using TaskManager.WinForm.Data;



namespace TaskManager.WinForm
{
    public partial class LoginForm : Form
    {
        private readonly UserService _userService;

        public LoginForm()
        {
            InitializeComponent();

            var repo = new UserRepository("users.json");
            _userService = new UserService(repo);
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            var email = txtEmail.Text.Trim();
            var password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Bitte E-Mail und Passwort eingeben.");
                return;
            }

            string message;
            var user = _userService.Login(email, password, out message);
            MessageBox.Show(message);

            if (user != null)
            {
                MessageBox.Show($"Willkommen, {user.Username}!");
                this.Hide();

                // ✅ Benutzer an MainForm übergeben
                // Wenn Login erfolgreich ist
                var mainForm = new MainForm(user); // user ist das zurückgegebene User-Objekt vom Login
                mainForm.ShowDialog();


                this.Close();
                this.DialogResult = DialogResult.OK;
            }
        }
        


        private void btnRegister_Click(object sender, EventArgs e)
        {
            var registerForm = new RegisterForm();
            registerForm.ShowDialog();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
