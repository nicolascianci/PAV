using Dominio;
using Interfaces;
using Presentadores;
using Sistema.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema
{
    public partial class Gestion_Categorias : Form, IGestionCategorias
    {
        PresentadorGestionCategorias _presentador;
        Categoria _categoria = new Categoria();

        public Gestion_Categorias()
        {
            InitializeComponent();
            _presentador = new PresentadorGestionCategorias(this);
            this.ActualizarCategorias();
        }

        public string NombreCategoria => this.nombre_categoria_ctrl.Text;

        public void ActualizarCategorias()
        {
            this.BS_Categoria.DataSource = _presentador.MostrarCategorias();
        }

        private void nombre_categoria_ctrl_TextChanged(object sender, EventArgs e)
        {
            this.BS_Categoria.DataSource = _presentador.BuscarCategorias();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            ABM_Categoria _form = new ABM_Categoria();
            _form._nuevo = true;
            _form.ShowDialog();
            this.ActualizarCategorias();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            ABM_Categoria _form = new ABM_Categoria();
            _form._nuevo = false;
            _form.Modificar(_categoria);
            _form.ShowDialog();
            this.ActualizarCategorias();
        }

        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            if (this.Categorias_DG.CurrentRow != null)
                _categoria = this.Categorias_DG.CurrentRow.DataBoundItem as Categoria;
                          
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            ABM_Categoria _form = new ABM_Categoria();
            _form.Modificar(_categoria);
            _form.EliminarCategoria();
            this.ActualizarCategorias();
        }
    }
}
