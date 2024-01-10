namespace Actividad2B
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
            this.lstLenguajes = new System.Windows.Forms.ListBox();
            this.btnCargarLenguajes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstLenguajes
            // 
            this.lstLenguajes.FormattingEnabled = true;
            this.lstLenguajes.ItemHeight = 20;
            this.lstLenguajes.Location = new System.Drawing.Point(412, 143);
            this.lstLenguajes.Name = "lstLenguajes";
            this.lstLenguajes.Size = new System.Drawing.Size(299, 324);
            this.lstLenguajes.TabIndex = 0;
            // 
            // btnCargarLenguajes
            // 
            this.btnCargarLenguajes.Location = new System.Drawing.Point(491, 491);
            this.btnCargarLenguajes.Name = "btnCargarLenguajes";
            this.btnCargarLenguajes.Size = new System.Drawing.Size(136, 46);
            this.btnCargarLenguajes.TabIndex = 1;
            this.btnCargarLenguajes.Text = "Cargar lenguajes";
            this.btnCargarLenguajes.UseVisualStyleBackColor = true;
            this.btnCargarLenguajes.Click += new System.EventHandler(this.btnCargarLenguajes_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 657);
            this.Controls.Add(this.btnCargarLenguajes);
            this.Controls.Add(this.lstLenguajes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox lstLenguajes;
        private Button btnCargarLenguajes;
    }
}