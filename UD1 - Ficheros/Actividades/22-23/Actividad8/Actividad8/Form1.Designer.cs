namespace Actividad8
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreAlumno = new System.Windows.Forms.TextBox();
            this.txtApellidoAlumno = new System.Windows.Forms.TextBox();
            this.btnInsertarAlumno = new System.Windows.Forms.Button();
            this.lstAlumnos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(284, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(284, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellidos";
            // 
            // txtNombreAlumno
            // 
            this.txtNombreAlumno.Location = new System.Drawing.Point(409, 66);
            this.txtNombreAlumno.Name = "txtNombreAlumno";
            this.txtNombreAlumno.Size = new System.Drawing.Size(125, 27);
            this.txtNombreAlumno.TabIndex = 2;
            // 
            // txtApellidoAlumno
            // 
            this.txtApellidoAlumno.Location = new System.Drawing.Point(409, 124);
            this.txtApellidoAlumno.Name = "txtApellidoAlumno";
            this.txtApellidoAlumno.Size = new System.Drawing.Size(125, 27);
            this.txtApellidoAlumno.TabIndex = 3;
            // 
            // btnInsertarAlumno
            // 
            this.btnInsertarAlumno.Location = new System.Drawing.Point(621, 91);
            this.btnInsertarAlumno.Name = "btnInsertarAlumno";
            this.btnInsertarAlumno.Size = new System.Drawing.Size(135, 29);
            this.btnInsertarAlumno.TabIndex = 4;
            this.btnInsertarAlumno.Text = "Insertar alumno";
            this.btnInsertarAlumno.UseVisualStyleBackColor = true;
            this.btnInsertarAlumno.Click += new System.EventHandler(this.btnInsertarAlumno_Click);
            // 
            // lstAlumnos
            // 
            this.lstAlumnos.FormattingEnabled = true;
            this.lstAlumnos.ItemHeight = 20;
            this.lstAlumnos.Location = new System.Drawing.Point(328, 254);
            this.lstAlumnos.Name = "lstAlumnos";
            this.lstAlumnos.Size = new System.Drawing.Size(399, 324);
            this.lstAlumnos.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 613);
            this.Controls.Add(this.lstAlumnos);
            this.Controls.Add(this.btnInsertarAlumno);
            this.Controls.Add(this.txtApellidoAlumno);
            this.Controls.Add(this.txtNombreAlumno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtNombreAlumno;
        private TextBox txtApellidoAlumno;
        private Button btnInsertarAlumno;
        private ListBox lstAlumnos;
    }
}