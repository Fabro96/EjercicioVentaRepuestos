using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Solucion.LibreriaNegocio
{
    public class Repuesto
    {
        //ATRIBUTOS
        private int _codigo;
        private string _nombre;
        private double _precio;
        private int _stock;
        private Categoria _categoria;

        //CONSTRUCTORES
        public Repuesto() { }
        public Repuesto(int codigo, string nombre, double precio, int stock)
        {
            this._codigo = codigo;
            this._nombre = nombre;
            this._precio = precio;
            this._stock = stock;
            this._categoria = new Categoria();
        }

        //PROPIEDADES
        public int Codigo
        {
            set { _codigo = value; }
            get { return _codigo;  }
        }
        public string Nombre
        {
            set { _nombre = value; }
            get { return _nombre;  }
        }
        public double Precio
        {
            set { _precio = value; }
            get { return _precio;  }
        }
        public int Stock
        {
            get { return _stock; }
        }
        public Categoria Categoria
        {
            set { _categoria = value; }
            get { return _categoria;  }
        }
        //MÉTODOS
        public override string ToString()
        {
            return base.ToString();
        }

    }
}
