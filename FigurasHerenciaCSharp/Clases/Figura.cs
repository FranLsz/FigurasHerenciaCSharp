using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasHerenciaCSharp.Clases
{
    public abstract class Figura
    {
        public string Nombre { get; set; }

        protected Figura()
        {
            Nombre = "";
        }

        protected Figura(string nombre)
        {
            Nombre = nombre;
        }


        public abstract string Detalles();
        public abstract double Area();
        public abstract double Perimetro();

    }
}
