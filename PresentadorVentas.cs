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
using System.Windows.Forms;

namespace Presentadores
{
    //TODO: No debe invocarse desde el presentador a recursos de la vista, como se corrigió
    //en los repositorios. Revisar todos los casos (en todos los presentadores).
    public class PresentadorVentas
    {
        IOperacion _vista;
        Operacion _operacion = new Operacion();
        List<OperacionViewModel> _listaDetalle = new List<OperacionViewModel>();

        List<Articulo> _listaArticulos = new List<Articulo>();

        RepositorioArticulos _negocioArticulo;
        RepositorioVentas _negocioVentas;
        TipoOperacion _tipoOperacion = new TipoOperacion();

        public PresentadorVentas(IOperacion vistaPar)
        {
            _vista = vistaPar;
            //TODO: La creación de la operación debería ser un proceso atómico (realizarse todo en un solo paso),
            //mientras que en este caso está dividido, se crea acá la instacia, en el método VistaRealizarOperacion
            //se le asignan la mayoría de los datos y en el repositorio se le termina asignando la
            //fecha.
           

            _negocioArticulo = new RepositorioArticulos();
            _negocioVentas = new RepositorioVentas();
           
        }

        public PresentadorVentas(IOperacion vistaPar, int idVentaPar)
        {
            _vista = vistaPar;
            _negocioVentas = new RepositorioVentas();
            _negocioArticulo = new RepositorioArticulos();
            _operacion = _negocioVentas.BuscarVenta(idVentaPar);

            if(_operacion != null)
            {
                List<Detalle> listaDetalleOperacion = _negocioVentas.BuscarDetalle(idVentaPar);
                _listaDetalle = new List<OperacionViewModel>();
                _listaDetalle = listaDetalleOperacion.Select(p => new OperacionViewModel
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

        public bool VistaRealizarOperacion(List<OperacionViewModel> e,out string mens)
        {
            if(this.ValidarOperacion(e,out mens))
            {
                _operacion.TipoOperacion = TipoOperacion.Venta;                

                using (TransactionScope scope = new TransactionScope())
                {
                    _operacion.PuntoVenta = 1;
                    _operacion.NumeroVenta = _negocioVentas.ObtenerNumero();                    
                    _operacion.Descuento = this._vista.Descuento;
                    _operacion.Fecha = DateTime.Now;
                    //_operacion.OperacionDetalle = new List<Detalle>();

                    foreach (var Item in e)
                    {
                        //TODO: recordar el patrón Creador, ¿quién debería crear el detalle?
                        //Detalle _detalle = new Detalle();
                        //_detalle.ArticuloID = Convert.ToInt32(Item.IdArticulo);
                        //_detalle.Cantidad = Convert.ToDecimal(Item.Cantidad);
                        //_detalle.PrecioUnitario = Convert.ToDouble(Item.PrecioUnitario);

                        //_operacion.agregarDetalle(Item.IdArticulo, Item.Cantidad, Item.PrecioUnitario);
                        this._negocioArticulo.ActualizarStock(Item.IdArticulo, (decimal)Item.Cantidad);
                    }

                    _negocioVentas.GuardarVenta(_operacion);

                    scope.Complete();
                }

                mens = "Se realizo con exito la venta.";
                this.LimpiarFormulario();
                _operacion = new Operacion();//una nueva operacion cuando retome el formulario
                return true;
            }
            else
            {
                return false;
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

                _operacion.agregarDetalle(_detalle.IdArticulo, _detalle.Cantidad, _detalle.PrecioUnitario);
                _listaDetalle.Add(_detalle);
            }else
            {
                var _item = _listaDetalle.Where(x => x.IdArticulo == articuloPar.Id).FirstOrDefault();
                int _indice = _listaDetalle.IndexOf(_item);
                _listaDetalle.RemoveAt(_indice);
                _item.Cantidad = _item.Cantidad + this._vista.Cantidad;
                _listaDetalle.Insert(_indice, _item);
                _operacion.editarDetalle(_item.IdArticulo, _item.Cantidad, _item.PrecioUnitario);
            }

            
            this._vista.ListaArticulos = _listaDetalle;
            this._vista.NombreArticulo = "";
            this.Totales();
        }

        public void EliminarArticulo(int idArticuloPar)
        {
            var _item = _listaDetalle.Where(x => Convert.ToInt32(x.IdArticulo) == idArticuloPar).FirstOrDefault();

            _listaDetalle.Remove(_item);
            _operacion.eliminarDetalle(idArticuloPar);
            this._vista.ListaArticulos = _listaDetalle;
            this.Totales();
            
        }

        //TODO: patrón Experto, ¿quién debería conocer el total?
        public void Totales()
        {
            _operacion.Descuento = this._vista.Descuento;
            this._vista.TotalConDescuento = _operacion.Total;
            this._vista.TotalSinDescuento = _operacion.TotalSinDescuento;

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

        private bool ValidarOperacion(List<OperacionViewModel> detalle, out string mens)
        {
            if(detalle == null || detalle.Count <= 0)
            {
                mens = "La operacion no tiene detalle.";
                return false;
            }

            mens = "";
            return true;
        }
    }
}
