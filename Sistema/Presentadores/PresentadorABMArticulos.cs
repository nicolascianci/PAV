using Datos;
using Dominio;
using Dominio.ViewModels;
using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentadores
{
    //TODO: No debe invocarse desde el presentador a recursos de la vista, como se corrigió
    //en los repositorios. Revisar todos los casos (en todos los presentadores).
    public class PresentadorABMArticulos
    {
        IABMArticulos _vista;
        private RepositorioABMArticulos _repositorio;
        private List<CategoriaViewModel> _lista_categorias = new List<CategoriaViewModel>();
       

        public PresentadorABMArticulos(IABMArticulos vistaPar)
        {
            _vista = vistaPar;
            _repositorio = new RepositorioABMArticulos();

            //TODO: los eventos, tienen sentido? Son útiles cuando se quiere trasladar
            //un evento generado por un control, por ejemplo: se hace click en un botón y el
            //handler de ese evento se quiere resolver en el presentador. Ver inidicación para esto
            //en la misma vista.
            _vista.AgregarProductoAceptar += this.AgregarProducto;
            _vista.EditarProductoAceptar += this.EditarProducto;
            _vista.EliminarProductoAceptar += this.EliminarProducto;
        }

        public void AgregarProducto(object sender, Articulo p)
        {
            string _mensaje;

            if (ValidarArticulo(p, out _mensaje))
            {
                _repositorio.AgregarProducto(p);
            }
            else
            {
                
                MessageBox.Show(_mensaje, "Validar Articulo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void EditarProducto(object sender, Articulo p)
        {
            string _mensaje;

            if (ValidarArticulo(p, out _mensaje))
            {
                _repositorio.AgregarProducto(p);               
            }
            else
            {
                MessageBox.Show(_mensaje, "Validar Articulo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void EliminarProducto(object sender, Articulo p)
        {            
             _repositorio.EliminarProducto(p);
        }

        public List<CategoriaViewModel> BuscarCategorias()
        {
            _lista_categorias = _repositorio.BuscarTodasCategorias().Select(x => new CategoriaViewModel
            {
                IdCategoria = x.Id,
                NombreCategoria = x.Nombre
            }).OrderBy(x => x.IdCategoria).ToList();

            return _lista_categorias;
        }

        public void DevolverCategoria(int idcategoria)
        {
            this._vista.articulo.CategoriaId = idcategoria;
            this._vista.articulo.Categoria = _repositorio.GetCategoria(idcategoria);            
        }

        private bool ValidarArticulo(Articulo articulo, out string mensaje)
        {
            Articulo _articulo = _repositorio.BuscarArticulo(articulo.Id);

            if (_articulo != null && _articulo.Id != articulo.Id)
            {                
                mensaje = "Existe otro articulo con el mismo Codigo.";
                return false;
            }
            
            if(!articulo.ValidarArticulo(out mensaje))
            {
                return false;
            }

            return true;
            //return _repositorio.ValidarArticulo(articulo);
        }

        public CategoriaViewModel SeleccionarCategoria(int idcategoria)
        {
            return _lista_categorias.Where(p => p.IdCategoria == idcategoria).First();
        }
    }
}
