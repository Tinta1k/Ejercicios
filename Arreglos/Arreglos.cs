using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreglos
{
    internal class Arreglos
    {
        static void sumadenotas()
        {
            int[] notas = new int[4];
            int sumador = 0;
            
            int numeros;
            Console.WriteLine("Numeros");
            for (int j = 0; j < 5; j++)
            { 
                numeros = int.Parse(Console.ReadLine());
                notas[j] = numeros;
                sumador += numeros;
            }
            

            sumador = sumador / 5;
            Console.WriteLine(sumador);



        }
    }
}
