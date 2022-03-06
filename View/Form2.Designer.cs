
namespace CheckList
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lbBrand3 = new System.Windows.Forms.Label();
            this.lbBrand2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.closeButton2 = new System.Windows.Forms.PictureBox();
            this.minimizeButton2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.lbErrorPrice = new System.Windows.Forms.Label();
            this.lbErrorStock = new System.Windows.Forms.Label();
            this.lbErrorName = new System.Windows.Forms.Label();
            this.lbErrorId = new System.Windows.Forms.Label();
            this.btnClean = new System.Windows.Forms.Button();
            this.lbUserMessage = new System.Windows.Forms.Label();
            this.tbStock = new System.Windows.Forms.TextBox();
            this.lbStock = new System.Windows.Forms.Label();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.lbPrice = new System.Windows.Forms.Label();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.lbDescription = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.lbId = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.productCtrlBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productCtrlBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.Silver;
            this.btnRemove.Location = new System.Drawing.Point(-3, 55);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(214, 46);
            this.btnRemove.TabIndex = 8;
            this.btnRemove.Text = "   Quitar";
            this.btnRemove.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lbBrand3
            // 
            this.lbBrand3.AutoSize = true;
            this.lbBrand3.Font = new System.Drawing.Font("Unispace", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBrand3.ForeColor = System.Drawing.Color.Silver;
            this.lbBrand3.Location = new System.Drawing.Point(98, 36);
            this.lbBrand3.Name = "lbBrand3";
            this.lbBrand3.Size = new System.Drawing.Size(73, 29);
            this.lbBrand3.TabIndex = 5;
            this.lbBrand3.Text = "List";
            // 
            // lbBrand2
            // 
            this.lbBrand2.AutoSize = true;
            this.lbBrand2.Font = new System.Drawing.Font("Unispace", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBrand2.ForeColor = System.Drawing.Color.Silver;
            this.lbBrand2.Location = new System.Drawing.Point(66, 3);
            this.lbBrand2.Name = "lbBrand2";
            this.lbBrand2.Size = new System.Drawing.Size(95, 33);
            this.lbBrand2.TabIndex = 4;
            this.lbBrand2.Text = "Check";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // closeButton2
            // 
            this.closeButton2.Image = ((System.Drawing.Image)(resources.GetObject("closeButton2.Image")));
            this.closeButton2.Location = new System.Drawing.Point(1204, 5);
            this.closeButton2.Name = "closeButton2";
            this.closeButton2.Size = new System.Drawing.Size(16, 16);
            this.closeButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.closeButton2.TabIndex = 1;
            this.closeButton2.TabStop = false;
            this.closeButton2.Click += new System.EventHandler(this.closeButton2_Click);
            // 
            // minimizeButton2
            // 
            this.minimizeButton2.Image = ((System.Drawing.Image)(resources.GetObject("minimizeButton2.Image")));
            this.minimizeButton2.Location = new System.Drawing.Point(1176, 5);
            this.minimizeButton2.Name = "minimizeButton2";
            this.minimizeButton2.Size = new System.Drawing.Size(16, 16);
            this.minimizeButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.minimizeButton2.TabIndex = 2;
            this.minimizeButton2.TabStop = false;
            this.minimizeButton2.Click += new System.EventHandler(this.minimizeButton2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.panel1.Controls.Add(this.btnRegister);
            this.panel1.Controls.Add(this.btnHelp);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lbBrand2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lbBrand3);
            this.panel1.Location = new System.Drawing.Point(-2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(214, 645);
            this.panel1.TabIndex = 9;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.Color.Silver;
            this.btnRegister.Location = new System.Drawing.Point(0, 116);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(214, 30);
            this.btnRegister.TabIndex = 12;
            this.btnRegister.Text = "Historial";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.ForeColor = System.Drawing.Color.Silver;
            this.btnHelp.Location = new System.Drawing.Point(3, 80);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(208, 30);
            this.btnHelp.TabIndex = 11;
            this.btnHelp.Text = "Ayuda";
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.btnModify);
            this.panel2.Controls.Add(this.btnRemove);
            this.panel2.Location = new System.Drawing.Point(3, 484);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(214, 149);
            this.panel2.TabIndex = 10;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Silver;
            this.btnAdd.Location = new System.Drawing.Point(0, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(208, 46);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "   Guardar";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnModify
            // 
            this.btnModify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.btnModify.FlatAppearance.BorderSize = 0;
            this.btnModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModify.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModify.ForeColor = System.Drawing.Color.Silver;
            this.btnModify.Location = new System.Drawing.Point(0, 102);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(210, 46);
            this.btnModify.TabIndex = 9;
            this.btnModify.Text = "  Modificar";
            this.btnModify.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModify.UseVisualStyleBackColor = false;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Silver;
            this.btnSearch.Location = new System.Drawing.Point(955, 10);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(109, 29);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Silver;
            this.dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.ColumnHeadersHeight = 40;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.stockDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.productBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(94)))), ((int)(((byte)(129)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView.EnableHeadersVisualStyles = false;
            this.dataGridView.GridColor = System.Drawing.Color.Silver;
            this.dataGridView.Location = new System.Drawing.Point(578, 45);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(94)))), ((int)(((byte)(129)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Silver;
            this.dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(652, 599);
            this.dataGridView.TabIndex = 10;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 60;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 115;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Descripción";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Precio";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn.Width = 80;
            // 
            // stockDataGridViewTextBoxColumn
            // 
            this.stockDataGridViewTextBoxColumn.DataPropertyName = "Stock";
            this.stockDataGridViewTextBoxColumn.HeaderText = "Stock";
            this.stockDataGridViewTextBoxColumn.Name = "stockDataGridViewTextBoxColumn";
            this.stockDataGridViewTextBoxColumn.ReadOnly = true;
            this.stockDataGridViewTextBoxColumn.Width = 80;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(CheckList.Product);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.lbErrorPrice);
            this.groupBox.Controls.Add(this.lbErrorStock);
            this.groupBox.Controls.Add(this.lbErrorName);
            this.groupBox.Controls.Add(this.lbErrorId);
            this.groupBox.Controls.Add(this.btnClean);
            this.groupBox.Controls.Add(this.lbUserMessage);
            this.groupBox.Controls.Add(this.tbStock);
            this.groupBox.Controls.Add(this.lbStock);
            this.groupBox.Controls.Add(this.tbPrice);
            this.groupBox.Controls.Add(this.lbPrice);
            this.groupBox.Controls.Add(this.tbDescription);
            this.groupBox.Controls.Add(this.lbDescription);
            this.groupBox.Controls.Add(this.tbName);
            this.groupBox.Controls.Add(this.lbName);
            this.groupBox.Controls.Add(this.tbId);
            this.groupBox.Controls.Add(this.lbId);
            this.groupBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox.ForeColor = System.Drawing.Color.Silver;
            this.groupBox.Location = new System.Drawing.Point(218, 35);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(354, 588);
            this.groupBox.TabIndex = 11;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Datos del Producto";
            // 
            // lbErrorPrice
            // 
            this.lbErrorPrice.AutoSize = true;
            this.lbErrorPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErrorPrice.ForeColor = System.Drawing.Color.DarkRed;
            this.lbErrorPrice.Location = new System.Drawing.Point(76, 342);
            this.lbErrorPrice.Name = "lbErrorPrice";
            this.lbErrorPrice.Size = new System.Drawing.Size(14, 18);
            this.lbErrorPrice.TabIndex = 22;
            this.lbErrorPrice.Text = "*";
            // 
            // lbErrorStock
            // 
            this.lbErrorStock.AutoSize = true;
            this.lbErrorStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErrorStock.ForeColor = System.Drawing.Color.DarkRed;
            this.lbErrorStock.Location = new System.Drawing.Point(76, 396);
            this.lbErrorStock.Name = "lbErrorStock";
            this.lbErrorStock.Size = new System.Drawing.Size(14, 18);
            this.lbErrorStock.TabIndex = 21;
            this.lbErrorStock.Text = "*";
            // 
            // lbErrorName
            // 
            this.lbErrorName.AutoSize = true;
            this.lbErrorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErrorName.ForeColor = System.Drawing.Color.DarkRed;
            this.lbErrorName.Location = new System.Drawing.Point(76, 177);
            this.lbErrorName.Name = "lbErrorName";
            this.lbErrorName.Size = new System.Drawing.Size(14, 18);
            this.lbErrorName.TabIndex = 20;
            this.lbErrorName.Text = "*";
            // 
            // lbErrorId
            // 
            this.lbErrorId.AutoSize = true;
            this.lbErrorId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErrorId.ForeColor = System.Drawing.Color.DarkRed;
            this.lbErrorId.Location = new System.Drawing.Point(76, 113);
            this.lbErrorId.Name = "lbErrorId";
            this.lbErrorId.Size = new System.Drawing.Size(14, 18);
            this.lbErrorId.TabIndex = 19;
            this.lbErrorId.Text = "*";
            // 
            // btnClean
            // 
            this.btnClean.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.btnClean.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnClean.FlatAppearance.BorderSize = 0;
            this.btnClean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClean.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClean.ForeColor = System.Drawing.Color.Silver;
            this.btnClean.Location = new System.Drawing.Point(23, 471);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(303, 80);
            this.btnClean.TabIndex = 11;
            this.btnClean.Text = "Limpiar";
            this.btnClean.UseVisualStyleBackColor = false;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // lbUserMessage
            // 
            this.lbUserMessage.AutoSize = true;
            this.lbUserMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserMessage.ForeColor = System.Drawing.Color.Silver;
            this.lbUserMessage.Location = new System.Drawing.Point(30, 431);
            this.lbUserMessage.Name = "lbUserMessage";
            this.lbUserMessage.Size = new System.Drawing.Size(165, 20);
            this.lbUserMessage.TabIndex = 18;
            this.lbUserMessage.Text = "Mensaje de usuario";
            // 
            // tbStock
            // 
            this.tbStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(94)))), ((int)(((byte)(129)))));
            this.tbStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStock.ForeColor = System.Drawing.Color.Silver;
            this.tbStock.Location = new System.Drawing.Point(133, 374);
            this.tbStock.MaxLength = 5;
            this.tbStock.Name = "tbStock";
            this.tbStock.Size = new System.Drawing.Size(81, 22);
            this.tbStock.TabIndex = 17;
            this.tbStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbStock_KeyPress);
            // 
            // lbStock
            // 
            this.lbStock.AutoSize = true;
            this.lbStock.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStock.ForeColor = System.Drawing.Color.Silver;
            this.lbStock.Location = new System.Drawing.Point(47, 372);
            this.lbStock.Name = "lbStock";
            this.lbStock.Size = new System.Drawing.Size(80, 24);
            this.lbStock.TabIndex = 16;
            this.lbStock.Text = "STOCK:";
            // 
            // tbPrice
            // 
            this.tbPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(94)))), ((int)(((byte)(129)))));
            this.tbPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrice.ForeColor = System.Drawing.Color.Silver;
            this.tbPrice.Location = new System.Drawing.Point(133, 320);
            this.tbPrice.MaxLength = 7;
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(81, 22);
            this.tbPrice.TabIndex = 15;
            this.tbPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPrice_KeyPress);
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.ForeColor = System.Drawing.Color.Silver;
            this.lbPrice.Location = new System.Drawing.Point(36, 319);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(91, 24);
            this.lbPrice.TabIndex = 14;
            this.lbPrice.Text = "PRECIO:";
            // 
            // tbDescription
            // 
            this.tbDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(94)))), ((int)(((byte)(129)))));
            this.tbDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDescription.ForeColor = System.Drawing.Color.Silver;
            this.tbDescription.Location = new System.Drawing.Point(23, 241);
            this.tbDescription.MaxLength = 100;
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(303, 57);
            this.tbDescription.TabIndex = 13;
            // 
            // lbDescription
            // 
            this.lbDescription.AutoSize = true;
            this.lbDescription.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescription.ForeColor = System.Drawing.Color.Silver;
            this.lbDescription.Location = new System.Drawing.Point(74, 208);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(183, 30);
            this.lbDescription.TabIndex = 12;
            this.lbDescription.Text = "DESCRIPCIÓN:";
            // 
            // tbName
            // 
            this.tbName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(94)))), ((int)(((byte)(129)))));
            this.tbName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.ForeColor = System.Drawing.Color.Silver;
            this.tbName.Location = new System.Drawing.Point(148, 146);
            this.tbName.MaxLength = 50;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(178, 22);
            this.tbName.TabIndex = 11;
            this.tbName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbName_KeyPress);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.Silver;
            this.lbName.Location = new System.Drawing.Point(23, 144);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(104, 24);
            this.lbName.TabIndex = 10;
            this.lbName.Text = "NOMBRE:";
            // 
            // tbId
            // 
            this.tbId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(94)))), ((int)(((byte)(129)))));
            this.tbId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbId.ForeColor = System.Drawing.Color.Silver;
            this.tbId.Location = new System.Drawing.Point(148, 88);
            this.tbId.MaxLength = 4;
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(178, 22);
            this.tbId.TabIndex = 9;
            this.tbId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbId_KeyPress);
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbId.ForeColor = System.Drawing.Color.Silver;
            this.lbId.Location = new System.Drawing.Point(91, 86);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(36, 24);
            this.lbId.TabIndex = 8;
            this.lbId.Text = "ID:";
            // 
            // tbSearch
            // 
            this.tbSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(94)))), ((int)(((byte)(129)))));
            this.tbSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.ForeColor = System.Drawing.Color.Silver;
            this.tbSearch.Location = new System.Drawing.Point(756, 12);
            this.tbSearch.MaxLength = 100;
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(178, 22);
            this.tbSearch.TabIndex = 19;
            // 
            // productCtrlBindingSource
            // 
            this.productCtrlBindingSource.DataSource = typeof(CheckList.Controller.ProductCtrl);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(21)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(1232, 635);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.minimizeButton2);
            this.Controls.Add(this.closeButton2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Opacity = 0.87D;
            this.Text = " ";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productCtrlBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox closeButton2;
        private System.Windows.Forms.PictureBox minimizeButton2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbBrand2;
        private System.Windows.Forms.Label lbBrand3;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.TextBox tbStock;
        private System.Windows.Forms.Label lbStock;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbUserMessage;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.BindingSource productCtrlBindingSource;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lbErrorId;
        private System.Windows.Forms.Label lbErrorName;
        private System.Windows.Forms.Label lbErrorPrice;
        private System.Windows.Forms.Label lbErrorStock;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnRegister;
    }
}