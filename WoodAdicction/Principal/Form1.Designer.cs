
namespace Principal
{
    partial class Form1
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
            this.lblTituloActividades = new System.Windows.Forms.Label();
            this.dgvActividades = new System.Windows.Forms.DataGridView();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnCuota = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActividades)).BeginInit();
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
            this.lblNombre.Location = new System.Drawing.Point(156, 62);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(82, 20);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre: ";
            // 
            // pcbCliente
            // 
            this.pcbCliente.Location = new System.Drawing.Point(15, 47);
            this.pcbCliente.Name = "pcbCliente";
            this.pcbCliente.Size = new System.Drawing.Size(115, 129);
            this.pcbCliente.TabIndex = 2;
            this.pcbCliente.TabStop = false;
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Font = new System.Drawing.Font("Berlin Sans FB", 13F);
            this.lblDni.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(96)))), ((int)(((byte)(0)))));
            this.lblDni.Location = new System.Drawing.Point(159, 85);
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
            this.lblFechaNacimiento.Location = new System.Drawing.Point(156, 117);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(147, 20);
            this.lblFechaNacimiento.TabIndex = 4;
            this.lblFechaNacimiento.Text = "Fecha nacimiento:";
            // 
            // lblTituloActividades
            // 
            this.lblTituloActividades.AutoSize = true;
            this.lblTituloActividades.Font = new System.Drawing.Font("Berlin Sans FB", 11F);
            this.lblTituloActividades.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(96)))), ((int)(((byte)(0)))));
            this.lblTituloActividades.Location = new System.Drawing.Point(22, 263);
            this.lblTituloActividades.Name = "lblTituloActividades";
            this.lblTituloActividades.Size = new System.Drawing.Size(188, 17);
            this.lblTituloActividades.TabIndex = 5;
            this.lblTituloActividades.Text = "ACTIVIDADES QUE REALIZA";
            // 
            // dgvActividades
            // 
            this.dgvActividades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActividades.Location = new System.Drawing.Point(15, 305);
            this.dgvActividades.Name = "dgvActividades";
            this.dgvActividades.Size = new System.Drawing.Size(536, 60);
            this.dgvActividades.TabIndex = 6;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(156)))), ((int)(((byte)(144)))));
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Berlin Sans FB", 12F);
            this.btnEditar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEditar.Location = new System.Drawing.Point(454, 47);
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
            this.btnCuota.Location = new System.Drawing.Point(454, 106);
            this.btnCuota.Name = "btnCuota";
            this.btnCuota.Size = new System.Drawing.Size(113, 35);
            this.btnCuota.TabIndex = 8;
            this.btnCuota.Text = "Cobrar Cuota";
            this.btnCuota.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(602, 413);
            this.Controls.Add(this.btnCuota);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.dgvActividades);
            this.Controls.Add(this.lblTituloActividades);
            this.Controls.Add(this.lblFechaNacimiento);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.pcbCliente);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.labelFichaSocio);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActividades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFichaSocio;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.PictureBox pcbCliente;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.Label lblTituloActividades;
        private System.Windows.Forms.DataGridView dgvActividades;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnCuota;
    }
}

