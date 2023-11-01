
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClientes));
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.btnVerCliente = new System.Windows.Forms.Button();
            this.btnAgregarCliente = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.panelContainerSocios = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panelContainerFiltro = new System.Windows.Forms.Panel();
            this.panelFiltroAvanzado = new System.Windows.Forms.Panel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnRestablecer = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.nudEdadFinal = new System.Windows.Forms.NumericUpDown();
            this.nudEdadInicio = new System.Windows.Forms.NumericUpDown();
            this.cbxTipoMembresia = new System.Windows.Forms.ComboBox();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOcultar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnVerMas = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panelAviso = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.panelContainerSocios.SuspendLayout();
            this.panelContainerFiltro.SuspendLayout();
            this.panelFiltroAvanzado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdadFinal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdadInicio)).BeginInit();
            this.panelAviso.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvClientes
            // 
            this.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvClientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(41)))));
            this.dgvClientes.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Berlin Sans FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvClientes.ColumnHeadersHeight = 30;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Berlin Sans FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClientes.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvClientes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvClientes.EnableHeadersVisualStyles = false;
            this.dgvClientes.Location = new System.Drawing.Point(41, 61);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.RowHeadersVisible = false;
            this.dgvClientes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(771, 230);
            this.dgvClientes.TabIndex = 1;
            this.dgvClientes.SelectionChanged += new System.EventHandler(this.dgvClientes_SelectionChanged);
            // 
            // btnVerCliente
            // 
            this.btnVerCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(180)))), ((int)(((byte)(53)))));
            this.btnVerCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerCliente.FlatAppearance.BorderSize = 0;
            this.btnVerCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerCliente.Font = new System.Drawing.Font("Berlin Sans FB", 15F);
            this.btnVerCliente.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnVerCliente.Location = new System.Drawing.Point(315, 320);
            this.btnVerCliente.Name = "btnVerCliente";
            this.btnVerCliente.Size = new System.Drawing.Size(223, 48);
            this.btnVerCliente.TabIndex = 3;
            this.btnVerCliente.Text = "Ver Socio";
            this.btnVerCliente.UseVisualStyleBackColor = false;
            this.btnVerCliente.Click += new System.EventHandler(this.btnVerCliente_Click);
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(180)))), ((int)(((byte)(53)))));
            this.btnAgregarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarCliente.FlatAppearance.BorderSize = 0;
            this.btnAgregarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarCliente.Font = new System.Drawing.Font("Berlin Sans FB", 15F);
            this.btnAgregarCliente.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAgregarCliente.Location = new System.Drawing.Point(41, 320);
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.Size = new System.Drawing.Size(223, 48);
            this.btnAgregarCliente.TabIndex = 4;
            this.btnAgregarCliente.Text = "Agregar Socio";
            this.btnAgregarCliente.UseVisualStyleBackColor = false;
            this.btnAgregarCliente.Click += new System.EventHandler(this.btnAgregarCliente_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(180)))), ((int)(((byte)(53)))));
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Berlin Sans FB", 15F);
            this.btnModificar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnModificar.Location = new System.Drawing.Point(589, 320);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(223, 48);
            this.btnModificar.TabIndex = 5;
            this.btnModificar.Text = "Modificar Socio";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // panelContainerSocios
            // 
            this.panelContainerSocios.AutoScroll = true;
            this.panelContainerSocios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelContainerSocios.Controls.Add(this.label9);
            this.panelContainerSocios.Controls.Add(this.dgvClientes);
            this.panelContainerSocios.Controls.Add(this.btnModificar);
            this.panelContainerSocios.Controls.Add(this.btnAgregarCliente);
            this.panelContainerSocios.Controls.Add(this.btnVerCliente);
            this.panelContainerSocios.Location = new System.Drawing.Point(268, 314);
            this.panelContainerSocios.Name = "panelContainerSocios";
            this.panelContainerSocios.Size = new System.Drawing.Size(850, 412);
            this.panelContainerSocios.TabIndex = 6;
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
            // panelContainerFiltro
            // 
            this.panelContainerFiltro.Controls.Add(this.panelFiltroAvanzado);
            this.panelContainerFiltro.Controls.Add(this.label11);
            this.panelContainerFiltro.Controls.Add(this.panelAviso);
            this.panelContainerFiltro.Controls.Add(this.textBox1);
            this.panelContainerFiltro.Controls.Add(this.label1);
            this.panelContainerFiltro.Controls.Add(this.label3);
            this.panelContainerFiltro.Location = new System.Drawing.Point(268, 23);
            this.panelContainerFiltro.Name = "panelContainerFiltro";
            this.panelContainerFiltro.Size = new System.Drawing.Size(850, 257);
            this.panelContainerFiltro.TabIndex = 0;
            // 
            // panelFiltroAvanzado
            // 
            this.panelFiltroAvanzado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.panelFiltroAvanzado.Controls.Add(this.btnBuscar);
            this.panelFiltroAvanzado.Controls.Add(this.btnRestablecer);
            this.panelFiltroAvanzado.Controls.Add(this.label12);
            this.panelFiltroAvanzado.Controls.Add(this.nudEdadFinal);
            this.panelFiltroAvanzado.Controls.Add(this.nudEdadInicio);
            this.panelFiltroAvanzado.Controls.Add(this.cbxTipoMembresia);
            this.panelFiltroAvanzado.Controls.Add(this.dtpFechaInicio);
            this.panelFiltroAvanzado.Controls.Add(this.txtDni);
            this.panelFiltroAvanzado.Controls.Add(this.label6);
            this.panelFiltroAvanzado.Controls.Add(this.label5);
            this.panelFiltroAvanzado.Controls.Add(this.label4);
            this.panelFiltroAvanzado.Controls.Add(this.label2);
            this.panelFiltroAvanzado.Controls.Add(this.btnOcultar);
            this.panelFiltroAvanzado.Controls.Add(this.label7);
            this.panelFiltroAvanzado.Controls.Add(this.btnVerMas);
            this.panelFiltroAvanzado.Controls.Add(this.label8);
            this.panelFiltroAvanzado.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelFiltroAvanzado.Location = new System.Drawing.Point(0, 217);
            this.panelFiltroAvanzado.Name = "panelFiltroAvanzado";
            this.panelFiltroAvanzado.Size = new System.Drawing.Size(848, 40);
            this.panelFiltroAvanzado.TabIndex = 19;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(105)))), ((int)(((byte)(45)))));
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBuscar.Location = new System.Drawing.Point(701, 127);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(117, 39);
            this.btnBuscar.TabIndex = 23;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
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
            this.btnRestablecer.Location = new System.Drawing.Point(582, 127);
            this.btnRestablecer.Name = "btnRestablecer";
            this.btnRestablecer.Size = new System.Drawing.Size(110, 39);
            this.btnRestablecer.TabIndex = 22;
            this.btnRestablecer.Text = "Restablecer";
            this.btnRestablecer.UseVisualStyleBackColor = false;
            this.btnRestablecer.MouseEnter += new System.EventHandler(this.btnRestablecer_MouseEnter);
            this.btnRestablecer.MouseLeave += new System.EventHandler(this.btnRestablecer_MouseLeave);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label12.Location = new System.Drawing.Point(697, 73);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(14, 19);
            this.label12.TabIndex = 21;
            this.label12.Text = "-";
            // 
            // nudEdadFinal
            // 
            this.nudEdadFinal.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudEdadFinal.Location = new System.Drawing.Point(728, 71);
            this.nudEdadFinal.Name = "nudEdadFinal";
            this.nudEdadFinal.Size = new System.Drawing.Size(60, 27);
            this.nudEdadFinal.TabIndex = 20;
            // 
            // nudEdadInicio
            // 
            this.nudEdadInicio.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudEdadInicio.Location = new System.Drawing.Point(620, 71);
            this.nudEdadInicio.Name = "nudEdadInicio";
            this.nudEdadInicio.Size = new System.Drawing.Size(60, 27);
            this.nudEdadInicio.TabIndex = 19;
            // 
            // cbxTipoMembresia
            // 
            this.cbxTipoMembresia.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTipoMembresia.FormattingEnabled = true;
            this.cbxTipoMembresia.Location = new System.Drawing.Point(416, 71);
            this.cbxTipoMembresia.Name = "cbxTipoMembresia";
            this.cbxTipoMembresia.Size = new System.Drawing.Size(168, 27);
            this.cbxTipoMembresia.TabIndex = 18;
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaInicio.Location = new System.Drawing.Point(217, 72);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(168, 27);
            this.dtpFechaInicio.TabIndex = 17;
            // 
            // txtDni
            // 
            this.txtDni.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDni.Location = new System.Drawing.Point(18, 72);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(168, 27);
            this.txtDni.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Berlin Sans FB", 15F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(96)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(616, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 23);
            this.label6.TabIndex = 10;
            this.label6.Text = "Rango de edades";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Berlin Sans FB", 15F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(96)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(213, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "Fecha de inicio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Berlin Sans FB", 15F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(96)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(412, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tipo de membresia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB", 15F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(96)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(14, 46);
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
            this.btnOcultar.Location = new System.Drawing.Point(540, 168);
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
            this.label7.Location = new System.Drawing.Point(285, 166);
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
            this.btnVerMas.Location = new System.Drawing.Point(543, 8);
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
            this.label8.Location = new System.Drawing.Point(288, 8);
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
            this.label11.Location = new System.Drawing.Point(69, 136);
            this.label11.MaximumSize = new System.Drawing.Size(300, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(296, 51);
            this.label11.TabIndex = 17;
            this.label11.Text = "¡Usa la busqueda avanzada para encontrar un socio por su dni, tipo de membresia, " +
    "estado y demas datos!";
            // 
            // panelAviso
            // 
            this.panelAviso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(173)))), ((int)(((byte)(91)))));
            this.panelAviso.Controls.Add(this.label10);
            this.panelAviso.Location = new System.Drawing.Point(448, 78);
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
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.textBox1.Location = new System.Drawing.Point(69, 93);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(183, 33);
            this.textBox1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 15F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(96)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(69, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Berlin Sans FB", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(345, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 30);
            this.label3.TabIndex = 5;
            this.label3.Text = "Buscar Socios";
            // 
            // FormClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.panelContainerSocios);
            this.Controls.Add(this.panelContainerFiltro);
            this.Name = "FormClientes";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormClientes";
            this.Load += new System.EventHandler(this.FormClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.panelContainerSocios.ResumeLayout(false);
            this.panelContainerSocios.PerformLayout();
            this.panelContainerFiltro.ResumeLayout(false);
            this.panelContainerFiltro.PerformLayout();
            this.panelFiltroAvanzado.ResumeLayout(false);
            this.panelFiltroAvanzado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdadFinal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdadInicio)).EndInit();
            this.panelAviso.ResumeLayout(false);
            this.panelAviso.PerformLayout();
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
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
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown nudEdadFinal;
        private System.Windows.Forms.NumericUpDown nudEdadInicio;
        private System.Windows.Forms.ComboBox cbxTipoMembresia;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.TextBox txtDni;
    }
}