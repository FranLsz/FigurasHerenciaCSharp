﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasHerenciaCSharp.Clases
{
    class Circulo : Figura
    {
        public double Radio { get; set; }

        public Circulo() : base()
        {
            Radio = 0;
        }

        public Circulo(string nombre, double radio) : base(nombre)
        {
            Nombre = nombre;
            Radio = radio;
        }

        public override string Detalles()
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
    }
}