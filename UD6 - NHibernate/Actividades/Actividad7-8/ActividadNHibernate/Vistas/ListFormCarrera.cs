using ActividadNHibernate.Entidades;
using ActividadNHibernate.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActividadNHibernate.Vistas
{
    public partial class ListFormCarrera : Form
    {
        public ListFormCarrera()
        {
            InitializeComponent();
            configurarDataGridView();
            cargarListCarreras();
            cargarInstitutos();
        }

        private CarreraService carreraService = new CarreraService();
        private InstitutoService institutoService = new InstitutoService();

        private void configurarDataGridView()
        {
            DataGridViewButtonColumn columnActualizar = new DataGridViewButtonColumn();
            DataGridViewButtonColumn columnEliminar = new DataGridViewButtonColumn();

            columnActualizar.HeaderText = "Actualizar";
            columnActualizar.Name = "Actualizar";
            columnActualizar.Text = "Actualizar";
            columnActualizar.UseColumnTextForButtonValue = true;

            columnEliminar.HeaderText = "Eliminar";
            columnEliminar.Name = "Eliminar";
            columnEliminar.Text = "Eliminar";
            columnEliminar.UseColumnTextForButtonValue = true;

            this.tblCarreras.Columns.Add("id", "ID Instituto");
            this.tblCarreras.Columns.Add("name", "Nombre Carrera");
            this.tblCarreras.Columns.Add("description", "Instituto");
            this.tblCarreras.Columns.Add(columnActualizar);
            this.tblCarreras.Columns.Add(columnEliminar);
        }

        private void cargarListCarreras()
        {
            this.tblCarreras.Rows.Clear();
            List<Carrera> listaCarreras = this.carreraService.GetAll();

            foreach (Carrera carrera in listaCarreras)
            {
                this.tblCarreras.Rows.Add(carrera.IdCarrera, carrera.NombreCarrera, carrera.UnInstituto.NombreInstituto);
            }
        }

        private void eliminarCarrera(int id)
        {
            Carrera _carrera = this.carreraService.GetById(id);
            this.carreraService.Delete(_carrera);
            this.cargarListCarreras();
        }

        private void actualizarCarrera(int id)
        {
            Carrera _carrera = this.carreraService.GetById(id);
            this.cargarFormCarrera(_carrera);
        }

        private void tblInstitutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tblCarreras.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                if (MessageBox.Show("¿Quieres eliminar la carrera?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id = (int)tblCarreras.Rows[e.RowIndex].Cells["id"].Value;
                    this.eliminarCarrera(id);
                }
            }
            else if (tblCarreras.Columns[e.ColumnIndex].Name == "Actualizar")
            {
                int id = (int)tblCarreras.Rows[e.RowIndex].Cells["id"].Value;
                this.actualizarCarrera(id);
            }
        }

        private void cargarFormCarrera(Carrera unaCarrera)
        {
            FormCarrera viewForm = new FormCarrera(unaCarrera);
            viewForm.Show();
        }

        private void btnNuevoInstituto_Click(object sender, EventArgs e)
        {
            this.cargarFormCarrera(null);
        }

        private void btnActualizarTabla_Click(object sender, EventArgs e)
        {
            this.cargarListCarreras();
        }

        private void btnVerTodasCarreras_Click(object sender, EventArgs e)
        {
            this.cargarListCarreras();
        }

        private void cargarInstitutos()
        {
            List<Instituto> lista = this.institutoService.GetAll();
            this.cbInstitutos.DataSource = lista;
        }

        private void cbInstitutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.tblCarreras.Rows.Clear();
            Instituto unInstituto = (Instituto)this.cbInstitutos.SelectedItem;
            IList<Carrera> lista = this.carreraService.GetCarreraByInstituto(unInstituto);
            foreach (Carrera carrera in lista)
            {
                this.tblCarreras.Rows.Add(carrera.IdCarrera, carrera.NombreCarrera);
            }
        }
    }
}
