
namespace Sistema.Formularios
{
    partial class ABM_Articulos
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.articulosbd = new System.Windows.Forms.BindingSource(this.components);
            this.txt_PrecioFinal = new System.Windows.Forms.TextBox();
            this.txt_Margen = new System.Windows.Forms.TextBox();
            this.txt_CCIVA = new System.Windows.Forms.TextBox();
            this.txt_PorcIVA = new System.Windows.Forms.TextBox();
            this.txt_CSIVA = new System.Windows.Forms.TextBox();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.categorias_bs = new System.Windows.Forms.BindingSource(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.stock_txt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.datosGrillaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.articulosbd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorias_bs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosGrillaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.articulosbd, "Estado", true));
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.articulosbd, "Estado", true));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(143, 333);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(202, 21);
            this.comboBox1.TabIndex = 8;
            // 
            // articulosbd
            // 
            this.articulosbd.DataSource = typeof(Dominio.articulo);
            // 
            // txt_PrecioFinal
            // 
            this.txt_PrecioFinal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.articulosbd, "Preciofinal", true));
            this.txt_PrecioFinal.Enabled = false;
            this.txt_PrecioFinal.Location = new System.Drawing.Point(143, 258);
            this.txt_PrecioFinal.Name = "txt_PrecioFinal";
            this.txt_PrecioFinal.Size = new System.Drawing.Size(411, 20);
            this.txt_PrecioFinal.TabIndex = 6;
            // 
            // txt_Margen
            // 
            this.txt_Margen.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.articulosbd, "MargenDeGanancia", true));
            this.txt_Margen.Location = new System.Drawing.Point(145, 217);
            this.txt_Margen.Name = "txt_Margen";
            this.txt_Margen.Size = new System.Drawing.Size(411, 20);
            this.txt_Margen.TabIndex = 5;
            // 
            // txt_CCIVA
            // 
            this.txt_CCIVA.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.articulosbd, "CostoConIva", true));
            this.txt_CCIVA.Enabled = false;
            this.txt_CCIVA.Location = new System.Drawing.Point(145, 182);
            this.txt_CCIVA.Name = "txt_CCIVA";
            this.txt_CCIVA.Size = new System.Drawing.Size(411, 20);
            this.txt_CCIVA.TabIndex = 4;
            // 
            // txt_PorcIVA
            // 
            this.txt_PorcIVA.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.articulosbd, "PorcentajeIva", true));
            this.txt_PorcIVA.Location = new System.Drawing.Point(145, 144);
            this.txt_PorcIVA.Name = "txt_PorcIVA";
            this.txt_PorcIVA.Size = new System.Drawing.Size(411, 20);
            this.txt_PorcIVA.TabIndex = 3;
            // 
            // txt_CSIVA
            // 
            this.txt_CSIVA.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.articulosbd, "CostoSinIva", true));
            this.txt_CSIVA.Location = new System.Drawing.Point(145, 104);
            this.txt_CSIVA.Name = "txt_CSIVA";
            this.txt_CSIVA.Size = new System.Drawing.Size(411, 20);
            this.txt_CSIVA.TabIndex = 2;
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_descripcion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.articulosbd, "Descripcion", true));
            this.txt_descripcion.Location = new System.Drawing.Point(145, 65);
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(411, 20);
            this.txt_descripcion.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 336);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Estado";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 261);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Precio de Venta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Margen de Ganancia";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Costo Con Iva";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Porc. IVA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Costo Sin Iva";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Descripcion";
            // 
            // txt_codigo
            // 
            this.txt_codigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_codigo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.articulosbd, "Codigo", true));
            this.txt_codigo.Location = new System.Drawing.Point(145, 27);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(411, 20);
            this.txt_codigo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Codigo";
            // 
            // btn_guardar
            // 
            this.btn_guardar.Image = global::Sistema.Properties.Resources.Guardar;
            this.btn_guardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_guardar.Location = new System.Drawing.Point(632, 385);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(85, 53);
            this.btn_guardar.TabIndex = 10;
            this.btn_guardar.Text = "GUARDAR";
            this.btn_guardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click_1);
            // 
            // categorias_bs
            // 
            this.categorias_bs.DataSource = typeof(Dominio.categoria);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 373);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 34;
            this.label9.Text = "Categoria";
            // 
            // stock_txt
            // 
            this.stock_txt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.articulosbd, "stock", true));
            this.stock_txt.Location = new System.Drawing.Point(143, 294);
            this.stock_txt.Name = "stock_txt";
            this.stock_txt.Size = new System.Drawing.Size(411, 20);
            this.stock_txt.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(29, 297);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 36;
            this.label10.Text = "Stock";
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.categorias_bs, "Nombre", true));
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.datosGrillaBindingSource, "codigo", true));
            this.comboBox2.DataSource = this.datosGrillaBindingSource;
            this.comboBox2.DisplayMember = "columna1";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(143, 370);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(202, 21);
            this.comboBox2.TabIndex = 9;
            this.comboBox2.ValueMember = "codigo";
            // 
            // datosGrillaBindingSource
            // 
            this.datosGrillaBindingSource.DataSource = typeof(Dominio.Datos_Grilla);
            // 
            // ABM_Articulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.stock_txt);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txt_PrecioFinal);
            this.Controls.Add(this.txt_Margen);
            this.Controls.Add(this.txt_CCIVA);
            this.Controls.Add(this.txt_PorcIVA);
            this.Controls.Add(this.txt_CSIVA);
            this.Controls.Add(this.txt_descripcion);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_codigo);
            this.Controls.Add(this.label1);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.categorias_bs, "Nombre", true));
            this.Name = "ABM_Articulos";
            this.Text = "ABM_Articulos";
            ((System.ComponentModel.ISupportInitialize)(this.articulosbd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorias_bs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosGrillaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txt_PrecioFinal;
        private System.Windows.Forms.TextBox txt_Margen;
        private System.Windows.Forms.TextBox txt_CCIVA;
        private System.Windows.Forms.TextBox txt_PorcIVA;
        private System.Windows.Forms.TextBox txt_CSIVA;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.BindingSource articulosbd;
        private System.Windows.Forms.BindingSource categorias_bs;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox stock_txt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.BindingSource datosGrillaBindingSource;
    }
}