namespace Proyecto_Pantalla
{
    partial class P_productos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(P_productos));
            this.img_Salir = new System.Windows.Forms.PictureBox();
            this.lbl_Productos = new System.Windows.Forms.Label();
            this.lbl_NombreProducto = new System.Windows.Forms.Label();
            this.txt_NombreProducto = new System.Windows.Forms.TextBox();
            this.lbl_PrecioProducto = new System.Windows.Forms.Label();
            this.txt_PrecioProducto = new System.Windows.Forms.TextBox();
            this.DGView_Productos = new System.Windows.Forms.DataGridView();
            this.btn_Guardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.img_Salir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGView_Productos)).BeginInit();
            this.SuspendLayout();
            // 
            // img_Salir
            // 
            this.img_Salir.Image = ((System.Drawing.Image)(resources.GetObject("img_Salir.Image")));
            this.img_Salir.Location = new System.Drawing.Point(767, 0);
            this.img_Salir.Name = "img_Salir";
            this.img_Salir.Size = new System.Drawing.Size(32, 33);
            this.img_Salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_Salir.TabIndex = 3;
            this.img_Salir.TabStop = false;
            this.img_Salir.Click += new System.EventHandler(this.img_Salir_Click);
            // 
            // lbl_Productos
            // 
            this.lbl_Productos.AutoSize = true;
            this.lbl_Productos.Font = new System.Drawing.Font("Tahoma", 26.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Productos.Location = new System.Drawing.Point(287, 37);
            this.lbl_Productos.Name = "lbl_Productos";
            this.lbl_Productos.Size = new System.Drawing.Size(195, 42);
            this.lbl_Productos.TabIndex = 4;
            this.lbl_Productos.Text = "Productos";
            // 
            // lbl_NombreProducto
            // 
            this.lbl_NombreProducto.AutoSize = true;
            this.lbl_NombreProducto.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NombreProducto.Location = new System.Drawing.Point(61, 119);
            this.lbl_NombreProducto.Name = "lbl_NombreProducto";
            this.lbl_NombreProducto.Size = new System.Drawing.Size(181, 19);
            this.lbl_NombreProducto.TabIndex = 5;
            this.lbl_NombreProducto.Text = "Nombre del Producto";
            // 
            // txt_NombreProducto
            // 
            this.txt_NombreProducto.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txt_NombreProducto.Location = new System.Drawing.Point(248, 114);
            this.txt_NombreProducto.Name = "txt_NombreProducto";
            this.txt_NombreProducto.Size = new System.Drawing.Size(187, 24);
            this.txt_NombreProducto.TabIndex = 6;
            // 
            // lbl_PrecioProducto
            // 
            this.lbl_PrecioProducto.AutoSize = true;
            this.lbl_PrecioProducto.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PrecioProducto.Location = new System.Drawing.Point(479, 119);
            this.lbl_PrecioProducto.Name = "lbl_PrecioProducto";
            this.lbl_PrecioProducto.Size = new System.Drawing.Size(60, 19);
            this.lbl_PrecioProducto.TabIndex = 7;
            this.lbl_PrecioProducto.Text = "Precio";
            // 
            // txt_PrecioProducto
            // 
            this.txt_PrecioProducto.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PrecioProducto.Location = new System.Drawing.Point(545, 115);
            this.txt_PrecioProducto.Name = "txt_PrecioProducto";
            this.txt_PrecioProducto.Size = new System.Drawing.Size(187, 23);
            this.txt_PrecioProducto.TabIndex = 8;
            // 
            // DGView_Productos
            // 
            this.DGView_Productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGView_Productos.Location = new System.Drawing.Point(65, 167);
            this.DGView_Productos.Name = "DGView_Productos";
            this.DGView_Productos.Size = new System.Drawing.Size(667, 181);
            this.DGView_Productos.TabIndex = 9;
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.BackColor = System.Drawing.Color.Black;
            this.btn_Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Guardar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Guardar.ForeColor = System.Drawing.Color.White;
            this.btn_Guardar.Location = new System.Drawing.Point(590, 376);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(175, 34);
            this.btn_Guardar.TabIndex = 17;
            this.btn_Guardar.Text = "Guardar Producto";
            this.btn_Guardar.UseVisualStyleBackColor = false;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // P_productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.DGView_Productos);
            this.Controls.Add(this.txt_PrecioProducto);
            this.Controls.Add(this.lbl_PrecioProducto);
            this.Controls.Add(this.txt_NombreProducto);
            this.Controls.Add(this.lbl_NombreProducto);
            this.Controls.Add(this.lbl_Productos);
            this.Controls.Add(this.img_Salir);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "P_productos";
            this.Text = "P_productos";
            this.Load += new System.EventHandler(this.P_productos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.img_Salir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGView_Productos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox img_Salir;
        private System.Windows.Forms.Label lbl_Productos;
        private System.Windows.Forms.Label lbl_NombreProducto;
        private System.Windows.Forms.TextBox txt_NombreProducto;
        private System.Windows.Forms.Label lbl_PrecioProducto;
        private System.Windows.Forms.TextBox txt_PrecioProducto;
        private System.Windows.Forms.DataGridView DGView_Productos;
        private System.Windows.Forms.Button btn_Guardar;
    }
}