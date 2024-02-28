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
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            string cadenaConexion = "Initial Catalog = Futbol; Data Source = localhost; user=sa; password=montecastelo";

            using(IDbConnection conexion = new SqlConnection(cadenaConexion))
            {
                var consulta = @"SELECT * FROM Equipos";

                //Ejecucion de la consulta
                List<Equipo> equipos = (List<Equipo>) conexion.Query<Equipo>(consulta);
                lstEquipos.DataSource = equipos;
            }
        }
    }
}
