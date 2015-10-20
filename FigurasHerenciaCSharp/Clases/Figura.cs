using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasHerenciaCSharp.Clases
{
    public abstract class Figura
    {

        #region Propiedades

        public string Nombre { get; set; }

        #endregion


        #region Constructores

        protected Figura()
        {
            Nombre = "";
        }

        protected Figura(string nombre)
        {
            Nombre = nombre;
        }

        #endregion


        #region Metodos

        public abstract string Detalles();
        public abstract double Area();
        public abstract double Perimetro();

        #endregion

    }
}
