namespace Actividad6
{
    public partial class Form1 : Form
    {
        public string rutaFichero;
        public StreamReader fichero;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCargarFichero_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    rutaFichero= openFileDialog.FileName;
                    fichero = File.OpenText(rutaFichero);
                    leerLineas();
                }
            }
        }

        private void btnRefrescarFichero_Click(object sender, EventArgs e)
        {
            leerLineas();
        }

        public void leerLineas()
        {
            for (int i = 0; i < 10; i++)
            {
                if (fichero.ReadLine() != null)
                {
                    lstFichero.Items.Add(fichero.ReadLine());
                }
                else
                {
                    break;
                }
            }
        }
    }
}