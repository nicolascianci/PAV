using Datos;
using Dominio;
using Dominio.ViewModels;
using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;


namespace Presentadores
{
    public class PresentadorVentas
    {
        IOperacion _vista;
        Operacion _operacion;
        List<OperacionViewModel> _listaDetalle;

        List<Articulo> _listaArticulos = new List<Articulo>();

        RepositorioArticulos _negocioArticulo;
        RepositorioVentas _negocioVentas;
        TipoOperacion _tipoOperacion = new TipoOperacion();

        public PresentadorVentas(IOperacion vistaPar)
        {
            _vista = vistaPar;
            _operacion = new Operacion();
            _operacion.TipoOperacion = TipoOperacion.Venta;
            _listaDetalle = new List<OperacionViewModel>();

            _negocioArticulo = new RepositorioArticulos();
            _negocioVentas = new RepositorioVentas();

            _vista.RealizarOperacion += this.VistaRealizarOperacion;
        }

        public PresentadorVentas(IOperacion vistaPar, int idVentaPar)
        {
            _vista = vistaPar;
            _negocioVentas = new RepositorioVentas();
            _negocioArticulo = new RepositorioArticulos();
            _operacion = _negocioVentas.BuscarVenta(idVentaPar);

            if(_operacion != null)
            {
                _listaDetalle = new List<OperacionViewModel>();
                _listaDetalle = _operacion.OperacionDetalle.Select(p => new OperacionViewModel
                {
                    IdArticulo = p.ArticuloID,
                    DescripcionArticulo = p.Articulo.Descripcion,
                    PrecioUnitario = p.PrecioUnitario,
                    Cantidad = (double)p.Cantidad,
                    Stock = (double)p.Articulo.Stock
                }).ToList();

                this._vista.ListaArticulos = _listaDetalle;
                this._vista.Descuento = _operacion.Descuento;
                
                this.Totales();
            }
        }

        private void VistaRealizarOperacion(object sender, List<OperacionViewModel> e)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                _operacion.PuntoVenta = 1;
                _operacion.NumeroVenta = _negocioVentas.ObtenerNumero();
                _operacion.TotalSinDescuento = this._vista.TotalSinDescuento;
                _operacion.Descuento = this._vista.Descuento;
                _operacion.Total = this._vista.TotalConDescuento;
                _operacion.OperacionDetalle = new List<Detalle>();

                foreach (var Item in e)
                {
                    Detalle _detalle = new Detalle();
                    _detalle.ArticuloID = Convert.ToInt32(Item.IdArticulo);
                    //_detalle.articulo = negocio_articulo_tmp.Uno(Convert.ToInt32(item_tmp.codigo));
                    _detalle.Cantidad = Convert.ToDecimal(Item.Cantidad);
                    _detalle.PrecioUnitario = Convert.ToDouble(Item.PrecioUnitario);

                    _operacion.OperacionDetalle.Add(_detalle);
                    this._negocioArticulo.ActualizarStock(_detalle.ArticuloID, _detalle.Cantidad);
                }

                _negocioVentas.GuardarVenta(_operacion);

                scope.Complete();                
            }

        }

        public List<Articulo> BuscarArticulos()
        {
            _listaArticulos = _negocioArticulo.BuscarArticulos(this._vista.NombreArticulo);
           
            return _listaArticulos;
            
        }


        public void AgregarDetalle(Articulo articuloPar)
        {
            OperacionViewModel _detalle = new OperacionViewModel();

            if(!_listaDetalle.Any(x => x.IdArticulo == articuloPar.Id))
            {
                _detalle.IdArticulo = articuloPar.Id;
                _detalle.DescripcionArticulo = articuloPar.Descripcion;
                _detalle.PrecioUnitario = articuloPar.Preciofinal;
                _detalle.Cantidad = _vista.Cantidad;
                _detalle.Stock = (double)articuloPar.Stock;

                _listaDetalle.Add(_detalle);
            }else
            {
                var _item = _listaDetalle.Where(x => x.IdArticulo == articuloPar.Id).FirstOrDefault();
                int _indice = _listaDetalle.IndexOf(_item);
                _listaDetalle.RemoveAt(_indice);
                _item.Cantidad = _item.Cantidad + this._vista.Cantidad;
                _listaDetalle.Insert(_indice, _item);
            }

            this._vista.ListaArticulos = _listaDetalle;
            this._vista.NombreArticulo = "";
            this.Totales();
        }

        public void EliminarArticulo(int idArticuloPar)
        {
            var _item = _listaDetalle.Where(x => Convert.ToInt32(x.IdArticulo) == idArticuloPar).FirstOrDefault();

            _listaDetalle.Remove(_item);

            this._vista.ListaArticulos = _listaDetalle;
            this.Totales();
            
        }

        public void Totales()
        {
            double _total = 0;

            foreach(var item in this._vista.ListaArticulos)
            {
                _total = _total + Convert.ToDouble(item.Total);

            }

            this._vista.TotalSinDescuento = _total;

            if (this._vista.Descuento != 0.00)
                this._vista.TotalConDescuento = _total * (1 - (this._vista.Descuento/100));
            else
                this._vista.TotalConDescuento = _total;

        }

        public void LimpiarFormulario()
        {
            this._listaArticulos = new List<Articulo>();
            this._listaDetalle = new List<OperacionViewModel>();

            this._vista.ListaArticulos = _listaDetalle;
            this._vista.Cantidad = 0;
            this._vista.Descuento = 0;
            this._vista.NombreArticulo = "";
            this._vista.TotalConDescuento = 0;
            this._vista.TotalSinDescuento = 0;
            

        }
    }
}
