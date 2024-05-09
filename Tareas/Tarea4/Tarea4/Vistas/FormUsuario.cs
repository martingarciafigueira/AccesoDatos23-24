using NHibernate.Engine;
using RibeiroMartinezAliciaTarea5.Entidades;
using RibeiroMartinezAliciaTarea5.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using NHibernate;

namespace RibeiroMartinezAliciaTarea5.Vistas
{
    public partial class FormUsuario : Form
    {
        //Defino las siguientes variables
        private UsuarioService usuarioService;
        private Usuario user;
        private UsuarioDAO usuariodao = new UsuarioDAO();



        public FormUsuario()
        {
            InitializeComponent();
        }



        //Sobrecargo el constructor
        public FormUsuario(Usuario usuario)
        {
            this.usuarioService = new UsuarioService();
            this.user = usuario;
            InitializeComponent();

            //Utilizo el siguiente método
            this.Configurar();

        }



        //Método para que nos diga si el objeto es nuevo o actualizado
        private bool HasUsuario()
        {
            return this.user != null;
        }



        //Método para saber si construimos una interfaz gráfica en el formulario para insertar un elemento o para actualizarlo
        private void Configurar()
        {
            if (this.HasUsuario())
            {
                this.labelTitulo.Text = "Actualizar Usuario";
                this.txtNombre.Text = this.user.Nombre;
                this.txtApellidos.Text = this.user.Apellidos;
                this.txtCorreo.Text = this.user.Email;
                this.txtUsuario.Text = this.user.NombreUsuario;
                this.txtContrasena.Text = this.user.Contrasenha;
               
            }
            else
            {
                this.labelTitulo.Text = "Registrar Usuario";
            }
        }



        //Método para guardar el nuevo usuario/ usuario actualizado
        private void GuardarUsuario()
        {


            //Utilizo los métodos siguientes para verificar si está todo correcto

            if (ValidarNombre() == false)
            {
                return;
            }

            if (ValidarApellidos() == false)
            {
                return;
            }

            if (ValidarEmail() == false)
            {
                return;
            }

            if (ValidarEmail2() == false)
            {
                return;
            }

            if (ValidarUsuario() == false)
            {
                return;
            }

            if (ValidarUsuario2() == false)
            {
                return;
            }

            if (ValidarContrasena() == false)
            {
                return;
            }

            if (ValidarContrasena2() == false)
            {
                return;
            }

            //Si es para actualizar muestro los datos en los TextBox
            if (this.HasUsuario())
            {
                
                this.user.Nombre = this.txtNombre.Text;
                this.user.Apellidos = this.txtApellidos.Text;
                this.user.Email = this.txtCorreo.Text;
                this.user.NombreUsuario = this.txtUsuario.Text;
                this.user.Contrasenha = this.txtContrasena.Text;

                //Utilizo el siguiente método para actualizar
                this.usuarioService.Update(this.user);
                this.Close();
            }


            else
            {                

                //Creo un nuevo objeto Uusario y guardo los datos introducidos
                Usuario nuevoUser = new Usuario();              
                nuevoUser.Nombre = this.txtNombre.Text;
                nuevoUser.Apellidos = this.txtApellidos.Text;
                nuevoUser.Email = this.txtCorreo.Text;
                nuevoUser.NombreUsuario = this.txtUsuario.Text;
                nuevoUser.Contrasenha = this.txtContrasena.Text;

                //Utilizo el siguiente método para guardar
                usuariodao.CrearUsuario(nuevoUser);
                this.Close();
            }

            
            limpiarTexto();
        }



        //Botón guardar
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarUsuario();
        }



        //Creo un método para borrar las cajas de texto 
        private void limpiarTexto()
        {
            txtNombre.Clear();
            txtApellidos.Clear();
            txtCorreo.Clear();
            txtUsuario.Clear();
            txtContrasena.Clear();

        }



        //Creo una serie de métodos para que cuando el usuario quiera añadir un nuevo usuario se rellenen todos los campos obligatoriamente y correctamente


