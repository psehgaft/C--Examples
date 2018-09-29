using System;
using System.Collections.Specialized;
using System.Text;

namespace DemoStringCollectionEspecial
{
    class Program
    {
        static void Main(string[] args)
        {
            StringCollection cadenas = new StringCollection();
            cadenas.Add("Cadena 1");
            cadenas.Add("Numero 2");
            cadenas.Add("Otra cadena");

            foreach (String s in cadenas)
            {
                Console.WriteLine("String: " + s);
            }
            
            /*for (int i = 0; i < cadenas.Count; i++)
            {
                Console.WriteLine("String )0)", i, cadenas);
            }*/

            Console.ReadLine();
        }
    }
}
