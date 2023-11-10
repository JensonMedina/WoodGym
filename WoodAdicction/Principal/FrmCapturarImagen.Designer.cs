
namespace Principal
{
    partial class FrmCapturarImagen
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
            this.btnGrabar = new System.Windows.Forms.Button();
            this.cbxGrabar = new System.Windows.Forms.ComboBox();
            this.pbxGrabar = new System.Windows.Forms.PictureBox();
            this.pbxCapturar = new System.Windows.Forms.PictureBox();
            this.btnCapturar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxGrabar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCapturar)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGrabar
            // 
            this.btnGrabar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(180)))), ((int)(((byte)(53)))));
            this.btnGrabar.FlatAppearance.BorderSize = 0;
            this.btnGrabar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrabar.Font = new System.Drawing.Font("Berlin Sans FB", 15F);
            this.btnGrabar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGrabar.Location = new System.Drawing.Point(226, 35);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(98, 31);
            this.btnGrabar.TabIndex = 0;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = false;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // cbxGrabar
            // 
            this.cbxGrabar.Font = new System.Drawing.Font("Calibri", 15F);
            this.cbxGrabar.FormattingEnabled = true;
            this.cbxGrabar.Location = new System.Drawing.Point(37, 34);
            this.cbxGrabar.Name = "cbxGrabar";
            this.cbxGrabar.Size = new System.Drawing.Size(183, 32);
            this.cbxGrabar.TabIndex = 1;
            // 
            // pbxGrabar
            // 
            this.pbxGrabar.Location = new System.Drawing.Point(37, 83);
            this.pbxGrabar.Name = "pbxGrabar";
            this.pbxGrabar.Size = new System.Drawing.Size(287, 185);
            this.pbxGrabar.TabIndex = 2;
            this.pbxGrabar.TabStop = false;
            // 
            // pbxCapturar
            // 
            this.pbxCapturar.Location = new System.Drawing.Point(358, 83);
            this.pbxCapturar.Name = "pbxCapturar";
            this.pbxCapturar.Size = new System.Drawing.Size(287, 185);
            this.pbxCapturar.TabIndex = 3;
            this.pbxCapturar.TabStop = false;
            // 
            // btnCapturar
            // 
            this.btnCapturar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(180)))), ((int)(((byte)(53)))));
            this.btnCapturar.FlatAppearance.BorderSize = 0;
            this.btnCapturar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapturar.Font = new System.Drawing.Font("Berlin Sans FB", 15F);
            this.btnCapturar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCapturar.Location = new System.Drawing.Point(547, 35);
            this.btnCapturar.Name = "btnCapturar";
            this.btnCapturar.Size = new System.Drawing.Size(98, 31);
            this.btnCapturar.TabIndex = 4;
            this.btnCapturar.Text = "Capturar";
            this.btnCapturar.UseVisualStyleBackColor = false;
            this.btnCapturar.Visible = false;
            this.btnCapturar.Click += new System.EventHandler(this.btnCapturar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(180)))), ((int)(((byte)(53)))));
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Berlin Sans FB", 15F);
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGuardar.Location = new System.Drawing.Point(358, 292);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(150, 31);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Visible = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnCapturar);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.pbxCapturar);
            this.panel1.Controls.Add(this.cbxGrabar);
            this.panel1.Controls.Add(this.pbxGrabar);
            this.panel1.Controls.Add(this.btnGrabar);
            this.panel1.Location = new System.Drawing.Point(60, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(680, 350);
            this.panel1.TabIndex = 6;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackgroundImage = global::Principal.Properties.Resources.iconoCerrar;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Location = new System.Drawing.Point(771, 5);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(27, 27);
            this.btnCerrar.TabIndex = 25;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // FrmCapturarImagen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(800, 430);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCapturarImagen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCapturarImagen";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmCapturarImagen_FormClosed);
            this.Load += new System.EventHandler(this.FrmCapturarImagen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxGrabar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCapturar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.ComboBox cbxGrabar;
        private System.Windows.Forms.PictureBox pbxGrabar;
        private System.Windows.Forms.PictureBox pbxCapturar;
        private System.Windows.Forms.Button btnCapturar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCerrar;
    }
}