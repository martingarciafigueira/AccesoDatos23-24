using ActividadNHibernate.Servicios;
using ActividadNHibernate.Vistas;
using NHibernate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActividadNHibernate
{
    public partial class frmGeneral : Form
    {

        private InstitutoService institutoService = new InstitutoService();

        public frmGeneral()
        {
            InitializeComponent();
            Configuraciones.NHibernateUtil.Start();
        }

        private void cargarListFormInstitutos()
        {
            this.pnlContenedor.Controls.Clear();
            ListFormInstituto viewListInstituto = new ListFormInstituto();
            viewListInstituto.TopLevel = false;
            viewListInstituto.Dock = DockStyle.Fill;
            this.pnlContenedor.Controls.Add(viewListInstituto);
            viewListInstituto.Show();
        }

        private void cargarListFormCarreras()
        {
            this.pnlContenedor.Controls.Clear();
            ListFormCarrera viewListCarrera = new ListFormCarrera();
            viewListCarrera.TopLevel = false;
            viewListCarrera.Dock = DockStyle.Fill;
            this.pnlContenedor.Controls.Add(viewListCarrera);
            viewListCarrera.Show();
        }

        private void btnInstituto_Click(object sender, EventArgs e)
        {
            cargarListFormInstitutos();
        }

        private void btnCarrera_Click(object sender, EventArgs e)
        {
            cargarListFormCarreras();
        }
    }
}
