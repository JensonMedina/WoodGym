
namespace Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnCaja = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnAcceso = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlMenu.Controls.Add(this.btnCaja);
            this.pnlMenu.Controls.Add(this.btnClientes);
            this.pnlMenu.Controls.Add(this.btnAcceso);
            this.pnlMenu.Location = new System.Drawing.Point(2, 97);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(177, 355);
            this.pnlMenu.TabIndex = 0;
            // 
            // btnCaja
            // 
            this.btnCaja.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCaja.FlatAppearance.BorderSize = 0;
            this.btnCaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCaja.Font = new System.Drawing.Font("Berlin Sans FB", 15F);
            this.btnCaja.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCaja.Location = new System.Drawing.Point(0, 100);
            this.btnCaja.Name = "btnCaja";
            this.btnCaja.Size = new System.Drawing.Size(177, 50);
            this.btnCaja.TabIndex = 2;
            this.btnCaja.Text = "Caja";
            this.btnCaja.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCaja.UseVisualStyleBackColor = true;
            this.btnCaja.Click += new System.EventHandler(this.btnCaja_Click);
            this.btnCaja.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.btnCaja.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.Color.Transparent;
            this.btnClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Berlin Sans FB", 15F);
            this.btnClientes.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClientes.Location = new System.Drawing.Point(0, 50);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(177, 50);
            this.btnClientes.TabIndex = 1;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.btnClientes.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            // 
            // btnAcceso
            // 
            this.btnAcceso.BackColor = System.Drawing.Color.Transparent;
            this.btnAcceso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAcceso.FlatAppearance.BorderSize = 0;
            this.btnAcceso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcceso.Font = new System.Drawing.Font("Berlin Sans FB", 15F);
            this.btnAcceso.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAcceso.Location = new System.Drawing.Point(0, 0);
            this.btnAcceso.Name = "btnAcceso";
            this.btnAcceso.Size = new System.Drawing.Size(177, 50);
            this.btnAcceso.TabIndex = 0;
            this.btnAcceso.Text = "Acceso";
            this.btnAcceso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAcceso.UseVisualStyleBackColor = false;
            this.btnAcceso.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.btnAcceso.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(177, 90);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 13F);
            this.label1.Location = new System.Drawing.Point(75, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Wood Gym";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 51);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlMenu);
            this.Name = "Form2";
            this.Text = "Form2";
            this.pnlMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCaja;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnAcceso;
    }
}