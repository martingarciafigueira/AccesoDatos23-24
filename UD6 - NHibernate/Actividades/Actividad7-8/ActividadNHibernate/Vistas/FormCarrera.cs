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
    public partial class FormCarrera : Form
    {
        private CarreraService carreraService;
        private InstitutoService institutoService;
        private Carrera unaCarrera;

        public FormCarrera()
        {
            InitializeComponent();
        }

        public FormCarrera(Carrera _carrera)
        {
            this.carreraService = new CarreraService();
            this.institutoService = new InstitutoService();
            this.unaCarrera = _carrera;
            InitializeComponent();
            this.configurar();
            this.cargarInstitutos();
        }

        private bool hasCarrera()
        {
            return this.unaCarrera != null;
        }

        private void configurar()
        {
            if (this.hasCarrera())
            {
                this.lblTitulo.Text = "Actualizar Carrera";
                this.txtNombreCarrera.Text = this.unaCarrera.NombreCarrera;
            }
            else
            {
                this.lblTitulo.Text = "Registrar Carrera";
            }
        }

        private void GuardarCarrera()
        {
            if (this.hasCarrera())
            {
                this.unaCarrera.NombreCarrera = this.txtNombreCarrera.Text;
                this.unaCarrera.UnInstituto = (Instituto)this.cbInstitutos.SelectedItem;
                this.carreraService.Update(this.unaCarrera);
            }
            else
            {
                Carrera nuevaCarrera = new Carrera();
                nuevaCarrera.NombreCarrera = this.txtNombreCarrera.Text;
                nuevaCarrera.UnInstituto = (Instituto)this.cbInstitutos.SelectedItem;
                this.carreraService.Save(nuevaCarrera);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.GuardarCarrera();
            this.Close();
        }

        private void cargarInstitutos()
        {
            List<Instituto> lista = this.institutoService.GetAll();
            this.cbInstitutos.DataSource = lista;
        }
    }
}
