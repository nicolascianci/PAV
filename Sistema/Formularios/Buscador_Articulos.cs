using Dominio;
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
    public partial class Buscador_Articulos : Form
    {
        public Buscador_Articulos(List<articulo> lista_articulos_par)
        {
            InitializeComponent();
            this.articulos_bs.DataSource = lista_articulos_par;
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.Enter:
                    if (dataGridView1.CurrentRow != null)
                        this.Tag = (articulo)this.dataGridView1.CurrentRow.DataBoundItem;
                    else
                        this.Tag = null;
                    
                    this.Dispose();
                    break;
            }
        }
    }
}
