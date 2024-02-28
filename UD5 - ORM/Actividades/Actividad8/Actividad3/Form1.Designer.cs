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
			this.btnCargarEquipos = new System.Windows.Forms.Button();
			this.lstEquipos = new System.Windows.Forms.ListBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.txtPais = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtCodigo = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnInsertarEquipo = new System.Windows.Forms.Button();
			this.panel3 = new System.Windows.Forms.Panel();
			this.txtPosicion = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtNombreFutbolista = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtCodigoFutbolista = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.btnInsertarFutbolista = new System.Windows.Forms.Button();
			this.label10 = new System.Windows.Forms.Label();
			this.btnCargarFutbolista = new System.Windows.Forms.Button();
			this.lstFutbolistas = new System.Windows.Forms.ListBox();
			this.btnCargarFutbolistas = new System.Windows.Forms.Button();
			this.btnModificarFutbolista = new System.Windows.Forms.Button();
			this.btnModificarEquipo = new System.Windows.Forms.Button();
			this.btnCargarEquipo = new System.Windows.Forms.Button();
			this.label11 = new System.Windows.Forms.Label();
			this.btnBorrarFutbolista = new System.Windows.Forms.Button();
			this.btnBorrarEquipo = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnCargarEquipos
			// 
			this.btnCargarEquipos.Location = new System.Drawing.Point(13, 431);
			this.btnCargarEquipos.Name = "btnCargarEquipos";
			this.btnCargarEquipos.Size = new System.Drawing.Size(133, 73);
			this.btnCargarEquipos.TabIndex = 0;
			this.btnCargarEquipos.Text = "Cargar equipos";
			this.btnCargarEquipos.UseVisualStyleBackColor = true;
			this.btnCargarEquipos.Click += new System.EventHandler(this.btnCargarEquipos_Click);
			// 
			// lstEquipos
			// 
			this.lstEquipos.FormattingEnabled = true;
			this.lstEquipos.ItemHeight = 16;
			this.lstEquipos.Location = new System.Drawing.Point(12, 73);
			this.lstEquipos.Name = "lstEquipos";
			this.lstEquipos.Size = new System.Drawing.Size(134, 340);
			this.lstEquipos.TabIndex = 1;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnBorrarFutbolista);
			this.panel1.Controls.Add(this.btnBorrarEquipo);
			this.panel1.Controls.Add(this.lstFutbolistas);
			this.panel1.Controls.Add(this.btnCargarFutbolistas);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.lstEquipos);
			this.panel1.Controls.Add(this.btnCargarEquipos);
			this.panel1.Location = new System.Drawing.Point(33, 51);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(334, 635);
			this.panel1.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(52, 14);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(207, 32);
			this.label1.TabIndex = 3;
			this.label1.Text = "VER EQUIPOS";
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.btnModificarEquipo);
			this.panel2.Controls.Add(this.btnCargarEquipo);
			this.panel2.Controls.Add(this.label11);
			this.panel2.Controls.Add(this.txtPais);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.txtNombre);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.txtCodigo);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.btnInsertarEquipo);
			this.panel2.Location = new System.Drawing.Point(451, 51);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(334, 635);
			this.panel2.TabIndex = 3;
			// 
			// txtPais
			// 
			this.txtPais.Location = new System.Drawing.Point(146, 170);
			this.txtPais.Name = "txtPais";
			this.txtPais.Size = new System.Drawing.Size(100, 22);
			this.txtPais.TabIndex = 9;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(53, 173);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(34, 16);
			this.label5.TabIndex = 8;
			this.label5.Text = "País";
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(146, 122);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(100, 22);
			this.txtNombre.TabIndex = 7;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(53, 125);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(56, 16);
			this.label4.TabIndex = 6;
			this.label4.Text = "Nombre";
			// 
			// txtCodigo
			// 
			this.txtCodigo.Location = new System.Drawing.Point(146, 70);
			this.txtCodigo.Name = "txtCodigo";
			this.txtCodigo.Size = new System.Drawing.Size(100, 22);
			this.txtCodigo.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(53, 73);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(51, 16);
			this.label3.TabIndex = 4;
			this.label3.Text = "Codigo";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(17, 14);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(290, 32);
			this.label2.TabIndex = 3;
			this.label2.Text = "INSERTAR EQUIPOS";
			// 
			// btnInsertarEquipo
			// 
			this.btnInsertarEquipo.Location = new System.Drawing.Point(105, 224);
			this.btnInsertarEquipo.Name = "btnInsertarEquipo";
			this.btnInsertarEquipo.Size = new System.Drawing.Size(111, 58);
			this.btnInsertarEquipo.TabIndex = 0;
			this.btnInsertarEquipo.Text = "Insertar equipo";
			this.btnInsertarEquipo.UseVisualStyleBackColor = true;
			this.btnInsertarEquipo.Click += new System.EventHandler(this.btnInsertarEquipo_Click);
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.btnModificarFutbolista);
			this.panel3.Controls.Add(this.btnCargarFutbolista);
			this.panel3.Controls.Add(this.label10);
			this.panel3.Controls.Add(this.txtPosicion);
			this.panel3.Controls.Add(this.label6);
			this.panel3.Controls.Add(this.txtNombreFutbolista);
			this.panel3.Controls.Add(this.label7);
			this.panel3.Controls.Add(this.txtCodigoFutbolista);
			this.panel3.Controls.Add(this.label8);
			this.panel3.Controls.Add(this.label9);
			this.panel3.Controls.Add(this.btnInsertarFutbolista);
			this.panel3.Location = new System.Drawing.Point(889, 51);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(410, 635);
			this.panel3.TabIndex = 4;
			// 
			// txtPosicion
			// 
			this.txtPosicion.Location = new System.Drawing.Point(191, 167);
			this.txtPosicion.Name = "txtPosicion";
			this.txtPosicion.Size = new System.Drawing.Size(100, 22);
			this.txtPosicion.TabIndex = 9;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(98, 170);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(59, 16);
			this.label6.TabIndex = 8;
			this.label6.Text = "Posicion";
			// 
			// txtNombreFutbolista
			// 
			this.txtNombreFutbolista.Location = new System.Drawing.Point(191, 119);
			this.txtNombreFutbolista.Name = "txtNombreFutbolista";
			this.txtNombreFutbolista.Size = new System.Drawing.Size(100, 22);
			this.txtNombreFutbolista.TabIndex = 7;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(98, 122);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(56, 16);
			this.label7.TabIndex = 6;
			this.label7.Text = "Nombre";
			// 
			// txtCodigoFutbolista
			// 
			this.txtCodigoFutbolista.Location = new System.Drawing.Point(191, 67);
			this.txtCodigoFutbolista.Name = "txtCodigoFutbolista";
			this.txtCodigoFutbolista.Size = new System.Drawing.Size(100, 22);
			this.txtCodigoFutbolista.TabIndex = 5;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(98, 70);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(51, 16);
			this.label8.TabIndex = 4;
			this.label8.Text = "Codigo";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(17, 14);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(354, 32);
			this.label9.TabIndex = 3;
			this.label9.Text = "INSERTAR FUTBOLISTAS";
			// 
			// btnInsertarFutbolista
			// 
			this.btnInsertarFutbolista.Location = new System.Drawing.Point(152, 226);
			this.btnInsertarFutbolista.Name = "btnInsertarFutbolista";
			this.btnInsertarFutbolista.Size = new System.Drawing.Size(95, 56);
			this.btnInsertarFutbolista.TabIndex = 0;
			this.btnInsertarFutbolista.Text = "Insertar futbolista";
			this.btnInsertarFutbolista.UseVisualStyleBackColor = true;
			this.btnInsertarFutbolista.Click += new System.EventHandler(this.btnInsertarFutbolista_Click);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(23, 371);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(387, 32);
			this.label10.TabIndex = 10;
			this.label10.Text = "ACTUALIZAR FUTBOLISTAS";
			// 
			// btnCargarFutbolista
			// 
			this.btnCargarFutbolista.Location = new System.Drawing.Point(61, 418);
			this.btnCargarFutbolista.Name = "btnCargarFutbolista";
			this.btnCargarFutbolista.Size = new System.Drawing.Size(95, 60);
			this.btnCargarFutbolista.TabIndex = 11;
			this.btnCargarFutbolista.Text = "Cargar futbolista";
			this.btnCargarFutbolista.UseVisualStyleBackColor = true;
			this.btnCargarFutbolista.Click += new System.EventHandler(this.button1_Click);
			// 
			// lstFutbolistas
			// 
			this.lstFutbolistas.FormattingEnabled = true;
			this.lstFutbolistas.ItemHeight = 16;
			this.lstFutbolistas.Location = new System.Drawing.Point(178, 73);
			this.lstFutbolistas.Name = "lstFutbolistas";
			this.lstFutbolistas.Size = new System.Drawing.Size(134, 340);
			this.lstFutbolistas.TabIndex = 5;
			// 
			// btnCargarFutbolistas
			// 
			this.btnCargarFutbolistas.Location = new System.Drawing.Point(179, 431);
			this.btnCargarFutbolistas.Name = "btnCargarFutbolistas";
			this.btnCargarFutbolistas.Size = new System.Drawing.Size(133, 73);
			this.btnCargarFutbolistas.TabIndex = 4;
			this.btnCargarFutbolistas.Text = "Cargar futbolistas";
			this.btnCargarFutbolistas.UseVisualStyleBackColor = true;
			this.btnCargarFutbolistas.Click += new System.EventHandler(this.btnCargarFutbolistas_Click);
			// 
			// btnModificarFutbolista
			// 
			this.btnModificarFutbolista.Location = new System.Drawing.Point(254, 418);
			this.btnModificarFutbolista.Name = "btnModificarFutbolista";
			this.btnModificarFutbolista.Size = new System.Drawing.Size(95, 56);
			this.btnModificarFutbolista.TabIndex = 12;
			this.btnModificarFutbolista.Text = "Modificar futbolista";
			this.btnModificarFutbolista.UseVisualStyleBackColor = true;
			this.btnModificarFutbolista.Click += new System.EventHandler(this.btnModificarFutbolista_Click);
			// 
			// btnModificarEquipo
			// 
			this.btnModificarEquipo.Location = new System.Drawing.Point(195, 428);
			this.btnModificarEquipo.Name = "btnModificarEquipo";
			this.btnModificarEquipo.Size = new System.Drawing.Size(95, 56);
			this.btnModificarEquipo.TabIndex = 15;
			this.btnModificarEquipo.Text = "Modificar equipo";
			this.btnModificarEquipo.UseVisualStyleBackColor = true;
			this.btnModificarEquipo.Click += new System.EventHandler(this.btnModificarEquipo_Click);
			// 
			// btnCargarEquipo
			// 
			this.btnCargarEquipo.Location = new System.Drawing.Point(32, 428);
			this.btnCargarEquipo.Name = "btnCargarEquipo";
			this.btnCargarEquipo.Size = new System.Drawing.Size(95, 60);
			this.btnCargarEquipo.TabIndex = 14;
			this.btnCargarEquipo.Text = "Cargar equipo";
			this.btnCargarEquipo.UseVisualStyleBackColor = true;
			this.btnCargarEquipo.Click += new System.EventHandler(this.btnCargarEquipo_Click);
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(8, 381);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(323, 32);
			this.label11.TabIndex = 13;
			this.label11.Text = "ACTUALIZAR EQUIPOS";
			// 
			// btnBorrarFutbolista
			// 
			this.btnBorrarFutbolista.Location = new System.Drawing.Point(179, 529);
			this.btnBorrarFutbolista.Name = "btnBorrarFutbolista";
			this.btnBorrarFutbolista.Size = new System.Drawing.Size(133, 73);
			this.btnBorrarFutbolista.TabIndex = 7;
			this.btnBorrarFutbolista.Text = "Borrar futbolista seleccionado";
			this.btnBorrarFutbolista.UseVisualStyleBackColor = true;
			this.btnBorrarFutbolista.Click += new System.EventHandler(this.btnBorrarFutbolista_Click);
			// 
			// btnBorrarEquipo
			// 
			this.btnBorrarEquipo.Location = new System.Drawing.Point(13, 529);
			this.btnBorrarEquipo.Name = "btnBorrarEquipo";
			this.btnBorrarEquipo.Size = new System.Drawing.Size(133, 73);
			this.btnBorrarEquipo.TabIndex = 6;
			this.btnBorrarEquipo.Text = "Borrar equipo seleccionado";
			this.btnBorrarEquipo.UseVisualStyleBackColor = true;
			this.btnBorrarEquipo.Click += new System.EventHandler(this.btnBorrarEquipo_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1351, 726);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCargarEquipos;
        private System.Windows.Forms.ListBox lstEquipos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnInsertarEquipo;
        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtPosicion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNombreFutbolista;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCodigoFutbolista;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnInsertarFutbolista;
		private System.Windows.Forms.Button btnCargarFutbolista;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.ListBox lstFutbolistas;
		private System.Windows.Forms.Button btnCargarFutbolistas;
		private System.Windows.Forms.Button btnModificarFutbolista;
		private System.Windows.Forms.Button btnModificarEquipo;
		private System.Windows.Forms.Button btnCargarEquipo;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Button btnBorrarFutbolista;
		private System.Windows.Forms.Button btnBorrarEquipo;
	}
}

