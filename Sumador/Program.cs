using System;
using Biblioteca;

namespace ConsolaSumador
{
    class Program
    {
        static void Main(string[] args)
        {
            Sumador s1 = new Sumador(5);
            Sumador s2 = new Sumador();

            Console.WriteLine(s1.Sumar(5, 5));
            //int cantSuma1 = (int)s1;
            //Console.WriteLine($"Cant Sumas: {s1.GetCantSumas()}");
            Console.WriteLine(s2.Sumar("Hola", "mundo"));
           // int cantSuma2 = (int)s2;
            ((Console.WriteLine($"Cant Sumas: {s2.GetCantSumas()}");

            Console.WriteLine(s1 + s2);
            Console.WriteLine(s1 + s2);

            /*
            Sumador suma1 = new Sumador();
            
            suma1.Sumador(5);
            suma1.Sumar

            
            
            Console.WriteLine("Hello World!");
            */
        }
    }
}
