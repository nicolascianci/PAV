
namespace Sistema.Formularios
{
    partial class Gestion_Articulos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gestion_Articulos));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nombre_articulo_ctrl = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_Agregar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_Modificar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_Eliminar = new System.Windows.Forms.ToolStripButton();
            this.gestionArticulosViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idArticuloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionArticuloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costoSinIvaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costoConIvaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioFinalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreCategoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gestionArticulosViewModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idArticuloDataGridViewTextBoxColumn,
            this.descripcionArticuloDataGridViewTextBoxColumn,
            this.costoSinIvaDataGridViewTextBoxColumn,
            this.costoConIvaDataGridViewTextBoxColumn,
            this.precioFinalDataGridViewTextBoxColumn,
            this.estadoProductoDataGridViewTextBoxColumn,
            this.nombreCategoriaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.gestionArticulosViewModelBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 5;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(853, 416);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CurrentCellChanged += new System.EventHandler(this.dataGridView1_CurrentCellChanged);
            // 
            // nombre_articulo_ctrl
            // 
            this.nombre_articulo_ctrl.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.nombre_articulo_ctrl.Dock = System.Windows.Forms.DockStyle.Top;
            this.nombre_articulo_ctrl.Location = new System.Drawing.Point(0, 25);
            this.nombre_articulo_ctrl.Name = "nombre_articulo_ctrl";
            this.nombre_articulo_ctrl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nombre_articulo_ctrl.Size = new System.Drawing.Size(853, 20);
            this.nombre_articulo_ctrl.TabIndex = 4;
            this.nombre_articulo_ctrl.TextChanged += new System.EventHandler(this.nombre_articulo_ctrl_TextChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Agregar,
            this.toolStripSeparator1,
            this.btn_Modificar,
            this.toolStripSeparator2,
            this.btn_Eliminar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(853, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Agregar.Image")));
            this.btn_Agregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(72, 22);
            this.btn_Agregar.Text = "Agregar ";
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Modificar.Image")));
            this.btn_Modificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(78, 22);
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Eliminar.Image")));
            this.btn_Eliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(70, 22);
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // gestionArticulosViewModelBindingSource
            // 
            this.gestionArticulosViewModelBindingSource.DataSource = typeof(Dominio.ViewModels.GestionArticulosViewModel);
            // 
            // idArticuloDataGridViewTextBoxColumn
            // 
            this.idArticuloDataGridViewTextBoxColumn.DataPropertyName = "IdArticulo";
            this.idArticuloDataGridViewTextBoxColumn.HeaderText = "IdArticulo";
            this.idArticuloDataGridViewTextBoxColumn.Name = "idArticuloDataGridViewTextBoxColumn";
            this.idArticuloDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descripcionArticuloDataGridViewTextBoxColumn
            // 
            this.descripcionArticuloDataGridViewTextBoxColumn.DataPropertyName = "descripcionArticulo";
            this.descripcionArticuloDataGridViewTextBoxColumn.HeaderText = "descripcionArticulo";
            this.descripcionArticuloDataGridViewTextBoxColumn.Name = "descripcionArticuloDataGridViewTextBoxColumn";
            this.descripcionArticuloDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // costoSinIvaDataGridViewTextBoxColumn
            // 
            this.costoSinIvaDataGridViewTextBoxColumn.DataPropertyName = "costoSinIva";
            this.costoSinIvaDataGridViewTextBoxColumn.HeaderText = "costoSinIva";
            this.costoSinIvaDataGridViewTextBoxColumn.Name = "costoSinIvaDataGridViewTextBoxColumn";
            this.costoSinIvaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // costoConIvaDataGridViewTextBoxColumn
            // 
            this.costoConIvaDataGridViewTextBoxColumn.DataPropertyName = "costoConIva";
            this.costoConIvaDataGridViewTextBoxColumn.HeaderText = "costoConIva";
            this.costoConIvaDataGridViewTextBoxColumn.Name = "costoConIvaDataGridViewTextBoxColumn";
            this.costoConIvaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // precioFinalDataGridViewTextBoxColumn
            // 
            this.precioFinalDataGridViewTextBoxColumn.DataPropertyName = "precioFinal";
            this.precioFinalDataGridViewTextBoxColumn.HeaderText = "precioFinal";
            this.precioFinalDataGridViewTextBoxColumn.Name = "precioFinalDataGridViewTextBoxColumn";
            this.precioFinalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estadoProductoDataGridViewTextBoxColumn
            // 
            this.estadoProductoDataGridViewTextBoxColumn.DataPropertyName = "estadoProducto";
            this.estadoProductoDataGridViewTextBoxColumn.HeaderText = "estadoProducto";
            this.estadoProductoDataGridViewTextBoxColumn.Name = "estadoProductoDataGridViewTextBoxColumn";
            this.estadoProductoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreCategoriaDataGridViewTextBoxColumn
            // 
            this.nombreCategoriaDataGridViewTextBoxColumn.DataPropertyName = "nombreCategoria";
            this.nombreCategoriaDataGridViewTextBoxColumn.HeaderText = "nombreCategoria";
            this.nombreCategoriaDataGridViewTextBoxColumn.Name = "nombreCategoriaDataGridViewTextBoxColumn";
            this.nombreCategoriaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Gestion_Articulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 461);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.nombre_articulo_ctrl);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Gestion_Articulos";
            this.Text = "Gestion_Articulos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gestionArticulosViewModelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox nombre_articulo_ctrl;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_Agregar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btn_Modificar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btn_Eliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idArticuloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionArticuloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costoSinIvaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costoConIvaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioFinalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCategoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource gestionArticulosViewModelBindingSource;
    }
}