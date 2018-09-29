using System;
using System.Collections.Generic;
using System.Text;
using MiLibreria;

namespace Casa
{
   public class Program
    {
        static void Main(string[] args)
        {
            Persona p = new Persona("Heber", "Romero", "Tellez", 23);
            Console.WriteLine("Mi nombre es: " + p.PropiedadNombre);
            Console.ReadLine();

        }
    }
}
