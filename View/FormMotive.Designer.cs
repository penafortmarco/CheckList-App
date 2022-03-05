
namespace DoctorMeeting.View
{
    partial class FormMotive
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnMotive = new System.Windows.Forms.Button();
            this.tbMotive = new System.Windows.Forms.TextBox();
            this.lbErrorMotive = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(30, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 30);
            this.label1.TabIndex = 23;
            this.label1.Text = "Motivo de operación";
            // 
            // btnMotive
            // 
            this.btnMotive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.btnMotive.FlatAppearance.BorderSize = 0;
            this.btnMotive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMotive.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMotive.ForeColor = System.Drawing.Color.Silver;
            this.btnMotive.Location = new System.Drawing.Point(12, 144);
            this.btnMotive.Name = "btnMotive";
            this.btnMotive.Size = new System.Drawing.Size(303, 59);
            this.btnMotive.TabIndex = 24;
            this.btnMotive.Text = "Continuar";
            this.btnMotive.UseVisualStyleBackColor = false;
            this.btnMotive.Click += new System.EventHandler(this.btnMotive_Click);
            // 
            // tbMotive
            // 
            this.tbMotive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(94)))), ((int)(((byte)(129)))));
            this.tbMotive.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbMotive.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMotive.ForeColor = System.Drawing.Color.Silver;
            this.tbMotive.Location = new System.Drawing.Point(12, 70);
            this.tbMotive.MaxLength = 100;
            this.tbMotive.Multiline = true;
            this.tbMotive.Name = "tbMotive";
            this.tbMotive.Size = new System.Drawing.Size(303, 38);
            this.tbMotive.TabIndex = 25;
            // 
            // lbErrorMotive
            // 
            this.lbErrorMotive.AutoSize = true;
            this.lbErrorMotive.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErrorMotive.ForeColor = System.Drawing.Color.DarkRed;
            this.lbErrorMotive.Location = new System.Drawing.Point(44, 111);
            this.lbErrorMotive.Name = "lbErrorMotive";
            this.lbErrorMotive.Size = new System.Drawing.Size(223, 18);
            this.lbErrorMotive.TabIndex = 26;
            this.lbErrorMotive.Text = " *Agrega un motivo de operación";
            // 
            // FormMotive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(21)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(334, 215);
            this.Controls.Add(this.lbErrorMotive);
            this.Controls.Add(this.tbMotive);
            this.Controls.Add(this.btnMotive);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMotive";
            this.Text = "FormMotive";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMotive;
        private System.Windows.Forms.TextBox tbMotive;
        private System.Windows.Forms.Label lbErrorMotive;
    }
}