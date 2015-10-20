using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasHerenciaCSharp.Clases
{
    class Rectangulo : Figura
    {
        public double Ancho { get; set; }
        public double Alto { get; set; }

        public Rectangulo() : base()
        {
            Ancho = 0;
            Alto = 0;
        }

        public Rectangulo(string nombre, double ancho, double alto) : base(nombre)
        {
            Nombre = nombre;
            Ancho = ancho;
            Alto = alto;
        }


        public override string Detalles()
        {
            return "El nombre del rectangulo es: " + Nombre + " X y su area es: " + Area();
        }

        public override double Area()
        {
            return Ancho * Alto;
        }

        public override double Perimetro()
        {
            return (2 * Ancho) + (2 * Alto);
        }
    }
}
