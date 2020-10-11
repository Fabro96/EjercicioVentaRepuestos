using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucion.LibreriaNegocio
{
    public class Categoria
    {
        //ATRIBUTOS
        private int _codigo;
        private string _nombre;

        //CONSTRUCTORES
        public Categoria() { }
        public Categoria(int codigo, string nombre)
        {
            this._codigo = codigo;
            this._nombre = nombre;
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

        //MÉTODOS
    }
}
