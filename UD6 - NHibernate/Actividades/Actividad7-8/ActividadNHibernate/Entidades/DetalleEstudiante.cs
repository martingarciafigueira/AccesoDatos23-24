using NHibernate.Mapping.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadNHibernate.Entidades
{
    [Serializable]
    [Class(Schema = "dbo", Table = "DetalleEstudiante", NameType = typeof(DetalleEstudiante))]
    public class DetalleEstudiante
    {
        [Id(Name = "IdDetalleEstudiante", Column = "IdDetalleEstudiante", Type = "int"), Generator(1, Class = "identity")]
        public virtual int IdDetalleEstudiante { get; set; }
        [Property(Column = "DomicilioEstudiante", Type = "string")]
        public virtual String DomicilioEstudiante { get; set; }
        [Property(Column = "TelefonoEstudiante", Type = "string")]
        public virtual String TelefonoEstudiante { get; set; }
        [Property(Column = "CorreoElectronicoEstudiante", Type = "string")]
        public virtual String CorreoElectronicoEstudiante { get; set; }

        [ManyToOne(ClassType = typeof(Estudiante), Column = "idEstudiante", Name = "UnEstudiante", Unique = true)]
        public virtual Estudiante UnEstudiante { get; set; }
    }
}
