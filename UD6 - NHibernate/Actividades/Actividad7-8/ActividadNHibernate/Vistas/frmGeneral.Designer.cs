
namespace ActividadNHibernate
{
    partial class frmGeneral
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
            this.btnInstituto = new System.Windows.Forms.Button();
            this.btnCarrera = new System.Windows.Forms.Button();
            this.btnAsignatura = new System.Windows.Forms.Button();
            this.btnEstudiante = new System.Windows.Forms.Button();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnInstituto
            // 
            this.btnInstituto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInstituto.Location = new System.Drawing.Point(28, 25);
            this.btnInstituto.Name = "btnInstituto";
            this.btnInstituto.Size = new System.Drawing.Size(192, 85);
            this.btnInstituto.TabIndex = 0;
            this.btnInstituto.Text = "Instituto";
            this.btnInstituto.UseVisualStyleBackColor = true;
            this.btnInstituto.Click += new System.EventHandler(this.btnInstituto_Click);
            // 
            // btnCarrera
            // 
            this.btnCarrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarrera.Location = new System.Drawing.Point(263, 25);
            this.btnCarrera.Name = "btnCarrera";
            this.btnCarrera.Size = new System.Drawing.Size(192, 85);
            this.btnCarrera.TabIndex = 1;
            this.btnCarrera.Text = "Carrera";
            this.btnCarrera.UseVisualStyleBackColor = true;
            this.btnCarrera.Click += new System.EventHandler(this.btnCarrera_Click);
            // 
            // btnAsignatura
            // 
            this.btnAsignatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignatura.Location = new System.Drawing.Point(514, 25);
            this.btnAsignatura.Name = "btnAsignatura";
            this.btnAsignatura.Size = new System.Drawing.Size(192, 85);
            this.btnAsignatura.TabIndex = 2;
            this.btnAsignatura.Text = "Asignatura";
            this.btnAsignatura.UseVisualStyleBackColor = true;
            // 
            // btnEstudiante
            // 
            this.btnEstudiante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstudiante.Location = new System.Drawing.Point(790, 25);
            this.btnEstudiante.Name = "btnEstudiante";
            this.btnEstudiante.Size = new System.Drawing.Size(192, 85);
            this.btnEstudiante.TabIndex = 3;
            this.btnEstudiante.Text = "Estudiante";
            this.btnEstudiante.UseVisualStyleBackColor = true;
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.Location = new System.Drawing.Point(28, 144);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(954, 385);
            this.pnlContenedor.TabIndex = 4;
            // 
            // frmGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 551);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.btnEstudiante);
            this.Controls.Add(this.btnAsignatura);
            this.Controls.Add(this.btnCarrera);
            this.Controls.Add(this.btnInstituto);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmGeneral";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInstituto;
        private System.Windows.Forms.Button btnCarrera;
        private System.Windows.Forms.Button btnAsignatura;
        private System.Windows.Forms.Button btnEstudiante;
        private System.Windows.Forms.Panel pnlContenedor;
    }
}

