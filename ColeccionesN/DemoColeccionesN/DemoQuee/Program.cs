using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace DemoQuee
{
    class Program
    {
        static Queue cola = new Queue();
        static void Main(string[] args)
        {
            
            cola.Enqueue(23);
            cola.Enqueue("Hola");
            cola.Enqueue(345.567);
            
            object obj = cola.Dequeue();
            Console.WriteLine("Objeto desencola: " + obj);
            mostrarCola();
            
            Console.ReadLine();
        }
        public static void mostrarCola()
        {
            foreach (object x in cola)
            {
                Console.WriteLine("Elemento: " + x);
            }
        }
    }
}
