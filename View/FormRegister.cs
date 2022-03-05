using DoctorMeeting.Controller;
using DoctorMeeting.Model;
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
    public partial class FormRegister : Form
    {
        RegisterCtrl registerCtrl = new RegisterCtrl();
        public FormRegister()
        {
            InitializeComponent();
            dataGridView2.DataSource = registerCtrl.consultation();
        }

        private void FormRegister_Load(object sender, EventArgs e)
        {
            dataGridView2.DataSource = registerCtrl.consultation();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
