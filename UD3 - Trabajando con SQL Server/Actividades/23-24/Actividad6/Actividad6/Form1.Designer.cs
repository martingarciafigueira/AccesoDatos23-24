namespace Actividad6
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
            this.components = new System.ComponentModel.Container();
            this.lstFutbolistas = new System.Windows.Forms.ListBox();
            this.lstEquipos = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbFutbolistaEquipo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnInsertarFutbolista = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreFutbolista = new System.Windows.Forms.TextBox();
            this.txtCodigoFutbolista = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnInsertarEquipo = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNombreEquipo = new System.Windows.Forms.TextBox();
            this.txtCodigoEquipo = new System.Windows.Forms.TextBox();
            this.futbolDataSet = new Actividad6.FutbolDataSet();
            this.equiposBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.equiposTableAdapter = new Actividad6.FutbolDataSetTableAdapters.EquiposTableAdapter();
            this.btnBorrarFutbolista = new System.Windows.Forms.Button();
            this.btnBorrarEquipo = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.futbolDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equiposBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lstFutbolistas
            // 
            this.lstFutbolistas.FormattingEnabled = true;
            this.lstFutbolistas.ItemHeight = 16;
            this.lstFutbolistas.Location = new System.Drawing.Point(34, 35);
            this.lstFutbolistas.Name = "lstFutbolistas";
            this.lstFutbolistas.Size = new System.Drawing.Size(165, 356);
            this.lstFutbolistas.TabIndex = 1;
            // 
            // lstEquipos
            // 
            this.lstEquipos.FormattingEnabled = true;
            this.lstEquipos.ItemHeight = 16;
            this.lstEquipos.Location = new System.Drawing.Point(253, 35);
            this.lstEquipos.Name = "lstEquipos";
            this.lstEquipos.Size = new System.Drawing.Size(181, 356);
            this.lstEquipos.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbFutbolistaEquipo);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btnInsertarFutbolista);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtNombreFutbolista);
            this.panel1.Controls.Add(this.txtCodigoFutbolista);
            this.panel1.Location = new System.Drawing.Point(554, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(831, 191);
            this.panel1.TabIndex = 4;
            // 
            // cbFutbolistaEquipo
            // 
            this.cbFutbolistaEquipo.FormattingEnabled = true;
            this.cbFutbolistaEquipo.Location = new System.Drawing.Point(114, 142);
            this.cbFutbolistaEquipo.Name = "cbFutbolistaEquipo";
            this.cbFutbolistaEquipo.Size = new System.Drawing.Size(199, 24);
            this.cbFutbolistaEquipo.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Equipo";
            // 
            // btnInsertarFutbolista
            // 
            this.btnInsertarFutbolista.Location = new System.Drawing.Point(576, 95);
            this.btnInsertarFutbolista.Name = "btnInsertarFutbolista";
            this.btnInsertarFutbolista.Size = new System.Drawing.Size(195, 39);
            this.btnInsertarFutbolista.TabIndex = 5;
            this.btnInsertarFutbolista.Text = "INSERTAR";
            this.btnInsertarFutbolista.UseVisualStyleBackColor = true;
            this.btnInsertarFutbolista.Click += new System.EventHandler(this.btnInsertarFutbolista_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(288, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(241, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "INSERTAR FUTBOLISTA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Codigo";
            // 
            // txtNombreFutbolista
            // 
            this.txtNombreFutbolista.Location = new System.Drawing.Point(114, 103);
            this.txtNombreFutbolista.Name = "txtNombreFutbolista";
            this.txtNombreFutbolista.Size = new System.Drawing.Size(199, 22);
            this.txtNombreFutbolista.TabIndex = 1;
            // 
            // txtCodigoFutbolista
            // 
            this.txtCodigoFutbolista.Location = new System.Drawing.Point(114, 56);
            this.txtCodigoFutbolista.Name = "txtCodigoFutbolista";
            this.txtCodigoFutbolista.Size = new System.Drawing.Size(199, 22);
            this.txtCodigoFutbolista.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnInsertarEquipo);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtNombreEquipo);
            this.panel2.Controls.Add(this.txtCodigoEquipo);
            this.panel2.Location = new System.Drawing.Point(554, 250);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(831, 141);
            this.panel2.TabIndex = 5;
            // 
            // btnInsertarEquipo
            // 
            this.btnInsertarEquipo.Location = new System.Drawing.Point(576, 71);
            this.btnInsertarEquipo.Name = "btnInsertarEquipo";
            this.btnInsertarEquipo.Size = new System.Drawing.Size(195, 39);
            this.btnInsertarEquipo.TabIndex = 5;
            this.btnInsertarEquipo.Text = "INSERTAR";
            this.btnInsertarEquipo.UseVisualStyleBackColor = true;
            this.btnInsertarEquipo.Click += new System.EventHandler(this.btnInsertarEquipo_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(308, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "INSERTAR EQUIPO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Nombre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Codigo";
            // 
            // txtNombreEquipo
            // 
            this.txtNombreEquipo.Location = new System.Drawing.Point(114, 103);
            this.txtNombreEquipo.Name = "txtNombreEquipo";
            this.txtNombreEquipo.Size = new System.Drawing.Size(199, 22);
            this.txtNombreEquipo.TabIndex = 1;
            // 
            // txtCodigoEquipo
            // 
            this.txtCodigoEquipo.Location = new System.Drawing.Point(114, 56);
            this.txtCodigoEquipo.Name = "txtCodigoEquipo";
            this.txtCodigoEquipo.Size = new System.Drawing.Size(199, 22);
            this.txtCodigoEquipo.TabIndex = 0;
            // 
            // futbolDataSet
            // 
            this.futbolDataSet.DataSetName = "FutbolDataSet";
            this.futbolDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // equiposBindingSource
            // 
            this.equiposBindingSource.DataMember = "Equipos";
            this.equiposBindingSource.DataSource = this.futbolDataSet;
            // 
            // equiposTableAdapter
            // 
            this.equiposTableAdapter.ClearBeforeFill = true;
            // 
            // btnBorrarFutbolista
            // 
            this.btnBorrarFutbolista.Location = new System.Drawing.Point(62, 406);
            this.btnBorrarFutbolista.Name = "btnBorrarFutbolista";
            this.btnBorrarFutbolista.Size = new System.Drawing.Size(93, 37);
            this.btnBorrarFutbolista.TabIndex = 6;
            this.btnBorrarFutbolista.Text = "BORRAR";
            this.btnBorrarFutbolista.UseVisualStyleBackColor = true;
            this.btnBorrarFutbolista.Click += new System.EventHandler(this.btnBorrarFutbolista_Click);
            // 
            // btnBorrarEquipo
            // 
            this.btnBorrarEquipo.Location = new System.Drawing.Point(298, 406);
            this.btnBorrarEquipo.Name = "btnBorrarEquipo";
            this.btnBorrarEquipo.Size = new System.Drawing.Size(93, 37);
            this.btnBorrarEquipo.TabIndex = 7;
            this.btnBorrarEquipo.Text = "BORRAR";
            this.btnBorrarEquipo.UseVisualStyleBackColor = true;
            this.btnBorrarEquipo.Click += new System.EventHandler(this.btnBorrarEquipo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1441, 735);
            this.Controls.Add(this.btnBorrarEquipo);
            this.Controls.Add(this.btnBorrarFutbolista);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lstEquipos);
            this.Controls.Add(this.lstFutbolistas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.futbolDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equiposBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox lstFutbolistas;
        private System.Windows.Forms.ListBox lstEquipos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnInsertarFutbolista;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreFutbolista;
        private System.Windows.Forms.TextBox txtCodigoFutbolista;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnInsertarEquipo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNombreEquipo;
        private System.Windows.Forms.TextBox txtCodigoEquipo;
        private System.Windows.Forms.Label label7;
        private FutbolDataSet futbolDataSet;
        private System.Windows.Forms.BindingSource equiposBindingSource;
        private FutbolDataSetTableAdapters.EquiposTableAdapter equiposTableAdapter;
        private System.Windows.Forms.ComboBox cbFutbolistaEquipo;
        private System.Windows.Forms.Button btnBorrarFutbolista;
        private System.Windows.Forms.Button btnBorrarEquipo;
    }
}

