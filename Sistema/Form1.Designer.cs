
namespace Sistema
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.vENTASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pRODUCTOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gESTIONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pCAJAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBRIRCAJAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cERRARCAJAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cONSULTARCAJASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cATEGORIAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gESTIONToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(16, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vENTASToolStripMenuItem,
            this.pRODUCTOSToolStripMenuItem,
            this.pCAJAToolStripMenuItem,
            this.cATEGORIAToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.Stretch = false;
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // vENTASToolStripMenuItem
            // 
            this.vENTASToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaVentaToolStripMenuItem,
            this.consultarVentasToolStripMenuItem});
            this.vENTASToolStripMenuItem.Image = global::Sistema.Properties.Resources.carritos_de_compra__1_;
            this.vENTASToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.vENTASToolStripMenuItem.Name = "vENTASToolStripMenuItem";
            this.vENTASToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.vENTASToolStripMenuItem.Text = "VENTAS";
            // 
            // nuevaVentaToolStripMenuItem
            // 
            this.nuevaVentaToolStripMenuItem.Name = "nuevaVentaToolStripMenuItem";
            this.nuevaVentaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nuevaVentaToolStripMenuItem.Text = "Nueva Venta";
            this.nuevaVentaToolStripMenuItem.Click += new System.EventHandler(this.nuevaVentaToolStripMenuItem_Click);
            // 
            // consultarVentasToolStripMenuItem
            // 
            this.consultarVentasToolStripMenuItem.Name = "consultarVentasToolStripMenuItem";
            this.consultarVentasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.consultarVentasToolStripMenuItem.Text = "Consultar Ventas";
            this.consultarVentasToolStripMenuItem.Click += new System.EventHandler(this.consultarVentasToolStripMenuItem_Click);
            // 
            // pRODUCTOSToolStripMenuItem
            // 
            this.pRODUCTOSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gESTIONToolStripMenuItem});
            this.pRODUCTOSToolStripMenuItem.Image = global::Sistema.Properties.Resources.pastel;
            this.pRODUCTOSToolStripMenuItem.Name = "pRODUCTOSToolStripMenuItem";
            this.pRODUCTOSToolStripMenuItem.Size = new System.Drawing.Size(102, 24);
            this.pRODUCTOSToolStripMenuItem.Text = "PRODUCTOS";
            // 
            // gESTIONToolStripMenuItem
            // 
            this.gESTIONToolStripMenuItem.Name = "gESTIONToolStripMenuItem";
            this.gESTIONToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.gESTIONToolStripMenuItem.Text = "GESTION";
            this.gESTIONToolStripMenuItem.Click += new System.EventHandler(this.gESTIONToolStripMenuItem_Click);
            // 
            // pCAJAToolStripMenuItem
            // 
            this.pCAJAToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aBRIRCAJAToolStripMenuItem,
            this.cERRARCAJAToolStripMenuItem,
            this.cONSULTARCAJASToolStripMenuItem});
            this.pCAJAToolStripMenuItem.Image = global::Sistema.Properties.Resources.caja_registradora;
            this.pCAJAToolStripMenuItem.Name = "pCAJAToolStripMenuItem";
            this.pCAJAToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.pCAJAToolStripMenuItem.Text = "CAJA";
            // 
            // aBRIRCAJAToolStripMenuItem
            // 
            this.aBRIRCAJAToolStripMenuItem.Name = "aBRIRCAJAToolStripMenuItem";
            this.aBRIRCAJAToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.aBRIRCAJAToolStripMenuItem.Text = "ABRIR CAJA";
            this.aBRIRCAJAToolStripMenuItem.Click += new System.EventHandler(this.aBRIRCAJAToolStripMenuItem_Click);
            // 
            // cERRARCAJAToolStripMenuItem
            // 
            this.cERRARCAJAToolStripMenuItem.Name = "cERRARCAJAToolStripMenuItem";
            this.cERRARCAJAToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.cERRARCAJAToolStripMenuItem.Text = "CERRAR CAJA";
            // 
            // cONSULTARCAJASToolStripMenuItem
            // 
            this.cONSULTARCAJASToolStripMenuItem.Name = "cONSULTARCAJASToolStripMenuItem";
            this.cONSULTARCAJASToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.cONSULTARCAJASToolStripMenuItem.Text = "CONSULTAR CAJAS";
            // 
            // cATEGORIAToolStripMenuItem
            // 
            this.cATEGORIAToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gESTIONToolStripMenuItem1});
            this.cATEGORIAToolStripMenuItem.Image = global::Sistema.Properties.Resources.categorias;
            this.cATEGORIAToolStripMenuItem.Name = "cATEGORIAToolStripMenuItem";
            this.cATEGORIAToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
            this.cATEGORIAToolStripMenuItem.Text = "CATEGORIA";
            // 
            // gESTIONToolStripMenuItem1
            // 
            this.gESTIONToolStripMenuItem1.Name = "gESTIONToolStripMenuItem1";
            this.gESTIONToolStripMenuItem1.Size = new System.Drawing.Size(121, 22);
            this.gESTIONToolStripMenuItem1.Text = "GESTION";
            this.gESTIONToolStripMenuItem1.Click += new System.EventHandler(this.gESTIONToolStripMenuItem1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Sistema.Properties.Resources.El_Pastelero;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(0, 28);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 422);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem vENTASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pRODUCTOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gESTIONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pCAJAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cATEGORIAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gESTIONToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem nuevaVentaToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem aBRIRCAJAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cERRARCAJAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cONSULTARCAJASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarVentasToolStripMenuItem;
    }
}

