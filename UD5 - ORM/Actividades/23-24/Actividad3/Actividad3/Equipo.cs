using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Actividad3
{
    class Equipo
    {
        private string Codigo { get; set; }
        private string Nombre { get; set; }
        private string Pais { get; set; }
        private int Goles { get; set; }
        private int Puntos { get; set; }
        private string PJ { get; set; }
        private int PG { get; set; }
        private int PE { get; set; }
        private int PP { get; set; }
        private string Estadio { get; set; }
        private string Ciudad { get; set; }

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

        public Equipo(string codigo, string nombre)
        {
            Codigo = codigo;
            Nombre = nombre;
        }

        public override string ToString()
        {
            return this.Nombre;
        }
    }
}
