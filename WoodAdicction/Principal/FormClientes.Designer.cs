
namespace Principal
{
    partial class FormClientes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClientes));
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.btnVerCliente = new System.Windows.Forms.Button();
            this.btnAgregarCliente = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.panelContainerSocios = new System.Windows.Forms.Panel();
            this.btnCobrarCuota = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.panelAviso = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelContainerFiltro = new System.Windows.Forms.Panel();
            this.panelFiltroAvanzado = new System.Windows.Forms.Panel();
            this.cbxEstado = new System.Windows.Forms.ComboBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxMesInicio = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cbxAñoInicio = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnRestablecer = new System.Windows.Forms.Button();
            this.cbxTipoMembresia = new System.Windows.Forms.ComboBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOcultar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnVerMas = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.panelContainerSocios.SuspendLayout();
            this.panelAviso.SuspendLayout();
            this.panelContainerFiltro.SuspendLayout();
            this.panelFiltroAvanzado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvClientes
            // 
            this.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvClientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(41)))));
            this.dgvClientes.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Berlin Sans FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvClientes.ColumnHeadersHeight = 30;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Berlin Sans FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClientes.DefaultCellStyle = dataGridViewCellStyle16;
            this.dgvClientes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvClientes.EnableHeadersVisualStyles = false;
            this.dgvClientes.Location = new System.Drawing.Point(35, 167);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.RowHeadersVisible = false;
            this.dgvClientes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(770, 254);
            this.dgvClientes.TabIndex = 1;
            this.dgvClientes.SelectionChanged += new System.EventHandler(this.dgvClientes_SelectionChanged);
            // 
            // btnVerCliente
            // 
            this.btnVerCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(96)))), ((int)(((byte)(0)))));
            this.btnVerCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerCliente.FlatAppearance.BorderSize = 0;
            this.btnVerCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerCliente.Font = new System.Drawing.Font("Berlin Sans FB", 15F);
            this.btnVerCliente.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnVerCliente.Location = new System.Drawing.Point(235, 464);
            this.btnVerCliente.Name = "btnVerCliente";
            this.btnVerCliente.Size = new System.Drawing.Size(168, 48);
            this.btnVerCliente.TabIndex = 3;
            this.btnVerCliente.Text = "Ver Socio";
            this.btnVerCliente.UseVisualStyleBackColor = false;
            this.btnVerCliente.Click += new System.EventHandler(this.btnVerCliente_Click);
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(96)))), ((int)(((byte)(0)))));
            this.btnAgregarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarCliente.FlatAppearance.BorderSize = 0;
            this.btnAgregarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarCliente.Font = new System.Drawing.Font("Berlin Sans FB", 15F);
            this.btnAgregarCliente.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAgregarCliente.Location = new System.Drawing.Point(35, 464);
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.Size = new System.Drawing.Size(168, 48);
            this.btnAgregarCliente.TabIndex = 4;
            this.btnAgregarCliente.Text = "Agregar Socio";
            this.btnAgregarCliente.UseVisualStyleBackColor = false;
            this.btnAgregarCliente.Click += new System.EventHandler(this.btnAgregarCliente_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(96)))), ((int)(((byte)(0)))));
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Berlin Sans FB", 15F);
            this.btnModificar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnModificar.Location = new System.Drawing.Point(435, 464);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(168, 48);
            this.btnModificar.TabIndex = 5;
            this.btnModificar.Text = "Modificar Socio";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // panelContainerSocios
            // 
            this.panelContainerSocios.AutoScroll = true;
            this.panelContainerSocios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelContainerSocios.Controls.Add(this.btnCobrarCuota);
            this.panelContainerSocios.Controls.Add(this.label9);
            this.panelContainerSocios.Controls.Add(this.panelAviso);
            this.panelContainerSocios.Controls.Add(this.dgvClientes);
            this.panelContainerSocios.Controls.Add(this.btnModificar);
            this.panelContainerSocios.Controls.Add(this.txtNombre);
            this.panelContainerSocios.Controls.Add(this.label1);
            this.panelContainerSocios.Controls.Add(this.btnAgregarCliente);
            this.panelContainerSocios.Controls.Add(this.btnVerCliente);
            this.panelContainerSocios.Location = new System.Drawing.Point(23, 165);
            this.panelContainerSocios.Name = "panelContainerSocios";
            this.panelContainerSocios.Size = new System.Drawing.Size(840, 540);
            this.panelContainerSocios.TabIndex = 6;
            // 
            // btnCobrarCuota
            // 
            this.btnCobrarCuota.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(96)))), ((int)(((byte)(0)))));
            this.btnCobrarCuota.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCobrarCuota.FlatAppearance.BorderSize = 0;
            this.btnCobrarCuota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCobrarCuota.Font = new System.Drawing.Font("Berlin Sans FB", 15F);
            this.btnCobrarCuota.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCobrarCuota.Location = new System.Drawing.Point(635, 464);
            this.btnCobrarCuota.Name = "btnCobrarCuota";
            this.btnCobrarCuota.Size = new System.Drawing.Size(168, 48);
            this.btnCobrarCuota.TabIndex = 17;
            this.btnCobrarCuota.Text = "Cobrar Cuota";
            this.btnCobrarCuota.UseVisualStyleBackColor = false;
            this.btnCobrarCuota.Click += new System.EventHandler(this.btnCobrarCuota_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Berlin Sans FB", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(386, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 30);
            this.label9.TabIndex = 6;
            this.label9.Text = "Socios";
            // 
            // panelAviso
            // 
            this.panelAviso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(173)))), ((int)(((byte)(91)))));
            this.panelAviso.Controls.Add(this.label10);
            this.panelAviso.Location = new System.Drawing.Point(456, 70);
            this.panelAviso.Name = "panelAviso";
            this.panelAviso.Size = new System.Drawing.Size(340, 70);
            this.panelAviso.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Berlin Sans FB", 17F);
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Location = new System.Drawing.Point(22, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(296, 26);
            this.label10.TabIndex = 12;
            this.label10.Text = "Busca un socio por su nombre";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.txtNombre.Location = new System.Drawing.Point(84, 91);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(183, 33);
            this.txtNombre.TabIndex = 13;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 15F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(96)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(84, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre";
            // 
            // panelContainerFiltro
            // 
            this.panelContainerFiltro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelContainerFiltro.Controls.Add(this.panelFiltroAvanzado);
            this.panelContainerFiltro.Controls.Add(this.label11);
            this.panelContainerFiltro.Controls.Add(this.label3);
            this.panelContainerFiltro.Location = new System.Drawing.Point(900, 165);
            this.panelContainerFiltro.Name = "panelContainerFiltro";
            this.panelContainerFiltro.Size = new System.Drawing.Size(430, 189);
            this.panelContainerFiltro.TabIndex = 0;
            // 
            // panelFiltroAvanzado
            // 
            this.panelFiltroAvanzado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.panelFiltroAvanzado.Controls.Add(this.cbxEstado);
            this.panelFiltroAvanzado.Controls.Add(this.txtEdad);
            this.panelFiltroAvanzado.Controls.Add(this.label12);
            this.panelFiltroAvanzado.Controls.Add(this.label6);
            this.panelFiltroAvanzado.Controls.Add(this.cbxMesInicio);
            this.panelFiltroAvanzado.Controls.Add(this.label13);
            this.panelFiltroAvanzado.Controls.Add(this.cbxAñoInicio);
            this.panelFiltroAvanzado.Controls.Add(this.btnBuscar);
            this.panelFiltroAvanzado.Controls.Add(this.btnRestablecer);
            this.panelFiltroAvanzado.Controls.Add(this.cbxTipoMembresia);
            this.panelFiltroAvanzado.Controls.Add(this.txtDni);
            this.panelFiltroAvanzado.Controls.Add(this.label5);
            this.panelFiltroAvanzado.Controls.Add(this.label4);
            this.panelFiltroAvanzado.Controls.Add(this.label2);
            this.panelFiltroAvanzado.Controls.Add(this.btnOcultar);
            this.panelFiltroAvanzado.Controls.Add(this.label7);
            this.panelFiltroAvanzado.Controls.Add(this.btnVerMas);
            this.panelFiltroAvanzado.Controls.Add(this.label8);
            this.panelFiltroAvanzado.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelFiltroAvanzado.Location = new System.Drawing.Point(0, 148);
            this.panelFiltroAvanzado.Name = "panelFiltroAvanzado";
            this.panelFiltroAvanzado.Size = new System.Drawing.Size(427, 40);
            this.panelFiltroAvanzado.TabIndex = 19;
            // 
            // cbxEstado
            // 
            this.cbxEstado.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxEstado.FormattingEnabled = true;
            this.cbxEstado.Location = new System.Drawing.Point(204, 269);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(168, 27);
            this.cbxEstado.TabIndex = 33;
            // 
            // txtEdad
            // 
            this.txtEdad.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEdad.Location = new System.Drawing.Point(204, 225);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(168, 27);
            this.txtEdad.TabIndex = 32;
            this.txtEdad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEdad_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Berlin Sans FB", 15F);
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(25, 225);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 23);
            this.label12.TabIndex = 31;
            this.label12.Text = "Edad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Berlin Sans FB", 15F);
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(25, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 23);
            this.label6.TabIndex = 29;
            this.label6.Text = "Estado";
            // 
            // cbxMesInicio
            // 
            this.cbxMesInicio.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMesInicio.FormattingEnabled = true;
            this.cbxMesInicio.Location = new System.Drawing.Point(204, 137);
            this.cbxMesInicio.Name = "cbxMesInicio";
            this.cbxMesInicio.Size = new System.Drawing.Size(168, 27);
            this.cbxMesInicio.TabIndex = 28;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Berlin Sans FB", 15F);
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(25, 139);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 23);
            this.label13.TabIndex = 26;
            this.label13.Text = "Mes inicio";
            // 
            // cbxAñoInicio
            // 
            this.cbxAñoInicio.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxAñoInicio.FormattingEnabled = true;
            this.cbxAñoInicio.Location = new System.Drawing.Point(204, 93);
            this.cbxAñoInicio.Name = "cbxAñoInicio";
            this.cbxAñoInicio.Size = new System.Drawing.Size(168, 27);
            this.cbxAñoInicio.TabIndex = 24;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(105)))), ((int)(((byte)(45)))));
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBuscar.Location = new System.Drawing.Point(246, 316);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(117, 39);
            this.btnBuscar.TabIndex = 23;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            this.btnBuscar.MouseEnter += new System.EventHandler(this.btnBuscar_MouseEnter);
            this.btnBuscar.MouseLeave += new System.EventHandler(this.btnBuscar_MouseLeave);
            // 
            // btnRestablecer
            // 
            this.btnRestablecer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(164)))));
            this.btnRestablecer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestablecer.FlatAppearance.BorderSize = 0;
            this.btnRestablecer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestablecer.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestablecer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRestablecer.Location = new System.Drawing.Point(75, 316);
            this.btnRestablecer.Name = "btnRestablecer";
            this.btnRestablecer.Size = new System.Drawing.Size(110, 39);
            this.btnRestablecer.TabIndex = 22;
            this.btnRestablecer.Text = "Restablecer";
            this.btnRestablecer.UseVisualStyleBackColor = false;
            this.btnRestablecer.Click += new System.EventHandler(this.btnRestablecer_Click);
            this.btnRestablecer.MouseEnter += new System.EventHandler(this.btnRestablecer_MouseEnter);
            this.btnRestablecer.MouseLeave += new System.EventHandler(this.btnRestablecer_MouseLeave);
            // 
            // cbxTipoMembresia
            // 
            this.cbxTipoMembresia.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTipoMembresia.FormattingEnabled = true;
            this.cbxTipoMembresia.Location = new System.Drawing.Point(204, 181);
            this.cbxTipoMembresia.Name = "cbxTipoMembresia";
            this.cbxTipoMembresia.Size = new System.Drawing.Size(168, 27);
            this.cbxTipoMembresia.TabIndex = 18;
            // 
            // txtDni
            // 
            this.txtDni.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDni.Location = new System.Drawing.Point(204, 49);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(168, 27);
            this.txtDni.TabIndex = 16;
            this.txtDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDni_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Berlin Sans FB", 15F);
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(25, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "Año inicio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Berlin Sans FB", 15F);
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(25, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tipo de membresia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB", 15F);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(25, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Dni";
            // 
            // btnOcultar
            // 
            this.btnOcultar.BackgroundImage = global::Principal.Properties.Resources.iconoOcultar;
            this.btnOcultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOcultar.FlatAppearance.BorderSize = 0;
            this.btnOcultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOcultar.Location = new System.Drawing.Point(327, 365);
            this.btnOcultar.Name = "btnOcultar";
            this.btnOcultar.Size = new System.Drawing.Size(24, 24);
            this.btnOcultar.TabIndex = 15;
            this.btnOcultar.UseVisualStyleBackColor = true;
            this.btnOcultar.Click += new System.EventHandler(this.btnOcultar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Berlin Sans FB", 15F);
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(77, 365);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(249, 23);
            this.label7.TabIndex = 12;
            this.label7.Text = "Ocultar búsqueda avanzada";
            // 
            // btnVerMas
            // 
            this.btnVerMas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVerMas.BackgroundImage")));
            this.btnVerMas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerMas.FlatAppearance.BorderSize = 0;
            this.btnVerMas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerMas.Location = new System.Drawing.Point(327, 7);
            this.btnVerMas.Name = "btnVerMas";
            this.btnVerMas.Size = new System.Drawing.Size(24, 24);
            this.btnVerMas.TabIndex = 15;
            this.btnVerMas.UseVisualStyleBackColor = true;
            this.btnVerMas.Click += new System.EventHandler(this.btnVerMas_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Berlin Sans FB", 15F);
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(77, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(249, 23);
            this.label8.TabIndex = 12;
            this.label8.Text = "Mostrar búsqueda avanzada";
            // 
            // label11
            // 
            this.label11.AllowDrop = true;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Berlin Sans FB", 11F);
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label11.Location = new System.Drawing.Point(67, 72);
            this.label11.MaximumSize = new System.Drawing.Size(300, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(296, 51);
            this.label11.TabIndex = 17;
            this.label11.Text = "¡Usa la busqueda avanzada para encontrar un socio por su dni, tipo de membresia, " +
    "estado y demas datos!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Berlin Sans FB", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(135, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 30);
            this.label3.TabIndex = 5;
            this.label3.Text = "Buscar Socios";
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackgroundImage = global::Principal.Properties.Resources.iconoCerrar;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Location = new System.Drawing.Point(1336, 13);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(27, 27);
            this.btnCerrar.TabIndex = 7;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Principal.Properties.Resources.FondoWoodGym;
            this.pictureBox1.Location = new System.Drawing.Point(23, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 136);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Principal.Properties.Resources.FondoWoodGym;
            this.panel1.Controls.Add(this.panelContainerFiltro);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panelContainerSocios);
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1386, 788);
            this.panel1.TabIndex = 9;
            // 
            // FormClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "FormClientes";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.panelContainerSocios.ResumeLayout(false);
            this.panelContainerSocios.PerformLayout();
            this.panelAviso.ResumeLayout(false);
            this.panelAviso.PerformLayout();
            this.panelContainerFiltro.ResumeLayout(false);
            this.panelContainerFiltro.PerformLayout();
            this.panelFiltroAvanzado.ResumeLayout(false);
            this.panelFiltroAvanzado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContainerFiltro;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Button btnVerCliente;
        private System.Windows.Forms.Button btnAgregarCliente;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Panel panelContainerSocios;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnVerMas;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panelAviso;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panelFiltroAvanzado;
        private System.Windows.Forms.Button btnOcultar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnRestablecer;
        private System.Windows.Forms.ComboBox cbxTipoMembresia;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxMesInicio;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbxAñoInicio;
        private System.Windows.Forms.ComboBox cbxEstado;
        private System.Windows.Forms.Button btnCobrarCuota;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
    }
}