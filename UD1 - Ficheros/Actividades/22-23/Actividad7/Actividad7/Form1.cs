using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Actividad7
{
    public partial class Form1 : Form
    {
        public string rutaFichero;
        public StreamWriter fichero;
        public StreamReader lecturaFichero;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.InitialDirectory = @"c:\prueba";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    rutaFichero = dialog.FileName;
                    LeerFichero();
                }
            }
        }

        private void btnInsertarFrase_Click(object sender, EventArgs e)
        {
            fichero = File.AppendText(rutaFichero);
            fichero.WriteLine(txtFrase.Text);
            fichero.Close();
            LeerFichero();
            txtFrase.Clear();
        }

        public void LeerFichero()
        {
            lstFichero.Items.Clear();
            lecturaFichero = File.OpenText(rutaFichero);
            while (!lecturaFichero.EndOfStream)
            {
                lstFichero.Items.Add(lecturaFichero.ReadLine());
            }
            lecturaFichero.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}