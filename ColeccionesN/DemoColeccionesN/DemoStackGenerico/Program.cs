using System;
using System.Collections.Generic;
using System.Text;

namespace DemoStackGenerico
{
    class Program
    {
        static Stack<int> pila = new Stack<int>();
        static void Main(string[] args)
        {
            
            // La siguente linea genera un error devido 
            // a que se esta susando una PILA generica
            //pila.Push("No me acuerdo");
            pila.Push(34);
            pila.Push(456);
            pila.Push(3);
            pila.Push(11);
            Console.WriteLine(mostrarPila());
            
            // Desapilando un entero
            pila.Pop();
            Console.WriteLine(mostrarPila());
            Console.ReadLine();
        }

        static public string mostrarPila()
        {
         StringBuilder sb =  new StringBuilder();
         foreach (int x in pila)
            {
                sb.Append(x.ToString()+ " ");
            }
         return sb.ToString();
        }
    }
}
