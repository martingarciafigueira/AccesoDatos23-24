namespace Actividad6
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCargarFichero = new System.Windows.Forms.Button();
            this.btnRefrescarFichero = new System.Windows.Forms.Button();
            this.lstFichero = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnCargarFichero
            // 
            this.btnCargarFichero.Location = new System.Drawing.Point(377, 567);
            this.btnCargarFichero.Name = "btnCargarFichero";
            this.btnCargarFichero.Size = new System.Drawing.Size(112, 42);
            this.btnCargarFichero.TabIndex = 0;
            this.btnCargarFichero.Text = "Cargar fichero";
            this.btnCargarFichero.UseVisualStyleBackColor = true;
            this.btnCargarFichero.Click += new System.EventHandler(this.btnCargarFichero_Click);
            // 
            // btnRefrescarFichero
            // 
            this.btnRefrescarFichero.Location = new System.Drawing.Point(626, 563);
            this.btnRefrescarFichero.Name = "btnRefrescarFichero";
            this.btnRefrescarFichero.Size = new System.Drawing.Size(108, 50);
            this.btnRefrescarFichero.TabIndex = 1;
            this.btnRefrescarFichero.Text = "Refrescar fichero";
            this.btnRefrescarFichero.UseVisualStyleBackColor = true;
            this.btnRefrescarFichero.Click += new System.EventHandler(this.btnRefrescarFichero_Click);
            // 
            // lstFichero
            // 
            this.lstFichero.FormattingEnabled = true;
            this.lstFichero.ItemHeight = 20;
            this.lstFichero.Location = new System.Drawing.Point(351, 118);
            this.lstFichero.Name = "lstFichero";
            this.lstFichero.Size = new System.Drawing.Size(443, 404);
            this.lstFichero.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 700);
            this.Controls.Add(this.lstFichero);
            this.Controls.Add(this.btnRefrescarFichero);
            this.Controls.Add(this.btnCargarFichero);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnCargarFichero;
        private Button btnRefrescarFichero;
        private ListBox lstFichero;
    }
}