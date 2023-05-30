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
        IOperacion vista_tmp;
        Operacion operacion_tmp;
        List<OperacionViewModel> lista_detalle;

        List<articulo> lista_articulos_tmp = new List<articulo>();

        R_Articulos negocio_articulo_tmp;
        R_Ventas negocio_ventas_tmp;
        Tipo_Operacion tipo_oper = new Tipo_Operacion();

        public PresentadorVentas(IOperacion vista_par)
        {
            vista_tmp = vista_par;
            operacion_tmp = new Operacion();
            operacion_tmp.TipoOperacion = Tipo_Operacion.Venta;
            lista_detalle = new List<OperacionViewModel>();

            negocio_articulo_tmp = new R_Articulos();
            negocio_ventas_tmp = new R_Ventas();

           vista_tmp.Realizar_Operacion += this.Vista_tmp_Realizar_Operacion;
        }

        public PresentadorVentas(IOperacion vista_par, int idventa_par)
        {
            vista_tmp = vista_par;
            negocio_ventas_tmp = new R_Ventas();
            negocio_articulo_tmp = new R_Articulos();
            operacion_tmp = negocio_ventas_tmp.Buscar_Venta(idventa_par);

            if(operacion_tmp != null)
            {
                lista_detalle = new List<OperacionViewModel>();
                lista_detalle = operacion_tmp.OperacionDetalle.Select(p => new OperacionViewModel
                {
                    idArticulo = p.articuloID,
                    descripcionArticulo = p.articulo.Descripcion,
                    precioUnitario = p.precioUnitario,
                    cantidad = (double)p.cantidad,
                    stock = (double)p.articulo.stock
                }).ToList();

                this.vista_tmp.lista_articulos = lista_detalle;
                //this.vista_tmp.total_sin_descuento = operacion_tmp.totas_sin_descuento;
                this.vista_tmp.descuento = operacion_tmp.descuento;
                //this.vista_tmp.total_con_descuento = operacion_tmp.total;
                this.Totales();
            }
        }

        private void Vista_tmp_Realizar_Operacion(object sender, List<OperacionViewModel> e)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                operacion_tmp.puntoVenta = 1;
                operacion_tmp.numeroVenta = negocio_ventas_tmp.Obtener_Numero();
                operacion_tmp.totalSinDescuento = this.vista_tmp.total_sin_descuento;
                operacion_tmp.total = this.vista_tmp.total_con_descuento;
                operacion_tmp.OperacionDetalle = new List<Detalle>();

                foreach (var item_tmp in e)
                {
                    Detalle _detalle = new Detalle();
                    _detalle.articuloID = Convert.ToInt32(item_tmp.idArticulo);
                    //_detalle.articulo = negocio_articulo_tmp.Uno(Convert.ToInt32(item_tmp.codigo));
                    _detalle.cantidad = Convert.ToDecimal(item_tmp.cantidad);
                    _detalle.precioUnitario = Convert.ToDouble(item_tmp.precioUnitario);

                    operacion_tmp.OperacionDetalle.Add(_detalle);
                    this.negocio_articulo_tmp.Actualizar_Stock(_detalle.articuloID, _detalle.cantidad);
                }

                negocio_ventas_tmp.Guardar_Venta(operacion_tmp);

                scope.Complete();
            }

        }

        public List<articulo> Buscar_Articulos()
        {
            lista_articulos_tmp = negocio_articulo_tmp.Buscar_Articulos(this.vista_tmp.nombre_articulo);

           
                return lista_articulos_tmp;
            
        }


        public void Agregar_Detalle(articulo articulo_tmp)
        {
            OperacionViewModel _detalle = new OperacionViewModel();

                _detalle.idArticulo = articulo_tmp.id;
                _detalle.descripcionArticulo = articulo_tmp.Descripcion;
                _detalle.cantidad = vista_tmp.cantidad;
                _detalle.stock = (double)articulo_tmp.stock;
            

            lista_detalle.Add(_detalle);

            this.vista_tmp.lista_articulos = lista_detalle;
            this.vista_tmp.nombre_articulo = "";
            this.Totales();
        }

        public void Eliminar_Articulo(int idarticulo_par)
        {
            var _item = lista_detalle.Where(x => Convert.ToInt32(x.idArticulo) == idarticulo_par).FirstOrDefault();

            lista_detalle.Remove(_item);

            this.vista_tmp.lista_articulos = lista_detalle;
            this.Totales();
            
        }

        public void Totales()
        {
            double _total = 0;

            foreach(var item in this.vista_tmp.lista_articulos)
            {
                _total = _total + Convert.ToDouble(item.total);

            }

            this.vista_tmp.total_sin_descuento = _total;

            if (this.vista_tmp.descuento != 0.00)
                this.vista_tmp.total_con_descuento = _total * (this.vista_tmp.descuento/100);
            else
                this.vista_tmp.total_con_descuento = _total;

        }

        //public void Realizar_Operacion()
        //{
        //    using (TransactionScope scope = new TransactionScope())
        //    {
        //        operacion_tmp.punto_venta = 1;
        //        operacion_tmp.numero_venta = negocio_ventas_tmp.Obtener_Numero();
        //        operacion_tmp.total = this.vista_tmp.total_con_descuento;
        //        operacion_tmp.Operacion_Detalle = new List<Detalle>();

        //        foreach (var item_tmp in lista_detalle)
        //        {
        //            Detalle _detalle = new Detalle();
        //            _detalle.articuloID = Convert.ToInt32(item_tmp.codigo);
        //            //_detalle.articulo = negocio_articulo_tmp.Uno(Convert.ToInt32(item_tmp.codigo));
        //            _detalle.cantidad = Convert.ToDecimal(item_tmp.columna3);
        //            _detalle.precio_unitario = Convert.ToDouble(item_tmp.columna4);

        //            operacion_tmp.Operacion_Detalle.Add(_detalle);
        //            this.negocio_articulo_tmp.Actualizar_Stock(_detalle.articuloID, _detalle.cantidad);
        //        }

        //        negocio_ventas_tmp.Guardar_Venta(operacion_tmp);

        //        scope.Complete();
        //    }
               
        //}
    }
}
