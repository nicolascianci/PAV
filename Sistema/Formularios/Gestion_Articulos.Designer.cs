
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gestion_Articulos));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costoSinIvaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.porcentajeIvaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costoConIvaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.margenDeGananciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preciofinalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriaestadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Articulos_BS = new System.Windows.Forms.BindingSource(this.components);
            this.nombre_articulo_ctrl = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_Agregar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_Modificar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_Eliminar = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Articulos_BS)).BeginInit();
            this.toolStrip1.SuspendLayout();
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
            this.idDataGridViewTextBoxColumn,
            this.codigoDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.costoSinIvaDataGridViewTextBoxColumn,
            this.porcentajeIvaDataGridViewTextBoxColumn,
            this.costoConIvaDataGridViewTextBoxColumn,
            this.margenDeGananciaDataGridViewTextBoxColumn,
            this.preciofinalDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn,
            this.categoriaestadoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.Articulos_BS;
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
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo";
            this.codigoDataGridViewTextBoxColumn.HeaderText = "Codigo";
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            this.codigoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // costoSinIvaDataGridViewTextBoxColumn
            // 
            this.costoSinIvaDataGridViewTextBoxColumn.DataPropertyName = "CostoSinIva";
            dataGridViewCellStyle1.Format = "N2";
            this.costoSinIvaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.costoSinIvaDataGridViewTextBoxColumn.HeaderText = "CostoSinIva";
            this.costoSinIvaDataGridViewTextBoxColumn.Name = "costoSinIvaDataGridViewTextBoxColumn";
            this.costoSinIvaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // porcentajeIvaDataGridViewTextBoxColumn
            // 
            this.porcentajeIvaDataGridViewTextBoxColumn.DataPropertyName = "PorcentajeIva";
            dataGridViewCellStyle2.Format = "p";
            dataGridViewCellStyle2.NullValue = null;
            this.porcentajeIvaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.porcentajeIvaDataGridViewTextBoxColumn.HeaderText = "PorcentajeIva";
            this.porcentajeIvaDataGridViewTextBoxColumn.Name = "porcentajeIvaDataGridViewTextBoxColumn";
            this.porcentajeIvaDataGridViewTextBoxColumn.ReadOnly = true;
            this.porcentajeIvaDataGridViewTextBoxColumn.Visible = false;
            // 
            // costoConIvaDataGridViewTextBoxColumn
            // 
            this.costoConIvaDataGridViewTextBoxColumn.DataPropertyName = "CostoConIva";
            dataGridViewCellStyle3.Format = "N2";
            this.costoConIvaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.costoConIvaDataGridViewTextBoxColumn.HeaderText = "CostoConIva";
            this.costoConIvaDataGridViewTextBoxColumn.Name = "costoConIvaDataGridViewTextBoxColumn";
            this.costoConIvaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // margenDeGananciaDataGridViewTextBoxColumn
            // 
            this.margenDeGananciaDataGridViewTextBoxColumn.DataPropertyName = "MargenDeGanancia";
            this.margenDeGananciaDataGridViewTextBoxColumn.HeaderText = "MargenDeGanancia";
            this.margenDeGananciaDataGridViewTextBoxColumn.Name = "margenDeGananciaDataGridViewTextBoxColumn";
            this.margenDeGananciaDataGridViewTextBoxColumn.ReadOnly = true;
            this.margenDeGananciaDataGridViewTextBoxColumn.Visible = false;
            // 
            // preciofinalDataGridViewTextBoxColumn
            // 
            this.preciofinalDataGridViewTextBoxColumn.DataPropertyName = "Preciofinal";
            dataGridViewCellStyle4.Format = "N2";
            this.preciofinalDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.preciofinalDataGridViewTextBoxColumn.HeaderText = "Preciofinal";
            this.preciofinalDataGridViewTextBoxColumn.Name = "preciofinalDataGridViewTextBoxColumn";
            this.preciofinalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "Estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            this.estadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoriaestadoDataGridViewTextBoxColumn
            // 
            this.categoriaestadoDataGridViewTextBoxColumn.DataPropertyName = "CategoriaId";
            this.categoriaestadoDataGridViewTextBoxColumn.HeaderText = "Categoria";
            this.categoriaestadoDataGridViewTextBoxColumn.Name = "categoriaestadoDataGridViewTextBoxColumn";
            this.categoriaestadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Articulos_BS
            // 
            this.Articulos_BS.DataSource = typeof(Dominio.articulo);
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
            ((System.ComponentModel.ISupportInitialize)(this.Articulos_BS)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
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
        private System.Windows.Forms.BindingSource Articulos_BS;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costoSinIvaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn porcentajeIvaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costoConIvaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn margenDeGananciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn preciofinalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoriaestadoDataGridViewTextBoxColumn;
    }
}