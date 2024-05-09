using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RibeiroMartinezAliciaTarea5.Servicios
{
    class IRepositoryImpl<TEntity, TKey> : IRepository<TEntity, TKey> where TEntity : class
    {
        //En esta clase creo los siguientes métodos definidos en la interfaz

        public void Delete(TEntity entity)
        {
            ISession sesion = GetSession();
            ITransaction transaction = sesion.BeginTransaction();

            try
            {
                sesion.Delete(entity);
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



        public List<TEntity> GetAll()
        {
            ISession sesion = GetSession();
            List<TEntity> lista = sesion.Query<TEntity>().ToList();
            sesion.Close();
            return lista;
        }



        public TEntity GetById(TKey id)
        {

            ISession sesion = GetSession();
            TEntity entidad = sesion.Get<TEntity>(id);
            sesion.Close();
            return entidad;
        }



        public TKey Save(TEntity entity)
        {
            ISession sesion = GetSession();
            ITransaction transaction = sesion.BeginTransaction();

            try
            {
                TKey tkey = (TKey)sesion.Save(entity);
                transaction.Commit();
                sesion.Close();
                return tkey;
            }
            catch (Exception)
            {
                transaction.Rollback();
                sesion.Close();
                throw;
            }
        }



        public void Update(TEntity entity)
        {
            ISession sesion = GetSession();
            ITransaction transaction = sesion.BeginTransaction();

            try
            {
                sesion.Update(entity);
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


        //Creo un método GetISession() para obtener la sesión
        protected ISession GetSession()
        {
            return Configuraciones.NHibernateUtil.GetISessionFactory().OpenSession();
        }
    }
}
