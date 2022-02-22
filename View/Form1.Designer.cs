
namespace CheckList
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mainPanel = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.PictureBox();
            this.minimizeButton = new System.Windows.Forms.PictureBox();
            this.brandImg = new System.Windows.Forms.PictureBox();
            this.lbBrand = new System.Windows.Forms.Label();
            this.lbBrand2 = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.lbLogin = new System.Windows.Forms.Label();
            this.lbUsername = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.line = new System.Windows.Forms.Label();
            this.lbForgotPassword = new System.Windows.Forms.Label();
            this.lbUserError = new System.Windows.Forms.Label();
            this.lbPasswordError = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brandImg)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.mainPanel.Controls.Add(this.closeButton);
            this.mainPanel.Controls.Add(this.minimizeButton);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(392, 27);
            this.mainPanel.TabIndex = 0;
            this.mainPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainTitle_MouseDown);
            // 
            // closeButton
            // 
            this.closeButton.Image = ((System.Drawing.Image)(resources.GetObject("closeButton.Image")));
            this.closeButton.Location = new System.Drawing.Point(364, 8);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(16, 16);
            this.closeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.closeButton.TabIndex = 13;
            this.closeButton.TabStop = false;
            this.closeButton.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // minimizeButton
            // 
            this.minimizeButton.Image = ((System.Drawing.Image)(resources.GetObject("minimizeButton.Image")));
            this.minimizeButton.Location = new System.Drawing.Point(331, 8);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(16, 16);
            this.minimizeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.minimizeButton.TabIndex = 0;
            this.minimizeButton.TabStop = false;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeBtn_Click);
            // 
            // brandImg
            // 
            this.brandImg.Image = ((System.Drawing.Image)(resources.GetObject("brandImg.Image")));
            this.brandImg.Location = new System.Drawing.Point(0, 33);
            this.brandImg.Name = "brandImg";
            this.brandImg.Size = new System.Drawing.Size(200, 200);
            this.brandImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.brandImg.TabIndex = 2;
            this.brandImg.TabStop = false;
            // 
            // lbBrand
            // 
            this.lbBrand.AutoSize = true;
            this.lbBrand.Font = new System.Drawing.Font("Unispace", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBrand.ForeColor = System.Drawing.Color.Silver;
            this.lbBrand.Location = new System.Drawing.Point(177, 61);
            this.lbBrand.Name = "lbBrand";
            this.lbBrand.Size = new System.Drawing.Size(170, 58);
            this.lbBrand.TabIndex = 3;
            this.lbBrand.Text = "Check";
            // 
            // lbBrand2
            // 
            this.lbBrand2.AutoSize = true;
            this.lbBrand2.Font = new System.Drawing.Font("Unispace", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBrand2.ForeColor = System.Drawing.Color.Silver;
            this.lbBrand2.Location = new System.Drawing.Point(255, 109);
            this.lbBrand2.Name = "lbBrand2";
            this.lbBrand2.Size = new System.Drawing.Size(112, 44);
            this.lbBrand2.TabIndex = 4;
            this.lbBrand2.Text = "List";
            // 
            // tbUsername
            // 
            this.tbUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(94)))), ((int)(((byte)(129)))));
            this.tbUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsername.ForeColor = System.Drawing.Color.White;
            this.tbUsername.Location = new System.Drawing.Point(28, 315);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(340, 17);
            this.tbUsername.TabIndex = 5;
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLogin.ForeColor = System.Drawing.Color.Silver;
            this.lbLogin.Location = new System.Drawing.Point(114, 253);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(180, 33);
            this.lbLogin.TabIndex = 6;
            this.lbLogin.Text = "Iniciar Sesión";
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsername.ForeColor = System.Drawing.Color.Silver;
            this.lbUsername.Location = new System.Drawing.Point(27, 291);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(66, 21);
            this.lbUsername.TabIndex = 7;
            this.lbUsername.Text = "Usuario";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassword.ForeColor = System.Drawing.Color.Silver;
            this.lbPassword.Location = new System.Drawing.Point(24, 350);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(103, 21);
            this.lbPassword.TabIndex = 8;
            this.lbPassword.Text = "Contraseña";
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(94)))), ((int)(((byte)(129)))));
            this.tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.ForeColor = System.Drawing.Color.White;
            this.tbPassword.Location = new System.Drawing.Point(27, 374);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '•';
            this.tbPassword.Size = new System.Drawing.Size(340, 17);
            this.tbPassword.TabIndex = 9;
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.loginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginButton.FlatAppearance.BorderSize = 0;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.Color.White;
            this.loginButton.Location = new System.Drawing.Point(27, 422);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(340, 66);
            this.loginButton.TabIndex = 10;
            this.loginButton.Text = "Proceder";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // line
            // 
            this.line.AutoSize = true;
            this.line.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.line.ForeColor = System.Drawing.Color.DarkGray;
            this.line.Location = new System.Drawing.Point(82, 491);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(230, 16);
            this.line.TabIndex = 11;
            this.line.Text = "_____________________________________";
            // 
            // lbForgotPassword
            // 
            this.lbForgotPassword.AutoSize = true;
            this.lbForgotPassword.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbForgotPassword.ForeColor = System.Drawing.Color.DarkGray;
            this.lbForgotPassword.Location = new System.Drawing.Point(81, 514);
            this.lbForgotPassword.Name = "lbForgotPassword";
            this.lbForgotPassword.Size = new System.Drawing.Size(231, 16);
            this.lbForgotPassword.TabIndex = 12;
            this.lbForgotPassword.Text = "¿Olvidaste la contraseña? Contáctanos.";
            // 
            // lbUserError
            // 
            this.lbUserError.AutoSize = true;
            this.lbUserError.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserError.ForeColor = System.Drawing.Color.DarkRed;
            this.lbUserError.Location = new System.Drawing.Point(28, 335);
            this.lbUserError.Name = "lbUserError";
            this.lbUserError.Size = new System.Drawing.Size(150, 16);
            this.lbUserError.TabIndex = 13;
            this.lbUserError.Text = "Usuario ingresado erróneo.";
            // 
            // lbPasswordError
            // 
            this.lbPasswordError.AutoSize = true;
            this.lbPasswordError.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPasswordError.ForeColor = System.Drawing.Color.DarkRed;
            this.lbPasswordError.Location = new System.Drawing.Point(24, 394);
            this.lbPasswordError.Name = "lbPasswordError";
            this.lbPasswordError.Size = new System.Drawing.Size(177, 16);
            this.lbPasswordError.TabIndex = 14;
            this.lbPasswordError.Text = "Contraseña ingresada errónea.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(21)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(392, 539);
            this.Controls.Add(this.lbPasswordError);
            this.Controls.Add(this.lbUserError);
            this.Controls.Add(this.lbForgotPassword);
            this.Controls.Add(this.line);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbUsername);
            this.Controls.Add(this.lbLogin);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.lbBrand2);
            this.Controls.Add(this.lbBrand);
            this.Controls.Add(this.brandImg);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Opacity = 0.8D;
            this.Text = "Form1";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brandImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.PictureBox brandImg;
        private System.Windows.Forms.Label lbBrand;
        private System.Windows.Forms.Label lbBrand2;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label line;
        private System.Windows.Forms.Label lbForgotPassword;
        private System.Windows.Forms.PictureBox closeButton;
        private System.Windows.Forms.PictureBox minimizeButton;
        private System.Windows.Forms.Label lbUserError;
        private System.Windows.Forms.Label lbPasswordError;
    }
}

