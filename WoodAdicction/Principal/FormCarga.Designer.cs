
namespace Principal
{
    partial class FormCarga
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
            this.components = new System.ComponentModel.Container();
            this.label3 = new System.Windows.Forms.Label();
            this.myProgressBar = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Berlin Sans FB", 15.75F);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(487, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Version 1.0";
            // 
            // myProgressBar
            // 
            this.myProgressBar.ForeColor = System.Drawing.Color.RoyalBlue;
            this.myProgressBar.Location = new System.Drawing.Point(-1, 285);
            this.myProgressBar.Name = "myProgressBar";
            this.myProgressBar.Size = new System.Drawing.Size(610, 17);
            this.myProgressBar.TabIndex = 4;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormCarga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(96)))), ((int)(((byte)(0)))));
            this.BackgroundImage = global::Principal.Properties.Resources.FondoWoodGym;
            this.ClientSize = new System.Drawing.Size(600, 300);
            this.Controls.Add(this.myProgressBar);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("MS PGothic", 21.75F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "FormCarga";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormCarga_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar myProgressBar;
        private System.Windows.Forms.Timer timer1;
    }
}