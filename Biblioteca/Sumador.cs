using System;

namespace Biblioteca
{
    public class Sumador
    {
        private int cantidadSumas;

        public Sumador(int cantSumas)
        {
            this.cantidadSumas = cantSumas;
        }
        public Sumador(): this(0)
        {
        }
        public int GetCantSumas()
        {
            return cantidadSumas;
        }
        public long Sumar(long a, long b)
        {
            this.cantidadSumas++;
            return a+b;
        }
        
        public string Sumar (string a, string b)
        {
            this.cantidadSumas++;

            return a+b;
        }

        public static explicit operator int(Sumador s1)
        {
            return s1.cantidadSumas;
        }

        public static long operator + (Sumador s1, Sumador s2)
        {
            return s1.cantidadSumas + s2.cantidadSumas;
        }

        public static bool operator |(Sumador s1, Sumador s2)
        {
            if (s1.cantidadSumas == s2.cantidadSumas)
            {
                return true;
            }
            return false;
        }
        /*
        private int cantidadSumas;

        public Sumador(int cantidadSumas)
        {
            this.cantidadSumas = cantidadSumas;
        }

        public Sumador ():this(0)
        {
        }

        public int Sumar(int cantidadSumas)
        {
            return this.cantidadSumas = cantidadSumas + 1;
        }
        public static long Sumar(long suma1, long suma2)
        {
            return suma1 + suma2;
        }
        public static string Sumar(string suma1, string suma2)
        {
            return $"{suma1}" + "${suma2}";
        }
        */

    }
}
