
namespace Principal
{
    partial class FrmCierreCaja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCierreCaja));
            this.txtCajaFinalEfectivo = new System.Windows.Forms.TextBox();
            this.dtpCierreCaja = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.btnCierreCaja = new System.Windows.Forms.Button();
            this.cbxTipoCierre = new System.Windows.Forms.ComboBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTotalIngresos = new System.Windows.Forms.TextBox();
            this.txtTotalGastos = new System.Windows.Forms.TextBox();
            this.txtIngresosTransferencia = new System.Windows.Forms.TextBox();
            this.txtGastosTransferencias = new System.Windows.Forms.TextBox();
            this.txtGastosEfectivo = new System.Windows.Forms.TextBox();
            this.txtIngresosEfectivo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCajaFinalTransferencias = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCajaFinalEfectivo
            // 
            this.txtCajaFinalEfectivo.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCajaFinalEfectivo.Location = new System.Drawing.Point(36, 472);
            this.txtCajaFinalEfectivo.Name = "txtCajaFinalEfectivo";
            this.txtCajaFinalEfectivo.ReadOnly = true;
            this.txtCajaFinalEfectivo.Size = new System.Drawing.Size(211, 32);
            this.txtCajaFinalEfectivo.TabIndex = 37;
            // 
            // dtpCierreCaja
            // 
            this.dtpCierreCaja.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCierreCaja.Location = new System.Drawing.Point(292, 72);
            this.dtpCierreCaja.Name = "dtpCierreCaja";
            this.dtpCierreCaja.Size = new System.Drawing.Size(211, 32);
            this.dtpCierreCaja.TabIndex = 36;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Berlin Sans FB", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(96)))), ((int)(((byte)(0)))));
            this.label12.Location = new System.Drawing.Point(193, 10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(166, 30);
            this.label12.TabIndex = 35;
            this.label12.Text = "Cierre de caja";
            // 
            // btnCierreCaja
            // 
            this.btnCierreCaja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(96)))), ((int)(((byte)(0)))));
            this.btnCierreCaja.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCierreCaja.FlatAppearance.BorderSize = 0;
            this.btnCierreCaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCierreCaja.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCierreCaja.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCierreCaja.Location = new System.Drawing.Point(183, 132);
            this.btnCierreCaja.Name = "btnCierreCaja";
            this.btnCierreCaja.Size = new System.Drawing.Size(211, 41);
            this.btnCierreCaja.TabIndex = 34;
            this.btnCierreCaja.Text = "Cerrar caja";
            this.btnCierreCaja.UseVisualStyleBackColor = false;
            this.btnCierreCaja.Click += new System.EventHandler(this.btnCierreCaja_Click);
            // 
            // cbxTipoCierre
            // 
            this.cbxTipoCierre.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTipoCierre.FormattingEnabled = true;
            this.cbxTipoCierre.Location = new System.Drawing.Point(36, 72);
            this.cbxTipoCierre.Name = "cbxTipoCierre";
            this.cbxTipoCierre.Size = new System.Drawing.Size(211, 32);
            this.cbxTipoCierre.TabIndex = 38;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackgroundImage = global::Principal.Properties.Resources.iconoCerrar;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Location = new System.Drawing.Point(853, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(27, 27);
            this.btnCerrar.TabIndex = 39;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtTotalIngresos);
            this.panel1.Controls.Add(this.txtTotalGastos);
            this.panel1.Controls.Add(this.txtIngresosTransferencia);
            this.panel1.Controls.Add(this.txtGastosTransferencias);
            this.panel1.Controls.Add(this.txtGastosEfectivo);
            this.panel1.Controls.Add(this.txtIngresosEfectivo);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtCajaFinalTransferencias);
            this.panel1.Controls.Add(this.txtCajaFinalEfectivo);
            this.panel1.Controls.Add(this.btnCierreCaja);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.cbxTipoCierre);
            this.panel1.Controls.Add(this.dtpCierreCaja);
            this.panel1.Location = new System.Drawing.Point(196, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(576, 548);
            this.panel1.TabIndex = 40;
            // 
            // txtTotalIngresos
            // 
            this.txtTotalIngresos.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalIngresos.Location = new System.Drawing.Point(36, 390);
            this.txtTotalIngresos.Name = "txtTotalIngresos";
            this.txtTotalIngresos.ReadOnly = true;
            this.txtTotalIngresos.Size = new System.Drawing.Size(211, 32);
            this.txtTotalIngresos.TabIndex = 55;
            // 
            // txtTotalGastos
            // 
            this.txtTotalGastos.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalGastos.Location = new System.Drawing.Point(301, 390);
            this.txtTotalGastos.Name = "txtTotalGastos";
            this.txtTotalGastos.ReadOnly = true;
            this.txtTotalGastos.Size = new System.Drawing.Size(211, 32);
            this.txtTotalGastos.TabIndex = 54;
            // 
            // txtIngresosTransferencia
            // 
            this.txtIngresosTransferencia.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIngresosTransferencia.Location = new System.Drawing.Point(36, 308);
            this.txtIngresosTransferencia.Name = "txtIngresosTransferencia";
            this.txtIngresosTransferencia.ReadOnly = true;
            this.txtIngresosTransferencia.Size = new System.Drawing.Size(211, 32);
            this.txtIngresosTransferencia.TabIndex = 53;
            // 
            // txtGastosTransferencias
            // 
            this.txtGastosTransferencias.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGastosTransferencias.Location = new System.Drawing.Point(301, 308);
            this.txtGastosTransferencias.Name = "txtGastosTransferencias";
            this.txtGastosTransferencias.ReadOnly = true;
            this.txtGastosTransferencias.Size = new System.Drawing.Size(211, 32);
            this.txtGastosTransferencias.TabIndex = 52;
            // 
            // txtGastosEfectivo
            // 
            this.txtGastosEfectivo.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGastosEfectivo.Location = new System.Drawing.Point(301, 226);
            this.txtGastosEfectivo.Name = "txtGastosEfectivo";
            this.txtGastosEfectivo.ReadOnly = true;
            this.txtGastosEfectivo.Size = new System.Drawing.Size(211, 32);
            this.txtGastosEfectivo.TabIndex = 51;
            // 
            // txtIngresosEfectivo
            // 
            this.txtIngresosEfectivo.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIngresosEfectivo.Location = new System.Drawing.Point(36, 226);
            this.txtIngresosEfectivo.Name = "txtIngresosEfectivo";
            this.txtIngresosEfectivo.ReadOnly = true;
            this.txtIngresosEfectivo.Size = new System.Drawing.Size(211, 32);
            this.txtIngresosEfectivo.TabIndex = 50;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Berlin Sans FB", 10F);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(96)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(298, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 16);
            this.label10.TabIndex = 49;
            this.label10.Text = "Fecha";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Berlin Sans FB", 10F);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(96)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(33, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 16);
            this.label9.TabIndex = 48;
            this.label9.Text = "Tipo de cierre";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Berlin Sans FB", 10F);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(96)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(301, 275);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 16);
            this.label8.TabIndex = 47;
            this.label8.Text = "Gastos transferencias";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Berlin Sans FB", 10F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(96)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(36, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 16);
            this.label7.TabIndex = 46;
            this.label7.Text = "Ingresos transferencias";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Berlin Sans FB", 10F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(96)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(301, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 16);
            this.label6.TabIndex = 45;
            this.label6.Text = "Gastos efectivo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Berlin Sans FB", 10F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(96)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(36, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 16);
            this.label5.TabIndex = 44;
            this.label5.Text = "Ingresos efectivo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Berlin Sans FB", 10F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(96)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(301, 357);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 16);
            this.label4.TabIndex = 43;
            this.label4.Text = "Total gastos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Berlin Sans FB", 10F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(96)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(36, 357);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 42;
            this.label3.Text = "Total ingresos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB", 10F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(96)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(301, 439);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 16);
            this.label2.TabIndex = 41;
            this.label2.Text = "Caja final transferencias";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 10F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(96)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(36, 439);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 16);
            this.label1.TabIndex = 40;
            this.label1.Text = "Caja final efectivo";
            // 
            // txtCajaFinalTransferencias
            // 
            this.txtCajaFinalTransferencias.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCajaFinalTransferencias.Location = new System.Drawing.Point(301, 472);
            this.txtCajaFinalTransferencias.Name = "txtCajaFinalTransferencias";
            this.txtCajaFinalTransferencias.ReadOnly = true;
            this.txtCajaFinalTransferencias.Size = new System.Drawing.Size(211, 32);
            this.txtCajaFinalTransferencias.TabIndex = 39;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Principal.Properties.Resources.FondoWoodGym;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(154, 136);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // FrmCierreCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(892, 606);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCierreCaja";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cerrar Caja";
            this.Load += new System.EventHandler(this.FrmCierreCaja_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtCajaFinalEfectivo;
        private System.Windows.Forms.DateTimePicker dtpCierreCaja;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnCierreCaja;
        private System.Windows.Forms.ComboBox cbxTipoCierre;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCajaFinalTransferencias;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtTotalIngresos;
        private System.Windows.Forms.TextBox txtTotalGastos;
        private System.Windows.Forms.TextBox txtIngresosTransferencia;
        private System.Windows.Forms.TextBox txtGastosTransferencias;
        private System.Windows.Forms.TextBox txtGastosEfectivo;
        private System.Windows.Forms.TextBox txtIngresosEfectivo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}