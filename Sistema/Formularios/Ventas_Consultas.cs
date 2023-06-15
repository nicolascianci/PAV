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
    public partial class Ventas_Consultas : Form, IConsultaVentas
    {

        PresentadorVentasConsultas _presentador;

        public Ventas_Consultas()
        {
            InitializeComponent();
            _presentador = new PresentadorVentasConsultas(this);
        }

        #region IConsulta_Ventas

        public DateTime Desde
        {
            get
            {
                if (this.desde_ctrl.Text == "  /  /")
                    return DateTime.MinValue;
                else
                    return Convert.ToDateTime(this.desde_ctrl.Text);
            }
            
        }
        public DateTime Hasta
        {
            get
            {
                if (this.Hasta_ctrl.Text == "  /  /")
                    return DateTime.MaxValue;
                else
                    return Convert.ToDateTime(this.Hasta_ctrl.Text + " 23:59:59");
            }
        }
        public List<ConsultaVentasViewModel> ListaVentas
        {
            get => (List<ConsultaVentasViewModel>)consultaVentasViewModelBindingSource.DataSource;
            set => consultaVentasViewModelBindingSource.DataSource = value;
        }

        public int IdVenta
        {
            get
            {
                if (this.ventas_grilla.CurrentRow != null)
                {
                    var datos = (ConsultaVentasViewModel)this.ventas_grilla.CurrentRow.DataBoundItem;
                    return Convert.ToInt32(datos.NumeroVenta);
                }
                return 0;
            }
        }

        decimal IConsultaVentas.Total { set => this.total_txt.Text = value.ToString(); }

        #endregion

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            
            _presentador.Buscar_Ventas();
            this.desde_ctrl.ReadOnly = true;
            this.Hasta_ctrl.ReadOnly = true;

        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.desde_ctrl.Text = "";
            this.Hasta_ctrl.Text = "";
            _presentador.limpiar();
            this.Hasta_ctrl.ReadOnly = false;
            this.desde_ctrl.ReadOnly = false;
        }

        private void ventas_grilla_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(this.IdVenta != 0)
            {
                Ventas _from = new Ventas(IdVenta);// para ver el detalle de la operacion
                _from.ShowDialog();
            }
                
        }
    }
}