using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasHerenciaCSharp.Interfaces
{
    public interface ICalculosGeometricos
    {
        String Definicion { get; set; }

        double CalcularMetros();
        double CalcularPrecioTotal(double precioMetro);
        void Representar();
        void Colorear(string color);

    }
}
