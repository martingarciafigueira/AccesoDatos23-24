namespace ActividadNHibernate.Vistas
{
    partial class ListFormCarrera
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
            this.label1 = new System.Windows.Forms.Label();
            this.tblCarreras = new System.Windows.Forms.DataGridView();
            this.btnNuevaCarrera = new System.Windows.Forms.Button();
            this.btnActualizarTabla = new System.Windows.Forms.Button();
            this.btnVerTodasCarreras = new System.Windows.Forms.Button();
            this.cbInstitutos = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.tblCarreras)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista de carreras";
            // 
            // tblCarreras
            // 
            this.tblCarreras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblCarreras.Location = new System.Drawing.Point(28, 143);
            this.tblCarreras.Name = "tblCarreras";
            this.tblCarreras.Size = new System.Drawing.Size(917, 337);
            this.tblCarreras.TabIndex = 1;
            this.tblCarreras.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblInstitutos_CellContentClick);
            // 
            // btnNuevaCarrera
            // 
            this.btnNuevaCarrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaCarrera.Location = new System.Drawing.Point(635, 33);
            this.btnNuevaCarrera.Name = "btnNuevaCarrera";
            this.btnNuevaCarrera.Size = new System.Drawing.Size(153, 29);
            this.btnNuevaCarrera.TabIndex = 2;
            this.btnNuevaCarrera.Text = "Nueva carrera";
            this.btnNuevaCarrera.UseVisualStyleBackColor = true;
            this.btnNuevaCarrera.Click += new System.EventHandler(this.btnNuevoInstituto_Click);
            // 
            // btnActualizarTabla
            // 
            this.btnActualizarTabla.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarTabla.Location = new System.Drawing.Point(792, 33);
            this.btnActualizarTabla.Name = "btnActualizarTabla";
            this.btnActualizarTabla.Size = new System.Drawing.Size(153, 29);
            this.btnActualizarTabla.TabIndex = 3;
            this.btnActualizarTabla.Text = "Actualizar tabla";
            this.btnActualizarTabla.UseVisualStyleBackColor = true;
            this.btnActualizarTabla.Click += new System.EventHandler(this.btnActualizarTabla_Click);
            // 
            // btnVerTodasCarreras
            // 
            this.btnVerTodasCarreras.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerTodasCarreras.Location = new System.Drawing.Point(28, 89);
            this.btnVerTodasCarreras.Name = "btnVerTodasCarreras";
            this.btnVerTodasCarreras.Size = new System.Drawing.Size(153, 29);
            this.btnVerTodasCarreras.TabIndex = 4;
            this.btnVerTodasCarreras.Text = "Ver todas";
            this.btnVerTodasCarreras.UseVisualStyleBackColor = true;
            this.btnVerTodasCarreras.Click += new System.EventHandler(this.btnVerTodasCarreras_Click);
            // 
            // cbInstitutos
            // 
            this.cbInstitutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbInstitutos.FormattingEnabled = true;
            this.cbInstitutos.Location = new System.Drawing.Point(229, 89);
            this.cbInstitutos.Name = "cbInstitutos";
            this.cbInstitutos.Size = new System.Drawing.Size(190, 28);
            this.cbInstitutos.TabIndex = 5;
            this.cbInstitutos.Text = "Seleccionar instituto";
            this.cbInstitutos.SelectedIndexChanged += new System.EventHandler(this.cbInstitutos_SelectedIndexChanged);
            // 
            // ListFormCarrera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 492);
            this.Controls.Add(this.cbInstitutos);
            this.Controls.Add(this.btnVerTodasCarreras);
            this.Controls.Add(this.btnActualizarTabla);
            this.Controls.Add(this.btnNuevaCarrera);
            this.Controls.Add(this.tblCarreras);
            this.Controls.Add(this.label1);
            this.Name = "ListFormCarrera";
            this.Text = "ListFormInstituto";
            ((System.ComponentModel.ISupportInitialize)(this.tblCarreras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView tblCarreras;
        private System.Windows.Forms.Button btnNuevaCarrera;
        private System.Windows.Forms.Button btnActualizarTabla;
        private System.Windows.Forms.Button btnVerTodasCarreras;
        private System.Windows.Forms.ComboBox cbInstitutos;
    }
}