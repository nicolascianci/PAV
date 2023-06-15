using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class RepositorioABMCategorias
    {
        private Modelo _repositorio;

        public RepositorioABMCategorias()
        {
            _repositorio = new Modelo();
        }

        public List<Categoria> TodasCategorias()
        {
            List<Categoria> _lista = new List<Categoria>();
            _lista = (from a in _repositorio.Categorias
                     where a.Febaj == null                     
                     select a).ToList();

            return _lista;
        }
        

        public void AgregarCategoria(Categoria categoriaPar)
        {
            categoriaPar.Fealt = DateTime.Now;
            _repositorio.Categorias.Add(categoriaPar);
            _repositorio.SaveChanges();
        }

        public void ModificarCategoria(Categoria categoriaPar)
        {
            var categoria = _repositorio.Categorias.Where(x => x.Id == categoriaPar.Id).FirstOrDefault();

            categoria.Nombre = categoriaPar.Nombre;
            categoria.Femod = DateTime.Now;

            _repositorio.SaveChanges();
        }

        public void EliminarCategoria(Categoria categoriaPar)
        {
            var categoria = _repositorio.Categorias.Where(x => x.Id == categoriaPar.Id).FirstOrDefault();

            categoria.Febaj = DateTime.Now;

            _repositorio.SaveChanges();
        }


        public List<Categoria> BuscarCategorias(string nombreCategoriaPar)
        { 
            List<Categoria> query = (from a in _repositorio.Categorias
                                    where a.Febaj == null
                                    && a.Nombre.Contains(nombreCategoriaPar)
                                    select a).ToList();

            return query;
        }
    }
}
