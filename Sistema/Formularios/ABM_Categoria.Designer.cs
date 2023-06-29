
namespace Sistema.Formularios
{
    partial class ABM_Categoria
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
            this.label1 = new System.Windows.Forms.Label();
            this.nombre_categoria_ctrl = new System.Windows.Forms.TextBox();
            this.BS_Categoria = new System.Windows.Forms.BindingSource(this.components);
            this.guardar_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BS_Categoria)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "NOMBRE";
            // 
            // nombre_categoria_ctrl
            // 
            this.nombre_categoria_ctrl.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.nombre_categoria_ctrl.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BS_Categoria, "Nombre", true));
            this.nombre_categoria_ctrl.Location = new System.Drawing.Point(138, 44);
            this.nombre_categoria_ctrl.Name = "nombre_categoria_ctrl";
            this.nombre_categoria_ctrl.Size = new System.Drawing.Size(419, 20);
            this.nombre_categoria_ctrl.TabIndex = 1;
            // 
            // BS_Categoria
            // 
            this.BS_Categoria.DataSource = typeof(Dominio.Categoria);
            // 
            // guardar_btn
            // 
            this.guardar_btn.Image = global::Sistema.Properties.Resources.Guardar;
            this.guardar_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.guardar_btn.Location = new System.Drawing.Point(581, 27);
            this.guardar_btn.Name = "guardar_btn";
            this.guardar_btn.Size = new System.Drawing.Size(79, 58);
            this.guardar_btn.TabIndex = 2;
            this.guardar_btn.Text = "GUARDAR";
            this.guardar_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.guardar_btn.UseVisualStyleBackColor = true;
            this.guardar_btn.Click += new System.EventHandler(this.guardar_btn_Click);
            // 
            // ABM_Categoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 100);
            this.Controls.Add(this.guardar_btn);
            this.Controls.Add(this.nombre_categoria_ctrl);
            this.Controls.Add(this.label1);
            this.Name = "ABM_Categoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABM_Categoria";
            ((System.ComponentModel.ISupportInitialize)(this.BS_Categoria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nombre_categoria_ctrl;
        private System.Windows.Forms.Button guardar_btn;
        private System.Windows.Forms.BindingSource BS_Categoria;
    }
}