using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasHerenciaCSharp.Clases
{
    class Circulo : Figura
    {

        #region Propiedades

        public double Radio { get; set; }

        #endregion


        #region Constructores

        public Circulo() : base()
        {
            Radio = 0;
        }

        public Circulo(string nombre, double radio) : base(nombre)
        {
            Nombre = nombre;
            Radio = radio;
        }

        #endregion


        #region Metodos

        //sealed impide que se sobreescriba el metodo en los hijos de Circulo
        public sealed override string Detalles()
        {
            return "El nombre del circulo es: " + Nombre + " y su area es: " + Area();
        }

        public override double Area()
        {
            return Math.PI * Math.Pow(Radio, 2);
        }

        public override double Perimetro()
        {
            return 2 * Math.PI * Radio;
        }

        

        #endregion

    }
}
