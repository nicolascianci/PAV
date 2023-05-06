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
        categoria _categoria = new categoria();
        public bool _nuevo;
        private PresentadorABM_Categoria _presentador;


        public ABM_Categoria()
        {
            InitializeComponent();
            _presentador = new PresentadorABM_Categoria(this);
            BS_Categoria.DataSource = _categoria;
        }

        public event EventHandler<categoria> AgregarCategoriaAceptar;
        public event EventHandler<categoria> EditarCategoriaAceptar;
        public event EventHandler<categoria> EliminarCategoriaAceptar;

        public void Modificar(categoria categoria_par)
        {
            _categoria = categoria_par;
            BS_Categoria.DataSource = _categoria;
        }

        protected virtual void OnAgregarCategoria(categoria categoria_par)
        {
            AgregarCategoriaAceptar?.Invoke(this, categoria_par);
        }

        protected virtual void OnEditarCategiaAceptar(categoria categoria_par)
        {
            EditarCategoriaAceptar?.Invoke(this, categoria_par);
        }

        protected virtual void OnEliminarCategoriaAceptar(categoria categoria_par)
        {
            EliminarCategoriaAceptar?.Invoke(this, categoria_par);
        }

        public void EliminarCategoria()
        {
            var resultado = MessageBox.Show("¿Deseas eliminar la Categoria?", "Categoria", MessageBoxButtons.OKCancel);
            if (resultado == DialogResult.OK)
            {
                OnEliminarCategoriaAceptar(_categoria);
                this.Dispose();
            }
        }

        private void guardar_btn_Click(object sender, EventArgs e)
        {
            if(_nuevo)
            {
                var resultado = MessageBox.Show("¿Deseas crear la Categoria?", "Categoria", MessageBoxButtons.OKCancel);
                if (resultado == DialogResult.OK)
                {
                    OnAgregarCategoria(_categoria);
                }
                
            }
            else
            {
                OnEditarCategiaAceptar(_categoria);
            }

            this.Dispose();
        }
    }
}
