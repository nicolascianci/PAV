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
            string mens;
            if (_presentador.AbrirCaja(out mens))
            {
                MessageBox.Show(mens, "CAJA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult result = MessageBox.Show(mens, "CAJA", MessageBoxButtons.YesNo);

                mens = "";
                if (result == DialogResult.Yes)
                    _presentador.CerrarAbrirCaja(out mens);

                MessageBox.Show(mens, "CAJA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void consultarVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ventas_Consultas _from = new Ventas_Consultas();
            _from.ShowDialog();
        }
    }
}
