using PetaPoco;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPokemon
{
	public partial class Form1 : Form
	{
		Database db;
		public Form1()
		{
			InitializeComponent();
			db = new PetaPoco.Database("conexionPokemon");
			List<Tipo> tipos = GetListaTipos();
			lstTiposPokemon.DataSource = tipos;
		}

		private void btnMostrarPokemon_Click(object sender, EventArgs e)
		{
			Tipo[] tiposSeleccionados = lstTiposPokemon.SelectedItems.Cast<Tipo>().ToArray();

			if (txtPesoMayor.Text == "")
			{
                float pesoMenor, pesoMayor;
                float.TryParse(txtPesoMenor.Text, out pesoMenor);
                float.TryParse(txtPesoMayor.Text, out pesoMayor);
                lstPokemon.DataSource = GetListaPokemonInRangoKilos(pesoMenor, pesoMayor);
			}
			if (txtPSMenor.Text != "" && txtPSMayor.Text != "")
			{
				int psMenor, psMayor;

				int.TryParse(txtPSMenor.Text, out psMenor);
				int.TryParse(txtPSMayor.Text, out psMayor);

				lstPokemon.DataSource = GetListaPokemonInRangoPS(psMenor, psMayor);
			}
			if (tiposSeleccionados.Length > 0)
			{
				lstPokemon.DataSource = GetListaPokemonByTipos(tiposSeleccionados);
            }
		}

		public List<Pokemon> GetListaPokemon()
		{
			return db.Fetch<Pokemon>();
		}

		public List<Pokemon> GetListaPokemonMenorKilos(float kilos)
		{
			return (List<Pokemon>)db.Fetch<Pokemon>().Where(x => x.Peso <= kilos).ToList();
		}

		public List<Pokemon> GetListaPokemonByTipo(Tipo tipoPokemon)
		{
			List<Pokemon> listaPokemonDelTipoElegido = new List<Pokemon>();
			List<Pokemon_tipo> pokemon_Tipos = db.Fetch<Pokemon_tipo>().Where(x => x.Id_tipo == tipoPokemon.Id_tipo).ToList();

			foreach (Pokemon_tipo pokemonTipo in pokemon_Tipos)
			{
				listaPokemonDelTipoElegido.Add(GetPokemonById(pokemonTipo.Numero_pokedex));
			}

			return listaPokemonDelTipoElegido;
		}

        public List<Pokemon> GetListaPokemonByTipos(Tipo[] tiposPokemon)
        {
            List<Pokemon> listaPokemonDelTipoElegido = new List<Pokemon>();
            List<Pokemon_tipo> pokemon_Tipos = new List<Pokemon_tipo>();

            foreach (Tipo item in tiposPokemon)
			{
				listaPokemonDelTipoElegido.AddRange(GetListaPokemonByTipo(item));
            }

            return (List<Pokemon>) listaPokemonDelTipoElegido;
        }	

        public Pokemon GetPokemonById(int idPokemon)
		{
			return GetListaPokemon().Where(x => x.Numero_pokedex == idPokemon).FirstOrDefault();
		}

		public List<Pokemon> GetListaPokemonInRangoKilos(float kilosMenor, float kilosMayor)
		{
			return (List<Pokemon>)db.Fetch<Pokemon>().Where(x => x.Peso >= kilosMenor && x.Peso <= kilosMayor).ToList();
		}

        public List<Pokemon> GetListaPokemonInRangoPS(int psMenor, int psMayor)
        {
            List<Pokemon> listaPokemonPS = new List<Pokemon>();
            List<int> listaNumPokedex = new List<int>();

            listaNumPokedex = (List<int>)db.Fetch<Pokemon_Estadisticas_Base>().Where(x => x.Ps >= psMenor && x.Ps <= psMayor).Select(x=> x.Numero_pokedex).ToList();

			foreach (int numpokedex in listaNumPokedex)
			{
				listaPokemonPS.Add(GetPokemonById(numpokedex));
			}

			return listaPokemonPS;
        }

        public List<Tipo> GetListaTipos()
		{
			return db.Fetch<Tipo>();
		}
	}
}
