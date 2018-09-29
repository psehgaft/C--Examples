using System;
using System.Collections.Generic;
using System.Text;

namespace DemoQueue
{
    class Program
    {
        static Queue<int> cola = new Queue<int>();
        static void Main(string[] args)
        {

            cola.Enqueue(23);
            cola.Enqueue(856);
            cola.Enqueue(88888888);
            mostrarCola();

            int num = cola.Dequeue();
            Console.WriteLine("Objeto desencola: " + num);
            mostrarCola();

            Console.ReadLine();
        }
        public static void mostrarCola()
        {
            foreach (int x in cola)
            {
                Console.WriteLine("Elemento: " + x);
            }
        }
    }
}
