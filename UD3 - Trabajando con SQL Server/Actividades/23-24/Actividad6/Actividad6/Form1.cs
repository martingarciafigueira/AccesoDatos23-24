using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad6
{
    public partial class Form1 : Form
    {
        SqlConnection conexion;

        public Form1()
        {
            InitializeComponent();
            string cadConex = ConfigurationManager.ConnectionStrings["Actividad6.Properties.Settings.FutbolConnectionString"].ConnectionString;
            conexion = new SqlConnection(cadConex);
            conexion.Open();
            RellenaListaFutbolistas();
            RellenaListaEquipos();
        }

        public void RellenaListaFutbolistas()
        {
            //Creo la consulta
            string consulta = "SELECT * FROM Futbolistas";
            SqlCommand comando = new SqlCommand(consulta, conexion);
            SqlDataAdapter adapter = new SqlDataAdapter(comando);
            RellenarListaConAdapter(lstFutbolistas, adapter, "Codigo", "Nombre");
        }
        
        public void RellenaListaEquipos()
        {
            //Creo la consulta
            string consulta = "SELECT * FROM Equipos";
            SqlCommand comando = new SqlCommand(consulta, conexion);
            SqlDataAdapter adapter1 = new SqlDataAdapter(comando);
            SqlDataAdapter adapter2 = new SqlDataAdapter(comando);
            using (adapter1)
            {
                DataTable datatable = new DataTable();
                adapter1.Fill(datatable);

                cbFutbolistaEquipo.ValueMember = "Codigo"; //La clave asociada a cada futbolista
                cbFutbolistaEquipo.DisplayMember = "Nombre"; //El nombre asociado a cada futbolista
                cbFutbolistaEquipo.DataSource = datatable;
            }
            RellenarListaConAdapter(lstEquipos, adapter2, "Codigo", "Nombre");
        }

        //Metodo escalable. Puedo rellenar cualquier ListBox con cualquier SQLDataAdapter
        public void RellenarListaConAdapter(ListBox listaParaRellenar, SqlDataAdapter adaptadorARellenar, string campoIdentificador, string campoAMostrar)
        {
            using (adaptadorARellenar)
            {
                DataTable datatable = new DataTable();
                adaptadorARellenar.Fill(datatable);

                listaParaRellenar.ValueMember = campoIdentificador; //La clave asociada a cada futbolista
                listaParaRellenar.DisplayMember = campoAMostrar; //El nombre asociado a cada futbolista
                listaParaRellenar.DataSource = datatable;
            }
        }

        private void btnInsertarFutbolista_Click(object sender, EventArgs e)
        {
            string consulta = "INSERT INTO Futbolistas (Codigo, Nombre) VALUES (@Codigo, @Nombre)";
            SqlCommand comando = new SqlCommand(consulta, conexion);

            comando.Parameters.AddWithValue("@Codigo", txtCodigoFutbolista.Text);
            comando.Parameters.AddWithValue("@Nombre", txtNombreFutbolista.Text);
            comando.Parameters.AddWithValue("@CodigoEquipo", cbFutbolistaEquipo.SelectedValue);
            comando.ExecuteNonQuery();

            RellenaListaFutbolistas();
            txtCodigoFutbolista.Clear();
            txtNombreFutbolista.Clear();
        }

        private void btnInsertarEquipo_Click(object sender, EventArgs e)
        {
            string consulta = "INSERT INTO Equipos (Codigo, Nombre) VALUES (@Codigo, @Nombre)";
            SqlCommand comando = new SqlCommand(consulta, conexion);

            comando.Parameters.AddWithValue("@Codigo", txtCodigoEquipo.Text);
            comando.Parameters.AddWithValue("@Nombre", txtNombreEquipo.Text);
            comando.ExecuteNonQuery();

            RellenaListaEquipos();
            txtCodigoEquipo.Clear();
            txtNombreEquipo.Clear();
        }

        private void btnBorrarFutbolista_Click(object sender, EventArgs e)
        {
            string consulta = "DELETE FROM Futbolistas WHERE Codigo = @Codigo";
            SqlCommand comando = new SqlCommand(consulta, conexion);

            comando.Parameters.AddWithValue("@Codigo", lstFutbolistas.SelectedValue);
            comando.ExecuteNonQuery();

            RellenaListaFutbolistas();
        }

        private void btnBorrarEquipo_Click(object sender, EventArgs e)
        {
            string consulta = "SELECT COUNT(Codigo) FROM Futbolistas WHERE CodigoEquipo = @CodigoEquipo";
            SqlCommand comando = new SqlCommand(consulta, conexion);
            comando.Parameters.AddWithValue("@CodigoEquipo", lstEquipos.SelectedValue);
            int registros = (int) comando.ExecuteScalar();

            if (registros > 0)
            {
                DialogResult respuesta = MessageBox.Show("El equipo tiene futbolistas asociados. ¿Desea borrarlos o cancelar?", "ADVERTENCIA", MessageBoxButtons.OKCancel);

                if (respuesta == DialogResult.OK)
                {
                    consulta = "DELETE FROM Futbolistas WHERE CodigoEquipo = @Codigo;" +
                        "DELETE FROM Equipos WHERE Codigo = @Codigo;";

                    comando = new SqlCommand(consulta, conexion);

                    comando.Parameters.AddWithValue("@Codigo", lstEquipos.SelectedValue);
                    comando.ExecuteNonQuery();
                    RellenaListaFutbolistas();
                }
            }
            else
            {
                consulta = "DELETE FROM Equipos WHERE Codigo = @Codigo";
                comando = new SqlCommand(consulta, conexion);

                comando.Parameters.AddWithValue("@Codigo", lstEquipos.SelectedValue);
                comando.ExecuteNonQuery();
            }

            RellenaListaEquipos();
        }
    }
}
