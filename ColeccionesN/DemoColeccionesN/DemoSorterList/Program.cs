using System;
using System.Collections.Generic;
using System.Text;

namespace DemoSorterList
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList<int, string> alumnos = new SortedList<int, string>();
            alumnos.Add(3, "Pancho");
            alumnos.Add(4, "Alex");
            alumnos.Add(5, "Chates");
            alumnos.Add(1, "Heber");
            alumnos.Add(2, "Erick");
            
            mostrarAlumnos(alumnos);
            alumnos.Remove(5);
            mostrarAlumnos(alumnos);
            Console.ReadLine();
        }

        public static void mostrarAlumnos(SortedList<int,string> temp)
        {
            foreach (string s in temp.Values)
            {
                Console.WriteLine("Nombre: " + s);
            }
            Console.WriteLine("********************************\n");
         }
    }
}
