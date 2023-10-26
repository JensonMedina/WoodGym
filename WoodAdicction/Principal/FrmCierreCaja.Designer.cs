
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
            this.SuspendLayout();
            // 
            // txtCierreCaja
            // 
            this.txtCierreCaja.Font = new System.Drawing.Font("Berlin Sans FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCierreCaja.Location = new System.Drawing.Point(126, 278);
            this.txtCierreCaja.Name = "txtCierreCaja";
            this.txtCierreCaja.ReadOnly = true;
            this.txtCierreCaja.Size = new System.Drawing.Size(181, 31);
            this.txtCierreCaja.TabIndex = 37;
            // 
            // dtpCierreCaja
            // 
            this.dtpCierreCaja.Font = new System.Drawing.Font("Berlin Sans FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCierreCaja.Location = new System.Drawing.Point(128, 154);
            this.dtpCierreCaja.Name = "dtpCierreCaja";
            this.dtpCierreCaja.Size = new System.Drawing.Size(200, 31);
            this.dtpCierreCaja.TabIndex = 36;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Berlin Sans FB", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(141, 50);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(166, 30);
            this.label12.TabIndex = 35;
            this.label12.Text = "Cierre de caja";
            // 
            // btnCierreCaja
            // 
            this.btnCierreCaja.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCierreCaja.Font = new System.Drawing.Font("Berlin Sans FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCierreCaja.Location = new System.Drawing.Point(159, 206);
            this.btnCierreCaja.Name = "btnCierreCaja";
            this.btnCierreCaja.Size = new System.Drawing.Size(138, 41);
            this.btnCierreCaja.TabIndex = 34;
            this.btnCierreCaja.Text = "Cerrar caja";
            this.btnCierreCaja.UseVisualStyleBackColor = true;
            this.btnCierreCaja.Click += new System.EventHandler(this.btnCierreCaja_Click);
            // 
            // cbxTipoCierre
            // 
            this.cbxTipoCierre.Font = new System.Drawing.Font("Berlin Sans FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTipoCierre.FormattingEnabled = true;
            this.cbxTipoCierre.Location = new System.Drawing.Point(128, 106);
            this.cbxTipoCierre.Name = "cbxTipoCierre";
            this.cbxTipoCierre.Size = new System.Drawing.Size(200, 31);
            this.cbxTipoCierre.TabIndex = 38;
            // 
            // FrmCierreCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 385);
            this.Controls.Add(this.cbxTipoCierre);
            this.Controls.Add(this.txtCierreCaja);
            this.Controls.Add(this.dtpCierreCaja);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnCierreCaja);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCierreCaja";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCierreCaja";
            this.Load += new System.EventHandler(this.FrmCierreCaja_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCierreCaja;
        private System.Windows.Forms.DateTimePicker dtpCierreCaja;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnCierreCaja;
        private System.Windows.Forms.ComboBox cbxTipoCierre;
    }
}