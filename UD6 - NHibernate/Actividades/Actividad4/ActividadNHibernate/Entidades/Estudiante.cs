using NHibernate.Mapping;
using NHibernate.Mapping.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadNHibernate.Entidades
{
    [Serializable]
    [Class(Schema = "dbo", Table = "Estudiante", NameType = typeof(Estudiante))]
    public class Estudiante
    {
        [Id(Name = "IdEstudiante", Column = "IdEstudiante", Type = "int"), Generator(1, Class = "identity")]
        public virtual int IdEstudiante { get; set; }

        [Property(Column = "NombreEstudiante", Type = "string", NotNull = true)]
        public virtual String NombreEstudiante { get; set; }

        [Property(Column = "ApellidoEstudiante", Type = "string", NotNull = true)]
        public virtual String ApellidoEstudiante { get; set; }

        [Property(Column = "DocumentoEstudiante", Type = "string", NotNull = true)]
        public virtual String DocumentoEstudiante { get; set; }

        [ManyToOne(ClassType = typeof(Instituto), OuterJoin = OuterJoinStrategy.True)]
        public virtual Instituto UnInstituto { get; set; }

        [Set(0, Name = "ListaAsignaturas", Table = "estudiante_asignatura", Inverse = false, Cascade = "all")]
        [Key(1, Column = "IdAsignatura")]
        [ManyToMany(2, ClassType = typeof(Asignatura), Column = "IdEstudiante")]
        public virtual List<Asignatura> ListaAsignaturas { get; set; }
    }
}
