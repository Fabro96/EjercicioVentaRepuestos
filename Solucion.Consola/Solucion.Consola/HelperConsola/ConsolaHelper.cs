using System;
using System.Text.RegularExpressions;
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

        public static string PedirNombreRepuesto()
        {
            string s;
            Console.WriteLine("\nIngrese el nombre del repuesto");
            Regex expresion = new Regex("^[a-zA-Z]+$");
            s = Console.ReadLine();
            while (!expresion.IsMatch(s))
            {
                Console.WriteLine("\nIntentelo nuevamente por favor. Recuerde que solo se aceptan letras o palabras.");
                s = Console.ReadLine();
            }
            return s.ToUpper();
        }
        public static int PedirCodigoRepuesto(int min, int max)
        {
            int res;
            Console.WriteLine("\nIngrese el código del repuesto: ");
            do
            {
                if (!int.TryParse(Console.ReadLine(), out res))
                {
                    Console.WriteLine("\nIngrese un código válido por favor. Puede ser un número entre 0 y 999999");
                    res = -1;
                }

            } while (res < min || res > max);
            return res;
        }
        public static double PedirPrecio(double min, double max)
        {
            double res;
            Console.WriteLine("\nIngrese el precio del Repuesto: ");
            do
            {
                if (!double.TryParse(Console.ReadLine(), out res))
                {
                    Console.WriteLine("\nIngrese el precio nuevamente por favor.");
                    res = -1;
                }
            } while (res < min || res > max);
            return res;
        }
        public static int PedirCodigoCategoria(int min, int max)
        {
            int res;
            Console.WriteLine("\nIngrese el número de la Categoria del Repuesto\n" +
                              "1 - Motor\n" +
                              "2 - Accesorio\n" +
                              "3 - Ruedas\n");
            do
            {
                if (!int.TryParse(Console.ReadLine(), out res))
                {
                    Console.WriteLine("\nIngrese una opción válida por favor. Recuede\n" +
                                      "1 - Motor\n" +
                                      "2 - Accesorio\n" +
                                      "3 - Ruedas\n");
                    res = -1;
                }

            } while (res < min || res > max);
            return res;
        }
        public static int PedirStock(int min, int max)
        {
            int res;
            Console.WriteLine("\nIngrese cuanto stock del repuesto está ingresando: ");
            do
            {
                if (!int.TryParse(Console.ReadLine(), out res))
                {
                    Console.WriteLine("\nIngrese el número debe estar entre 1 y 999999");
                    res = -1;
                }

            } while (res < min || res > max);
            return res;
        }
    }
}
    
