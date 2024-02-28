using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad3
{
    public partial class Form1 : Form
    {
        string cadenaConexion = "Initial Catalog=Futbol;Data Source=localhost;user=sa;password=root";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCargarEquipos_Click(object sender, EventArgs e)
        {
            cargarEquipos();
        }

        private void btnInsertarEquipo_Click(object sender, EventArgs e)
        {
            Equipo equipoNuevo = new Equipo();

            equipoNuevo.Codigo = txtCodigo.Text;
            equipoNuevo.Nombre = txtNombre.Text;
            equipoNuevo.Pais = txtPais.Text;

            InsertarEquipo(equipoNuevo);

            txtCodigo.Clear();
            txtNombre.Clear();
            txtPais.Clear();
        }

        private void btnInsertarFutbolista_Click(object sender, EventArgs e)
        {
            Equipo equipoSeleccionado;
            Futbolista nuevoFutbolista = new Futbolista();

            if (lstEquipos.SelectedItem != null)
            {
                equipoSeleccionado = (Equipo)lstEquipos.SelectedItem;

                nuevoFutbolista.Codigo = txtCodigoFutbolista.Text;
                nuevoFutbolista.Nombre = txtNombreFutbolista.Text;
                nuevoFutbolista.Posicion = txtPosicion.Text;
                nuevoFutbolista.CodigoEquipo = equipoSeleccionado.Codigo;

                InsertarFutbolista(nuevoFutbolista);
            }
            else
            {
                MessageBox.Show("Debes seleccionar un equipo");
            }
        }

        public void cargarEquipos()
        {
            using (IDbConnection db = new SqlConnection(cadenaConexion))
            {
                var consulta = "SELECT * FROM Equipos";
                List<Equipo> listaEquipos = (List<Equipo>)db.Query<Equipo>(consulta);
                lstEquipos.DataSource = listaEquipos;
            }
        }

		public void cargarFutbolistas()
		{
			using (IDbConnection db = new SqlConnection(cadenaConexion))
			{
				var consulta = "SELECT * FROM Futbolistas";
				List<Futbolista> listaFutbolistas = (List<Futbolista>)db.Query<Futbolista>(consulta);
				lstFutbolistas.DataSource = listaFutbolistas;
			}
		}

		public void borrarFutbolista(Futbolista futbolista)
		{
			using (IDbConnection db = new SqlConnection(cadenaConexion))
			{
				var consulta = "DELETE Futbolistas WHERE Codigo = @Codigo";
				db.Execute(consulta, futbolista);
			}
		}

		public void borrarEquipo(Equipo equipo)
		{
			using (IDbConnection db = new SqlConnection(cadenaConexion))
			{
				var consulta = "DELETE Equipos WHERE Codigo = @Codigo";
				db.Execute(consulta, equipo);
			}
		}

		public void actualizarFutbolista(Futbolista futbolista)
        {
			using (IDbConnection db = new SqlConnection(cadenaConexion))
			{
				var consulta = "UPDATE Futbolistas SET Nombre = @Nombre, Posicion = @Posicion WHERE Codigo = @Codigo";
				db.Execute(consulta, futbolista);
			}
		}

		public void actualizarEquipo(Equipo equipo)
		{
			using (IDbConnection db = new SqlConnection(cadenaConexion))
			{
				var consulta = "UPDATE Equipos SET Nombre = @Nombre, Pais = @Pais WHERE Codigo = @Codigo";
				db.Execute(consulta, equipo);
			}
		}

		public void InsertarFutbolista(Futbolista futbolista)
        {
            using (IDbConnection db = new SqlConnection(cadenaConexion))
            {
                var consulta = "INSERT INTO Futbolistas (Codigo,Nombre,CodigoEquipo,Posicion) VALUES (@Codigo, @Nombre, @CodigoEquipo, @Posicion)";
                db.Execute(consulta, futbolista);
            }
        }

        public void InsertarEquipo(Equipo equipo)
        {
            using (IDbConnection db = new SqlConnection(cadenaConexion))
            {
                var consulta = $@"INSERT INTO Equipos (Codigo, Nombre, Pais) VALUES (@Codigo, @Nombre, @Pais)";
                db.Execute(consulta, equipo);
            }
        }

		private void btnCargarFutbolistas_Click(object sender, EventArgs e)
		{
            cargarFutbolistas();
		}

		private void button1_Click(object sender, EventArgs e)
		{
            Futbolista futbolistaElegido = (Futbolista) lstFutbolistas.SelectedItem;

            txtCodigoFutbolista.Text = futbolistaElegido.Codigo;
            txtNombreFutbolista.Text = futbolistaElegido.Nombre;
            txtPosicion.Text = futbolistaElegido.Posicion;
		}

		private void btnModificarFutbolista_Click(object sender, EventArgs e)
		{
			Futbolista futbolistaElegido = (Futbolista)lstFutbolistas.SelectedItem;

            if (futbolistaElegido.Nombre != txtNombreFutbolista.Text)
            {
				futbolistaElegido.Nombre = txtNombreFutbolista.Text;
			}
            
            if (futbolistaElegido.Posicion != txtPosicion.Text)
            {
				futbolistaElegido.Posicion = txtPosicion.Text;
			}

			actualizarFutbolista(futbolistaElegido);
		}

		private void btnCargarEquipo_Click(object sender, EventArgs e)
		{
			Equipo equipoElegido = (Equipo) lstEquipos.SelectedItem;

			txtCodigo.Text = equipoElegido.Codigo;
			txtNombre.Text = equipoElegido.Nombre;
			txtPais.Text = equipoElegido.Pais;
		}

		private void btnModificarEquipo_Click(object sender, EventArgs e)
		{
			Equipo equipoElegido = (Equipo)lstEquipos.SelectedItem;

			if (equipoElegido.Nombre != txtNombre.Text)
			{
				equipoElegido.Nombre = txtNombre.Text;
			}

			if (equipoElegido.Pais != txtPais.Text)
			{
				equipoElegido.Pais = txtPais.Text;
			}

			actualizarEquipo(equipoElegido);
		}

		private void btnBorrarEquipo_Click(object sender, EventArgs e)
		{
			Equipo equipoElegido = (Equipo)lstEquipos.SelectedItem;

            borrarEquipo(equipoElegido);
			cargarEquipos();
		}

		private void btnBorrarFutbolista_Click(object sender, EventArgs e)
		{
			Futbolista futbolistaElegido = (Futbolista)lstFutbolistas.SelectedItem;

			borrarFutbolista(futbolistaElegido);
			cargarFutbolistas();
		}
	}
}
