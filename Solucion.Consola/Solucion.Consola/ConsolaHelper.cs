using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucion.Consola
{
    public static class ConsolaHelper
    {
        public static int OpcionMenu(int min, int max)
        {
            int res;
            Console.WriteLine("Ingrese la opción que desee utilizar: ");
            do
            {
                if (!int.TryParse(Console.ReadLine(), out res))
                {
                    Console.WriteLine("\nIngrese una opción válida por favor.");
                    res = -1;
                }
            } while (res < min || res > max);
            return res;
        }
    }
}
