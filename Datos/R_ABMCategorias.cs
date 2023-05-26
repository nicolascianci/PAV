using Dominio;
using Dominio.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class R_ABMCategorias
    {
        private Modelo repositorio;

        public R_ABMCategorias()
        {
            repositorio = new Modelo();
        }

        public List<categoria> Todas_Categorias()
        {
            List<categoria> _lista = new List<categoria>();
            _lista = (from a in repositorio.categorias
                     where a.febaj == null                     
                     select a).ToList();

            return _lista;
        }
        

        public void Agregar_Categoria(categoria categoria_par)
        {
            categoria_par.fealt = DateTime.Now;
            repositorio.categorias.Add(categoria_par);
            repositorio.SaveChanges();
        }

        public void Modificar_Categoria(categoria categoria_par)
        {
            var _categoria = repositorio.categorias.Where(x => x.id == categoria_par.id).FirstOrDefault();

            _categoria.Nombre = categoria_par.Nombre;
            _categoria.femod = DateTime.Now;

            repositorio.SaveChanges();
        }

        public void Eliminar_Categoria(categoria categoria_par)
        {
            var _categoria = repositorio.categorias.Where(x => x.id == categoria_par.id).FirstOrDefault();

            _categoria.febaj = DateTime.Now;

            repositorio.SaveChanges();
        }


        public List<categoria> Buscar_Categorias(string nombre_categoria_par)
        {
            

            List<categoria> query = (from a in repositorio.categorias
                                    where a.febaj == null
                                    && a.Nombre.Contains(nombre_categoria_par)
                                    select a).ToList();

            return query;
        }
    }
}
