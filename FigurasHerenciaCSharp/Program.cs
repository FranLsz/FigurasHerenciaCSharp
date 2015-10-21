using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FigurasHerenciaCSharp.Clases;

namespace FigurasHerenciaCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciamiento de objetos
            Circulo c1 = new Circulo();
            c1.Nombre = "miCirculo";
            c1.Radio = 4.566;

            Rectangulo r1 = new Rectangulo("miRectangulo", 20, 40);
            
            // Polimorfismo
            Figura f1 = c1;
            Figura f2 = r1;

            //se muestran por consola
            Console.WriteLine(c1.Detalles());
            Console.WriteLine(r1.Detalles());

            f1.ObtenerInfo(f1);
            f2.ObtenerInfo(f2);

            Console.ReadLine();
        }
    }
}
