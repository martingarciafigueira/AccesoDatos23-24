using System.Data;
using System.Data.SqlClient;

namespace Actviidad1
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        SqlCommand comando;
        Dictionary<string, int> dicFabricantes;
        public Form1()
        {
            InitializeComponent();
            conn = new SqlConnection("server=localhost; database=tienda; integrated security = true");
            conn.Open();
            ActualizarListadoProductos();
            ActualizarListadoFabricantes();
            ActualizarComboFabricantes();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            conn.Close();
        }

        private void btnNuevoFabricante_Click(object sender, EventArgs e)
        {
            string cadenaSQL = "INSERT INTO fabricante VALUES (@CodigoFabricante, @NombreFabricante)";
            int codigoFab;


            comando = new SqlCommand(cadenaSQL, conn);

            if (int.TryParse(txtCodigoFabricante.Text, out codigoFab))
            {
                comando.Parameters.AddWithValue("@CodigoFabricante", codigoFab);
                comando.Parameters.AddWithValue("@NombreFabricante", txtNombreFabricante.Text);

                int registrosAfectados = comando.ExecuteNonQuery();

                MessageBox.Show("Se han agregado " + registrosAfectados + " registros ");
                txtCodigoFabricante.Clear();
                txtNombreFabricante.Clear();
                ActualizarListadoFabricantes();
                ActualizarComboFabricantes();
            }
            else
            {
                MessageBox.Show("Algo falló");
            }
        }

        private void btnNuevoProducto_Click(object sender, EventArgs e)
        {
            int codigoFab, codigoProd;
            float precioProd;

            codigoFab = dicFabricantes[cbFabricantes.SelectedValue.ToString()];

            string cadenaSQL = "INSERT INTO producto VALUES (@CodigoProducto, @NombreProducto, @PrecioProducto, @CodigoFabricante)";

            comando = new SqlCommand(cadenaSQL, conn);

            int.TryParse(txtCodigoProducto.Text, out codigoProd);
            float.TryParse(txtPrecioProducto.Text, out precioProd);

            comando.Parameters.AddWithValue("@CodigoProducto", codigoProd);
            comando.Parameters.AddWithValue("@NombreProducto", txtNombreProducto.Text);
            comando.Parameters.AddWithValue("@PrecioProducto", precioProd);
            comando.Parameters.AddWithValue("@CodigoFabricante", codigoFab);

            int registrosAfectados = comando.ExecuteNonQuery();

            MessageBox.Show("Se han agregado " + registrosAfectados + " registros ");
            txtCodigoProducto.Clear();
            txtNombreProducto.Clear();
            txtPrecioProducto.Clear();
            ActualizarListadoProductos();
        }

        //Métodos públicos

        public void ActualizarListadoFabricantes()
        {
            SqlDataReader registros = ObtenerFabricantes();

            lstFabricantes.Items.Clear();
            while (registros.Read())
            {
                lstFabricantes.Items.Add(registros["nombre"]);
            }
            registros.Close();
        }

        public void ActualizarListadoProductos()
        {
            string cadenaSQL = "SELECT * FROM producto";
            comando = new SqlCommand(cadenaSQL, conn);
            SqlDataReader registros = comando.ExecuteReader();

            lstProductos.Items.Clear();
            while (registros.Read())
            {
                lstProductos.Items.Add(registros["nombre"]);
            }
            registros.Close();
        }

        public void ActualizarComboFabricantes()
        {
            dicFabricantes = new Dictionary<string, int>();
            SqlDataReader registros = ObtenerFabricantes();

            while (registros.Read())
            {
                dicFabricantes.Add(registros["nombre"].ToString(), int.Parse(registros["codigo"].ToString()));
            }

            cbFabricantes.DataSource = dicFabricantes.Keys.ToList();
            registros.Close();
        }

        public SqlDataReader ObtenerFabricantes()
        {
            string cadenaSQL = "SELECT * FROM fabricante";
            comando = new SqlCommand(cadenaSQL, conn);
            SqlDataReader registros = comando.ExecuteReader();
            return registros;
        }
    }
}
