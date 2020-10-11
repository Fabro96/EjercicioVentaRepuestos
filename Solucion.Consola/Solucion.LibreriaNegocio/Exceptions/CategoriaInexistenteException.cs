using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucion.LibreriaNegocio
{
    public class CategoriaInexistenteException : Exception
    {
        public CategoriaInexistenteException(string mensaje) : base(mensaje)
        {

        } 
    }
}
