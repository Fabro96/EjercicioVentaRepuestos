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
                Console.Clear();
                Console.WriteLine("MENÚ DE USUARIO\n");
                Console.WriteLine("1 - AGREGAR REPUESTO\n" +
                                  "2 - QUITAR REPUESTO\n" +
                                  "3 - MODIFICAR PRECIO\n" +
                                  "4 - AGREGAR STOCK\n" +
                                  "5 - QUITAR STOCK\n" +
                                  "6 - LISTAR REPUESTOS POR CATEGORIA\n" +
                                  "7 - LISTAR REPUESTOS\n" +
                                  "8 - EXIT\n");
                try
                {
                    int opcion = ConsolaHelper.OpcionMenu(1, 8);
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
                            Program.ListarRepuestos(vtaRep);
                            break;
                        case 8:
                            Program.Exit();
                            _continuarActivo = false;
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("\nLo sentimos, hubo un error en la ejecución del programa. Mensaje: " + ex.Message);
                }
 
            } while (_continuarActivo == true);
        }
        public static void AgregarRepuesto(VentaRepuestos vtaRep)
        {
            try
            {
                Console.WriteLine("AGREGAR REPUESTO");
                
                int codigo = ConsolaHelper.PedirCodigoRepuesto(0, 999999);
                string nombre = ConsolaHelper.PedirNombreRepuesto();
                double precio = ConsolaHelper.PedirPrecio(0, 999999);
                int stock = ConsolaHelper.PedirStock(1, 999999);
                int codigoCategoria = ConsolaHelper.PedirCodigoCategoria(1, 3);

                vtaRep.AgregarRepuesto(codigo, nombre, precio, stock, codigoCategoria);

                Console.WriteLine("\nEl Repuesto fue incorporado correctamente!");
                Console.WriteLine("\nIngrese una tecla para volver al Menú Principal.");
            }
            catch (CategoriaInexistenteException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("\nIngrese una tecla para volver al Menú Principal.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("\nLo sentimos, hubo un error en la ejecución del programa. Mensaje: " + ex.Message);
                Console.WriteLine("\nIngrese una tecla para volver al Menú Principal.");
            }
            Console.ReadKey();
            
        }
        public static void QuitarRepuesto(VentaRepuestos vtaRep)
        {

            try
            {
                if (vtaRep.TieneRepuesto > 0)
                {
                    vtaRep.ListarRepuestos();
                }
            }
            catch (NotImplementedException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
  
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
        public static void ListarRepuestos(VentaRepuestos vtaRep)
        {
            try
            {
                if (vtaRep.TieneRepuesto > 0)
                {
                    foreach(Repuesto repuesto in vtaRep.Productos)
                    {
                        Console.WriteLine(repuesto.ToString());
                    }
                }
                else
                {
                    throw new SinStockException("No hay stock de respuestos para mostrar en estos momentos.");
                }
            }
            catch (SinStockException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
            
        }
        public static void Exit()
        {
            Console.WriteLine("Gracias por haber utilizado la aplicación! Nos vemos la próxima!");
            Console.WriteLine("\nIngrese una tecla y saldrá del sistema.");
            Console.ReadKey();
        }
    }
}
