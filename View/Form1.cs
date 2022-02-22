using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using CheckList;
using MySql.Data.MySqlClient;

namespace CheckList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lbPasswordError.Text = null;
            lbUserError.Text = null;
            
        }
        #region Form1 Behavoiur
        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void loginButton_Click(object sender, EventArgs e)
        {
            UserData user = new UserData();
            bool access;

            access = (user.Username.Equals(tbUsername.Text) && user.Password.Equals(tbPassword.Text));
            if (access)
            {
                Form2 f2 = new Form2();
                f2.Show();
                lbUserError.Text = null;
                lbPasswordError.Text = null;
                this.Hide();
            }

            else
            {
                if (tbUsername.Text.Equals(user.Username) == false)
                {
                    lbUserError.Text = "Usuario ingresado erróneo.";
                    if (tbUsername.Text == "") { lbUserError.Text = "Este campo está vacío."; }
                }
                else { lbUserError.Text = null; }

                if (tbPassword.Text.Equals(user.Username) == false)
                {
                    lbPasswordError.Text = "Contraseña ingresada errónea.";
                    if (tbPassword.Text == "") { lbPasswordError.Text = "Este campo está vacío."; }
                }
                else { lbPasswordError.Text = null; }
            }
            tbUsername.Text = null;
            tbPassword.Text = null;
        }
        #endregion
        #region Form1 Movement
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void mainTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
