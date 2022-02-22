using MySql.Data.MySqlClient;
using CheckList;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CheckList.Controller;
using System.Threading;
using DoctorMeeting.View;

namespace CheckList
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            clean();
            loadTable(null);
        }
        #region Form2 Behavior (Buttoms)
        private void closeButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void minimizeButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool flag = false;
            Product product = new Product();
            try
            {
                product.Id = Convert.ToInt32(tbId.Text);
                product.Name = (tbName.Text).ToUpper();
                product.Description = (tbDescription.Text).ToUpper();
                product.Price = Convert.ToDouble(tbPrice.Text);
                product.Stock = Convert.ToInt32(tbStock.Text);
            }
            catch (FormatException)
            {
                lbUserMessage.Text = "Todos los campos son obligatorios.";
                lbUserMessage.Visible = true;
            }

            ProductCtrl crtl = new ProductCtrl();
            if(string.IsNullOrEmpty(tbId.Text))
            {
                try
                {
                    product.Id = Convert.ToInt32(tbId.Text);
                    flag = crtl.update(product);
                }
                catch (FormatException)
                {
                    lbUserMessage.Text = "Todos los campos son obligatorios.";
                    lbUserMessage.Visible = true;
                }
            }
            else
            {
                flag = crtl.add(product);
            }
            if (flag) 
            { 
                lbUserMessage.Text = "Registro guardado.";
                loadTable(null);
                clean();
            }
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32((dataGridView.CurrentRow.Cells[0].Value.ToString()));
            ProductCtrl crtl = new ProductCtrl();
            crtl.delete(id);
            loadTable(null);
        }
        private void btnModify_Click(object sender, EventArgs e)
        {
            tbId.Text = dataGridView.CurrentRow.Cells[0].Value.ToString();
            tbName.Text = dataGridView.CurrentRow.Cells[1].Value.ToString();
            tbDescription.Text = dataGridView.CurrentRow.Cells[2].Value.ToString();
            tbPrice.Text = dataGridView.CurrentRow.Cells[3].Value.ToString();
            tbStock.Text = dataGridView.CurrentRow.Cells[4].Value.ToString();

            int id = Convert.ToInt32((dataGridView.CurrentRow.Cells[0].Value.ToString()));
            ProductCtrl crtl = new ProductCtrl();
            crtl.delete(id);
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string data = tbSearch.Text;
            loadTable(data);
        }
        private void btnHelp_Click(object sender, EventArgs e)
        {
            FormHelp formHelp = new FormHelp();
            formHelp.StartPosition = FormStartPosition.CenterScreen;
            formHelp.Show();
        }
        private void btnClean_Click(object sender, EventArgs e)
        {
            clean();
        }
        #endregion
        #region Form2 movement

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
            private extern static void ReleaseCapture();

            [DllImport("user32.DLL", EntryPoint = "SendMessage")]
            private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
            private void Form2_MouseDown(object sender, MouseEventArgs e)
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0x112, 0xf012, 0);
            }


        #endregion
        #region Dynamic Functions
        public void clean()
        {
            tbId.Text = null;
            tbName.Text = null;
            tbDescription.Text = null;
            tbPrice.Text = null;
            tbStock.Text = null;
            tbSearch.Text = null;
            lbUserMessage.Visible = false;
            lbUserMessage.ForeColor = Color.Silver;

            lbErrorId.Visible = false;
            lbErrorName.Visible = false;
            lbErrorPrice.Visible = false;
            lbErrorStock.Visible = false;
        }
        private void loadTable(string data)
        {
            List<Product> productList = new List<Product>();
            ProductCtrl ctrl = new ProductCtrl();
            dataGridView.DataSource = ctrl.consultation(data);
        }
        #endregion
        #region Errors management
        private void tbId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) 
                || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                lbErrorId.Visible = true;
                lbErrorId.Text = " *Este campo es de dígitos numéricos";
                e.Handled = true;
            }
        }
        private void tbName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (
                 (e.KeyChar >= 32 && e.KeyChar <= 64)
                  || (e.KeyChar >= 91 && e.KeyChar <= 96)
                  || (e.KeyChar >= 123 && e.KeyChar <= 165)
                  || (e.KeyChar >= 166 && e.KeyChar <= 223)
                  || (e.KeyChar >= 238 && e.KeyChar <= 254)
               )
            {
                lbErrorName.Visible = true;
                lbErrorName.Text = " *Este campo es de dígitos alfabéticos";
                e.Handled = true;
            }
        }

        private void tbPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) 
                || (e.KeyChar == 47) 
                || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                lbErrorPrice.Visible = true;
                lbErrorPrice.Text = " *Este campo es de dígitos decimales";
                e.Handled = true;
            }
        }

        private void tbStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47)
             || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                lbErrorStock.Visible = true;
                lbErrorStock.Text = " *Este campo es de dígitos numéricos";
                e.Handled = true;
            }
        }
        #endregion
    }
}
