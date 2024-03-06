using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad3
{
    public partial class Form1 : Form
    {
        string cadenaConexion = "Initial Catalog = Futbol; Data Source = localhost; user=sa; password=montecastelo";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            using(IDbConnection conexion = new SqlConnection(cadenaConexion))
            {
                var consulta = @"SELECT * FROM Equipos";

                //Ejecucion de la consulta
                List<Equipo> equipos = (List<Equipo>) conexion.Query<Equipo>(consulta);
                lstEquipos.DataSource = equipos;
            }
        }

        private void lstEquipos_DoubleClick(object sender, EventArgs e)
        {
            string nombreEquipo = lstEquipos.SelectedItem.ToString();

            ShowListaFutbolistasEquipoTodosParametros(nombreEquipo);
            //ShowListaFutbolistasEquipoTresParametros("SD Eibar");
        }

        public void ShowListaFutbolistasEquipoTodosParametros(string equipo)
        {
            using (IDbConnection conexion = new SqlConnection(cadenaConexion))
            {
                var consulta = $@"SELECT F.* FROM Futbolistas F INNER JOIN Equipos E ON F.CodigoEquipo = E.Codigo WHERE E.Nombre LIKE '{equipo}'";

                //Ejecucion de la consulta
                List<Futbolista> futbolistas = (List<Futbolista>)conexion.Query<Futbolista>(consulta);
                lstFutbolistas.DataSource = futbolistas;
            }
        }

        public void ShowListaFutbolistasEquipoDosParametros(string equipo)
        {
            using (IDbConnection conexion = new SqlConnection(cadenaConexion))
            {
                var consulta = @"SELECT F.Codigo, F.Nombre FROM Futbolistas F INNER JOIN Equipos E ON F.CodigoEquipo = E.Codigo WHERE E.Nombre LIKE 'SD Eibar'";

                //Ejecucion de la consulta
                List<Futbolista> futbolistas = (List<Futbolista>)conexion.Query<Futbolista>(consulta);
                lstFutbolistas.DataSource = futbolistas;
            }
        }

        private void btnInsertarEquipo_Click(object sender, EventArgs e)
        {
            using (IDbConnection conexion = new SqlConnection(cadenaConexion))
            {
                var consulta = $@"INSERT INTO Equipos (Codigo, Nombre, Pais, Estadio, Ciudad) VALUES ('{txtCodigo.Text}', '{txtNombre.Text}', '{txtPais.Text}', '{txtEstadio.Text}','{txtCiudad.Text}')";

                //Ejecucion de la consulta
                conexion.Execute(new CommandDefinition(consulta));
            }
        }
    }
}
