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

        public virtual string Detalles()
        {
            return "El nombre de la figura es " + Nombre;
        }
        public abstract double Area();
        public abstract double Perimetro();

        public void ObtenerInfo(Figura f)
        {
            //devuelve la clase del objeto
            Console.WriteLine(f.GetType());

            //si la Figura es un Rectangulo
            if (f is Rectangulo)
            {
                Console.WriteLine("Esto es un rectangulo");
                var r = (Rectangulo)f;
                Console.WriteLine(r.Ancho);
            }
            //si es un circulo
            else if (f is Circulo)
            {
                Console.WriteLine("Esto es un circulo");
                var r = (Circulo)f;
                Console.WriteLine(r.Radio);

            }

            var area = f.Area();
        }
        #endregion

    }
}
