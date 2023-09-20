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
    public partial class ABMArticulos : Form, IABMArticulos
    {
        Articulo _articulos = new Articulo();
        CategoriaViewModel _categoria = new CategoriaViewModel();
        private PresentadorABMArticulos _presentador;
        public bool _nuevo;

        public Articulo articulo { get => _articulos; set => _articulos = value; }

        public ABMArticulos()
        {
            InitializeComponent();
            _presentador = new PresentadorABMArticulos(this);
            articulosbd.DataSource = _articulos;
            comboBox1.DataSource = Enum.GetValues(typeof(EstadoProducto));
            categoriaViewModelBindingSource.DataSource = _presentador.BuscarCategorias();
            comboBox2.DataSource = categoriaViewModelBindingSource.DataSource;
            categoriaViewModelBindingSource.Position = 0;
            
           
        }

        public event EventHandler<Articulo> AgregarProductoAceptar;
        public event EventHandler<Articulo> EditarProductoAceptar;
        public event EventHandler<Articulo> EliminarProductoAceptar;


        public void ActualizarProducto(Articulo p)
        {
            
            _articulos = p;
            articulosbd.DataSource = _articulos;            
            comboBox2.SelectedItem = _presentador.SeleccionarCategoria(p.Categoria.Id); ;
        }


        protected virtual void OnAgregarProductoAceptar(Articulo p)
        {
            AgregarProductoAceptar?.Invoke(this, p);
        }

        protected virtual void OnEditarProductoAceptar(Articulo p)
        {
            EditarProductoAceptar?.Invoke(this, p);
        }

        protected virtual void OnEliminarProductoAceptar(Articulo p)
        {
            EliminarProductoAceptar?.Invoke(this, p);
        }        

       

        public void EliminarProducto()
        {
            var resultado = MessageBox.Show("¿Deseas eliminar el Producto?", "Producto", MessageBoxButtons.OKCancel);
            if (resultado == DialogResult.OK)
            {
                OnEliminarProductoAceptar(_articulos);
                this.Dispose();
            }
        }

        public void Modificar(Articulo articuloPar)
        {
            articulosbd.DataSource = articuloPar;
            comboBox2.SelectedItem = _presentador.SeleccionarCategoria(articuloPar.Categoria.Id);
        }

        private void btn_guardar_Click_1(object sender, EventArgs e)
        {
            try
            {
                bool _cerra = false;

                if (_nuevo)
                {

                    var resultado = MessageBox.Show("¿Deseas crear el Crear Producto?", "Producto", MessageBoxButtons.OKCancel);
                    if (resultado == DialogResult.OK)
                    {
                        
                        _categoria = (CategoriaViewModel)comboBox2.SelectedItem;
                        _presentador.DevolverCategoria(_categoria.IdCategoria);                        
                        OnAgregarProductoAceptar(_articulos);
                        _cerra = true;

                    }
                }
                else
                {
                    _categoria = (CategoriaViewModel)comboBox2.SelectedItem;                    
                    _presentador.DevolverCategoria(_categoria.IdCategoria);
                    OnEditarProductoAceptar(_articulos);
                    _cerra = true;

                }

                if(_cerra)
                    this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo realizar la operacion debido a un error. " + ex.Message, "Articulo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
