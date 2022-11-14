namespace DolphineAccountant
{
    partial class VentanaVentas
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
            this.btnCerrarVentas = new System.Windows.Forms.PictureBox();
            this.lblCompras = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCerrarVentas
            // 
            this.btnCerrarVentas.Image = global::DolphineAccountant.Properties.Resources.salir;
            this.btnCerrarVentas.Location = new System.Drawing.Point(12, 588);
            this.btnCerrarVentas.Name = "btnCerrarVentas";
            this.btnCerrarVentas.Size = new System.Drawing.Size(100, 50);
            this.btnCerrarVentas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrarVentas.TabIndex = 1;
            this.btnCerrarVentas.TabStop = false;
            this.btnCerrarVentas.Click += new System.EventHandler(this.btnCerrarVentas_Click);
            // 
            // lblCompras
            // 
            this.lblCompras.AutoSize = true;
            this.lblCompras.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompras.ForeColor = System.Drawing.Color.Snow;
            this.lblCompras.Location = new System.Drawing.Point(7, 9);
            this.lblCompras.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblCompras.Name = "lblCompras";
            this.lblCompras.Size = new System.Drawing.Size(90, 25);
            this.lblCompras.TabIndex = 5;
            this.lblCompras.Text = "VENTAS";
            // 
            // VentanaVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.lblCompras);
            this.Controls.Add(this.btnCerrarVentas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VentanaVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VentanaVentas";
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox btnCerrarVentas;
        private System.Windows.Forms.Label lblCompras;
    }
}