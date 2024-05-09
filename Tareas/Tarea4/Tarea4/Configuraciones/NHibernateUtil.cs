using NHibernate;
using NHibernate.Cfg;
using NHibernate.Mapping.Attributes;
using NHibernate.Tool.hbm2ddl;
using RibeiroMartinezAliciaTarea5.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RibeiroMartinezAliciaTarea5.Configuraciones
{
    //Creo el archivo de configuración - NHibernateUtil
    internal class NHibernateUtil
    {
        //Establezco la conexión con la base de datos
        public static ISessionFactory SessionFactory;


        //Nos devolverá un ISessionFactory
        private static ISessionFactory BuildSessionFactory()
        {
            try
            {
                if (NHibernateUtil.SessionFactory == null)
                {
                    //Defino un objeto Configuration con la configuración de la sesión
                    Configuration config = new Configuration();
                    config.Configure();

                    HbmSerializer.Default.Validate = true;
                    config.AddInputStream(HbmSerializer.Default.Serialize(Assembly.GetExecutingAssembly()));

                    //Le añado un Assembly con la tabla que se voy a mapear de la base de datos
                    config.AddAssembly(typeof(Usuario).Assembly);

                    //Defino un objeto SchemaUpdate y le paso el objeto Configuration
                    new SchemaUpdate(config);

                    NHibernateUtil.SessionFactory = config.BuildSessionFactory();
                }

                return NHibernateUtil.SessionFactory;
            }

            catch (Exception )
            {
                throw;
            }
        }



        //Creo el siguiente método para devolver el ISessionFactory
        public static ISessionFactory GetISessionFactory()
        {
            if (SessionFactory == null)
            {
                return BuildSessionFactory();
            }
            else
            {
                return SessionFactory;
            }
        }



        //Creo el siguiente método para iniciar la conexión con la BD
        public static void Start()
        {
            BuildSessionFactory();
        }



        //Creo el siguiente método para cerrar  la conexión con la BD
        public static void Stop()
        {
           GetISessionFactory().Close();
        
        }
    }
}
