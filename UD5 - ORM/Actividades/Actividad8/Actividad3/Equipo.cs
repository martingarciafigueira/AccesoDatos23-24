using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad3
{
    public class Equipo
    {
        string codigo;
        string nombre;
        string pais;
        int goles;
        int puntos;
        string pj;
        int pg;
        int pe;
        int pp;
        string estadio;
        string ciudad;

        public Equipo()
        {
        }

        public Equipo(string codigo, string nombre, string pais, int goles, int puntos, string pj, int pg, int pe, int pp, string estadio, string ciudad)
        {
            this.Codigo = codigo;
            this.Nombre = nombre;
            this.Pais = pais;
            this.Goles = goles;
            this.Puntos = puntos;
            this.Pj = pj;
            this.Pg = pg;
            this.Pe = pe;
            this.Pp = pp;
            this.Estadio = estadio;
            this.Ciudad = ciudad;
        }

        public string Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Pais { get => pais; set => pais = value; }
        public int Goles { get => goles; set => goles = value; }
        public int Puntos { get => puntos; set => puntos = value; }
        public string Pj { get => pj; set => pj = value; }
        public int Pg { get => pg; set => pg = value; }
        public int Pe { get => pe; set => pe = value; }
        public int Pp { get => pp; set => pp = value; }
        public string Estadio { get => estadio; set => estadio = value; }
        public string Ciudad { get => ciudad; set => ciudad = value; }

        public override string ToString()
        {
            return this.Nombre;
        }
    }
}
