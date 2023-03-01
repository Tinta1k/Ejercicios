using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreglos
{
    internal class Arreglos
    {
        public static int[] LlenarArreglo()
        {
            Random rnd = new Random();
            int[] arreglo = new int[10];
            for (int i = 0; i < arreglo.Length; i++)
            {
                arreglo[i] = rnd.Next(5, 101);
            }
            return arreglo;
        }
    }
}
