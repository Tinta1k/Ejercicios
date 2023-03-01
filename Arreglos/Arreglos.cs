using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreglos
{
    internal class Arreglos
    {
        public void ejercicio4()
        {
            int num;
            int[] vectormen = new int[10];
            Console.WriteLine("Ingrese los respectivos 10 números");
            for (int i = 0; i < 10; i++)
            {
                num = int.Parse(Console.ReadLine());
                vectormen[i] = num;
            }
            Array.Sort(vectormen);

            foreach (int numero in vectormen)
            {
                Console.Write(numero + " ");
            }
            Console.WriteLine(" ");
            Console.WriteLine("Presiona cualquier tecla para salir...");
            Console.ReadLine();
        }


    }
}
