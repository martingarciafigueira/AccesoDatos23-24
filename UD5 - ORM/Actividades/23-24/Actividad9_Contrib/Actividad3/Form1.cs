using Dapper;
using Dapper.Contrib.Extensions;
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

        enum TIPO_OPERACION
        {
            INSERT,
            UPDATE,
            DELETE
        };

        TIPO_OPERACION tipoOperacionEquipo = TIPO_OPERACION.INSERT;
        TIPO_OPERACION tipoOperacionFutbolista = TIPO_OPERACION.INSERT;

        public Form1()
        {
            InitializeComponent();
        }

        private void lstEquipos_DoubleClick(object sender, EventArgs e)
        {
            string nombreEquipo = lstEquipos.SelectedItem.ToString();

            ShowListaFutbolistasEquipoTodosParametros(nombreEquipo);
            //ShowListaFutbolistasEquipoTresParametros("SD Eibar");
        }

        public void ShowListaFutbolistasEquipoTodosParametros(string equipo)
        {
            List<Futbolista> futbolistas = ObtenerListaFutbolistasEquipoTodosParametros(equipo);
            lstFutbolistas.DataSource = futbolistas;
        }

        public List<Futbolista> ObtenerListaFutbolistasEquipoTodosParametros(string equipo)
        {
            using (IDbConnection conexion = new SqlConnection(cadenaConexion))
            {
                var consulta = $@"SELECT F.* FROM Futbolistas F INNER JOIN Equipos E ON F.CodigoEquipo = E.Codigo WHERE E.Nombre LIKE '{equipo}'";

                //Ejecucion de la consulta
                List<Futbolista> futbolistas = (List<Futbolista>)conexion.Query<Futbolista>(consulta);
                return futbolistas;
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
            Equipo equipo = new Equipo(txtCodigo.Text, txtNombre.Text, txtPais.Text, txtEstadio.Text, txtCiudad.Text);

            if (tipoOperacionEquipo == TIPO_OPERACION.INSERT)
            {
                InsertarEquipo(equipo);
            }
            else
            {
                EditarEquipo(equipo);
            }
            ActualizarListaEquipos();
        }

        private void btnInsertarFutbolista_Click(object sender, EventArgs e)
        {
            if (cbEquipoSeleccionado.SelectedItem != null)
            {
                int edad, dorsal;
                Equipo equipoSeleccionado = (Equipo)cbEquipoSeleccionado.SelectedItem;

                int.TryParse(txtEdadFutbolista.Text, out edad);
                int.TryParse(txtDorsalFutbolista.Text, out dorsal);

                Futbolista futbolista = new Futbolista(txtCodigoFutbolista.Text, txtNombreFutbolista.Text, equipoSeleccionado.Codigo, txtPosicionFutbolista.Text, edad, dorsal);

                if (tipoOperacionFutbolista == TIPO_OPERACION.INSERT)
                {
                    InsertarFutbolista(futbolista);
                }
                else
                {
                    EditarFutbolista(futbolista);
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un equipo");
            }
            ActualizarListaFutbolistas();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ActualizarListaEquipos();
        }

        private void btnEditarEquipo_Click(object sender, EventArgs e)
        {
            lblInsertarActualizarEquipos.Text = "Editar equipo";
            btnInsertarActualizarEquipo.Text = "Editar equipo";

            Equipo equipoSeleccionado = (Equipo)lstEquipos.SelectedItem;

            txtCodigo.Text = equipoSeleccionado.Codigo;
            txtCodigo.Enabled = false;
            txtNombre.Text = equipoSeleccionado.Nombre;
            txtPais.Text = equipoSeleccionado.Pais;
            txtEstadio.Text = equipoSeleccionado.Estadio;
            txtCiudad.Text = equipoSeleccionado.Ciudad;

            tipoOperacionEquipo = TIPO_OPERACION.UPDATE;

        }

        private void btnEditarFutbolista_Click(object sender, EventArgs e)
        {
            lblInsertarActualizarFutbolistas.Text = "Editar futbolista";
            btnInsertarActualizarFutbolista.Text = "Editar futbolista";

            Futbolista futbolistaSeleccionado = (Futbolista)lstFutbolistas.SelectedItem;

            txtCodigoFutbolista.Text = futbolistaSeleccionado.Codigo;
            txtCodigoFutbolista.Enabled = false;
            txtNombreFutbolista.Text = futbolistaSeleccionado.Nombre;
            txtPosicionFutbolista.Text = futbolistaSeleccionado.Posicion;
            txtEdadFutbolista.Text = futbolistaSeleccionado.Edad.ToString();
            txtDorsalFutbolista.Text = futbolistaSeleccionado.Dorsal.ToString();

            tipoOperacionFutbolista = TIPO_OPERACION.UPDATE;
        }

        private void btnBorrarFutbolista_Click(object sender, EventArgs e)
        {
            Futbolista futbolistaABorrar = lstFutbolistas.SelectedItem as Futbolista;
            BorrarFutbolista(futbolistaABorrar);
            ActualizarListaFutbolistas();
        }

        private void btnBorrarEquipo_Click(object sender, EventArgs e)
        {
            Equipo equipoABorrar = lstEquipos.SelectedItem as Equipo;
            List<Futbolista> futbolistasDeEquipoABorrar = ObtenerListaFutbolistasEquipoTodosParametros(equipoABorrar.Nombre);
            if (futbolistasDeEquipoABorrar.Count == 0)
            {
                BorrarEquipo(equipoABorrar);
            }
            else
            {
                DialogResult respuesta = MessageBox.Show("El equipo que desea borrar tiene futbolistas asociados, ¿Desea borrarlos?", "ADVERTENCIA", MessageBoxButtons.OKCancel);

                if (respuesta == DialogResult.OK)
                {
                    foreach (Futbolista futbolista in futbolistasDeEquipoABorrar)
                    {
                        BorrarFutbolista(futbolista);
                    }
                    BorrarEquipo(equipoABorrar);
                    ActualizarListaFutbolistas();
                }
                else
                {
                    MessageBox.Show("No se ha borrado el equipo");
                }
            }
            ActualizarListaEquipos();
        }

        //Métodos públicos
        public void InsertarEquipo(Equipo equipo)
        {
            using (IDbConnection conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Insert(equipo);
            }
        }
        public void InsertarFutbolista(Futbolista futbolista)
        {
            using (IDbConnection conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Insert(futbolista);
            }
        }
        public void EditarEquipo(Equipo equipo)
        {
            using (IDbConnection conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Update(equipo);
            }
        }
        public void EditarFutbolista(Futbolista futbolista)
        {
            using (IDbConnection conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Update(futbolista);
            }
        }

        public void ActualizarListaEquipos()
        {
            using (IDbConnection conexion = new SqlConnection(cadenaConexion))
            {
                List<Equipo> equipos = (List<Equipo>)conexion.GetAll<Equipo>();
                lstEquipos.DataSource = equipos;
                cbEquipoSeleccionado.DataSource = equipos;
            }
        }
        public void ActualizarListaFutbolistas()
        {
            using (IDbConnection conexion = new SqlConnection(cadenaConexion))
            {
                Equipo equipo = (Equipo)cbEquipoSeleccionado.SelectedItem;
                List<Futbolista> futbolistas = conexion.GetAll<Futbolista>().Where(x => x.CodigoEquipo == equipo.Codigo).ToList();
                lstFutbolistas.DataSource = futbolistas;
            }
        }

        public void BorrarFutbolista(Futbolista futbolista)
        {
            using (IDbConnection conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Delete(futbolista);
            }
        }

        public void BorrarEquipo(Equipo equipo)
        {
            using (IDbConnection conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Delete(equipo);
            }
        }
    }
}
