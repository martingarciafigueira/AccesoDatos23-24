namespace Actviidad1
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
            panel1 = new Panel();
            cbFabricantes = new ComboBox();
            label7 = new Label();
            label8 = new Label();
            txtPrecioProducto = new TextBox();
            btnNuevoProducto = new Button();
            label5 = new Label();
            label6 = new Label();
            txtNombreProducto = new TextBox();
            txtCodigoProducto = new TextBox();
            btnNuevoFabricante = new Button();
            label4 = new Label();
            label3 = new Label();
            txtNombreFabricante = new TextBox();
            txtCodigoFabricante = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            lstProductos = new ListBox();
            lstFabricantes = new ListBox();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(cbFabricantes);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(txtPrecioProducto);
            panel1.Controls.Add(btnNuevoProducto);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtNombreProducto);
            panel1.Controls.Add(txtCodigoProducto);
            panel1.Controls.Add(btnNuevoFabricante);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtNombreFabricante);
            panel1.Controls.Add(txtCodigoFabricante);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(41, 38);
            panel1.Name = "panel1";
            panel1.Size = new Size(498, 561);
            panel1.TabIndex = 0;
            // 
            // cbFabricantes
            // 
            cbFabricantes.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFabricantes.FormattingEnabled = true;
            cbFabricantes.Location = new Point(187, 463);
            cbFabricantes.Name = "cbFabricantes";
            cbFabricantes.Size = new Size(125, 28);
            cbFabricantes.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(33, 463);
            label7.Name = "label7";
            label7.Size = new Size(77, 20);
            label7.TabIndex = 14;
            label7.Text = "Fabricante";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(33, 418);
            label8.Name = "label8";
            label8.Size = new Size(50, 20);
            label8.TabIndex = 13;
            label8.Text = "Precio";
            // 
            // txtPrecioProducto
            // 
            txtPrecioProducto.Location = new Point(187, 415);
            txtPrecioProducto.Name = "txtPrecioProducto";
            txtPrecioProducto.Size = new Size(125, 27);
            txtPrecioProducto.TabIndex = 11;
            // 
            // btnNuevoProducto
            // 
            btnNuevoProducto.Location = new Point(351, 373);
            btnNuevoProducto.Name = "btnNuevoProducto";
            btnNuevoProducto.Size = new Size(115, 65);
            btnNuevoProducto.TabIndex = 10;
            btnNuevoProducto.Text = "Añadir nuevo producto";
            btnNuevoProducto.UseVisualStyleBackColor = true;
            btnNuevoProducto.Click += btnNuevoProducto_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(33, 367);
            label5.Name = "label5";
            label5.Size = new Size(129, 20);
            label5.TabIndex = 9;
            label5.Text = "Nombre producto";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(33, 322);
            label6.Name = "label6";
            label6.Size = new Size(58, 20);
            label6.TabIndex = 8;
            label6.Text = "Codigo";
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.Location = new Point(187, 364);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(125, 27);
            txtNombreProducto.TabIndex = 7;
            // 
            // txtCodigoProducto
            // 
            txtCodigoProducto.Location = new Point(187, 319);
            txtCodigoProducto.Name = "txtCodigoProducto";
            txtCodigoProducto.Size = new Size(125, 27);
            txtCodigoProducto.TabIndex = 6;
            // 
            // btnNuevoFabricante
            // 
            btnNuevoFabricante.Location = new Point(351, 134);
            btnNuevoFabricante.Name = "btnNuevoFabricante";
            btnNuevoFabricante.Size = new Size(115, 65);
            btnNuevoFabricante.TabIndex = 5;
            btnNuevoFabricante.Text = "Añadir nuevo fabricante";
            btnNuevoFabricante.UseVisualStyleBackColor = true;
            btnNuevoFabricante.Click += btnNuevoFabricante_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 179);
            label4.Name = "label4";
            label4.Size = new Size(135, 20);
            label4.TabIndex = 4;
            label4.Text = "Nombre fabricante";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 134);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 3;
            label3.Text = "Codigo";
            // 
            // txtNombreFabricante
            // 
            txtNombreFabricante.Location = new Point(187, 176);
            txtNombreFabricante.Name = "txtNombreFabricante";
            txtNombreFabricante.Size = new Size(125, 27);
            txtNombreFabricante.TabIndex = 2;
            // 
            // txtCodigoFabricante
            // 
            txtCodigoFabricante.Location = new Point(187, 131);
            txtCodigoFabricante.Name = "txtCodigoFabricante";
            txtCodigoFabricante.Size = new Size(125, 27);
            txtCodigoFabricante.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS Gothic", 15F);
            label1.Location = new Point(64, 25);
            label1.Name = "label1";
            label1.Size = new Size(324, 25);
            label1.TabIndex = 0;
            label1.Text = "ZONA INSERTAR NUEVA INFO";
            // 
            // panel2
            // 
            panel2.Controls.Add(lstProductos);
            panel2.Controls.Add(lstFabricantes);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(670, 38);
            panel2.Name = "panel2";
            panel2.Size = new Size(498, 561);
            panel2.TabIndex = 1;
            // 
            // lstProductos
            // 
            lstProductos.FormattingEnabled = true;
            lstProductos.Location = new Point(97, 319);
            lstProductos.Name = "lstProductos";
            lstProductos.Size = new Size(322, 144);
            lstProductos.TabIndex = 3;
            // 
            // lstFabricantes
            // 
            lstFabricantes.FormattingEnabled = true;
            lstFabricantes.Location = new Point(97, 84);
            lstFabricantes.Name = "lstFabricantes";
            lstFabricantes.Size = new Size(322, 144);
            lstFabricantes.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MS Gothic", 15F);
            label2.Location = new Point(82, 25);
            label2.Name = "label2";
            label2.Size = new Size(337, 25);
            label2.TabIndex = 1;
            label2.Text = "ZONA VER INFO ACTUALIZADA";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1254, 643);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            FormClosed += Form1_FormClosed;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private TextBox txtNombreFabricante;
        private TextBox txtCodigoFabricante;
        private Button btnNuevoFabricante;
        private Label label4;
        private Label label3;
        private Button btnNuevoProducto;
        private Label label5;
        private Label label6;
        private TextBox txtNombreProducto;
        private TextBox txtCodigoProducto;
        private Label label7;
        private Label label8;
        private TextBox txtPrecioProducto;
        private ListBox lstProductos;
        private ListBox lstFabricantes;
        private ComboBox cbFabricantes;
    }
}
