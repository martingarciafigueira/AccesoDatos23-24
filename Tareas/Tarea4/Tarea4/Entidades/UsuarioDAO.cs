using NHibernate;
using RibeiroMartinezAliciaTarea5.Servicios;
using RibeiroMartinezAliciaTarea5.Vistas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RibeiroMartinezAliciaTarea5.Entidades
{

    public class UsuarioDAO
    {
        private UsuarioService usuarioService = new UsuarioService();
    
        //Creo los siguientes métodos CRUD con sus transacciones

        //Método para crear un nuevo usuario
        public void CrearUsuario(Usuario nuevoUser)
        {   
            ISession sesion = GetSession();
            ITransaction transaction = sesion.BeginTransaction();

            try
            {
                this.usuarioService.Save(nuevoUser);
                transaction.Commit();
                sesion.Close();
            }

            catch (Exception)
            {
                transaction.Rollback();
                sesion.Close();
                throw;
            }

        }



        //Método para actualizar
        public void ActualizarUsuario(int id)
        {
            ISession sesion = GetSession();
            ITransaction transaction = sesion.BeginTransaction();

            try 
            {
                Usuario usuario = this.usuarioService.GetById(id);
                this.CargarFormUsuario(usuario);
                transaction.Commit();
                sesion.Close();
            }

            catch (Exception)
            {
                transaction.Rollback();
                sesion.Close();
                throw;
            }


        }



        //Método para borrar un usuario
        public void EliminarUsuario(int id)
        {
            ISession sesion = GetSession();
            ITransaction transaction = sesion.BeginTransaction();

            try
            {
                Usuario usuario = this.usuarioService.GetById(id);
                this.usuarioService.Delete(usuario);
                transaction.Commit();
                sesion.Close();
            }

            catch (Exception)
            {
                transaction.Rollback();
                sesion.Close();
                throw;
            }


        }



        //Método para leer la lista de usuarios
        public void LeerListaUsuario(DataGridView tblUsuarios)
        {
            ISession sesion = GetSession();
            ITransaction transaction = sesion.BeginTransaction();

            try
            {
                tblUsuarios.Rows.Clear();
                List<Usuario> listaUsuarios = this.usuarioService.GetAll();

                foreach (Usuario usuario in listaUsuarios)
                {
                    tblUsuarios.Rows.Add(usuario.IdUsuario, usuario.Nombre, usuario.Apellidos, usuario.Email, usuario.NombreUsuario, usuario.Contrasenha);
                }

                transaction.Commit();
                sesion.Close();
            }

            catch (Exception)
            {
                transaction.Rollback();
                sesion.Close();
                throw;
            }


        }



        //Método para abrir el siguiente Form
        private void CargarFormUsuario(Usuario user)
        {
            
            FormUsuario viewForm = new FormUsuario(user);
            viewForm.Show();     

        }



        protected ISession GetSession()
        {
            return Configuraciones.NHibernateUtil.GetISessionFactory().OpenSession();
        }

    }
}
