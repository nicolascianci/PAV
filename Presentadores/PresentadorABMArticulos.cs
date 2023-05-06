using Datos;
using Dominio;
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
        IABMArticulos vista_tmp;
        private R_ABMArticulos _repositorio;
        private List<Datos_Grilla> _lista_categorias = new List<Datos_Grilla>();
       

        public PresentadorABMArticulos(IABMArticulos vista_par)
        {
            vista_tmp = vista_par;
            _repositorio = new R_ABMArticulos();
           
            vista_tmp.AgregarProductoAceptar += this.AgregarProducto;
            vista_tmp.EditarProductoAceptar += this.EditarProducto;
            vista_tmp.EliminarProductoAceptar += this.EliminarProducto;
        }

        public void AgregarProducto(object sender, articulo p)
        {
            _repositorio.AgregarProducto(p);
        }

        public void EditarProducto(object sender, articulo p)
        {
            _repositorio.EditarProducto(p);
        }

        public void EliminarProducto(object sender, articulo p)
        {
            _repositorio.EliminarProducto(p);
        }

        public List<Datos_Grilla> Buscar_Categorias()
        {
            _lista_categorias = _repositorio.Buscar_Todas_Categorias_Item();
            return _lista_categorias;
        }
    }
}
