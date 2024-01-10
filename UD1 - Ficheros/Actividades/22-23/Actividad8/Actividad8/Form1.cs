namespace Actividad8
{
    public partial class Form1 : Form
    {
        string rutaFichero = @"c:\prueba\alumnos\nombresee.txt";
        StreamReader ficheroLectura;
        StreamWriter ficheroEscritura;
        List<string> lstNuevaInfo = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LeerFichero();
        }

        private void btnInsertarAlumno_Click(object sender, EventArgs e)
        {
            InsertarAlumno(txtNombreAlumno.Text, txtApellidoAlumno.Text);
            txtNombreAlumno.Clear();
            txtApellidoAlumno.Clear();
        }

        public void LeerFichero()
        {
            lstAlumnos.Items.Clear();
            if (File.Exists(rutaFichero))
            {
                ficheroLectura = File.OpenText(rutaFichero);

                while (!ficheroLectura.EndOfStream)
                {
                    lstAlumnos.Items.Add(ficheroLectura.ReadLine());
                }

                ficheroLectura.Close(); 
            }
            else
            {
                MessageBox.Show("El fichero " + rutaFichero + " no existe");
                Environment.Exit(0);
            }
        }

        public void InsertarAlumno(string nombre, string apellidos)
        {
            string infoCompleta = nombre + " " + apellidos;
            lstAlumnos.Items.Add(infoCompleta);
            lstNuevaInfo.Add(infoCompleta);
        }

        public void EscribirFichero()
        {
            ficheroEscritura = File.AppendText(rutaFichero);

            foreach (string alumno in lstNuevaInfo)
            {
                ficheroEscritura.WriteLine(alumno);
            }

            ficheroEscritura.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            EscribirFichero();
        }
    }
}