using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace DemoHashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable tabla = new Hashtable();
            tabla.Add("200706524", "Heber Romero");
            tabla.Add("200709939", "Erick Vicente");
            tabla.Add("200507587", "Alexander Arriaga");

            foreach (string s in tabla.Values)
            {
                Console.WriteLine("Nombre: " + s);
            }
            
            Console.WriteLine(tabla["200706524"].ToString());

            Console.ReadLine();
        }
    }
}
