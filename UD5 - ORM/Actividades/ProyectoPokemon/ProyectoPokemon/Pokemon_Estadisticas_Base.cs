using PetaPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPokemon
{
    [TableName("estadisticas_base")]
    [PrimaryKey("numero_pokedex")]
    public class Pokemon_Estadisticas_Base
    {
        int numero_pokedex;
        int ps;
        int ataque;
        int defensa;
        int especial;
        int velocidad;

        public Pokemon_Estadisticas_Base()
        {
        }

        public Pokemon_Estadisticas_Base(int numero_pokedex, int ps, int ataque, int defensa, int especial, int velocidad)
        {
            this.Numero_pokedex = numero_pokedex;
            this.Ps = ps;
            this.Ataque = ataque;
            this.Defensa = defensa;
            this.Especial = especial;
            this.Velocidad = velocidad;
        }

        public int Numero_pokedex { get => numero_pokedex; set => numero_pokedex = value; }
        public int Ps { get => ps; set => ps = value; }
        public int Ataque { get => ataque; set => ataque = value; }
        public int Defensa { get => defensa; set => defensa = value; }
        public int Especial { get => especial; set => especial = value; }
        public int Velocidad { get => velocidad; set => velocidad = value; }
    }
}
