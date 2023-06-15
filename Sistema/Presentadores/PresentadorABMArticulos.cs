using Datos;
using Dominio;
using Dominio.ViewModels;
using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentadores
{
    public class PresentadorABMArticulos
    {
        IABMArticulos _vista;
        private RepositorioABMArticulos _repositorio;
        private List<CategoriaViewModel> _lista_categorias = new List<CategoriaViewModel>();
       

        public PresentadorABMArticulos(IABMArticulos vistaPar)
        {
            _vista = vistaPar;
            _repositorio = new RepositorioABMArticulos();

            _vista.AgregarProductoAceptar += this.AgregarProducto;
            _vista.EditarProductoAceptar += this.EditarProducto;
            _vista.EliminarProductoAceptar += this.EliminarProducto;
        }

        public void AgregarProducto(object sender, Articulo p)
        {
            _repositorio.AgregarProducto(p);
        }

        public void EditarProducto(object sender, Articulo p)
        {
            _repositorio.EditarProducto(p);
        }

        public void EliminarProducto(object sender, Articulo p)
        {
            _repositorio.EliminarProducto(p);
        }

        public List<CategoriaViewModel> Buscar_Categorias()
        {
            _lista_categorias = _repositorio.BuscarTodasCategorias().Select(x => new CategoriaViewModel
            {
                IdCategoria = x.Id,
                NombreCategoria = x.Nombre
            }).OrderBy(x => x.IdCategoria).ToList();

            return _lista_categorias;
        }

        public Categoria Devolver_Categoria(int idcategoria)
        {
            return _repositorio.GetCategoria(idcategoria);
        }
    }
}
