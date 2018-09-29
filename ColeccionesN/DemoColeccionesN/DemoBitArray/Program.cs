using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace DemoBitArray
{
    class Program
    {
        static void Main(string[] args)
        {
            BitArray bitsA = new BitArray(4, true);
            BitArray bitsB = new BitArray(4, false);
            bool[] valores = { true, false, false, true };
            BitArray bitsC = new BitArray(valores);

            BitArray aux = bitsA.Xor(bitsC);

            foreach (bool b in aux)
            {
                if (!b)
                    Console.Write("0 ");
                else Console.Write("1 ");
            }
            Console.ReadLine();
        }
    }
}
