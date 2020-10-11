using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Solucion.LibreriaNegocio
{
    public class VentaRepuestos
    {
        //ATRIBUTOS
        private List<Repuesto> _listaProductos;
        private string _nombre;
        private string _direccion;

        //CONSTRUCTORES
        public VentaRepuestos() { }
        public VentaRepuestos(string nombre, string direccion)
        {
            this._nombre = nombre;
            this._direccion = direccion;
            this._listaProductos = new List<Repuesto>();
        }

        //PROPIEDADES
        public List<Repuesto> Productos
        {
            get { return _listaProductos; }
        }
        public string Nombre
        {
            set { _nombre = value; }
            get { return _nombre;  }
        }
        public string Direccion
        {
            set { _nombre = value; }
            get { return _nombre;  }
        }
        public int TieneRepuesto
        {
            get { return _listaProductos.Count; }
        }
        //MÉTODOS
        public void AgregarRepuesto(int codigo, string nombre, double precio, int stock, int codigoCategoria)
        {
            
            Repuesto repuesto = new Repuesto(codigo, nombre, precio, stock, codigoCategoria);

            this._listaProductos.Add(repuesto);

        }
        public void QuitarRepuesto(int codigoRepuesto)
        {
            Repuesto repuesto = this._listaProductos.SingleOrDefault(x => x.Codigo == codigoRepuesto);

            if(repuesto != null)
            {
                this._listaProductos.Remove(repuesto);
            }
            else
            {
                throw new CodigoInexistenteException("El código que ingresó no se encuentra en la lista.");
            }
        }
        public void ModificarPrecio(int codigoRepuesto, double precio)
        {
            
            foreach(Repuesto repuesto in _listaProductos)
            {
                if (repuesto != null && repuesto.Codigo == codigoRepuesto)
                {
                    repuesto.Precio = precio;
                }
                else
                {
                    throw new CodigoInexistenteException("El código que ingresó no se encuentra en la lista.");
                }

            }

            //if(repuesto != null)
            //{
            //    repuesto.Precio = precio;
            //}
            //else
            //{
            //    throw new CodigoInexistenteException("El código que ingresó no se encuentra en la lista.");
            //}
        }
        public void AgregarStock(int i, int ii)
        {
            throw new NotImplementedException();
        }
        //public List<Repuesto> TraerPorCategoria(int codigoCategoria)
        //{
        //    //Repuesto repuesto = this._listaProductos.SingleOrDefault(x => x.Categoria.Codigo == codigoCategoria);

        //    foreach(Repuesto repuesto in _listaProductos)
        //    {
        //        if(repuesto.Categoria.Codigo == codigoCategoria)
        //        {
        //            return _listaProductos;
        //        }
        //    }
            

        //}
        public void ListarRepuestos()
        {
            foreach(Repuesto repuesto in _listaProductos)
            {
                Console.WriteLine(repuesto.ToString());
            }

        }

    }
}
