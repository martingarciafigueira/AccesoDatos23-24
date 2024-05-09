using NHibernate;
using RibeiroMartinezAliciaTarea5.Entidades;
using RibeiroMartinezAliciaTarea5.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RibeiroMartinezAliciaTarea5.Configuraciones;
using RibeiroMartinezAliciaTarea5.Vistas;

namespace RibeiroMartinezAliciaTarea5
{
    public partial class Form1 : Form
    {

        private UsuarioService usuarioService = new UsuarioService();
       


        public Form1()
        {
            InitializeComponent();

            //Inicio la conexión
            Configuraciones.NHibernateUtil.Start();
        }

      

        //Creo el siguiente método para mostrar en el panel el siguiente Form
        private void cargarListUsuarios()
        {
            this.panel.Controls.Clear();
            ListFormUsuario viewListUsuario = new ListFormUsuario();
            viewListUsuario.TopLevel = false;
            viewListUsuario.Dock = DockStyle.Fill;
            this.panel.Controls.Add(viewListUsuario);
            viewListUsuario.Show();
        }



        //Botón para mostrar la lista donde utilizo el método anterior
        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            cargarListUsuarios();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
