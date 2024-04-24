using ActividadNHibernate.Entidades;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadNHibernate.Servicios
{
    class CarreraService : IRepositoryImpl<Carrera, int>
    {
        public IList<Carrera> GetCarreraByInstituto(Instituto _instituto)
        {
            ISession session = GetISession();
            IList<Carrera> lista = session.QueryOver<Carrera>().Where(x => x.UnInstituto == _instituto).List();
            session.Close();
            return lista;
        }
    }
}
