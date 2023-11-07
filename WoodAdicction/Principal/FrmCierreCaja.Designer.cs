
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
            this.txtCierreCaja = new System.Windows.Forms.TextBox();
            this.dtpCierreCaja = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.btnCierreCaja = new System.Windows.Forms.Button();
            this.cbxTipoCierre = new System.Windows.Forms.ComboBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCierreCaja
            // 
            this.txtCierreCaja.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCierreCaja.Location = new System.Drawing.Point(36, 255);
            this.txtCierreCaja.Name = "txtCierreCaja";
            this.txtCierreCaja.ReadOnly = true;
            this.txtCierreCaja.Size = new System.Drawing.Size(211, 32);
            this.txtCierreCaja.TabIndex = 37;
            // 
            // dtpCierreCaja
            // 
            this.dtpCierreCaja.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCierreCaja.Location = new System.Drawing.Point(36, 130);
            this.dtpCierreCaja.Name = "dtpCierreCaja";
            this.dtpCierreCaja.Size = new System.Drawing.Size(211, 32);
            this.dtpCierreCaja.TabIndex = 36;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Berlin Sans FB", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(96)))), ((int)(((byte)(0)))));
            this.label12.Location = new System.Drawing.Point(60, 11);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(166, 30);
            this.label12.TabIndex = 35;
            this.label12.Text = "Cierre de caja";
            // 
            // btnCierreCaja
            // 
            this.btnCierreCaja.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCierreCaja.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCierreCaja.Location = new System.Drawing.Point(36, 188);
            this.btnCierreCaja.Name = "btnCierreCaja";
            this.btnCierreCaja.Size = new System.Drawing.Size(211, 41);
            this.btnCierreCaja.TabIndex = 34;
            this.btnCierreCaja.Text = "Cerrar caja";
            this.btnCierreCaja.UseVisualStyleBackColor = true;
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
            this.btnCerrar.Location = new System.Drawing.Point(456, 5);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(27, 27);
            this.btnCerrar.TabIndex = 39;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtCierreCaja);
            this.panel1.Controls.Add(this.btnCierreCaja);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.cbxTipoCierre);
            this.panel1.Controls.Add(this.dtpCierreCaja);
            this.panel1.Location = new System.Drawing.Point(100, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 323);
            this.panel1.TabIndex = 40;
            // 
            // FrmCierreCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(485, 385);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCierreCaja";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCierreCaja";
            this.Load += new System.EventHandler(this.FrmCierreCaja_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtCierreCaja;
        private System.Windows.Forms.DateTimePicker dtpCierreCaja;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnCierreCaja;
        private System.Windows.Forms.ComboBox cbxTipoCierre;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Panel panel1;
    }
}