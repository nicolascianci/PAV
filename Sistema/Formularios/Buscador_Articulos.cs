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
using Sistema.ViewModels;
using Datos;

namespace Sistema.Formularios
{
    public partial class Buscador_Articulos : Form
    {
        RepositorioArticulos repositorio = new RepositorioArticulos();

        public Buscador_Articulos(List<Articulo> lista_articulos_par)
        {
            InitializeComponent();
            
            this.articulosBs.DataSource = lista_articulos_par
                .Select(p => new BuscadorArticulosViewModel
                {
                    IdArticulo = p.Id,
                    DescripcionArticulo = p.Descripcion,
                    CostoSinIva = p.CostoSinIva,
                    CostoConIva = p.CostoConIva,
                    PrecioFinal = p.Preciofinal,
                    Stock = p.Stock,
                    EstadoProducto = p.Estado,
                    NombreCategoria = p.Categoria.Nombre

                });
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.Enter:
                    if (dataGridView1.CurrentRow != null)
                    {
                        BuscadorArticulosViewModel articulo = (BuscadorArticulosViewModel)this.dataGridView1.CurrentRow.DataBoundItem;
                        this.Tag = repositorio.Uno(articulo.IdArticulo);
                    }
                    else
                        this.Tag = null;
                    
                    this.Dispose();
                    break;
            }
        }
    }
}
