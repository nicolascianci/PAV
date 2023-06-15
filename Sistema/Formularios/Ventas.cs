using Dominio;
using Dominio.ViewModels;
using Interfaces;
using Presentadores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema.Formularios
{
    public partial class Ventas : Form, IOperacion
    {
        List<Articulo> _listaArticulos = new List<Articulo>();
        Articulo _articulo = new Articulo();
        PresentadorVentas _presentador;

        public Ventas()
        {
            InitializeComponent();
            _presentador = new PresentadorVentas(this);
            Total_ctrl.Text = string.Format("{0:#,##0.00}", double.Parse(descuento_txb.Text));
            //cantidad_txb.Text = string.Format("{0:#,##0.00}", double.Parse(cantidad_txb.Text));
            total_descuento_txb.Text = string.Format("{0:#,##0.00}", double.Parse(descuento_txb.Text));
        }

        public Ventas(int idventa_par)
        {
            InitializeComponent();
            _presentador = new PresentadorVentas(this,idventa_par);
            Total_ctrl.Text = string.Format("{0:#,##0.00}", double.Parse(Total_ctrl.Text));
            //cantidad_txb.Text = string.Format("{0:#,##0.00}", double.Parse(cantidad_txb.Text));
            //descuento_txb.Text = string.Format("P", double.Parse(descuento_txb.Text));
            total_descuento_txb.Text = string.Format("{0:#,##0.00}", double.Parse(total_descuento_txb.Text));
            this.Confirmar_btn.Enabled = false;
            this.articulos_txt.Enabled = false;
        }

        public List<OperacionViewModel> ListaArticulos
        {
            get
            {
                return (List<OperacionViewModel>)this.operacionViewModelBindingSource.DataSource;
            }
            set
            {
                this.operacionViewModelBindingSource.DataSource = null;
                this.operacionViewModelBindingSource.DataSource = value;
            }
        }
        public string NombreArticulo { get => this.articulos_txt.Text; set => this.articulos_txt.Text = value; }
        public double Cantidad { get => Convert.ToDouble(cantidad_txb.Text); set => cantidad_txb.Text = value.ToString(); }
        public double TotalSinDescuento { get => Convert.ToDouble(this.Total_ctrl.Text); set => this.Total_ctrl.Text = value.ToString("N2"); }

        public double TotalConDescuento { get => Convert.ToDouble(total_descuento_txb.Text); set => this.total_descuento_txb.Text = value.ToString("N2"); }
        double IOperacion.Descuento { get => Convert.ToDouble(this.descuento_txb.Text); set => this.descuento_txb.Text = value.ToString(); }

        public event EventHandler<List<OperacionViewModel>> RealizarOperacion;

        private void articulos_txt_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.F2:
                    this.descuento_txb.ReadOnly = false;
                    this.descuento_txb.Focus();
                    break;

                case Keys.Enter:
                    _listaArticulos = _presentador.BuscarArticulos();

                    if (_listaArticulos.Count > 1)
                    {
                        Buscador_Articulos _form = new Buscador_Articulos(_listaArticulos);
                        _form.ShowDialog();

                        _articulo = null;
                        _articulo = (Articulo)_form.Tag;

                        this.articulo_lb.Text = _articulo.Descripcion;
                        this.panel2.Visible = true;
                        this.cantidad_txb.Focus();

                    }
                    else
                    {
                        if (_listaArticulos.Count == 0)
                        {
                            break;
                        }

                        this.articulo_lb.Text = _listaArticulos.FirstOrDefault().Descripcion;
                        _articulo = _listaArticulos.FirstOrDefault();
                        this.cantidad_txb.Focus();
                        this.panel2.Visible = true;
                    }


                    break;
            }
        }

        private void articulos_ctrl_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {               

                case Keys.Delete:

                    if (this.articulos_ctrl.CurrentRow != null)
                    {
                        var _articulo = (OperacionViewModel)this.articulos_ctrl.CurrentRow.DataBoundItem;

                        _presentador.EliminarArticulo(Convert.ToInt32(_articulo.IdArticulo));
                    }

                    break;

                case Keys.F2:
                    this.descuento_txb.ReadOnly = false;
                    this.descuento_txb.Focus();
                    break;

                default:
                    break;
            }

        }


        private void cantidad_txb_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.Enter:
                    if (this.Cantidad > 0)
                    {
                        _presentador.AgregarDetalle(_articulo);
                        this.panel2.Visible = false;
                    }
                    else
                        MessageBox.Show("No se puede ingresar cantidad 0 o menor", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    break;
            }
        }

        private void Confirmar_btn_Click(object sender, EventArgs e)
        {
            OnRealizarOperacion(this.ListaArticulos);
            //this.presentador_tmp.Realizar_Operacion();
            MessageBox.Show("Se realizo con exito la venta.", "Venta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this._presentador.LimpiarFormulario();
        }

        protected virtual void OnRealizarOperacion(List<OperacionViewModel> lista_par)
        {
            RealizarOperacion?.Invoke(this, lista_par);
        }

        private void panel_confirma_ctn_Click(object sender, EventArgs e)
        {
            if (this.Cantidad > 0)
            {
                _presentador.AgregarDetalle(_articulo);
                this.Cantidad = 0;
                this.panel2.Visible = false;
            }
            else
                MessageBox.Show("No se puede ingresar cantidad 0 o menor", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.NombreArticulo = "";
            this.Cantidad = 0;
            this.panel2.Visible = false;
        }

        private void Ventas_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F2:
                    this.descuento_txb.ReadOnly = false;
                    break;

                default:
                    break;
            }
        }

        private void descuento_txb_Leave(object sender, EventArgs e)
        {
            _presentador.Totales();
        }
    }
}
