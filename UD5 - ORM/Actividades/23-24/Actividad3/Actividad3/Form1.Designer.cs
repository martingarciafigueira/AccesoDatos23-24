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
            this.btnConectar = new System.Windows.Forms.Button();
            this.lstEquipos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(130, 266);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(154, 77);
            this.btnConectar.TabIndex = 0;
            this.btnConectar.Text = "Conecta";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // lstEquipos
            // 
            this.lstEquipos.FormattingEnabled = true;
            this.lstEquipos.ItemHeight = 16;
            this.lstEquipos.Location = new System.Drawing.Point(508, 119);
            this.lstEquipos.Name = "lstEquipos";
            this.lstEquipos.Size = new System.Drawing.Size(425, 420);
            this.lstEquipos.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 667);
            this.Controls.Add(this.lstEquipos);
            this.Controls.Add(this.btnConectar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.ListBox lstEquipos;
    }
}

