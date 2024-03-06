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
            this.lstFutbolistas = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.btnInsertarEquipo = new System.Windows.Forms.Button();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEstadio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.btnInsertarFutbolista = new System.Windows.Forms.Button();
            this.txtDorsalFutbolista = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEdadFutbolista = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPosicionFutbolista = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNombreFutbolista = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCodigoFutbolista = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbEquipoSeleccionado = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(39, 489);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(154, 77);
            this.btnConectar.TabIndex = 0;
            this.btnConectar.Text = "Cargar lista equipos";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // lstEquipos
            // 
            this.lstEquipos.FormattingEnabled = true;
            this.lstEquipos.ItemHeight = 16;
            this.lstEquipos.Location = new System.Drawing.Point(21, 63);
            this.lstEquipos.Name = "lstEquipos";
            this.lstEquipos.Size = new System.Drawing.Size(214, 404);
            this.lstEquipos.TabIndex = 1;
            this.lstEquipos.DoubleClick += new System.EventHandler(this.lstEquipos_DoubleClick);
            // 
            // lstFutbolistas
            // 
            this.lstFutbolistas.FormattingEnabled = true;
            this.lstFutbolistas.ItemHeight = 16;
            this.lstFutbolistas.Location = new System.Drawing.Point(270, 63);
            this.lstFutbolistas.Name = "lstFutbolistas";
            this.lstFutbolistas.Size = new System.Drawing.Size(204, 404);
            this.lstFutbolistas.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnInsertarEquipo);
            this.panel1.Controls.Add(this.txtCiudad);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtEstadio);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtPais);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtCodigo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(516, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(412, 429);
            this.panel1.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(75, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(250, 38);
            this.label6.TabIndex = 4;
            this.label6.Text = "Insertar equipos";
            // 
            // btnInsertarEquipo
            // 
            this.btnInsertarEquipo.Location = new System.Drawing.Point(233, 198);
            this.btnInsertarEquipo.Name = "btnInsertarEquipo";
            this.btnInsertarEquipo.Size = new System.Drawing.Size(154, 77);
            this.btnInsertarEquipo.TabIndex = 4;
            this.btnInsertarEquipo.Text = "Insertar equipo";
            this.btnInsertarEquipo.UseVisualStyleBackColor = true;
            this.btnInsertarEquipo.Click += new System.EventHandler(this.btnInsertarEquipo_Click);
            // 
            // txtCiudad
            // 
            this.txtCiudad.Location = new System.Drawing.Point(92, 379);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(100, 22);
            this.txtCiudad.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 379);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ciudad";
            // 
            // txtEstadio
            // 
            this.txtEstadio.Location = new System.Drawing.Point(92, 302);
            this.txtEstadio.Name = "txtEstadio";
            this.txtEstadio.Size = new System.Drawing.Size(100, 22);
            this.txtEstadio.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Estadio";
            // 
            // txtPais
            // 
            this.txtPais.Location = new System.Drawing.Point(92, 225);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(100, 22);
            this.txtPais.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Pais";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(92, 149);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 22);
            this.txtNombre.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(92, 84);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 22);
            this.txtCodigo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.cbEquipoSeleccionado);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.btnInsertarFutbolista);
            this.panel2.Controls.Add(this.txtDorsalFutbolista);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txtEdadFutbolista);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txtPosicionFutbolista);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txtNombreFutbolista);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.txtCodigoFutbolista);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Location = new System.Drawing.Point(978, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(412, 429);
            this.panel2.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(75, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(266, 38);
            this.label7.TabIndex = 4;
            this.label7.Text = "Insertar futbolista";
            // 
            // btnInsertarFutbolista
            // 
            this.btnInsertarFutbolista.Location = new System.Drawing.Point(232, 170);
            this.btnInsertarFutbolista.Name = "btnInsertarFutbolista";
            this.btnInsertarFutbolista.Size = new System.Drawing.Size(154, 77);
            this.btnInsertarFutbolista.TabIndex = 4;
            this.btnInsertarFutbolista.Text = "Insertar futbolista";
            this.btnInsertarFutbolista.UseVisualStyleBackColor = true;
            this.btnInsertarFutbolista.Click += new System.EventHandler(this.btnInsertarFutbolista_Click);
            // 
            // txtDorsalFutbolista
            // 
            this.txtDorsalFutbolista.Location = new System.Drawing.Point(92, 379);
            this.txtDorsalFutbolista.Name = "txtDorsalFutbolista";
            this.txtDorsalFutbolista.Size = new System.Drawing.Size(100, 22);
            this.txtDorsalFutbolista.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(11, 379);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 25);
            this.label8.TabIndex = 8;
            this.label8.Text = "Dorsal";
            // 
            // txtEdadFutbolista
            // 
            this.txtEdadFutbolista.Location = new System.Drawing.Point(92, 302);
            this.txtEdadFutbolista.Name = "txtEdadFutbolista";
            this.txtEdadFutbolista.Size = new System.Drawing.Size(100, 22);
            this.txtEdadFutbolista.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(11, 302);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 25);
            this.label9.TabIndex = 6;
            this.label9.Text = "Edad";
            // 
            // txtPosicionFutbolista
            // 
            this.txtPosicionFutbolista.Location = new System.Drawing.Point(92, 225);
            this.txtPosicionFutbolista.Name = "txtPosicionFutbolista";
            this.txtPosicionFutbolista.Size = new System.Drawing.Size(100, 22);
            this.txtPosicionFutbolista.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(11, 221);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 25);
            this.label10.TabIndex = 4;
            this.label10.Text = "Posición";
            // 
            // txtNombreFutbolista
            // 
            this.txtNombreFutbolista.Location = new System.Drawing.Point(92, 149);
            this.txtNombreFutbolista.Name = "txtNombreFutbolista";
            this.txtNombreFutbolista.Size = new System.Drawing.Size(100, 22);
            this.txtNombreFutbolista.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(11, 145);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 25);
            this.label11.TabIndex = 2;
            this.label11.Text = "Nombre";
            // 
            // txtCodigoFutbolista
            // 
            this.txtCodigoFutbolista.Location = new System.Drawing.Point(92, 84);
            this.txtCodigoFutbolista.Name = "txtCodigoFutbolista";
            this.txtCodigoFutbolista.Size = new System.Drawing.Size(100, 22);
            this.txtCodigoFutbolista.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(11, 80);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 25);
            this.label12.TabIndex = 0;
            this.label12.Text = "Codigo";
            // 
            // cbEquipoSeleccionado
            // 
            this.cbEquipoSeleccionado.FormattingEnabled = true;
            this.cbEquipoSeleccionado.Location = new System.Drawing.Point(244, 377);
            this.cbEquipoSeleccionado.Name = "cbEquipoSeleccionado";
            this.cbEquipoSeleccionado.Size = new System.Drawing.Size(121, 24);
            this.cbEquipoSeleccionado.TabIndex = 10;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(262, 338);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 25);
            this.label13.TabIndex = 11;
            this.label13.Text = "Equipo:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1567, 710);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lstFutbolistas);
            this.Controls.Add(this.lstEquipos);
            this.Controls.Add(this.btnConectar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.ListBox lstEquipos;
        private System.Windows.Forms.ListBox lstFutbolistas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnInsertarEquipo;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEstadio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnInsertarFutbolista;
        private System.Windows.Forms.TextBox txtDorsalFutbolista;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEdadFutbolista;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPosicionFutbolista;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNombreFutbolista;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCodigoFutbolista;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbEquipoSeleccionado;
    }
}

