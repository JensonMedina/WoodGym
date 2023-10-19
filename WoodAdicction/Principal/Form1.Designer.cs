
namespace Principal
{
    partial class FrmFichaCliente
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
            this.labelFichaSocio = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.pcbCliente = new System.Windows.Forms.PictureBox();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnCuota = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtFechaNacimiento = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtFechaInicio = new System.Windows.Forms.TextBox();
            this.txtTipoMembresia = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // labelFichaSocio
            // 
            this.labelFichaSocio.AutoSize = true;
            this.labelFichaSocio.Font = new System.Drawing.Font("Berlin Sans FB", 18F);
            this.labelFichaSocio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(96)))), ((int)(((byte)(0)))));
            this.labelFichaSocio.Location = new System.Drawing.Point(11, 9);
            this.labelFichaSocio.Name = "labelFichaSocio";
            this.labelFichaSocio.Size = new System.Drawing.Size(194, 26);
            this.labelFichaSocio.TabIndex = 0;
            this.labelFichaSocio.Text = "FICHA DEL SOCIO";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Berlin Sans FB", 13F);
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(96)))), ((int)(((byte)(0)))));
            this.lblNombre.Location = new System.Drawing.Point(443, 47);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(82, 20);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre: ";
            // 
            // pcbCliente
            // 
            this.pcbCliente.Location = new System.Drawing.Point(15, 47);
            this.pcbCliente.Name = "pcbCliente";
            this.pcbCliente.Size = new System.Drawing.Size(357, 301);
            this.pcbCliente.TabIndex = 2;
            this.pcbCliente.TabStop = false;
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Font = new System.Drawing.Font("Berlin Sans FB", 13F);
            this.lblDni.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(96)))), ((int)(((byte)(0)))));
            this.lblDni.Location = new System.Drawing.Point(455, 76);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(39, 20);
            this.lblDni.TabIndex = 3;
            this.lblDni.Text = "Dni:";
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Font = new System.Drawing.Font("Berlin Sans FB", 13F);
            this.lblFechaNacimiento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(96)))), ((int)(((byte)(0)))));
            this.lblFechaNacimiento.Location = new System.Drawing.Point(443, 112);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(147, 20);
            this.lblFechaNacimiento.TabIndex = 4;
            this.lblFechaNacimiento.Text = "Fecha nacimiento:";
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(156)))), ((int)(((byte)(144)))));
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Berlin Sans FB", 12F);
            this.btnEditar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEditar.Location = new System.Drawing.Point(447, 276);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(113, 35);
            this.btnEditar.TabIndex = 7;
            this.btnEditar.Text = "Editar Datos";
            this.btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnCuota
            // 
            this.btnCuota.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(180)))), ((int)(((byte)(53)))));
            this.btnCuota.FlatAppearance.BorderSize = 0;
            this.btnCuota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCuota.Font = new System.Drawing.Font("Berlin Sans FB", 12F);
            this.btnCuota.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCuota.Location = new System.Drawing.Point(733, 313);
            this.btnCuota.Name = "btnCuota";
            this.btnCuota.Size = new System.Drawing.Size(113, 35);
            this.btnCuota.TabIndex = 8;
            this.btnCuota.Text = "Cobrar Cuota";
            this.btnCuota.UseVisualStyleBackColor = false;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(631, 47);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 9;
            // 
            // txtFechaNacimiento
            // 
            this.txtFechaNacimiento.Location = new System.Drawing.Point(631, 114);
            this.txtFechaNacimiento.Name = "txtFechaNacimiento";
            this.txtFechaNacimiento.Size = new System.Drawing.Size(100, 20);
            this.txtFechaNacimiento.TabIndex = 10;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(631, 78);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(100, 20);
            this.txtDni.TabIndex = 11;
            // 
            // txtFechaInicio
            // 
            this.txtFechaInicio.Location = new System.Drawing.Point(631, 180);
            this.txtFechaInicio.Name = "txtFechaInicio";
            this.txtFechaInicio.Size = new System.Drawing.Size(100, 20);
            this.txtFechaInicio.TabIndex = 17;
            // 
            // txtTipoMembresia
            // 
            this.txtTipoMembresia.Location = new System.Drawing.Point(631, 218);
            this.txtTipoMembresia.Name = "txtTipoMembresia";
            this.txtTipoMembresia.Size = new System.Drawing.Size(100, 20);
            this.txtTipoMembresia.TabIndex = 16;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(631, 149);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(100, 20);
            this.txtTelefono.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 13F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(96)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(443, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Tipo Membresia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB", 13F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(96)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(443, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Fecha Inicio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Berlin Sans FB", 13F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(96)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(443, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Telefono";
            // 
            // FrmFichaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(909, 413);
            this.Controls.Add(this.txtFechaInicio);
            this.Controls.Add(this.txtTipoMembresia);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.txtFechaNacimiento);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnCuota);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.lblFechaNacimiento);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.pcbCliente);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.labelFichaSocio);
            this.Name = "FrmFichaCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmFichaCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFichaSocio;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.PictureBox pcbCliente;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnCuota;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtFechaNacimiento;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtFechaInicio;
        private System.Windows.Forms.TextBox txtTipoMembresia;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

