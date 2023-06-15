
namespace Sistema
{
    partial class Gestion_Categorias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gestion_Categorias));
            this.nombre_categoria_ctrl = new System.Windows.Forms.TextBox();
            this.btn_agregar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_modificar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Categorias_DG = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BS_Categoria = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Categorias_DG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_Categoria)).BeginInit();
            this.SuspendLayout();
            // 
            // nombre_categoria_ctrl
            // 
            this.nombre_categoria_ctrl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nombre_categoria_ctrl.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.nombre_categoria_ctrl.Dock = System.Windows.Forms.DockStyle.Top;
            this.nombre_categoria_ctrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre_categoria_ctrl.Location = new System.Drawing.Point(0, 40);
            this.nombre_categoria_ctrl.Name = "nombre_categoria_ctrl";
            this.nombre_categoria_ctrl.Size = new System.Drawing.Size(800, 22);
            this.nombre_categoria_ctrl.TabIndex = 1;
            this.nombre_categoria_ctrl.TextChanged += new System.EventHandler(this.nombre_categoria_ctrl_TextChanged);
            // 
            // btn_agregar
            // 
            this.btn_agregar.Image = ((System.Drawing.Image)(resources.GetObject("btn_agregar.Image")));
            this.btn_agregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(79, 37);
            this.btn_agregar.Text = "AGREGAR";
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolStripSeparator1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 40);
            // 
            // btn_modificar
            // 
            this.btn_modificar.Image = global::Sistema.Properties.Resources.pen_edit_modify_pencil_icon_181536;
            this.btn_modificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(90, 37);
            this.btn_modificar.Text = "MODIFICAR";
            this.btn_modificar.ToolTipText = "btn_modificar";
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolStripSeparator2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 40);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = global::Sistema.Properties.Resources._1486564399_close_81512;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(80, 37);
            this.toolStripButton3.Text = "ELIMINAR";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_agregar,
            this.toolStripSeparator1,
            this.btn_modificar,
            this.toolStripSeparator2,
            this.toolStripButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(800, 40);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Categorias_DG
            // 
            this.Categorias_DG.AllowUserToAddRows = false;
            this.Categorias_DG.AllowUserToDeleteRows = false;
            this.Categorias_DG.AutoGenerateColumns = false;
            this.Categorias_DG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Categorias_DG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn});
            this.Categorias_DG.DataSource = this.BS_Categoria;
            this.Categorias_DG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Categorias_DG.Location = new System.Drawing.Point(0, 62);
            this.Categorias_DG.Name = "Categorias_DG";
            this.Categorias_DG.ReadOnly = true;
            this.Categorias_DG.Size = new System.Drawing.Size(800, 388);
            this.Categorias_DG.TabIndex = 2;
            this.Categorias_DG.CurrentCellChanged += new System.EventHandler(this.dataGridView1_CurrentCellChanged);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // BS_Categoria
            // 
            this.BS_Categoria.DataSource = typeof(Dominio.Categoria);
            // 
            // Gestion_Categorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Categorias_DG);
            this.Controls.Add(this.nombre_categoria_ctrl);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Gestion_Categorias";
            this.Text = "Gestion_Categorias";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Categorias_DG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_Categoria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nombre_categoria_ctrl;
        private System.Windows.Forms.ToolStripButton btn_agregar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btn_modificar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.DataGridView Categorias_DG;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource BS_Categoria;
    }
}