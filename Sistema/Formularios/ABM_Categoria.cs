using Dominio;
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
    public partial class ABM_Categoria : Form, IABMCatagorias
    {
        Categoria _categoria = new Categoria();
        public bool _nuevo;
        private PresentadorABM_Categoria _presentador;


        public ABM_Categoria()
        {
            InitializeComponent();
            _presentador = new PresentadorABM_Categoria(this);
            BS_Categoria.DataSource = _categoria;
        }

        public event EventHandler<Categoria> AgregarCategoriaAceptar;
        public event EventHandler<Categoria> EditarCategoriaAceptar;
        public event EventHandler<Categoria> EliminarCategoriaAceptar;

        public void Modificar(Categoria categoriaPar)
        {
            _categoria = categoriaPar;
            BS_Categoria.DataSource = _categoria;
        }

        

        public void EliminarCategoria()
        {
            var resultado = MessageBox.Show("¿Deseas eliminar la Categoria?", "Categoria", MessageBoxButtons.OKCancel);
            if (resultado == DialogResult.OK)
            {
                _presentador.EliminarCategoria(_categoria);
                this.Dispose();
            }
        }

        private void guardar_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string mens;
                MessageBoxIcon icon;

                if (_nuevo)
                {
                   
                    var resultado = MessageBox.Show("¿Deseas crear la Categoria?", "Categoria", MessageBoxButtons.OKCancel);
                    if (resultado == DialogResult.OK)
                    {
                        
                        if(_presentador.AgregarCategoria(_categoria,out mens))
                        {
                            icon = MessageBoxIcon.Information;
                        }
                        else
                            icon = MessageBoxIcon.Error;

                        MessageBox.Show(mens, "CATEGORIA", MessageBoxButtons.OK, icon);
                    }

                }
                else
                {
                    if (_presentador.EditarCategoria(_categoria, out mens))
                    {
                        icon = MessageBoxIcon.Information;
                    }
                    else
                        icon = MessageBoxIcon.Error;

                    MessageBox.Show(mens, "CATEGORIA", MessageBoxButtons.OK, icon);
                }

                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puedo realizar la operacion debido a un error. " + ex.Message, "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
