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
        List<articulo> lista_articulos_tmp = new List<articulo>();
        articulo articulo_tmp = new articulo();
        PresentadorVentas presentador_tmp;

        public Ventas()
        {
            InitializeComponent();
            presentador_tmp = new PresentadorVentas(this);
            Total_ctrl.Text = string.Format("{0:#,##0.00}", double.Parse(descuento_txb.Text));
            //cantidad_txb.Text = string.Format("{0:#,##0.00}", double.Parse(cantidad_txb.Text));
            total_descuento_txb.Text = string.Format("{0:#,##0.00}", double.Parse(descuento_txb.Text));
        }

        public Ventas(int idventa_par)
        {
            InitializeComponent();
            presentador_tmp = new PresentadorVentas(this,idventa_par);
            Total_ctrl.Text = string.Format("{0:#,##0.00}", double.Parse(Total_ctrl.Text));
            //cantidad_txb.Text = string.Format("{0:#,##0.00}", double.Parse(cantidad_txb.Text));
            //descuento_txb.Text = string.Format("P", double.Parse(descuento_txb.Text));
            total_descuento_txb.Text = string.Format("{0:#,##0.00}", double.Parse(total_descuento_txb.Text));
            this.Confirmar_btn.Enabled = false;
            this.articulos_txt.Enabled = false;
        }

        public List<OperacionViewModel> lista_articulos
        {
            get
            {
                return (List<OperacionViewModel>)this.articulos_bs.DataSource;
            }
            set
            {
                this.articulos_bs.DataSource = null;
                this.articulos_bs.DataSource = value;
            }
        }
        public string nombre_articulo { get => this.articulos_txt.Text; set => this.articulos_txt.Text = value; }
        public double cantidad { get => Convert.ToDouble(cantidad_txb.Text); set => cantidad_txb.Text = value.ToString(); }
        public double total_sin_descuento { get => Convert.ToDouble(this.Total_ctrl.Text); set => this.Total_ctrl.Text = value.ToString("N2"); }

        public double total_con_descuento { get => Convert.ToDouble(total_descuento_txb.Text); set => this.total_descuento_txb.Text = value.ToString("N2"); }
        double IOperacion.descuento { get => Convert.ToDouble(this.descuento_txb.Text); set => this.descuento_txb.Text = value.ToString(); }

        public event EventHandler<List<OperacionViewModel>> Realizar_Operacion;

        private void articulos_txt_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.Enter:
                    lista_articulos_tmp = presentador_tmp.Buscar_Articulos();

                    if (lista_articulos_tmp.Count > 1)
                    {
                        Buscador_Articulos _form = new Buscador_Articulos(lista_articulos_tmp);
                        _form.ShowDialog();

                        articulo_tmp = null;
                        articulo_tmp = (articulo)_form.Tag;

                        this.articulo_lb.Text = articulo_tmp.Descripcion;
                        this.panel2.Visible = true;
                        this.cantidad_txb.Focus();

                    }
                    else
                    {
                        if (lista_articulos_tmp.Count == 0)
                        {
                            break;
                        }

                        this.articulo_lb.Text = lista_articulos_tmp.FirstOrDefault().Descripcion;
                        articulo_tmp = lista_articulos_tmp.FirstOrDefault();
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

                        presentador_tmp.Eliminar_Articulo(Convert.ToInt32(_articulo.idArticulo));
                    }

                    break;                
            }

        }


        private void cantidad_txb_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.Enter:
                    if (this.cantidad > 0)
                    {
                        presentador_tmp.Agregar_Detalle(articulo_tmp);
                        this.panel2.Visible = false;
                    }
                    else
                        MessageBox.Show("No se puede ingresar cantidad 0 o menor", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    break;
            }
        }

        private void Confirmar_btn_Click(object sender, EventArgs e)
        {
            OnRealizarOperacion(this.lista_articulos);
            //this.presentador_tmp.Realizar_Operacion();

            this.Dispose();

            var resultado = MessageBox.Show("¿Deseas Realizar otra venta?", "Producto", MessageBoxButtons.OKCancel);
            if (resultado == DialogResult.OK)
            {

                Ventas _from = new Ventas();
                _from.ShowDialog();
            }
        }

        protected virtual void OnRealizarOperacion(List<OperacionViewModel> lista_par)
        {
            Realizar_Operacion?.Invoke(this, lista_par);
        }

        private void panel_confirma_ctn_Click(object sender, EventArgs e)
        {
            if (this.cantidad > 0)
            {
                presentador_tmp.Agregar_Detalle(articulo_tmp);
                this.panel2.Visible = false;
            }
            else
                MessageBox.Show("No se puede ingresar cantidad 0 o menor", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.nombre_articulo = "";
            this.cantidad = 0;
            this.panel2.Visible = false;
        }
    }
}
