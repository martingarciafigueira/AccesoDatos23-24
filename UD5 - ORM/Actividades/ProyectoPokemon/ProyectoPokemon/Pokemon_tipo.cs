using PetaPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPokemon
{
	[TableName("pokemon_tipo")]
	[PrimaryKey("numero_pokedex, id_tipo")]
	public class Pokemon_tipo
	{
		int numero_pokedex;
		int id_tipo;

		public Pokemon_tipo()
		{
		}

		public Pokemon_tipo(int numero_pokedex, int id_tipo)
		{
			this.Numero_pokedex = numero_pokedex;
			this.Id_tipo = id_tipo;
		}

		public int Numero_pokedex { get => numero_pokedex; set => numero_pokedex = value; }
		public int Id_tipo { get => id_tipo; set => id_tipo = value; }
	}
}
