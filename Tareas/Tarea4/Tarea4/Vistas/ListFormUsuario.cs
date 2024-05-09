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

namespace RibeiroMartinezAliciaTarea5.Vistas
{
    public partial class ListFormUsuario : Form
    {
        //Defino las siguientes variables
        private UsuarioService usuarioService = new UsuarioService();
        private UsuarioDAO usuariodao = new UsuarioDAO();



        public ListFormUsuario()
        {
            InitializeComponent();

            //Utilizo los siguientes métodos
            ConfigurarDataGridView();
            CargarListUsuarios();
        }



        //Configuro las columnas que quiero que se muestren en cada caso y defino los métodos Actualizar y Eliminar
        private void ConfigurarDataGridView()
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

            this.tblUsuarios.Columns.Add("IdUsuario", "Id Usuario");
            this.tblUsuarios.Columns.Add("Nombre", "Nombre");
            this.tblUsuarios.Columns.Add("Apellidos", "Apellidos");
            this.tblUsuarios.Columns.Add("Email", "Email");
            this.tblUsuarios.Columns.Add("NombreUsuario", "Nombre Usuario");
            this.tblUsuarios.Columns.Add("Contrasenha", "Contraseña");
            this.tblUsuarios.Columns.Add(columnActualizar);
            this.tblUsuarios.Columns.Add(columnEliminar);

        }



        //Implemento el evento CellContentClick del DataGridView para eliminar o actualizar un usuario
        private void tblUsuarios_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //Si el usuario pulsó eliminar
                if (tblUsuarios.Columns[e.ColumnIndex].Name == "Eliminar")
                {
                    try
                    {
                        if (MessageBox.Show("¿Quieres eliminar el usuario?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            
                                int id = (int)tblUsuarios.Rows[e.RowIndex].Cells["IdUsuario"].Value;

                                //Utilizo el método de la clase usuarioDAO
                                usuariodao.EliminarUsuario(id);
                            
                        }
                    }

                    catch (NullReferenceException ex)
                    {
                        MessageBox.Show("Debe seleccionar un usuario válido");
                    }
                }


                //Si el usuario pulsó actualizar
                else if (tblUsuarios.Columns[e.ColumnIndex].Name == "Actualizar")
                {
                    try
                    {
                        int id = (int)tblUsuarios.Rows[e.RowIndex].Cells["IdUsuario"].Value;

                        //Utilizo el método de la clase usuarioDAO
                        usuariodao.ActualizarUsuario(id);

                    }

                    catch (NullReferenceException ex)
                    {
                        MessageBox.Show("Debe seleccionar un usuario válido");
                    }
                }
            }

            

            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error");
            }
        }



        //Método para cargar la lista de usuarios y mostrar
        private void CargarListUsuarios()
        {
            //Utilizo el método de la clase usuarioDAO
            usuariodao.LeerListaUsuario(tblUsuarios);
        }



        //Botón para actualizar la lista y que se muestre utilizando el método anterior
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.CargarListUsuarios();
        }



        //Método para abrir el siguiente Form
        private void cargarFormUsuario(Usuario user)
        {
            FormUsuario viewForm = new FormUsuario();
            viewForm.Show();
        }



        //Botón para abrir el FormUsuario
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            this.cargarFormUsuario(null);
        }



        private void ListFormUsuario_Load(object sender, EventArgs e)
        {

        }

      
    }
}
