using NHibernate.Mapping.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad1.Clases
{
    [Serializable]
    [Class(Schema = "dbo", Table = "DetalleEstudiante", NameType = typeof(DetalleEstudiante))]
    public class DetalleEstudiante
    {
        [Id(Name = "IdDetalleEstudiante", Column = "IdDetalleEstudiante", Type = "int"), Generator(1, Class = "identity")]
        public virtual int IdDetalleEstudiante { get; set; }
        public virtual string Domicilio { get; set; }
        public virtual string Telefono { get; set; }
        public virtual string email { get; set; }

        [ManyToOne(ClassType = typeof(Carrera), Column = "IdEstudiante", Name = "UnEstudiante", Unique = true)]
        public virtual Estudiante UnEstudiante { get; set; }
    }
}
