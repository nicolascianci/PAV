namespace Sistema.Formularios
{
    partial class Ventas_Consultas
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Hasta_ctrl = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.desde_ctrl = new System.Windows.Forms.MaskedTextBox();
            this.ventas_grilla = new System.Windows.Forms.DataGridView();
            this.ven = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bds_ventas = new System.Windows.Forms.BindingSource(this.components);
            this.btn_Salir = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.total_txt = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ventas_grilla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_ventas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_guardar);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Hasta_ctrl);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.desde_ctrl);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(874, 83);
            this.panel1.TabIndex = 0;
            // 
            // btn_guardar
            // 
            this.btn_guardar.Image = global::Sistema.Properties.Resources.buscar;
            this.btn_guardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_guardar.Location = new System.Drawing.Point(500, 11);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(85, 53);
            this.btn_guardar.TabIndex = 11;
            this.btn_guardar.Text = "BUSCAR";
            this.btn_guardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(263, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hasta";
            // 
            // Hasta_ctrl
            // 
            this.Hasta_ctrl.Location = new System.Drawing.Point(338, 31);
            this.Hasta_ctrl.Mask = "99/99/9999";
            this.Hasta_ctrl.Name = "Hasta_ctrl";
            this.Hasta_ctrl.Size = new System.Drawing.Size(100, 20);
            this.Hasta_ctrl.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Desde";
            // 
            // desde_ctrl
            // 
            this.desde_ctrl.Location = new System.Drawing.Point(115, 31);
            this.desde_ctrl.Mask = "99/99/9999";
            this.desde_ctrl.Name = "desde_ctrl";
            this.desde_ctrl.Size = new System.Drawing.Size(100, 20);
            this.desde_ctrl.TabIndex = 0;
            // 
            // ventas_grilla
            // 
            this.ventas_grilla.AllowUserToAddRows = false;
            this.ventas_grilla.AllowUserToDeleteRows = false;
            this.ventas_grilla.AutoGenerateColumns = false;
            this.ventas_grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ventas_grilla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ven,
            this.fac,
            this.fecha,
            this.total});
            this.ventas_grilla.DataSource = this.bds_ventas;
            this.ventas_grilla.Location = new System.Drawing.Point(0, 89);
            this.ventas_grilla.Name = "ventas_grilla";
            this.ventas_grilla.ReadOnly = true;
            this.ventas_grilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ventas_grilla.Size = new System.Drawing.Size(874, 295);
            this.ventas_grilla.TabIndex = 1;
            this.ventas_grilla.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ventas_grilla_CellDoubleClick);
            // 
            // ven
            // 
            this.ven.DataPropertyName = "codigo";
            this.ven.HeaderText = "Nº Venta";
            this.ven.Name = "ven";
            this.ven.ReadOnly = true;
            // 
            // fac
            // 
            this.fac.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fac.DataPropertyName = "columna1";
            this.fac.HeaderText = "Factura";
            this.fac.Name = "fac";
            this.fac.ReadOnly = true;
            // 
            // fecha
            // 
            this.fecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.fecha.DataPropertyName = "columna3";
            this.fecha.HeaderText = "Fecha Venta";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            this.fecha.Width = 200;
            // 
            // total
            // 
            this.total.DataPropertyName = "columna2";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N2";
            this.total.DefaultCellStyle = dataGridViewCellStyle1;
            this.total.HeaderText = "Total";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            // 
            // btn_Salir
            // 
            this.btn_Salir.Image = global::Sistema.Properties.Resources.salida;
            this.btn_Salir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Salir.Location = new System.Drawing.Point(778, 442);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(85, 53);
            this.btn_Salir.TabIndex = 12;
            this.btn_Salir.Text = "SALIR";
            this.btn_Salir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Image = global::Sistema.Properties.Resources.cerrar;
            this.btn_Cancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Cancelar.Location = new System.Drawing.Point(677, 442);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(85, 53);
            this.btn_Cancelar.TabIndex = 11;
            this.btn_Cancelar.Text = "CANCELAR";
            this.btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(674, 397);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Total";
            // 
            // total_txt
            // 
            this.total_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_txt.Location = new System.Drawing.Point(719, 395);
            this.total_txt.Name = "total_txt";
            this.total_txt.ReadOnly = true;
            this.total_txt.Size = new System.Drawing.Size(100, 22);
            this.total_txt.TabIndex = 14;
            this.total_txt.Text = "0,00";
            this.total_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 399);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(237, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Haga \"Doble Clic\" para ver el detalle de la venta";
            // 
            // Ventas_Consultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 507);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.total_txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.ventas_grilla);
            this.Controls.Add(this.panel1);
            this.Name = "Ventas_Consultas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Ventas";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ventas_grilla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_ventas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView ventas_grilla;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox Hasta_ctrl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox desde_ctrl;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.BindingSource bds_ventas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox total_txt;
        private System.Windows.Forms.DataGridViewTextBoxColumn ven;
        private System.Windows.Forms.DataGridViewTextBoxColumn fac;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.Label label4;
    }
}