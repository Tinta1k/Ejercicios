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
            Arreglos imprime = new Arreglos();
            string[] vector1 = { "Hola", "Mundo", "C#", "es", "divertido", "y", "poderoso", "para", "programar", "!!" };
            imprime.OrdenarInverso(vector1);
            Console.ReadKey();
        }
    }
}
