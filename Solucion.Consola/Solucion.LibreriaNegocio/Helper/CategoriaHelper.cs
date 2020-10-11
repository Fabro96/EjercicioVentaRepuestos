using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Solucion.LibreriaNegocio
{
    public static class CategoriaHelper
    {
        private static List<Categoria> _listaCategoria;

        static CategoriaHelper()
        {
            _listaCategoria = new List<Categoria>();

            _listaCategoria.Add(new Categoria(1, "Motor"));
            _listaCategoria.Add(new Categoria(2, "Accesorios"));
            _listaCategoria.Add(new Categoria(3, "Ruedas"));

        }

        public static List<Categoria> GetCategorias()
        {
            return _listaCategoria;
        }

        public static Categoria GetCategoriaPorCodigo(int codigoCat)
        {
            Categoria cat = null;

            foreach(Categoria c in _listaCategoria)
            {
                if (c.Codigo == codigoCat)
                    cat = c;
            }

            if (cat == null)
                throw new CategoriaInexistenteException("Categoria Inexistente");

            return cat;
        }
    }
}
