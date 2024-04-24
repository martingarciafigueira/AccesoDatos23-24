using NHibernate.Mapping.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad1.Clases
{
    [Serializable]
    [Class(Schema = "dbo", Table = "Estudiante", NameType = typeof(Estudiante))]
    public class Estudiante
    {
        [Id(Name = "IdEstudiante", Column = "IdEstudiante", Type = "int"), Generator(1, Class = "identity")]
        public virtual int IdEstudiante { get; set; }
        public virtual string Nombre { get; set; }
        public virtual string Apellido { get; set; }
        public virtual string Documento { get; set; }

        [Set(0, Name = "ListaAsignaturas", Table = "Estudiante_Asignatura", Inverse = false, Cascade = "all")]
        [Key(1, Column = "IdAsignatura")]
        [ManyToMany(2, ClassType = typeof(Asignatura), Column = "IdEstudiante")]
        public virtual List<Asignatura> ListaAsignaturas { get; set; }

        [ManyToOne(ClassType = typeof(Instituto), OuterJoin = OuterJoinStrategy.True)]
        public virtual Instituto UnInstituto { get; set; }

        [ManyToOne(ClassType = typeof(Carrera), Column = "IdDetalleEstudiante", Name = "UnDetalleEstudiante", Unique = true)]
        public virtual DetalleEstudiante UnDetalleEstudiante { get; set; }
    }
}
