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
    public partial class Gestion_Categorias : Form, IGestion_Categorias
    {
        PresentadorGestion_Categorias _presentador;
        categoria _categoria = new categoria();

        public Gestion_Categorias()
        {
            InitializeComponent();
            _presentador = new PresentadorGestion_Categorias(this);
            this.Actualizar_Categorias();
        }

        public string nombre_categoria => this.nombre_categoria_ctrl.Text;

        public void Actualizar_Categorias()
        {
            this.BS_Categoria.DataSource = _presentador.Mostrar_Categorias();
        }

        private void nombre_categoria_ctrl_TextChanged(object sender, EventArgs e)
        {
            this.BS_Categoria.DataSource = _presentador.Buscar_Categorias();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            ABM_Categoria _form = new ABM_Categoria();
            _form._nuevo = true;
            _form.ShowDialog();
            this.Actualizar_Categorias();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            ABM_Categoria _form = new ABM_Categoria();
            _form._nuevo = false;
            _form.Modificar(_categoria);
            _form.ShowDialog();
            this.Actualizar_Categorias();
        }

        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            if (this.Categorias_DG.CurrentRow != null)
                _categoria = this.Categorias_DG.CurrentRow.DataBoundItem as categoria;
                          
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            ABM_Categoria _form = new ABM_Categoria();
            _form.Modificar(_categoria);
            _form.EliminarCategoria();
            this.Actualizar_Categorias();
        }
    }
}
