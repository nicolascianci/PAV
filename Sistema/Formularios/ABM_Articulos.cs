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
    public partial class ABM_Articulos : Form, IABMArticulos
    {
        articulo articulos_tmp = new articulo();
        CategoriaViewModel _categoria = new CategoriaViewModel();
        private PresentadorABMArticulos _presentador;
        public bool _nuevo;

        public ABM_Articulos()
        {
            InitializeComponent();
            _presentador = new PresentadorABMArticulos(this);
            articulosbd.DataSource = articulos_tmp;
            comboBox1.DataSource = Enum.GetValues(typeof(EstadoProducto));
            datosGrillaBindingSource.DataSource = _presentador.Buscar_Categorias();
            comboBox2.DataSource = datosGrillaBindingSource.DataSource;
            datosGrillaBindingSource.Position = 0;
            
           
        }

        public event EventHandler<articulo> AgregarProductoAceptar;
        public event EventHandler<articulo> EditarProductoAceptar;
        public event EventHandler<articulo> EliminarProductoAceptar;


        public void ActualizarProducto(articulo p)
        {
            articulos_tmp = p;
            articulosbd.DataSource = articulos_tmp;
            datosGrillaBindingSource.Position = (int)p.CategoriaId - 1;
        }


        protected virtual void OnAgregarProductoAceptar(articulo p)
        {
            AgregarProductoAceptar?.Invoke(this, p);
        }

        protected virtual void OnEditarProductoAceptar(articulo p)
        {
            EditarProductoAceptar?.Invoke(this, p);
        }

        protected virtual void OnEliminarProductoAceptar(articulo p)
        {
            EliminarProductoAceptar?.Invoke(this, p);
        }        

       

        public void EliminarProducto()
        {
            var resultado = MessageBox.Show("¿Deseas eliminar el Producto?", "Producto", MessageBoxButtons.OKCancel);
            if (resultado == DialogResult.OK)
            {
                OnEliminarProductoAceptar(articulos_tmp);
                this.Dispose();
            }
        }

        public void Modificar(articulo articulo_par)
        {
            articulosbd.DataSource = articulo_par;
            datosGrillaBindingSource.Position = (int)articulo_par.CategoriaId - 1;
        }

        private void btn_guardar_Click_1(object sender, EventArgs e)
        {
            if (_nuevo)
            {

                var resultado = MessageBox.Show("¿Deseas crear el Crear Producto?", "Producto", MessageBoxButtons.OKCancel);
                if (resultado == DialogResult.OK)
                {
                    _categoria = (CategoriaViewModel)datosGrillaBindingSource.Current;
                    articulos_tmp.CategoriaId = Convert.ToInt32(_categoria.idCategoria);
                    articulos_tmp.categoria = _presentador.Devolver_Categoria(_categoria.idCategoria);
                    OnAgregarProductoAceptar(articulos_tmp);

                }
            }
            else
            {
                _categoria = (CategoriaViewModel)datosGrillaBindingSource.Current;
                articulos_tmp.CategoriaId = Convert.ToInt32(_categoria.idCategoria);
                articulos_tmp.categoria = _presentador.Devolver_Categoria(_categoria.idCategoria);
                OnEditarProductoAceptar(articulos_tmp);

            }

            this.Dispose();
        }
    }
}
