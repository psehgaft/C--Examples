using System;
using System.Collections.Generic;
using System.Text;

namespace DemoDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("A", "Asunto");
            dic.Add("T", "Trursielago");
            dic.Add("M", "Monotrema");
            dic.Add("S", "Sandia");

            mostrarDiccionario(dic);
            Console.ReadLine();
        }

        static void mostrarDiccionario(Dictionary<string, string> dic)
        {
            foreach (string s in dic.Keys)
            {
                Console.WriteLine("Key: " + s);
            }
            Console.WriteLine("************************************\n");
        }
        
    }
}
