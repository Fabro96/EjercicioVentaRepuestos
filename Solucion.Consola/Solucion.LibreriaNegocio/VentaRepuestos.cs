using System;
using System.Collections.Generic;
using System.Linq;
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
        //MÉTODOS
        public void AgregarRepuesto(Repuesto repuesto)
        {
            throw new NotImplementedException();
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

    }
}
