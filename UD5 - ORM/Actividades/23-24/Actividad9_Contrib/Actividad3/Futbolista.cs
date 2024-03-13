using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Actividad3
{
    [Table ("Futbolistas")]
    public class Futbolista
    {
        private string codigo;
        private string nombre;
        private string codigoEquipo;
        private string posicion;
        private int edad;
        private int goles;
        private int tA;
        private int tR;
        private int minutos;
        private string precioMercado;
        private int dorsal;
        private int peso;

        [ExplicitKey] public string Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string CodigoEquipo { get => codigoEquipo; set => codigoEquipo = value; }
        public string Posicion { get => posicion; set => posicion = value; }
        public int Edad { get => edad; set => edad = value; }
        public int Goles { get => goles; set => goles = value; }
        public int TA { get => tA; set => tA = value; }
        public int TR { get => tR; set => tR = value; }
        public int Minutos { get => minutos; set => minutos = value; }
        public string PrecioMercado { get => precioMercado; set => precioMercado = value; }
        public int Dorsal { get => dorsal; set => dorsal = value; }
        public int Peso { get => peso; set => peso = value; }

        public Futbolista()
        {
        }

        public Futbolista(string codigo, string nombre, string codigoEquipo, string posicion, int edad, int goles, int tA, int tR, int minutos, string precioMercado, int dorsal, int peso)
        {
            Codigo = codigo;
            Nombre = nombre;
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

        public Futbolista(string codigo, string nombre, string codigoEquipo, string posicion, int edad, int dorsal)
        {
            Codigo = codigo;
            Nombre = nombre;
            CodigoEquipo = codigoEquipo;
            Posicion = posicion;
            Edad = edad;
            Dorsal = dorsal;
        }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
