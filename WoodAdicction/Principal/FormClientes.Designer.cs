
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlFr = new System.Windows.Forms.Panel();
            this.btnFr = new System.Windows.Forms.Button();
            this.cbxFiltroFr = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxVerFr = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.btnVerCliente = new System.Windows.Forms.Button();
            this.btnAgregarCliente = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.pnlFr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFr
            // 
            this.pnlFr.Controls.Add(this.btnFr);
            this.pnlFr.Controls.Add(this.cbxFiltroFr);
            this.pnlFr.Controls.Add(this.label2);
            this.pnlFr.Controls.Add(this.cbxVerFr);
            this.pnlFr.Controls.Add(this.label1);
            this.pnlFr.Location = new System.Drawing.Point(0, 0);
            this.pnlFr.Name = "pnlFr";
            this.pnlFr.Size = new System.Drawing.Size(774, 100);
            this.pnlFr.TabIndex = 0;
            // 
            // btnFr
            // 
            this.btnFr.Font = new System.Drawing.Font("Berlin Sans FB", 8.25F);
            this.btnFr.Location = new System.Drawing.Point(578, 45);
            this.btnFr.Name = "btnFr";
            this.btnFr.Size = new System.Drawing.Size(75, 23);
            this.btnFr.TabIndex = 4;
            this.btnFr.Text = "Mostrar";
            this.btnFr.UseVisualStyleBackColor = true;
            // 
            // cbxFiltroFr
            // 
            this.cbxFiltroFr.FormattingEnabled = true;
            this.cbxFiltroFr.Location = new System.Drawing.Point(328, 48);
            this.cbxFiltroFr.Name = "cbxFiltroFr";
            this.cbxFiltroFr.Size = new System.Drawing.Size(121, 21);
            this.cbxFiltroFr.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB", 8.25F);
            this.label2.Location = new System.Drawing.Point(325, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Filtro";
            // 
            // cbxVerFr
            // 
            this.cbxVerFr.FormattingEnabled = true;
            this.cbxVerFr.Location = new System.Drawing.Point(87, 49);
            this.cbxVerFr.Name = "cbxVerFr";
            this.cbxVerFr.Size = new System.Drawing.Size(121, 21);
            this.cbxVerFr.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 8.25F);
            this.label1.Location = new System.Drawing.Point(84, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ver";
            // 
            // dgvClientes
            // 
            this.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvClientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvClientes.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Berlin Sans FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Berlin Sans FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClientes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvClientes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvClientes.Location = new System.Drawing.Point(0, 173);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(818, 200);
            this.dgvClientes.TabIndex = 1;
            this.dgvClientes.SelectionChanged += new System.EventHandler(this.dgvClientes_SelectionChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(218, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // btnVerCliente
            // 
            this.btnVerCliente.Location = new System.Drawing.Point(102, 463);
            this.btnVerCliente.Name = "btnVerCliente";
            this.btnVerCliente.Size = new System.Drawing.Size(75, 48);
            this.btnVerCliente.TabIndex = 3;
            this.btnVerCliente.Text = "Ver Socio";
            this.btnVerCliente.UseVisualStyleBackColor = true;
            this.btnVerCliente.Click += new System.EventHandler(this.btnVerCliente_Click);
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.Location = new System.Drawing.Point(591, 463);
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.Size = new System.Drawing.Size(99, 48);
            this.btnAgregarCliente.TabIndex = 4;
            this.btnAgregarCliente.Text = "Agregar Socio";
            this.btnAgregarCliente.UseVisualStyleBackColor = true;
            this.btnAgregarCliente.Click += new System.EventHandler(this.btnAgregarCliente_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(328, 463);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(105, 48);
            this.btnModificar.TabIndex = 5;
            this.btnModificar.Text = "Modificar Socio";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // FormClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 539);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregarCliente);
            this.Controls.Add(this.btnVerCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.pnlFr);
            this.Name = "FormClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormClientes";
            this.Load += new System.EventHandler(this.FormClientes_Load);
            this.pnlFr.ResumeLayout(false);
            this.pnlFr.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlFr;
        private System.Windows.Forms.Button btnFr;
        private System.Windows.Forms.ComboBox cbxFiltroFr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxVerFr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnVerCliente;
        private System.Windows.Forms.Button btnAgregarCliente;
        private System.Windows.Forms.Button btnModificar;
    }
}