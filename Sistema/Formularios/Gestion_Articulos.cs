﻿using Dominio;
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
    public partial class Gestion_Articulos : Form, IGestion_Producto
    {

        private PresentadorGestion_Articulos _presentador;
        //private List<VistaProducto> _productos = new List<VistaProducto>();
        private articulo _articulo;


        public Gestion_Articulos()
        {
            InitializeComponent();
            _presentador = new PresentadorGestion_Articulos(this);
            this.ActualizarLista();
        }

        public string nombre_articulo => this.nombre_articulo_ctrl.Text;

        public void ActualizarLista()
        {
            Articulos_BS.DataSource = _presentador.ActualizarListado();
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            ABM_Articulos _formulario = new ABM_Articulos();
            _formulario._nuevo = true;
            _formulario.ShowDialog();
            this.ActualizarLista();
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            ABM_Articulos _formulario = new ABM_Articulos();
            _formulario._nuevo = false;
            _formulario.ActualizarProducto(_articulo);
            _formulario.ShowDialog();
            this.ActualizarLista();
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            ABM_Articulos _formulario = new ABM_Articulos();
            _formulario.ActualizarProducto(_articulo);
            _formulario.EliminarProducto();
            this.ActualizarLista();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //_articulo = dataGridView1.CurrentRow.DataBoundItem as articulo;
        }

        private void nombre_articulo_ctrl_TextChanged(object sender, EventArgs e)
        {
            Articulos_BS.DataSource = _presentador.BuscarProductos(this.nombre_articulo_ctrl.Text);
        }

        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            if(dataGridView1.CurrentRow != null)
                _articulo = dataGridView1.CurrentRow.DataBoundItem as articulo;
        }
    }
}
