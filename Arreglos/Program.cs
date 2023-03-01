using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Arreglos;

namespace Arreglos
{
    class Program
    {
        static void Main(string[] args)
        {
            Arreglos llenar = new Arreglos();
            int[] arreglo = llenar();
            foreach (int num in arreglo)
            {
                Console.WriteLine(num);
            }
        }
    }
    }
}
