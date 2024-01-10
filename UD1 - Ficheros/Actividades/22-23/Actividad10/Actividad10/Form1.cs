namespace Actividad10
{
    public partial class Form1 : Form
    {
        string rutaCarpeta;
        DirectoryInfo directorio;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrearDirectorio_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog carpeta = new FolderBrowserDialog();

            if (carpeta.ShowDialog() == DialogResult.OK)
            {
                rutaCarpeta = carpeta.SelectedPath + @"\" + txtNombreCarpeta.Text;
                directorio = new DirectoryInfo(rutaCarpeta);

                if (directorio.Exists)
                {
                    MessageBox.Show("La carpeta ya existe");
                    return;
                }
                directorio.Create();
                MessageBox.Show("Carpeta creada correctamente");
            }
        }
    }
}