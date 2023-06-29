using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class RepositorioArticulos
    {
        private Modelo _repositorio;

        public RepositorioArticulos()
        {
            _repositorio = new Modelo();
        }

        public Articulo Uno(int idArticuloPar)
        {
            return _repositorio.Articulos.Where(x => x.Id == idArticuloPar).FirstOrDefault();
        }

        public List<Articulo> BuscarArticulos(string nombreArticuloPar)
        {
            List<Articulo> Lista = new List<Articulo>();

            Lista = _repositorio.Articulos.Where(x => x.Descripcion.Contains(nombreArticuloPar) && x.Febaj == null).ToList();

            return Lista;

        }

        public void ActualizarStock(int idArticuloPar, decimal stockDescontarPar)
        {
            Articulo articulo = (from a in _repositorio.Articulos
                                  where a.Id == idArticuloPar
                                  && a.Febaj == null
                                  select a).FirstOrDefault();

            if(articulo != null)
            {
                articulo.Stock = articulo.Stock - stockDescontarPar;
                _repositorio.SaveChanges();
            }
        }
    }
}
