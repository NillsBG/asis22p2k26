namespace CapaVista_Seguridad
{
    partial class Antes
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
            this.imprimirantes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // navegador1
            // 
            this.navegador1.Location = new System.Drawing.Point(12, 23);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(1438, 111);
            this.navegador1.TabIndex = 0;
            // 
            // imprimirantes
            // 
            this.imprimirantes.Location = new System.Drawing.Point(860, 434);
            this.imprimirantes.Name = "imprimirantes";
            this.imprimirantes.Size = new System.Drawing.Size(75, 23);
            this.imprimirantes.TabIndex = 1;
            this.imprimirantes.Text = "Imprimir";
            this.imprimirantes.UseVisualStyleBackColor = true;
            this.imprimirantes.Click += new System.EventHandler(this.imprimirantes_Click);
            // 
            // Antes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 499);
            this.Controls.Add(this.imprimirantes);
            this.Controls.Add(this.navegador1);
            this.Name = "Antes";
            this.Text = "Antes";
            this.ResumeLayout(false);

        }

        #endregion

        private CapaVista_Navegador.Navegador navegador1;
        private System.Windows.Forms.Button imprimirantes;
    }
}