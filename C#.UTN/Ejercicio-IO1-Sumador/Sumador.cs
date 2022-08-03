﻿ using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio19_Sumador
{
    public class Sumador
    {
        private int cantidadSumas;

        public Sumador(int cantidadSumas)
        {
            this.cantidadSumas = cantidadSumas;
        }
        public Sumador() : this(0)
        {

        }

        public int GetCantidadSumas()
        {
            return cantidadSumas;
        }
        public long Sumar(long a, long b)
        {
            cantidadSumas++;
            return a + b;
        }
        public string Sumar(string a, string b)
        {
            cantidadSumas += 1;
            return a + b;
        }

        public static explicit operator int(Sumador s)
        {
            return s.cantidadSumas;
        }

        public static long operator +(Sumador sumador1, Sumador sumador2)
        {
            return sumador1.cantidadSumas + sumador2.cantidadSumas;
        }
        public static bool operator -(Sumador sumador1, Sumador sumador2)
        {
            return sumador1.cantidadSumas == sumador2.cantidadSumas;
        }

    }
}
