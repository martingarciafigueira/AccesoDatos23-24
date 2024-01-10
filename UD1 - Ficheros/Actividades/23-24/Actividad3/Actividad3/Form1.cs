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

namespace Actividad3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLeerFichero_Click(object sender, EventArgs e)
        {
            lstFichero.Items.Clear();

            using (StreamReader fichero = new StreamReader("C:\\Log_Usuario.txt"))
            {
                while (!fichero.EndOfStream)
                {
                    string linea = fichero.ReadLine();
                    lstFichero.Items.Add(linea);
                }
            }
        }
    }
}
