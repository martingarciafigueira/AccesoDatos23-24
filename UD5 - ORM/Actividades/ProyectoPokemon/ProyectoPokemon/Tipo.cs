using PetaPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPokemon
{
	[TableName("tipo")]
	[PrimaryKey("id_tipo", AutoIncrement = true)]
	public class Tipo
	{
		int id_tipo;
		string nombre;
		int id_tipo_ataque;

		public Tipo()
		{
		}

		public Tipo(int id_tipo, string nombre, int id_tipo_ataque)
		{
			this.Id_tipo = id_tipo;
			this.Nombre = nombre;
			this.Id_tipo_ataque = id_tipo_ataque;
		}

		public int Id_tipo { get => id_tipo; set => id_tipo = value; }
		public string Nombre { get => nombre; set => nombre = value; }
		public int Id_tipo_ataque { get => id_tipo_ataque; set => id_tipo_ataque = value; }

		public override bool Equals(object obj)
		{
			return obj is Tipo tipo && id_tipo == tipo.id_tipo;
		}

		public override string ToString()
		{
			return this.nombre;
		}
	}
}
