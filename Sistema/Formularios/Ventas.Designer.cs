
namespace Sistema.Formularios
{
    partial class Ventas
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel_confirma_ctn = new System.Windows.Forms.Button();
            this.cantidad_txb = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.articulo_lb = new System.Windows.Forms.Label();
            this.articulos_ctrl = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idArticuloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionArticuloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioUnitarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operacionViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.articulos_txt = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Total_ctrl = new System.Windows.Forms.TextBox();
            this.descuento_txb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.total_descuento_txb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Confirmar_btn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.articulos_ctrl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.operacionViewModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.articulos_ctrl);
            this.panel1.Location = new System.Drawing.Point(12, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 259);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(198)))));
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.panel_confirma_ctn);
            this.panel2.Controls.Add(this.cantidad_txb);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.articulo_lb);
            this.panel2.Location = new System.Drawing.Point(120, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(487, 215);
            this.panel2.TabIndex = 1;
            this.panel2.Visible = false;
            // 
            // button1
            // 
            this.button1.Image = global::Sistema.Properties.Resources.volver;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(387, 154);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 58);
            this.button1.TabIndex = 11;
            this.button1.Text = "CANCELAR";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel_confirma_ctn
            // 
            this.panel_confirma_ctn.Image = global::Sistema.Properties.Resources.carritos_de_compra__1_;
            this.panel_confirma_ctn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.panel_confirma_ctn.Location = new System.Drawing.Point(291, 154);
            this.panel_confirma_ctn.Name = "panel_confirma_ctn";
            this.panel_confirma_ctn.Size = new System.Drawing.Size(80, 58);
            this.panel_confirma_ctn.TabIndex = 10;
            this.panel_confirma_ctn.Text = "CONFIRMAR";
            this.panel_confirma_ctn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.panel_confirma_ctn.UseVisualStyleBackColor = true;
            this.panel_confirma_ctn.Click += new System.EventHandler(this.panel_confirma_ctn_Click);
            // 
            // cantidad_txb
            // 
            this.cantidad_txb.Culture = new System.Globalization.CultureInfo("es-AR");
            this.cantidad_txb.Location = new System.Drawing.Point(177, 97);
            this.cantidad_txb.Mask = "#.###";
            this.cantidad_txb.Name = "cantidad_txb";
            this.cantidad_txb.Size = new System.Drawing.Size(100, 20);
            this.cantidad_txb.TabIndex = 3;
            this.cantidad_txb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.cantidad_txb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cantidad_txb_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(59, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "CANTIDAD";
            // 
            // articulo_lb
            // 
            this.articulo_lb.AutoSize = true;
            this.articulo_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.articulo_lb.Location = new System.Drawing.Point(59, 23);
            this.articulo_lb.Name = "articulo_lb";
            this.articulo_lb.Size = new System.Drawing.Size(57, 20);
            this.articulo_lb.TabIndex = 0;
            this.articulo_lb.Text = "label4";
            // 
            // articulos_ctrl
            // 
            this.articulos_ctrl.AllowUserToAddRows = false;
            this.articulos_ctrl.AllowUserToDeleteRows = false;
            this.articulos_ctrl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.articulos_ctrl.AutoGenerateColumns = false;
            this.articulos_ctrl.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.idArticuloDataGridViewTextBoxColumn,
            this.descripcionArticuloDataGridViewTextBoxColumn,
            this.precioUnitarioDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn,
            this.stockDataGridViewTextBoxColumn});
            this.articulos_ctrl.DataSource = this.operacionViewModelBindingSource;
            this.articulos_ctrl.Location = new System.Drawing.Point(3, 0);
            this.articulos_ctrl.Name = "articulos_ctrl";
            this.articulos_ctrl.ReadOnly = true;
            this.articulos_ctrl.RowHeadersWidth = 4;
            this.articulos_ctrl.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.articulos_ctrl.Size = new System.Drawing.Size(776, 255);
            this.articulos_ctrl.TabIndex = 0;
            this.articulos_ctrl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.articulos_ctrl_KeyDown);
            // 
            // id
            // 
            this.id.DataPropertyName = "idArticulo";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // idArticuloDataGridViewTextBoxColumn
            // 
            this.idArticuloDataGridViewTextBoxColumn.DataPropertyName = "idArticulo";
            this.idArticuloDataGridViewTextBoxColumn.HeaderText = "idArticulo";
            this.idArticuloDataGridViewTextBoxColumn.Name = "idArticuloDataGridViewTextBoxColumn";
            this.idArticuloDataGridViewTextBoxColumn.ReadOnly = true;
            this.idArticuloDataGridViewTextBoxColumn.Visible = false;
            // 
            // descripcionArticuloDataGridViewTextBoxColumn
            // 
            this.descripcionArticuloDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descripcionArticuloDataGridViewTextBoxColumn.DataPropertyName = "descripcionArticulo";
            this.descripcionArticuloDataGridViewTextBoxColumn.HeaderText = "descripcionArticulo";
            this.descripcionArticuloDataGridViewTextBoxColumn.Name = "descripcionArticuloDataGridViewTextBoxColumn";
            this.descripcionArticuloDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // precioUnitarioDataGridViewTextBoxColumn
            // 
            this.precioUnitarioDataGridViewTextBoxColumn.DataPropertyName = "precioUnitario";
            this.precioUnitarioDataGridViewTextBoxColumn.HeaderText = "precioUnitario";
            this.precioUnitarioDataGridViewTextBoxColumn.Name = "precioUnitarioDataGridViewTextBoxColumn";
            this.precioUnitarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            this.cantidadDataGridViewTextBoxColumn.DataPropertyName = "cantidad";
            this.cantidadDataGridViewTextBoxColumn.HeaderText = "cantidad";
            this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            this.cantidadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stockDataGridViewTextBoxColumn
            // 
            this.stockDataGridViewTextBoxColumn.DataPropertyName = "stock";
            this.stockDataGridViewTextBoxColumn.HeaderText = "stock";
            this.stockDataGridViewTextBoxColumn.Name = "stockDataGridViewTextBoxColumn";
            this.stockDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // operacionViewModelBindingSource
            // 
            this.operacionViewModelBindingSource.DataSource = typeof(Dominio.ViewModels.OperacionViewModel);
            // 
            // articulos_txt
            // 
            this.articulos_txt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.articulos_txt.Location = new System.Drawing.Point(132, 16);
            this.articulos_txt.Name = "articulos_txt";
            this.articulos_txt.Size = new System.Drawing.Size(593, 20);
            this.articulos_txt.TabIndex = 1;
            this.articulos_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.articulos_txt_KeyDown);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(50, 17);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(61, 16);
            this.label.TabIndex = 2;
            this.label.Text = "Articulo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 352);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "TOTAL";
            // 
            // Total_ctrl
            // 
            this.Total_ctrl.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Total_ctrl.Enabled = false;
            this.Total_ctrl.Location = new System.Drawing.Point(169, 354);
            this.Total_ctrl.Name = "Total_ctrl";
            this.Total_ctrl.ReadOnly = true;
            this.Total_ctrl.Size = new System.Drawing.Size(160, 20);
            this.Total_ctrl.TabIndex = 4;
            this.Total_ctrl.Text = "0";
            this.Total_ctrl.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // descuento_txb
            // 
            this.descuento_txb.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.descuento_txb.Location = new System.Drawing.Point(169, 392);
            this.descuento_txb.Name = "descuento_txb";
            this.descuento_txb.ReadOnly = true;
            this.descuento_txb.Size = new System.Drawing.Size(160, 20);
            this.descuento_txb.TabIndex = 6;
            this.descuento_txb.Text = "0";
            this.descuento_txb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.descuento_txb.Leave += new System.EventHandler(this.descuento_txb_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 392);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "DESCUENTO";
            // 
            // total_descuento_txb
            // 
            this.total_descuento_txb.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.total_descuento_txb.Enabled = false;
            this.total_descuento_txb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_descuento_txb.Location = new System.Drawing.Point(169, 428);
            this.total_descuento_txb.Name = "total_descuento_txb";
            this.total_descuento_txb.ReadOnly = true;
            this.total_descuento_txb.Size = new System.Drawing.Size(160, 22);
            this.total_descuento_txb.TabIndex = 8;
            this.total_descuento_txb.Text = "0";
            this.total_descuento_txb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 428);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "TOTAL C/DESC";
            // 
            // Confirmar_btn
            // 
            this.Confirmar_btn.Image = global::Sistema.Properties.Resources.carritos_de_compra__1_;
            this.Confirmar_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Confirmar_btn.Location = new System.Drawing.Point(645, 392);
            this.Confirmar_btn.Name = "Confirmar_btn";
            this.Confirmar_btn.Size = new System.Drawing.Size(80, 58);
            this.Confirmar_btn.TabIndex = 9;
            this.Confirmar_btn.Text = "CONFIRMAR";
            this.Confirmar_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Confirmar_btn.UseVisualStyleBackColor = true;
            this.Confirmar_btn.Click += new System.EventHandler(this.Confirmar_btn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(129, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(201, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Presione  \"Enter\" para ingresar el articulo";
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(798, 462);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Confirmar_btn);
            this.Controls.Add(this.total_descuento_txb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.descuento_txb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Total_ctrl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label);
            this.Controls.Add(this.articulos_txt);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Ventas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventas";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Ventas_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.articulos_ctrl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.operacionViewModelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView articulos_ctrl;
        private System.Windows.Forms.TextBox articulos_txt;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Total_ctrl;
        private System.Windows.Forms.TextBox descuento_txb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox total_descuento_txb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label articulo_lb;
        private System.Windows.Forms.MaskedTextBox cantidad_txb;
        private System.Windows.Forms.Button Confirmar_btn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button panel_confirma_ctn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn idArticuloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionArticuloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioUnitarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource operacionViewModelBindingSource;
    }
}