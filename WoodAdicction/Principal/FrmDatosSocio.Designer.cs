
namespace Principal
{
    partial class FrmDatosSocio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDatosSocio));
            this.pbxCliente = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCamara = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblEdad = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblVencimiento = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblDebe = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxCliente
            // 
            this.pbxCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxCliente.Location = new System.Drawing.Point(74, 154);
            this.pbxCliente.Name = "pbxCliente";
            this.pbxCliente.Size = new System.Drawing.Size(188, 222);
            this.pbxCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxCliente.TabIndex = 0;
            this.pbxCliente.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Berlin Sans FB", 20F);
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTitulo.Location = new System.Drawing.Point(368, 54);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(233, 30);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "DATOS DEL SOCIO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB", 15F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(96)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(344, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 23);
            this.label2.TabIndex = 2;
            this.label2.Tag = "";
            this.label2.Text = "Nombre *";
            // 
            // txtNombre
            // 
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(348, 190);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(175, 32);
            this.txtNombre.TabIndex = 3;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // txtApellido
            // 
            this.txtApellido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtApellido.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.Location = new System.Drawing.Point(578, 190);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(177, 32);
            this.txtApellido.TabIndex = 5;
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Berlin Sans FB", 15F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(96)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(574, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 23);
            this.label3.TabIndex = 4;
            this.label3.Tag = "";
            this.label3.Text = "Apellido *";
            // 
            // txtDni
            // 
            this.txtDni.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDni.Location = new System.Drawing.Point(348, 245);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(175, 32);
            this.txtDni.TabIndex = 7;
            this.txtDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDni_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Berlin Sans FB", 15F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(96)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(344, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 23);
            this.label4.TabIndex = 6;
            this.label4.Tag = "";
            this.label4.Text = "Dni *";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Berlin Sans FB", 15F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(96)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(574, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 23);
            this.label5.TabIndex = 8;
            this.label5.Tag = "";
            this.label5.Text = "Fecha de nacimiento";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(348, 300);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(175, 32);
            this.txtTelefono.TabIndex = 11;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDni_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Berlin Sans FB", 15F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(96)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(344, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 23);
            this.label6.TabIndex = 10;
            this.label6.Tag = "";
            this.label6.Text = "Telefono";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Berlin Sans FB", 15F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(96)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(574, 276);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 23);
            this.label7.TabIndex = 12;
            this.label7.Tag = "";
            this.label7.Text = "Fecha de inicio *";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(578, 245);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(177, 28);
            this.dtpFechaNacimiento.TabIndex = 16;
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaInicio.Location = new System.Drawing.Point(578, 300);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(177, 28);
            this.dtpFechaInicio.TabIndex = 17;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(96)))), ((int)(((byte)(0)))));
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Berlin Sans FB", 15F);
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGuardar.Location = new System.Drawing.Point(467, 397);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(98, 30);
            this.btnGuardar.TabIndex = 19;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(96)))), ((int)(((byte)(0)))));
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Berlin Sans FB", 15F);
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancelar.Location = new System.Drawing.Point(588, 397);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(98, 31);
            this.btnCancelar.TabIndex = 20;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnCamara
            // 
            this.btnCamara.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCamara.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCamara.BackgroundImage")));
            this.btnCamara.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCamara.FlatAppearance.BorderSize = 0;
            this.btnCamara.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCamara.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCamara.Location = new System.Drawing.Point(268, 154);
            this.btnCamara.Name = "btnCamara";
            this.btnCamara.Size = new System.Drawing.Size(30, 30);
            this.btnCamara.TabIndex = 22;
            this.btnCamara.UseVisualStyleBackColor = false;
            this.btnCamara.Click += new System.EventHandler(this.btnCamara_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackgroundImage = global::Principal.Properties.Resources.iconoCerrar;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Location = new System.Drawing.Point(813, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(27, 27);
            this.btnCerrar.TabIndex = 24;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Font = new System.Drawing.Font("Berlin Sans FB", 15F);
            this.lblEdad.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblEdad.Location = new System.Drawing.Point(192, 380);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(53, 23);
            this.lblEdad.TabIndex = 25;
            this.lblEdad.Text = "edad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 15F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(96)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(70, 405);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 23);
            this.label1.TabIndex = 26;
            this.label1.Text = "Vencimiento:";
            // 
            // lblVencimiento
            // 
            this.lblVencimiento.AutoSize = true;
            this.lblVencimiento.Font = new System.Drawing.Font("Berlin Sans FB", 15F);
            this.lblVencimiento.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblVencimiento.Location = new System.Drawing.Point(192, 404);
            this.lblVencimiento.Name = "lblVencimiento";
            this.lblVencimiento.Size = new System.Drawing.Size(116, 23);
            this.lblVencimiento.TabIndex = 27;
            this.lblVencimiento.Text = "Vencimiento:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Berlin Sans FB", 15F);
            this.lblEstado.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblEstado.Location = new System.Drawing.Point(192, 428);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(66, 23);
            this.lblEstado.TabIndex = 28;
            this.lblEstado.Text = "Estado";
            // 
            // lblDebe
            // 
            this.lblDebe.AutoSize = true;
            this.lblDebe.Font = new System.Drawing.Font("Berlin Sans FB", 15F);
            this.lblDebe.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDebe.Location = new System.Drawing.Point(192, 451);
            this.lblDebe.Name = "lblDebe";
            this.lblDebe.Size = new System.Drawing.Size(19, 23);
            this.lblDebe.TabIndex = 30;
            this.lblDebe.Text = "$";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Berlin Sans FB", 15F);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(96)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(70, 451);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 23);
            this.label10.TabIndex = 29;
            this.label10.Text = "Debe:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Principal.Properties.Resources.FondoWoodGym;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 136);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Berlin Sans FB", 15F);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(96)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(70, 382);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 23);
            this.label8.TabIndex = 32;
            this.label8.Text = "Edad";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Berlin Sans FB", 15F);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(96)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(70, 428);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 23);
            this.label9.TabIndex = 33;
            this.label9.Text = "Estado";
            // 
            // FrmDatosSocio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(860, 513);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblDebe);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblVencimiento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnCamara);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dtpFechaInicio);
            this.Controls.Add(this.dtpFechaNacimiento);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pbxCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDatosSocio";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDatosSocio";
            this.Load += new System.EventHandler(this.FrmDatosSocio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxCliente;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnCamara;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblVencimiento;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblDebe;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}