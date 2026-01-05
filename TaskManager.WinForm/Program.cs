using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskManager.WinForm.Data;
using TaskManager.WinForm.Service;

namespace TaskManager.WinForm
{
    internal static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                // ✅ Zeige Login-Form zuerst
                var loginForm = new LoginForm();

                // Wenn Login erfolgreich → MainForm starten
                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    Application.Run(new MainForm());
                }
            }
        }





    }

