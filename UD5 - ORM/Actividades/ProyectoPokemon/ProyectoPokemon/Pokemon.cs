using PetaPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPokemon
{
	[TableName("pokemon")]
	[PrimaryKey("numero_pokedex")]
	public class Pokemon
	{
		int numero_pokedex;
		string nombre;
		float peso;
		float altura;

		public Pokemon()
		{
		}

		public Pokemon(int numero_pokedex, string nombre, float peso, float altura)
		{
			this.Numero_pokedex = numero_pokedex;
			this.Nombre = nombre;
			this.Peso = peso;
			this.Altura = altura;
		}

		public int Numero_pokedex { get => numero_pokedex; set => numero_pokedex = value; }
		public string Nombre { get => nombre; set => nombre = value; }
		public float Peso { get => peso; set => peso = value; }
		public float Altura { get => altura; set => altura = value; }

		public override string ToString()
		{
			return this.Nombre;
		}
	}
}
