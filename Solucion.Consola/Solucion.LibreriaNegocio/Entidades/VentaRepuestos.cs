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
        public void QuitarRepuesto(int codigo)
        {
            throw new NotImplementedException();
        }
        public void ModificarPrecio(int codigo, double precio)
        {
            throw new NotImplementedException();
        }
        public void AgregarStock(int i, int ii)
        {
            throw new NotImplementedException();
        }
        public List<Repuesto> TraerPorCategoria(int codigo)
        {
            throw new NotImplementedException();
        }
        public void ListarRepuestos()
        {
            foreach(Repuesto repuesto in _listaProductos)
            {
                Console.WriteLine(repuesto.ToString());
            }

        }

    }
}
