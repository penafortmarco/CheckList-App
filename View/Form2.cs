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
using DoctorMeeting.Model;
using DoctorMeeting.Controller;

namespace CheckList
{
    public partial class Form2 : Form
    {
        private bool modified = false;
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
            Register register = new Register();

            try
            {
                product.Id = Convert.ToInt32(tbId.Text);
                product.Name = (tbName.Text).ToUpper();
                product.Description = (tbDescription.Text).ToUpper();
                product.Price = "$ "+tbPrice.Text.ToString();
                product.Stock = Convert.ToInt32(tbStock.Text);
            }
            catch (FormatException) { }

            if (isNull())
            {
                lbUserMessage.ForeColor = Color.Red;
                lbUserMessage.Text = "Llena todos los campos.";
                lbUserMessage.Visible = true;
            }
            else
            {
                ProductCtrl crtl = new ProductCtrl();
                flag = crtl.add(product);
                if (flag)
                {
                    loadTable(null);
                    clean();
                    lbUserMessage.Visible = true;
                    lbUserMessage.Text = "Registro guardado.";
                    //--------------------------------------------------Register Class---------------------------------------------------------------------------------------------//
                    Random random = new Random();
                    RegisterCtrl registerCtrl = new RegisterCtrl();
                    register.Id = random.Next(9999);
                    register.Date = Convert.ToString(DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year);
                    register.Time = Convert.ToString(DateTime.Now.Hour + ":" + DateTime.Now.Minute);
                    register.ProductData = $"ID: {product.Id}\n Nombre: {product.Name} Descripción: \n{product.Description}\n Precio: {product.Price}\n Stock: {product.Stock}";
                    if (modified)
                    {
                        register.Action = "Se modificó";
                        this.Hide();
                        FormMotive formMotive = new FormMotive(register.Id);
                        formMotive.StartPosition = FormStartPosition.CenterScreen;
                        formMotive.Show();
                        this.modified = false;
                    }
                    else register.Action = "Se agregó";
                    registerCtrl.add(register);
                }
                else
                {
                    lbErrorId.Visible = true;
                    lbErrorId.Text = " *Ya existe un producto con este ID";
                }
            }
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dataGridView.Rows.Count == 0)
            {
                lbUserMessage.ForeColor = Color.Red;
                lbUserMessage.Text = "Inventario completamente vacío.";
                lbUserMessage.Visible = true;
            }
            else
            {
                int id = Convert.ToInt32(dataGridView.CurrentRow.Cells[0].Value);
                string name = dataGridView.CurrentRow.Cells[1].Value.ToString();
                string descrp = dataGridView.CurrentRow.Cells[2].Value.ToString();
                string price = dataGridView.CurrentRow.Cells[3].Value.ToString();
                string stock = dataGridView.CurrentRow.Cells[4].Value.ToString();

                Register register = new Register();
                Random random = new Random();
                RegisterCtrl registerCtrl = new RegisterCtrl();


                register.Id = random.Next(9999);
                register.Date = Convert.ToString(DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year);
                register.Time = Convert.ToString(DateTime.Now.Hour + ":" + DateTime.Now.Minute);
                register.ProductData = $"ID: {id}\n Nombre: {name} Descripción: \n{descrp}\n Precio: {price}\n Stock: {stock}";
                register.Action = "Se quitó";

                this.Hide();
                FormMotive formMotive = new FormMotive(register.Id);
                formMotive.StartPosition = FormStartPosition.CenterScreen;
                formMotive.Show();

                registerCtrl.add(register);
                ProductCtrl crtl = new ProductCtrl();
                crtl.delete(id);
                loadTable(null);
                modified = false;
            }
        }
        private void btnModify_Click(object sender, EventArgs e)
        {
            clean();
            tbId.Text = dataGridView.CurrentRow.Cells[0].Value.ToString();
            tbName.Text = dataGridView.CurrentRow.Cells[1].Value.ToString();
            tbDescription.Text = dataGridView.CurrentRow.Cells[2].Value.ToString();
            tbPrice.Text = dataGridView.CurrentRow.Cells[3].Value.ToString();
            tbStock.Text = dataGridView.CurrentRow.Cells[4].Value.ToString();

            int id = Convert.ToInt32((dataGridView.CurrentRow.Cells[0].Value.ToString()));
            ProductCtrl crtl = new ProductCtrl();
            crtl.delete(id);
            modified = true;
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
        private void btnRegister_Click(object sender, EventArgs e)
        {
            FormRegister formRegister = new FormRegister();
            formRegister.StartPosition = FormStartPosition.CenterScreen;
            formRegister.Show();
        }
        private void btnClean_Click(object sender, EventArgs e)
        {
            clean();
            modified = false;
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
        private void allEnabled()
        {
            lbId.Enabled = true;
            tbId.Enabled = true;
            lbName.Enabled = true;
            tbName.Enabled = true;
            lbDescription.Enabled = true;
            tbDescription.Enabled = true;
            lbPrice.Enabled = true;
            tbPrice.Enabled = true;
            lbStock.Enabled = true;
            tbStock.Enabled = true;
            lbUserMessage.Enabled = true;
            btnClean.Enabled = true;
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

            if ((e.KeyChar >= 32 && e.KeyChar <= 43)
                || (e.KeyChar == 45)
                || (e.KeyChar == 46)
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
        private bool isNull()
        {
            if (string.IsNullOrEmpty(tbId.Text)
                || string.IsNullOrEmpty(tbName.Text)
                || string.IsNullOrEmpty(tbDescription.Text)
                || string.IsNullOrEmpty(tbPrice.Text)
                || string.IsNullOrEmpty(tbStock.Text))
            {
                return true;
            }
            else return false;
        }

        #endregion
    }
}
