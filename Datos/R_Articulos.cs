using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class R_Articulos
    {
        private Modelo repositorio;

        public R_Articulos()
        {
            repositorio = new Modelo();
        }

        public articulo Uno(int idarticulo_par)
        {
            return repositorio.articulos.Where(x => x.id == idarticulo_par).FirstOrDefault();
        }

        public List<articulo> Buscar_Articulos(string nombre_articulo_par)
        {
            List<articulo> lista_tmp = new List<articulo>();

            lista_tmp = repositorio.articulos.Where(x => x.Descripcion.Contains(nombre_articulo_par) && x.febaj == null).ToList();

            return lista_tmp;

        }

        public void Actualizar_Stock(int idarticulo_par, decimal stock_descontar_par)
        {
            articulo _articulo = (from a in repositorio.articulos
                                  where a.id == idarticulo_par
                                  && a.febaj == null
                                  select a).FirstOrDefault();

            if(_articulo != null)
            {
                _articulo.stock = _articulo.stock - stock_descontar_par;
                repositorio.SaveChanges();
            }
        }
    }
}
