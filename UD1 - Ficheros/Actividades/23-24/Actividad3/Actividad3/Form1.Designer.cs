namespace Actividad3
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstFichero = new System.Windows.Forms.ListBox();
            this.btnLeerFichero = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstFichero
            // 
            this.lstFichero.FormattingEnabled = true;
            this.lstFichero.ItemHeight = 16;
            this.lstFichero.Location = new System.Drawing.Point(269, 129);
            this.lstFichero.Name = "lstFichero";
            this.lstFichero.Size = new System.Drawing.Size(190, 276);
            this.lstFichero.TabIndex = 0;
            // 
            // btnLeerFichero
            // 
            this.btnLeerFichero.Location = new System.Drawing.Point(646, 248);
            this.btnLeerFichero.Name = "btnLeerFichero";
            this.btnLeerFichero.Size = new System.Drawing.Size(186, 82);
            this.btnLeerFichero.TabIndex = 1;
            this.btnLeerFichero.Text = "Leer fichero";
            this.btnLeerFichero.UseVisualStyleBackColor = true;
            this.btnLeerFichero.Click += new System.EventHandler(this.btnLeerFichero_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 621);
            this.Controls.Add(this.btnLeerFichero);
            this.Controls.Add(this.lstFichero);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstFichero;
        private System.Windows.Forms.Button btnLeerFichero;
    }
}

