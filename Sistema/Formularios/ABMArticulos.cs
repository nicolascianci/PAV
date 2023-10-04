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
        //Estas son variables de clase, aquí están bien los guiones bajos.
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


        public void ActualizarProducto(Articulo p)
        {
            
            _articulos = p;
            articulosbd.DataSource = _articulos;            
            comboBox2.SelectedItem = _presentador.SeleccionarCategoria(p.Categoria.Id);
        }              

       

        public void EliminarProducto()
        {
            var resultado = MessageBox.Show("¿Deseas eliminar el Producto?", "Producto", MessageBoxButtons.OKCancel);
            if (resultado == DialogResult.OK)
            {
                _presentador.EliminarProducto(this._articulos);
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
                //TODO: RECUERDA: los guiones bajos (_) solo se utilizan en variables de clase
                //NO en métodos.
                bool cerra = false;
                string mens;

                if (_nuevo)
                {

                    var resultado = MessageBox.Show("¿Deseas crear el Crear Producto?", "Producto", MessageBoxButtons.OKCancel);
                    if (resultado == DialogResult.OK)
                    {
                        
                        _categoria = (CategoriaViewModel)comboBox2.SelectedItem;
                        _presentador.DevolverCategoria(_categoria.IdCategoria);
                        //TODO: acá se realiza la invocación al evento, dentro del mismo handler
                        //(para aclarar, el handler del evento click es este mismo método)
                        //No tiene mucho sentido, ya que se podría haber realizado una llamada
                        //al presentador directamente, como se hace en la línea anterior.
                        //Como ejemplo: para que este manejador pueda ser resuelto en el presentador
                        //podrías haber suplantado el evento del click con el evento de la vista,
                        //de la siguiente manera:
                        // public event EventHandler<Articulo> AgregarProductoAceptar
                        // {add btn_guardar.Click += value }
                        // {remove btn_guardar.Click -= value}
                        //OnAgregarProductoAceptar(_articulos);
                        if (_presentador.AgregarProducto(this._articulos, out mens))
                        {
                            MessageBox.Show("Se agrego el producto exitosamente.", "Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            cerra = true;
                        }
                        else
                            MessageBox.Show(mens, "Productos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        

                    }
                }
                else
                {
                    _categoria = (CategoriaViewModel)comboBox2.SelectedItem;                    
                    _presentador.DevolverCategoria(_categoria.IdCategoria);
                    //OnEditarProductoAceptar(_articulos);
                    if(_presentador.EditarProducto(this._articulos, out mens))
                    {
                        MessageBox.Show("Se modifico el producto exitosamente.", "Producto", MessageBoxButtons.OK,MessageBoxIcon.Information);
                        cerra = true;
                    }
                    else
                        MessageBox.Show(mens, "Producto", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

                if(cerra)
                    this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo realizar la operacion debido a un error. " + ex.Message, "Articulo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
