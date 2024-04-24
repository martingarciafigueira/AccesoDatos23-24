﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NHibernate;
using NHibernate.Mapping.Attributes;
using NHibernate.Cfg;
using System.Reflection;
using ActividadNHibernate.Entidades;
using NHibernate.Tool.hbm2ddl;


namespace ActividadNHibernate.Configuraciones
{
    class NHibernateUtil
    {

        private static ISessionFactory sessionFactory;

        private static ISessionFactory BuildSessionFactory()
        {
            try
            {
                if (NHibernateUtil.sessionFactory == null)
                {
                    Configuration config = new Configuration();
                    config.Configure();

                    HbmSerializer.Default.Validate = true;
                    config.AddInputStream(HbmSerializer.Default.Serialize(Assembly.GetExecutingAssembly()));

                    config.AddAssembly(typeof(Asignatura).Assembly);
                    config.AddAssembly(typeof(Carrera).Assembly);
                    config.AddAssembly(typeof(DetalleEstudiante).Assembly);
                    config.AddAssembly(typeof(Estudiante).Assembly);
                    config.AddAssembly(typeof(Instituto).Assembly);

                    new SchemaUpdate(config);

                    NHibernateUtil.sessionFactory = config.BuildSessionFactory();
                }
                return NHibernateUtil.sessionFactory;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static ISessionFactory GetISessionFactory()
        {
            if (NHibernateUtil.sessionFactory == null)
            {
                return BuildSessionFactory();
            }
            else
            {
                return sessionFactory;
            }
        }

        public static void Start()
        {
            BuildSessionFactory();
        }
        public static void Stop()
        {
            NHibernateUtil.GetISessionFactory().Close();
        }

    }
}
