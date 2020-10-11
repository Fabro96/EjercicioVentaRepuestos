using System;
using Solucion.LibreriaNegocio;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucion.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            bool _continuarActivo = true;

            VentaRepuestos vtaRep = new VentaRepuestos("RE-PUESTO", "Warnes 666");

            Console.WriteLine("BIENVENIDO A " + vtaRep.Nombre + "!");
            Console.WriteLine("\nIngrese una tecla para pasar al Menú de Usuario.");
            Console.ReadKey();
            Console.Clear();

            do
            {
                Console.WriteLine("MENÚ DE USUARIO\n");
                Console.WriteLine("1 - AGREGAR REPUESTO\n" +
                                  "2 - QUITAR REPUESTO\n" +
                                  "3 - MODIFICAR PRECIO\n" +
                                  "4 - AGREGAR STOCK\n" +
                                  "5 - QUITAR STOCK\n" +
                                  "6 - LISTAR REPUESTOS POR CATEGORIA\n" +
                                  "7 - EXIT\n");
                try
                {
                    int opcion = ConsolaHelper.OpcionMenu(1, 7);
                    Console.Clear();

                    switch (opcion)
                    {
                        case 1:
                            Program.AgregarRepuesto(vtaRep);
                            break;
                        case 2:
                            Program.QuitarRepuesto(vtaRep);
                            break;
                        case 3:
                            Program.ModificarPrecio(vtaRep);
                            break;
                        case 4:
                            Program.AgregarStock(vtaRep);
                            break;
                        case 5:
                            Program.QuitarStock(vtaRep);
                            break;
                        case 6:
                            Program.ListarRepuestosPorCategoria(vtaRep);
                            break;
                        case 7:
                            Program.Exit();
                            _continuarActivo = false;
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Lo sentimos, hubo un error en la ejecución del programa. Mensaje: " + ex.Message);
                }
 
            } while (_continuarActivo == true);
        }
        public static void AgregarRepuesto(VentaRepuestos vtaRep)
        {
            throw new NotImplementedException();
        }
        public static void QuitarRepuesto(VentaRepuestos vtaRep)
        {
            throw new NotImplementedException();
        }
        public static void ModificarPrecio(VentaRepuestos vtaRep)
        {
            throw new NotImplementedException();
        }
        public static void AgregarStock(VentaRepuestos vtaRep)
        {
            throw new NotImplementedException();
        }
        public static void QuitarStock(VentaRepuestos vtaRep)
        {
            throw new NotImplementedException();
        }
        public static void ListarRepuestosPorCategoria(VentaRepuestos vtaRep)
        {
            throw new NotImplementedException();
        }
        public static void Exit()
        {
            Console.WriteLine("Gracias por haber utilizado la aplicación! Nos vemos la próxima!");
            Console.WriteLine("\nIngrese una tecla y saldrá del sistema.");
            Console.ReadKey();
        }
    }
}
