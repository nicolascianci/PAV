
namespace Sistema.Formularios
{
    partial class Buscador_Articulos
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.articulosBs = new System.Windows.Forms.BindingSource(this.components);
            this.idArticuloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionArticuloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costoSinIvaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costoConIvaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioFinalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreCategoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articulosBs)).BeginInit();
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
            this.stockDataGridViewTextBoxColumn,
            this.estadoProductoDataGridViewTextBoxColumn,
            this.nombreCategoriaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.articulosBs;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 5;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(800, 305);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            // 
            // articulosBs
            // 
            this.articulosBs.DataSource = typeof(Sistema.ViewModels.BuscadorArticulosViewModel);
            // 
            // idArticuloDataGridViewTextBoxColumn
            // 
            this.idArticuloDataGridViewTextBoxColumn.DataPropertyName = "IdArticulo";
            this.idArticuloDataGridViewTextBoxColumn.HeaderText = "IdArticulo";
            this.idArticuloDataGridViewTextBoxColumn.Name = "idArticuloDataGridViewTextBoxColumn";
            this.idArticuloDataGridViewTextBoxColumn.ReadOnly = true;
            this.idArticuloDataGridViewTextBoxColumn.Visible = false;
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
            // stockDataGridViewTextBoxColumn
            // 
            this.stockDataGridViewTextBoxColumn.DataPropertyName = "stock";
            this.stockDataGridViewTextBoxColumn.HeaderText = "stock";
            this.stockDataGridViewTextBoxColumn.Name = "stockDataGridViewTextBoxColumn";
            this.stockDataGridViewTextBoxColumn.ReadOnly = true;
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
            // Buscador_Articulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 305);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Buscador_Articulos";
            this.Text = "Buscador_Articulos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articulosBs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource articulosBs;
        private System.Windows.Forms.DataGridViewTextBoxColumn idArticuloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionArticuloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costoSinIvaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costoConIvaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioFinalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCategoriaDataGridViewTextBoxColumn;
    }
}