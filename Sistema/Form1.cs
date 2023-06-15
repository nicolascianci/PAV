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
    public partial class Form1 : Form
    {
        PresentadorInicio _presentador;
        public Form1()
        {
            InitializeComponent();
            this.pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            //this.BackgroundImageLayout = ImageLayout.Stretch;
            _presentador = new PresentadorInicio();
        }

        private void gESTIONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gestion_Articulos _form = new Gestion_Articulos();
            _form.ShowDialog();
        }

        private void gESTIONToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Gestion_Categorias _form = new Gestion_Categorias();
            _form.ShowDialog();
        }

        private void nuevaVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ventas _form = new Ventas();
            _form.ShowDialog();
        }

        private void aBRIRCAJAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _presentador.Abrir_Caja();
        }

        private void consultarVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ventas_Consultas _from = new Ventas_Consultas();
            _from.ShowDialog();
        }
    }
}
