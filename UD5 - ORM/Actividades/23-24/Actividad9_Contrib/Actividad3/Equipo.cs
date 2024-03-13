using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Actividad3
{
    [Table ("Equipos")]
    public class Equipo
    {
        private string codigo;
        private string nombre;
        private string pais;
        private int goles;
        private int puntos;
        private string pJ;
        private int pG;
        private int pE;
        private int pP;
        private string estadio;
        private string ciudad;

        [ExplicitKey] public string Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Pais { get => pais; set => pais = value; }
        public int Goles { get => goles; set => goles = value; }
        public int Puntos { get => puntos; set => puntos = value; }
        public string PJ { get => pJ; set => pJ = value; }
        public int PG { get => pG; set => pG = value; }
        public int PE { get => pE; set => pE = value; }
        public int PP { get => pP; set => pP = value; }
        public string Estadio { get => estadio; set => estadio = value; }
        public string Ciudad { get => ciudad; set => ciudad = value; }

        public Equipo(string codigo, string nombre, string pais, int goles, int puntos, string pJ, int pG, int pE, int pP, string estadio, string ciudad)
        {
            Codigo = codigo;
            Nombre = nombre;
            Pais = pais;
            Goles = goles;
            Puntos = puntos;
            PJ = pJ;
            PG = pG;
            PE = pE;
            PP = pP;
            Estadio = estadio;
            Ciudad = ciudad;
        }

        public Equipo(string codigo, string nombre, string pais, string estadio, string ciudad)
        {
            Codigo = codigo;
            Nombre = nombre;
            Pais = pais;
            Estadio = estadio;
            Ciudad = ciudad;
        }

        public override string ToString()
        {
            return this.Nombre;
        }
    }
}
