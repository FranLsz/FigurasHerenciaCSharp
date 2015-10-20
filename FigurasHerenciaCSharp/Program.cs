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
            Circulo c1= new Circulo();
            c1.Nombre = "miCirculo";
            c1.Radio = 4.566;

            Rectangulo r1 = new Rectangulo("miRectangulo", 20, 40);




            Console.WriteLine(c1.Detalles());
            Console.WriteLine(r1.Detalles());


            Console.ReadLine();
        }
    }
}
