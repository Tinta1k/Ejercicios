using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreglos
{
    internal class Arreglos{

        public void OrdenarInverso(string[] vector)
        {
            Array.Sort(vector);
            string[] vector2 = new string[10];
            for (int i = vector.Length - 1, j = 0; i >= 0; i--, j++)
            {
                vector2[j] = vector[i];
            }
            Console.WriteLine("Elementos en orden inverso:");
            foreach (string elem in vector2)
            {
                Console.WriteLine(elem);
            }
        }
    }
}
