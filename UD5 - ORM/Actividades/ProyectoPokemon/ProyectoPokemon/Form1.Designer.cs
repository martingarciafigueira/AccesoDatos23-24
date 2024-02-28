namespace ProyectoPokemon
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
            this.btnMostrarPokemon = new System.Windows.Forms.Button();
            this.lstPokemon = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPesoMayor = new System.Windows.Forms.TextBox();
            this.txtPesoMenor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lstTiposPokemon = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPSMenor = new System.Windows.Forms.TextBox();
            this.txtPSMayor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMostrarPokemon
            // 
            this.btnMostrarPokemon.Location = new System.Drawing.Point(689, 300);
            this.btnMostrarPokemon.Name = "btnMostrarPokemon";
            this.btnMostrarPokemon.Size = new System.Drawing.Size(180, 59);
            this.btnMostrarPokemon.TabIndex = 0;
            this.btnMostrarPokemon.Text = "Mostrar todos los Pokemon";
            this.btnMostrarPokemon.UseVisualStyleBackColor = true;
            this.btnMostrarPokemon.Click += new System.EventHandler(this.btnMostrarPokemon_Click);
            // 
            // lstPokemon
            // 
            this.lstPokemon.FormattingEnabled = true;
            this.lstPokemon.ItemHeight = 16;
            this.lstPokemon.Location = new System.Drawing.Point(63, 160);
            this.lstPokemon.Name = "lstPokemon";
            this.lstPokemon.Size = new System.Drawing.Size(219, 372);
            this.lstPokemon.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(310, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Filtrar por peso:";
            // 
            // txtPesoMayor
            // 
            this.txtPesoMayor.Location = new System.Drawing.Point(470, 208);
            this.txtPesoMayor.Name = "txtPesoMayor";
            this.txtPesoMayor.Size = new System.Drawing.Size(62, 22);
            this.txtPesoMayor.TabIndex = 3;
            // 
            // txtPesoMenor
            // 
            this.txtPesoMenor.Location = new System.Drawing.Point(313, 208);
            this.txtPesoMenor.Name = "txtPesoMenor";
            this.txtPesoMenor.Size = new System.Drawing.Size(58, 22);
            this.txtPesoMenor.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(403, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "--";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(74, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "POKEMON GALICIA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(310, 427);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Filtrar por tipo:";
            // 
            // lstTiposPokemon
            // 
            this.lstTiposPokemon.FormattingEnabled = true;
            this.lstTiposPokemon.ItemHeight = 16;
            this.lstTiposPokemon.Location = new System.Drawing.Point(313, 446);
            this.lstTiposPokemon.Name = "lstTiposPokemon";
            this.lstTiposPokemon.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstTiposPokemon.Size = new System.Drawing.Size(219, 84);
            this.lstTiposPokemon.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(403, 331);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 25);
            this.label4.TabIndex = 20;
            this.label4.Text = "--";
            // 
            // txtPSMenor
            // 
            this.txtPSMenor.Location = new System.Drawing.Point(313, 335);
            this.txtPSMenor.Name = "txtPSMenor";
            this.txtPSMenor.Size = new System.Drawing.Size(58, 22);
            this.txtPSMenor.TabIndex = 19;
            // 
            // txtPSMayor
            // 
            this.txtPSMayor.Location = new System.Drawing.Point(470, 335);
            this.txtPSMayor.Name = "txtPSMayor";
            this.txtPSMayor.Size = new System.Drawing.Size(62, 22);
            this.txtPSMayor.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(310, 287);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "Filtrar por puntos de salud:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 716);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPSMenor);
            this.Controls.Add(this.txtPSMayor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lstTiposPokemon);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPesoMenor);
            this.Controls.Add(this.txtPesoMayor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstPokemon);
            this.Controls.Add(this.btnMostrarPokemon);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnMostrarPokemon;
		private System.Windows.Forms.ListBox lstPokemon;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtPesoMayor;
		private System.Windows.Forms.TextBox txtPesoMenor;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lstTiposPokemon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPSMenor;
        private System.Windows.Forms.TextBox txtPSMayor;
        private System.Windows.Forms.Label label6;
    }
}

