using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad3
{
    public class Futbolista
    {
        private string Codigo { get; set; }
        private string Nombre { get; set; }
        private string Equipo { get; set; }
        private string CodigoEquipo { get; set; }
        private string Posicion { get; set; }
        private int Edad { get; set; }
        private int Goles { get; set; }
        private int TA { get; set; }
        private int TR { get; set; }
        private int Minutos { get; set; }
        private string PrecioMercado { get; set; }
        private int Dorsal { get; set; }
        private int Peso { get; set; }

        public Futbolista()
        {
        }

        public Futbolista(string codigo, string nombre, string equipo, string codigoEquipo, string posicion, int edad, int goles, int tA, int tR, int minutos, string precioMercado, int dorsal, int peso)
        {
            Codigo = codigo;
            Nombre = nombre;
            Equipo = equipo;
            CodigoEquipo = codigoEquipo;
            Posicion = posicion;
            Edad = edad;
            Goles = goles;
            TA = tA;
            TR = tR;
            Minutos = minutos;
            PrecioMercado = precioMercado;
            Dorsal = dorsal;
            Peso = peso;
        }

        public Futbolista(string codigo, string nombre)
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
