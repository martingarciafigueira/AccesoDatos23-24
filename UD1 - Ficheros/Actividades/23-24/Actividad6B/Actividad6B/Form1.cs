using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad6B
{
    public partial class Form1 : Form
    {
        public StreamReader fichero;
        const int NUMERO_LINEAS_POR_VEZ = 10;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (fichero == null)
            {
                string rutaFichero = "";
                using (OpenFileDialog openFile = new OpenFileDialog())
                {
                    if (openFile.ShowDialog() == DialogResult.OK)
                    {
                        rutaFichero = openFile.FileName;
                    }
                }
                fichero = new StreamReader(rutaFichero);
            }

            for (int i = 0; i < NUMERO_LINEAS_POR_VEZ; i++)
            {
                string linea = fichero.ReadLine();
                if (linea != null)
                {
                    listBox1.Items.Add(linea);
                }
                else
                {
                    break;
                }
            }
        }
    }
}