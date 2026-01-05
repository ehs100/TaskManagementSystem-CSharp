namespace TaskManager.WinForm
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
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblConfirm = new System.Windows.Forms.Label();
            this.txtConfirm = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnRegister
            // 
            this.btnRegister.AccessibleDescription = "Klick zum neuen Benutzer anlegen";
            this.btnRegister.AccessibleName = "Registrieren Knopf";
            this.btnRegister.Location = new System.Drawing.Point(283, 251);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 8;
            this.btnRegister.Text = "Registrieren";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleDescription = "Klick zum Schließen ohne Registrierung";
            this.btnCancel.AccessibleName = "Abbrechen Knopf";
            this.btnCancel.Location = new System.Drawing.Point(458, 251);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Abbrechen";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblUsername
            // 
            this.lblUsername.AccessibleDescription = "Beschriftung für Benutzername Eingabefeld";
            this.lblUsername.AccessibleName = "Benutzername Feld";
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(305, 112);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(78, 13);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Benutzername:";
            // 
            // lblEmail
            // 
            this.lblEmail.AccessibleDescription = "Beschriftung für E-Mail Eingabefeld";
            this.lblEmail.AccessibleName = "E-Mail Feld";
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(305, 148);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(39, 13);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "E-Mail:";
            // 
            // txtUsername
            // 
            this.txtUsername.AccessibleDescription = "Hier Benutzername eingeben";
            this.txtUsername.AccessibleName = "Benutzername Eingabe";
            this.txtUsername.Location = new System.Drawing.Point(381, 108);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(100, 20);
            this.txtUsername.TabIndex = 1;
            // 
            // txtEmail
            // 
            this.txtEmail.AcceptsTab = true;
            this.txtEmail.AccessibleDescription = "Hier E-Mail eingeben";
            this.txtEmail.AccessibleName = "E-Mail Eingabe";
            this.txtEmail.Location = new System.Drawing.Point(381, 141);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 3;
            // 
            // lblPassword
            // 
            this.lblPassword.AccessibleDescription = "Beschriftung für Passwort Eingabefeld“";
            this.lblPassword.AccessibleName = "Passwort Feld";
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(305, 179);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Passwort:";
            // 
            // txtPassword
            // 
            this.txtPassword.AccessibleDescription = "Hier Passwort eingeben";
            this.txtPassword.AccessibleName = "Passwort Eingabe";
            this.txtPassword.Location = new System.Drawing.Point(381, 172);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.Text = "UseSystemPasswordChar = true";
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // lblConfirm
            // 
            this.lblConfirm.AccessibleDescription = "Beschriftung für Passwort-Bestätigung";
            this.lblConfirm.AccessibleName = "Bestätigung Feld";
            this.lblConfirm.AutoSize = true;
            this.lblConfirm.Location = new System.Drawing.Point(305, 216);
            this.lblConfirm.Name = "lblConfirm";
            this.lblConfirm.Size = new System.Drawing.Size(105, 13);
            this.lblConfirm.TabIndex = 6;
            this.lblConfirm.Text = "Passwort bestätigen:";
            // 
            // txtConfirm
            // 
            this.txtConfirm.AccessibleDescription = "Hier Passwort erneut eingeben";
            this.txtConfirm.AccessibleName = "Bestätigung Eingabe";
            this.txtConfirm.Location = new System.Drawing.Point(416, 213);
            this.txtConfirm.Name = "txtConfirm";
            this.txtConfirm.Size = new System.Drawing.Size(100, 20);
            this.txtConfirm.TabIndex = 7;
            this.txtConfirm.Text = "UseSystemPasswordChar = true";
            this.txtConfirm.UseSystemPasswordChar = true;
            // 
            // RegisterForm
            // 
            this.AccessibleDescription = "Hier Benutzername eingeben";
            this.AccessibleName = "Benutzername Eingabe";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtConfirm);
            this.Controls.Add(this.lblConfirm);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRegister);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrierung";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblConfirm;
        private System.Windows.Forms.TextBox txtConfirm;
    }
}