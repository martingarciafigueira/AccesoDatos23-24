using NHibernate.Mapping.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad1.Clases
{
    [Serializable]
    [Class(Schema ="dbo", Table = "Asignatura", NameType = typeof(Asignatura))]
    public class Asignatura
    {
        [Id(Name = "IdAsignatura", Column = "IdAsignatura", Type = "int"), Generator(1,Class = "identity")]
        public virtual int IdAsignatura { get; set; }

        public virtual string NombreAsignatura { get; set; }
        public virtual string DescripcionAsignatura { get; set; }

        [ManyToOne(ClassType = typeof(Carrera), OuterJoin = OuterJoinStrategy.True)]
        public virtual Carrera UnaCarrera { get; set; }

        [Set(0, Name = "ListaEstudiantes", Table = "Estudiante_Asignatura", Inverse = true, Cascade = "all")]
        [Key(1, Column = "IdEstudiante")]
        [ManyToMany(2, ClassType = typeof(Estudiante), Column = "IdAsignatura")]
        public virtual List<Estudiante> ListaEstudiantes { get; set; }
    }
}
