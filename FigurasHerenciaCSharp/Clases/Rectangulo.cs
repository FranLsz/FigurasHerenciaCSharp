using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FigurasHerenciaCSharp.Interfaces;

namespace FigurasHerenciaCSharp.Clases
{
    class Rectangulo : Figura, ICalculosGeometricos, IComparable, IComparer
    {
        #region Propiedades

        public double Ancho { get; set; }
        public double Alto { get; set; }

        #endregion


        #region Constructores

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

        #endregion



        #region Metodos

        /*public override string Detalles()
        {
            return "El nombre del rectangulo es: " + Nombre + " X y su area es: " + Area();
        }*/

        public override double Area()
        {
            return Ancho * Alto;
        }

        public override double Perimetro()
        {
            return (2 * Ancho) + (2 * Alto);
        }

        #endregion

        public string Definicion { get; set; }
        public double CalcularMetros()
        {
            throw new NotImplementedException();
        }

        public double CalcularPrecioTotal(double precioMetro)
        {
            throw new NotImplementedException();
        }

        public void Representar()
        {
            throw new NotImplementedException();
        }

        public void Colorear(string color)
        {
            throw new NotImplementedException();
        }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }

        public int Compare(object x, object y)
        {
            throw new NotImplementedException();
        }
    }
}
