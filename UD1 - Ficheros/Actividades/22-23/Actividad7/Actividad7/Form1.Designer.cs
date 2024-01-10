namespace Actividad7
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
            this.txtFrase = new System.Windows.Forms.TextBox();
            this.btnInsertarFrase = new System.Windows.Forms.Button();
            this.lstFichero = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtFrase
            // 
            this.txtFrase.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFrase.Location = new System.Drawing.Point(225, 436);
            this.txtFrase.Name = "txtFrase";
            this.txtFrase.Size = new System.Drawing.Size(656, 38);
            this.txtFrase.TabIndex = 0;
            // 
            // btnInsertarFrase
            // 
            this.btnInsertarFrase.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnInsertarFrase.Location = new System.Drawing.Point(439, 507);
            this.btnInsertarFrase.Name = "btnInsertarFrase";
            this.btnInsertarFrase.Size = new System.Drawing.Size(237, 47);
            this.btnInsertarFrase.TabIndex = 1;
            this.btnInsertarFrase.Text = "Inserte frase:";
            this.btnInsertarFrase.UseVisualStyleBackColor = true;
            this.btnInsertarFrase.Click += new System.EventHandler(this.btnInsertarFrase_Click);
            // 
            // lstFichero
            // 
            this.lstFichero.FormattingEnabled = true;
            this.lstFichero.ItemHeight = 20;
            this.lstFichero.Location = new System.Drawing.Point(336, 38);
            this.lstFichero.Name = "lstFichero";
            this.lstFichero.Size = new System.Drawing.Size(406, 364);
            this.lstFichero.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 617);
            this.Controls.Add(this.lstFichero);
            this.Controls.Add(this.btnInsertarFrase);
            this.Controls.Add(this.txtFrase);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtFrase;
        private Button btnInsertarFrase;
        private ListBox lstFichero;
    }
}