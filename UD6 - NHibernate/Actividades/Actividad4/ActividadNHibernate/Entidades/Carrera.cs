using NHibernate.Mapping.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadNHibernate.Entidades
{
    [Serializable]
    [Class(Schema = "dbo", Table = "Carrera", NameType = typeof(Carrera))]
    public class Carrera
    {
        [Id(Name = "IdCarrera", Column = "IdCarrera", Type = "int"), Generator(1, Class = "identity")]
        public virtual int IdCarrera { get; set; }
        [Property(Column = "NombreCarrera", Type = "string", NotNull = true)]
        public virtual String NombreCarrera { get; set; }

        [ManyToOne(ClassType = typeof(Instituto), OuterJoin = OuterJoinStrategy.True)]
        public virtual Instituto UnInstituto { get; set; }
    }
}
