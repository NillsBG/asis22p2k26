namespace CapaVista_Mantenimiento.Forms
{
    partial class FrmMantenimiento
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
            this.navegador1 = new CapaVista_Navegador.Navegador();
            this.Ayuda = new System.Windows.Forms.Button();
            this.Reporte = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // navegador1
            // 
            this.navegador1.Location = new System.Drawing.Point(-5, 12);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(1438, 111);
            this.navegador1.TabIndex = 0;
            // 
            // Ayuda
            // 
            this.Ayuda.Location = new System.Drawing.Point(863, 421);
            this.Ayuda.Name = "Ayuda";
            this.Ayuda.Size = new System.Drawing.Size(75, 23);
            this.Ayuda.TabIndex = 1;
            this.Ayuda.Text = "Ayuda";
            this.Ayuda.UseVisualStyleBackColor = true;
            // 
            // Reporte
            // 
            this.Reporte.Location = new System.Drawing.Point(973, 423);
            this.Reporte.Name = "Reporte";
            this.Reporte.Size = new System.Drawing.Size(75, 23);
            this.Reporte.TabIndex = 2;
            this.Reporte.Text = "Reporte";
            this.Reporte.UseVisualStyleBackColor = true;
            this.Reporte.Click += new System.EventHandler(this.Reporte_Click);
            // 
            // FrmMantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 487);
            this.Controls.Add(this.Reporte);
            this.Controls.Add(this.Ayuda);
            this.Controls.Add(this.navegador1);
            this.Name = "FrmMantenimiento";
            this.Text = "FrmMantenimiento";
            this.ResumeLayout(false);

        }

        #endregion

        private CapaVista_Navegador.Navegador navegador1;
        private System.Windows.Forms.Button Ayuda;
        private System.Windows.Forms.Button Reporte;
    }
}