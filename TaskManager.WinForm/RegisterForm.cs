using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskManager.WinForm.Data;
using TaskManager.WinForm.Service;


namespace TaskManager.WinForm
{
    public partial class RegisterForm : Form
    {

        private readonly UserService _userService;


        public RegisterForm()
        {
            InitializeComponent();
            var repo = new UserRepository("users.json");
            _userService = new UserService(repo);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            var username = txtUsername.Text.Trim();
            var email = txtEmail.Text.Trim();
            var password = txtPassword.Text.Trim();
            var confirm = txtConfirm.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirm))
            {
                MessageBox.Show("Bitte alle Felder ausfüllen.");
                return;
            }

            if (password != confirm)
            {
                MessageBox.Show("Die Passwörter stimmen nicht überein.");
                return;
            }

            string message;
            bool success = _userService.Register(username, email, password, out message);

            // 💬 Diese Zeile ist entscheidend
            MessageBox.Show(message, "Registrierung", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (success)
            {
                this.Close();
            }
        }

    }

}