        private bool ValidarNombre()
        {
            if (string.IsNullOrEmpty(txtNombre.Text)) //Si el textBox está vacio da error, para mostrar el error por pantalla utilizo la herramienta ErrorProvider del Forms
            {
                errorProvider.SetError(txtNombre, "Debe escribir un nombre");
                return false;
            }

            else
            {
                errorProvider.SetError(txtNombre, "");
                return true;
            }
        }



        private bool ValidarApellidos()
        {
            if (string.IsNullOrEmpty(txtApellidos.Text))
            {
                errorProvider.SetError(txtApellidos, "Debe escribir los apellidos");
                return false;
            }

            else
            {
                errorProvider.SetError(txtApellidos, "");
                return true;
            }
        }



        private bool ValidarEmail()
        {
            if (string.IsNullOrEmpty(txtCorreo.Text))
            {
                errorProvider.SetError(txtCorreo, "Debe escribir un correo");
                return false;
            }

            else
            {
                errorProvider.SetError(txtCorreo, "");
                return true;
            }
        }



        private bool ValidarEmail2()
        {
            if (VerificarEmail(txtCorreo.Text) == false)
            {
                errorProvider.SetError(txtCorreo, "Debe escribir un email válido");
                return false;
            }

            else
            {
                errorProvider.SetError(txtCorreo, "");
                return true;
            }
        }



        private bool VerificarEmail(String email)
        {
            //Guardo los carácteres en un string con el formato correcto
            String caracteres = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";

            //Utilizo la clase Regex para comprobar si la cadena sigue el patrón
            if (Regex.IsMatch(email, caracteres))
            {
                if (Regex.Replace(email, caracteres, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {                 
                    return false;
                }
            }
            else
            {
                return false;
            }

        }



        private bool ValidarUsuario()
        {
            if (string.IsNullOrEmpty(txtUsuario.Text))
            {
                errorProvider.SetError(txtUsuario, "Debe escribir un nombre de usuario");
                return false;
            }

            else
            {
                errorProvider.SetError(txtUsuario, "");
                return true;
            }
        }



        private bool ValidarUsuario2()
        {
            if (VerificarUsuario(txtUsuario.Text) == false)
            {
                errorProvider.SetError(txtUsuario, "El nombre de usuario ya está en uso");
                return false;
            }

            else
            {
                errorProvider.SetError(txtUsuario, "");
                return true;
            }
        }



        private bool VerificarUsuario(string nombreUsuario)
        {
            //Creo una sesión de NHibernate
            ISession session = GetSession();

            //Verifico si el nombre de usuario ya existe en la base de datos utilizando IQuery
            IQuery query = session.CreateQuery("from Usuario where NombreUsuario = :nombreUsuario");
            query.SetParameter("nombreUsuario", nombreUsuario);
            Usuario usuarioExistente = query.UniqueResult<Usuario>();

            //Si es null, no existe
            if (usuarioExistente == null)
            {
                return true;
            }

            //Si existe
            else
            {   
                return false;        
            }

        }



        private bool ValidarContrasena()
        {
            if (string.IsNullOrEmpty(txtContrasena.Text))
            {
                errorProvider.SetError(txtContrasena, "Debe escribir una contraseña");
                return false;
            }

            else
            {
                errorProvider.SetError(txtContrasena, "");
                return true;
            }
        }



        private bool ValidarContrasena2()
        {
            if (VerificarContrasena(txtContrasena.Text) == false)
            {
                errorProvider.SetError(txtContrasena, "Debe escribir una contraseña válida");
                return false;
            }

            else
            {
                errorProvider.SetError(txtContrasena, "");
                return true;
            }
        }



        private bool VerificarContrasena(string contraseña)
        {
            //El tamaño de la contraseña tiene que ser mayor que 5 caracteres
            if (contraseña.Length < 5 )
            {

                return false;
            }


            //Si cumple con todo devuelve true
            return true;
        }



        protected ISession GetSession()
        {
            return Configuraciones.NHibernateUtil.GetISessionFactory().OpenSession();
        }

    }
}
