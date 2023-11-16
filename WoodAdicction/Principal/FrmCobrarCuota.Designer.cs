
namespace Principal
{
    partial class FrmCobrarCuota
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
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.Nombre = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxTipoMembresia = new System.Windows.Forms.ComboBox();
            this.btnCobrar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxMetodoPago = new System.Windows.Forms.ComboBox();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 15F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(96)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(17, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha: ";
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Font = new System.Drawing.Font("Calibri", 15F);
            this.dtpFechaInicio.Location = new System.Drawing.Point(220, 143);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(206, 32);
            this.dtpFechaInicio.TabIndex = 1;
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Font = new System.Drawing.Font("Berlin Sans FB", 15F);
            this.Nombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(96)))), ((int)(((byte)(0)))));
            this.Nombre.Location = new System.Drawing.Point(17, 89);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(83, 23);
            this.Nombre.TabIndex = 2;
            this.Nombre.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Berlin Sans FB", 15F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(96)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(17, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tipo de membresia:";
            // 
            // cbxTipoMembresia
            // 
            this.cbxTipoMembresia.Font = new System.Drawing.Font("Calibri", 15F);
            this.cbxTipoMembresia.FormattingEnabled = true;
            this.cbxTipoMembresia.Location = new System.Drawing.Point(220, 202);
            this.cbxTipoMembresia.Name = "cbxTipoMembresia";
            this.cbxTipoMembresia.Size = new System.Drawing.Size(206, 32);
            this.cbxTipoMembresia.TabIndex = 5;
            // 
            // btnCobrar
            // 
            this.btnCobrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(96)))), ((int)(((byte)(0)))));
            this.btnCobrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCobrar.FlatAppearance.BorderSize = 0;
            this.btnCobrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCobrar.Font = new System.Drawing.Font("Berlin Sans FB", 15F);
            this.btnCobrar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCobrar.Location = new System.Drawing.Point(127, 394);
            this.btnCobrar.Name = "btnCobrar";
            this.btnCobrar.Size = new System.Drawing.Size(98, 31);
            this.btnCobrar.TabIndex = 6;
            this.btnCobrar.Text = "Cobrar";
            this.btnCobrar.UseVisualStyleBackColor = false;
            this.btnCobrar.Click += new System.EventHandler(this.btnCobrar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Berlin Sans FB", 15F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(96)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(17, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "DNI:";
            // 
            // txtDni
            // 
            this.txtDni.Font = new System.Drawing.Font("Calibri", 15F);
            this.txtDni.Location = new System.Drawing.Point(220, 25);
            this.txtDni.Name = "txtDni";
            this.txtDni.ReadOnly = true;
            this.txtDni.Size = new System.Drawing.Size(206, 32);
            this.txtDni.TabIndex = 8;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Calibri", 15F);
            this.txtNombre.Location = new System.Drawing.Point(220, 84);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(206, 32);
            this.txtNombre.TabIndex = 9;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(96)))), ((int)(((byte)(0)))));
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Berlin Sans FB", 15F);
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancelar.Location = new System.Drawing.Point(245, 394);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(98, 31);
            this.btnCancelar.TabIndex = 21;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackgroundImage = global::Principal.Properties.Resources.iconoCerrar;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Location = new System.Drawing.Point(761, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(27, 27);
            this.btnCerrar.TabIndex = 25;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cbxMetodoPago);
            this.panel1.Controls.Add(this.txtMonto);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnCobrar);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtDni);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbxTipoMembresia);
            this.panel1.Controls.Add(this.dtpFechaInicio);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.Nombre);
            this.panel1.Location = new System.Drawing.Point(170, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(460, 460);
            this.panel1.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Berlin Sans FB", 15F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(96)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(17, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 23);
            this.label3.TabIndex = 24;
            this.label3.Text = "Metodo de pago:";
            // 
            // cbxMetodoPago
            // 
            this.cbxMetodoPago.Font = new System.Drawing.Font("Calibri", 15F);
            this.cbxMetodoPago.FormattingEnabled = true;
            this.cbxMetodoPago.Location = new System.Drawing.Point(220, 261);
            this.cbxMetodoPago.Name = "cbxMetodoPago";
            this.cbxMetodoPago.Size = new System.Drawing.Size(206, 32);
            this.cbxMetodoPago.TabIndex = 25;
            // 
            // txtMonto
            // 
            this.txtMonto.Font = new System.Drawing.Font("Calibri", 15F);
            this.txtMonto.Location = new System.Drawing.Point(220, 320);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(206, 32);
            this.txtMonto.TabIndex = 23;
            this.txtMonto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMonto_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB", 15F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(96)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(17, 325);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 23);
            this.label2.TabIndex = 22;
            this.label2.Text = "Monto:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Principal.Properties.Resources.FondoWoodGym;
            this.pictureBox1.Location = new System.Drawing.Point(1, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(154, 136);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // FrmCobrarCuota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 549);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCobrarCuota";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCobrarCuota";
            this.Load += new System.EventHandler(this.FrmCobrarCuota_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxTipoMembresia;
        private System.Windows.Forms.Button btnCobrar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxMetodoPago;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}