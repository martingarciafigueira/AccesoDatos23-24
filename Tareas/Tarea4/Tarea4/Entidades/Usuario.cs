using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Hago el mapeo Objeto-Relacional
using NHibernate.Mapping.Attributes;

namespace RibeiroMartinezAliciaTarea5.Entidades
{
    //Creo una clase de entidad Usuario

    //Hago que la clase sea serializable y creo las siguientes propiedades
    [Serializable]
    [Class(Schema = "dbo", Table = "Usuario", NameType = typeof(Usuario))]
    public class Usuario
    {
        //Defino IdUsuario como el ID y defino sus propiedades
        [Id(Name = "IdUsuario", Column = "IdUsuario", Type = "int"), Generator(1, Class = "identity")]
        public virtual int IdUsuario { get; set; }


        [Property(Column = "Nombre", Type = "string", NotNull = true)]
        public virtual string Nombre { get; set; }


        [Property(Column = "Apellidos", Type = "string", NotNull = true)]
        public virtual string Apellidos { get; set; }


        [Property(Column = "Email", Type = "string", NotNull = true)]
        public virtual string Email { get; set; }


        [Property(Column = "NombreUsuario", Type = "string", NotNull = true)]
        public virtual string NombreUsuario { get; set; }


        [Property(Column = "Contrasenha", Type = "string", NotNull = true)]
        public virtual string Contrasenha { get; set; }


    }
}
