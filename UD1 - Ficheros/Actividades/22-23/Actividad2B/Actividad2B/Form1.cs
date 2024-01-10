namespace Actividad2B
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCargarLenguajes_Click(object sender, EventArgs e)
        {
            StreamReader fichero = new StreamReader("C:/prueba/Log_Usuario.txt");
            lstLenguajes.Items.Clear();
            while (!fichero.EndOfStream)
            {
                lstLenguajes.Items.Add(fichero.ReadLine());
            }
            fichero.Close();
        }
    }
}