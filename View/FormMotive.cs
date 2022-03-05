using CheckList;
using DoctorMeeting.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoctorMeeting.View
{
    public partial class FormMotive : Form
    {
        private int _idNumber;
        public FormMotive(int idNumber)
        {
            _idNumber = idNumber;
            InitializeComponent();
            lbErrorMotive.Visible = false;
        }

        private void btnMotive_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbMotive.Text))
            {
                lbErrorMotive.Visible = true;
            }
            else
            {
                RegisterCtrl registerCtrl = new RegisterCtrl();
                registerCtrl.insertMotive(this._idNumber, tbMotive.Text);
                Form2 form = new Form2();
                this.Hide();
                form.Show();
            }
        }
    }
}
