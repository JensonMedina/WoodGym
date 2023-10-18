
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
            this.pnlFr = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxVerFr = new System.Windows.Forms.ComboBox();
            this.cbxFiltroFr = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFr = new System.Windows.Forms.Button();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
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
            // cbxVerFr
            // 
            this.cbxVerFr.FormattingEnabled = true;
            this.cbxVerFr.Location = new System.Drawing.Point(87, 49);
            this.cbxVerFr.Name = "cbxVerFr";
            this.cbxVerFr.Size = new System.Drawing.Size(121, 21);
            this.cbxVerFr.TabIndex = 1;
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
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(0, 250);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.Size = new System.Drawing.Size(774, 200);
            this.dgvClientes.TabIndex = 1;
            // 
            // FormClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.pnlFr);
            this.Name = "FormClientes";
            this.Text = "FormClientes";
            this.Load += new System.EventHandler(this.FormClientes_Load);
            this.pnlFr.ResumeLayout(false);
            this.pnlFr.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFr;
        private System.Windows.Forms.Button btnFr;
        private System.Windows.Forms.ComboBox cbxFiltroFr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxVerFr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvClientes;
    }
}