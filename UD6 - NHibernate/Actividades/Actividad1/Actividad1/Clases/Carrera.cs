using NHibernate.Mapping.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad1.Clases
{
    [Serializable]
    [Class(Schema = "dbo", Table = "Carrera", NameType = typeof(Carrera))]
    public class Carrera
    {
        [Id(Name = "IdCarrera", Column = "IdCarrera", Type = "int"), Generator(1, Class = "identity")]
        public virtual int IdCarrera { get; set; }
        public virtual string NombreCarrera { get; set; }

        [ManyToOne(ClassType = typeof(Instituto), OuterJoin = OuterJoinStrategy.True)]
        public virtual Instituto UnInstituto { get; set; }
        public virtual List<Asignatura> ListaAsignaturas { get; set; }
    }
}
