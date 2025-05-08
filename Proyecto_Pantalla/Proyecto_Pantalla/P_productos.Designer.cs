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
            this.gpbox_IngresarProductos = new System.Windows.Forms.GroupBox();
            this.txt_Stock = new System.Windows.Forms.TextBox();
            this.ListBox_CategoriaProducto = new System.Windows.Forms.ComboBox();
            this.lbl_Stock = new System.Windows.Forms.Label();
            this.lbl_Categoria = new System.Windows.Forms.Label();
            this.txt_Descripcion = new System.Windows.Forms.TextBox();
            this.lbl_Descripcion = new System.Windows.Forms.Label();
            this.gpbox_EliminarProducto = new System.Windows.Forms.GroupBox();
            this.txt_IdProducto = new System.Windows.Forms.TextBox();
            this.lbl_IdProducto = new System.Windows.Forms.Label();
            this.btn_EliminarProducto = new System.Windows.Forms.Button();
            this.btn_EditarProducto = new System.Windows.Forms.Button();
            this.gpbox_EditarProducto = new System.Windows.Forms.GroupBox();
            this.txt_EditarStock = new System.Windows.Forms.TextBox();
            this.ListBox_EditarCategoriaProducto = new System.Windows.Forms.ComboBox();
            this.lbl_EditarStock = new System.Windows.Forms.Label();
            this.lbl_Editar_Categoria = new System.Windows.Forms.Label();
            this.txt_EditarDescripcion = new System.Windows.Forms.TextBox();
            this.lbl_EditarDescripcion = new System.Windows.Forms.Label();
            this.txt_EditarNombre = new System.Windows.Forms.TextBox();
            this.lbl_EditarNombre = new System.Windows.Forms.Label();
            this.lbl_EditarPrecio = new System.Windows.Forms.Label();
            this.txt_EditarPrecio = new System.Windows.Forms.TextBox();
            this.txt_Editar_IdProducto = new System.Windows.Forms.TextBox();
            this.lbl_Editar_IdProducto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.img_Salir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGView_Productos)).BeginInit();
            this.gpbox_IngresarProductos.SuspendLayout();
            this.gpbox_EliminarProducto.SuspendLayout();
            this.gpbox_EditarProducto.SuspendLayout();
            this.SuspendLayout();
            // 
            // img_Salir
            // 
            this.img_Salir.Image = ((System.Drawing.Image)(resources.GetObject("img_Salir.Image")));
            this.img_Salir.Location = new System.Drawing.Point(867, 0);
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
            this.lbl_Productos.Font = new System.Drawing.Font("Tahoma", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
            this.lbl_Productos.Location = new System.Drawing.Point(1, 0);
            this.lbl_Productos.Name = "lbl_Productos";
            this.lbl_Productos.Size = new System.Drawing.Size(106, 23);
            this.lbl_Productos.TabIndex = 4;
            this.lbl_Productos.Text = "Productos";
            // 
            // lbl_NombreProducto
            // 
            this.lbl_NombreProducto.AutoSize = true;
            this.lbl_NombreProducto.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NombreProducto.Location = new System.Drawing.Point(21, 29);
            this.lbl_NombreProducto.Name = "lbl_NombreProducto";
            this.lbl_NombreProducto.Size = new System.Drawing.Size(56, 16);
            this.lbl_NombreProducto.TabIndex = 5;
            this.lbl_NombreProducto.Text = "Nombre";
            // 
            // txt_NombreProducto
            // 
            this.txt_NombreProducto.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NombreProducto.Location = new System.Drawing.Point(107, 26);
            this.txt_NombreProducto.Name = "txt_NombreProducto";
            this.txt_NombreProducto.Size = new System.Drawing.Size(213, 23);
            this.txt_NombreProducto.TabIndex = 6;
            // 
            // lbl_PrecioProducto
            // 
            this.lbl_PrecioProducto.AutoSize = true;
            this.lbl_PrecioProducto.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PrecioProducto.Location = new System.Drawing.Point(30, 80);
            this.lbl_PrecioProducto.Name = "lbl_PrecioProducto";
            this.lbl_PrecioProducto.Size = new System.Drawing.Size(47, 16);
            this.lbl_PrecioProducto.TabIndex = 7;
            this.lbl_PrecioProducto.Text = "Precio";
            // 
            // txt_PrecioProducto
            // 
            this.txt_PrecioProducto.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PrecioProducto.Location = new System.Drawing.Point(107, 81);
            this.txt_PrecioProducto.Name = "txt_PrecioProducto";
            this.txt_PrecioProducto.Size = new System.Drawing.Size(213, 23);
            this.txt_PrecioProducto.TabIndex = 8;
            // 
            // DGView_Productos
            // 
            this.DGView_Productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGView_Productos.Location = new System.Drawing.Point(60, 208);
            this.DGView_Productos.Name = "DGView_Productos";
            this.DGView_Productos.Size = new System.Drawing.Size(780, 180);
            this.DGView_Productos.TabIndex = 9;
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.BackColor = System.Drawing.Color.Green;
            this.btn_Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Guardar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Guardar.ForeColor = System.Drawing.Color.White;
            this.btn_Guardar.Location = new System.Drawing.Point(704, 394);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(175, 34);
            this.btn_Guardar.TabIndex = 17;
            this.btn_Guardar.Text = "Guardar Producto";
            this.btn_Guardar.UseVisualStyleBackColor = false;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // gpbox_IngresarProductos
            // 
            this.gpbox_IngresarProductos.BackColor = System.Drawing.SystemColors.ControlDark;
            this.gpbox_IngresarProductos.Controls.Add(this.txt_Stock);
            this.gpbox_IngresarProductos.Controls.Add(this.ListBox_CategoriaProducto);
            this.gpbox_IngresarProductos.Controls.Add(this.lbl_Stock);
            this.gpbox_IngresarProductos.Controls.Add(this.lbl_Categoria);
            this.gpbox_IngresarProductos.Controls.Add(this.txt_Descripcion);
            this.gpbox_IngresarProductos.Controls.Add(this.lbl_Descripcion);
            this.gpbox_IngresarProductos.Controls.Add(this.txt_NombreProducto);
            this.gpbox_IngresarProductos.Controls.Add(this.lbl_NombreProducto);
            this.gpbox_IngresarProductos.Controls.Add(this.lbl_PrecioProducto);
            this.gpbox_IngresarProductos.Controls.Add(this.txt_PrecioProducto);
            this.gpbox_IngresarProductos.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbox_IngresarProductos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gpbox_IngresarProductos.Location = new System.Drawing.Point(20, 39);
            this.gpbox_IngresarProductos.Name = "gpbox_IngresarProductos";
            this.gpbox_IngresarProductos.Size = new System.Drawing.Size(326, 163);
            this.gpbox_IngresarProductos.TabIndex = 18;
            this.gpbox_IngresarProductos.TabStop = false;
            this.gpbox_IngresarProductos.Text = "Ingresar Productos";
            // 
            // txt_Stock
            // 
            this.txt_Stock.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Stock.Location = new System.Drawing.Point(107, 134);
            this.txt_Stock.Name = "txt_Stock";
            this.txt_Stock.Size = new System.Drawing.Size(213, 23);
            this.txt_Stock.TabIndex = 17;
            // 
            // ListBox_CategoriaProducto
            // 
            this.ListBox_CategoriaProducto.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListBox_CategoriaProducto.FormattingEnabled = true;
            this.ListBox_CategoriaProducto.Items.AddRange(new object[] {
            "",
            "Hogar",
            "Tecnologia",
            "Ropa"});
            this.ListBox_CategoriaProducto.Location = new System.Drawing.Point(107, 106);
            this.ListBox_CategoriaProducto.Name = "ListBox_CategoriaProducto";
            this.ListBox_CategoriaProducto.Size = new System.Drawing.Size(213, 24);
            this.ListBox_CategoriaProducto.TabIndex = 16;
            // 
            // lbl_Stock
            // 
            this.lbl_Stock.AutoSize = true;
            this.lbl_Stock.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Stock.Location = new System.Drawing.Point(30, 135);
            this.lbl_Stock.Name = "lbl_Stock";
            this.lbl_Stock.Size = new System.Drawing.Size(43, 16);
            this.lbl_Stock.TabIndex = 12;
            this.lbl_Stock.Text = "Stock";
            // 
            // lbl_Categoria
            // 
            this.lbl_Categoria.AutoSize = true;
            this.lbl_Categoria.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Categoria.Location = new System.Drawing.Point(21, 109);
            this.lbl_Categoria.Name = "lbl_Categoria";
            this.lbl_Categoria.Size = new System.Drawing.Size(70, 16);
            this.lbl_Categoria.TabIndex = 11;
            this.lbl_Categoria.Text = "Categoria";
            // 
            // txt_Descripcion
            // 
            this.txt_Descripcion.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Descripcion.Location = new System.Drawing.Point(107, 52);
            this.txt_Descripcion.Name = "txt_Descripcion";
            this.txt_Descripcion.Size = new System.Drawing.Size(213, 23);
            this.txt_Descripcion.TabIndex = 10;
            // 
            // lbl_Descripcion
            // 
            this.lbl_Descripcion.AutoSize = true;
            this.lbl_Descripcion.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_Descripcion.Location = new System.Drawing.Point(6, 52);
            this.lbl_Descripcion.Name = "lbl_Descripcion";
            this.lbl_Descripcion.Size = new System.Drawing.Size(81, 16);
            this.lbl_Descripcion.TabIndex = 9;
            this.lbl_Descripcion.Text = "Descripcion";
            // 
            // gpbox_EliminarProducto
            // 
            this.gpbox_EliminarProducto.BackColor = System.Drawing.SystemColors.ControlDark;
            this.gpbox_EliminarProducto.Controls.Add(this.txt_IdProducto);
            this.gpbox_EliminarProducto.Controls.Add(this.lbl_IdProducto);
            this.gpbox_EliminarProducto.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbox_EliminarProducto.Location = new System.Drawing.Point(704, 60);
            this.gpbox_EliminarProducto.Name = "gpbox_EliminarProducto";
            this.gpbox_EliminarProducto.Size = new System.Drawing.Size(175, 104);
            this.gpbox_EliminarProducto.TabIndex = 19;
            this.gpbox_EliminarProducto.TabStop = false;
            this.gpbox_EliminarProducto.Text = "Eliminar Producto";
            // 
            // txt_IdProducto
            // 
            this.txt_IdProducto.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_IdProducto.Location = new System.Drawing.Point(40, 54);
            this.txt_IdProducto.Name = "txt_IdProducto";
            this.txt_IdProducto.Size = new System.Drawing.Size(84, 23);
            this.txt_IdProducto.TabIndex = 18;
            // 
            // lbl_IdProducto
            // 
            this.lbl_IdProducto.AutoSize = true;
            this.lbl_IdProducto.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IdProducto.Location = new System.Drawing.Point(41, 35);
            this.lbl_IdProducto.Name = "lbl_IdProducto";
            this.lbl_IdProducto.Size = new System.Drawing.Size(83, 16);
            this.lbl_IdProducto.TabIndex = 0;
            this.lbl_IdProducto.Text = "Id Producto";
            // 
            // btn_EliminarProducto
            // 
            this.btn_EliminarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_EliminarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_EliminarProducto.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EliminarProducto.ForeColor = System.Drawing.Color.White;
            this.btn_EliminarProducto.Location = new System.Drawing.Point(371, 394);
            this.btn_EliminarProducto.Name = "btn_EliminarProducto";
            this.btn_EliminarProducto.Size = new System.Drawing.Size(175, 34);
            this.btn_EliminarProducto.TabIndex = 20;
            this.btn_EliminarProducto.Text = "Eliminar Producto";
            this.btn_EliminarProducto.UseVisualStyleBackColor = false;
            this.btn_EliminarProducto.Click += new System.EventHandler(this.btn_EliminarProducto_Click);
            // 
            // btn_EditarProducto
            // 
            this.btn_EditarProducto.BackColor = System.Drawing.Color.Black;
            this.btn_EditarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_EditarProducto.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EditarProducto.ForeColor = System.Drawing.Color.White;
            this.btn_EditarProducto.Location = new System.Drawing.Point(20, 394);
            this.btn_EditarProducto.Name = "btn_EditarProducto";
            this.btn_EditarProducto.Size = new System.Drawing.Size(175, 34);
            this.btn_EditarProducto.TabIndex = 21;
            this.btn_EditarProducto.Text = "Editar Producto\r\n";
            this.btn_EditarProducto.UseVisualStyleBackColor = false;
            this.btn_EditarProducto.Click += new System.EventHandler(this.btn_EditarProducto_Click);
            // 
            // gpbox_EditarProducto
            // 
            this.gpbox_EditarProducto.BackColor = System.Drawing.SystemColors.ControlDark;
            this.gpbox_EditarProducto.Controls.Add(this.txt_Editar_IdProducto);
            this.gpbox_EditarProducto.Controls.Add(this.lbl_Editar_IdProducto);
            this.gpbox_EditarProducto.Controls.Add(this.txt_EditarStock);
            this.gpbox_EditarProducto.Controls.Add(this.ListBox_EditarCategoriaProducto);
            this.gpbox_EditarProducto.Controls.Add(this.lbl_EditarStock);
            this.gpbox_EditarProducto.Controls.Add(this.lbl_Editar_Categoria);
            this.gpbox_EditarProducto.Controls.Add(this.txt_EditarDescripcion);
            this.gpbox_EditarProducto.Controls.Add(this.lbl_EditarDescripcion);
            this.gpbox_EditarProducto.Controls.Add(this.txt_EditarNombre);
            this.gpbox_EditarProducto.Controls.Add(this.lbl_EditarNombre);
            this.gpbox_EditarProducto.Controls.Add(this.lbl_EditarPrecio);
            this.gpbox_EditarProducto.Controls.Add(this.txt_EditarPrecio);
            this.gpbox_EditarProducto.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbox_EditarProducto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gpbox_EditarProducto.Location = new System.Drawing.Point(362, 12);
            this.gpbox_EditarProducto.Name = "gpbox_EditarProducto";
            this.gpbox_EditarProducto.Size = new System.Drawing.Size(326, 190);
            this.gpbox_EditarProducto.TabIndex = 19;
            this.gpbox_EditarProducto.TabStop = false;
            this.gpbox_EditarProducto.Text = "Editar Productos";
            // 
            // txt_EditarStock
            // 
            this.txt_EditarStock.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_EditarStock.Location = new System.Drawing.Point(107, 161);
            this.txt_EditarStock.Name = "txt_EditarStock";
            this.txt_EditarStock.Size = new System.Drawing.Size(213, 23);
            this.txt_EditarStock.TabIndex = 17;
            // 
            // ListBox_EditarCategoriaProducto
            // 
            this.ListBox_EditarCategoriaProducto.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListBox_EditarCategoriaProducto.FormattingEnabled = true;
            this.ListBox_EditarCategoriaProducto.Items.AddRange(new object[] {
            "",
            "Hogar",
            "Tecnologia",
            "Ropa"});
            this.ListBox_EditarCategoriaProducto.Location = new System.Drawing.Point(107, 133);
            this.ListBox_EditarCategoriaProducto.Name = "ListBox_EditarCategoriaProducto";
            this.ListBox_EditarCategoriaProducto.Size = new System.Drawing.Size(213, 24);
            this.ListBox_EditarCategoriaProducto.TabIndex = 16;
            // 
            // lbl_EditarStock
            // 
            this.lbl_EditarStock.AutoSize = true;
            this.lbl_EditarStock.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EditarStock.Location = new System.Drawing.Point(30, 162);
            this.lbl_EditarStock.Name = "lbl_EditarStock";
            this.lbl_EditarStock.Size = new System.Drawing.Size(43, 16);
            this.lbl_EditarStock.TabIndex = 12;
            this.lbl_EditarStock.Text = "Stock";
            // 
            // lbl_Editar_Categoria
            // 
            this.lbl_Editar_Categoria.AutoSize = true;
            this.lbl_Editar_Categoria.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Editar_Categoria.Location = new System.Drawing.Point(21, 136);
            this.lbl_Editar_Categoria.Name = "lbl_Editar_Categoria";
            this.lbl_Editar_Categoria.Size = new System.Drawing.Size(70, 16);
            this.lbl_Editar_Categoria.TabIndex = 11;
            this.lbl_Editar_Categoria.Text = "Categoria";
            // 
            // txt_EditarDescripcion
            // 
            this.txt_EditarDescripcion.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_EditarDescripcion.Location = new System.Drawing.Point(107, 79);
            this.txt_EditarDescripcion.Name = "txt_EditarDescripcion";
            this.txt_EditarDescripcion.Size = new System.Drawing.Size(213, 23);
            this.txt_EditarDescripcion.TabIndex = 10;
            // 
            // lbl_EditarDescripcion
            // 
            this.lbl_EditarDescripcion.AutoSize = true;
            this.lbl_EditarDescripcion.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_EditarDescripcion.Location = new System.Drawing.Point(10, 79);
            this.lbl_EditarDescripcion.Name = "lbl_EditarDescripcion";
            this.lbl_EditarDescripcion.Size = new System.Drawing.Size(81, 16);
            this.lbl_EditarDescripcion.TabIndex = 9;
            this.lbl_EditarDescripcion.Text = "Descripcion";
            // 
            // txt_EditarNombre
            // 
            this.txt_EditarNombre.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_EditarNombre.Location = new System.Drawing.Point(107, 53);
            this.txt_EditarNombre.Name = "txt_EditarNombre";
            this.txt_EditarNombre.Size = new System.Drawing.Size(213, 23);
            this.txt_EditarNombre.TabIndex = 6;
            // 
            // lbl_EditarNombre
            // 
            this.lbl_EditarNombre.AutoSize = true;
            this.lbl_EditarNombre.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EditarNombre.Location = new System.Drawing.Point(21, 56);
            this.lbl_EditarNombre.Name = "lbl_EditarNombre";
            this.lbl_EditarNombre.Size = new System.Drawing.Size(56, 16);
            this.lbl_EditarNombre.TabIndex = 5;
            this.lbl_EditarNombre.Text = "Nombre";
            // 
            // lbl_EditarPrecio
            // 
            this.lbl_EditarPrecio.AutoSize = true;
            this.lbl_EditarPrecio.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EditarPrecio.Location = new System.Drawing.Point(30, 107);
            this.lbl_EditarPrecio.Name = "lbl_EditarPrecio";
            this.lbl_EditarPrecio.Size = new System.Drawing.Size(47, 16);
            this.lbl_EditarPrecio.TabIndex = 7;
            this.lbl_EditarPrecio.Text = "Precio";
            // 
            // txt_EditarPrecio
            // 
            this.txt_EditarPrecio.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_EditarPrecio.Location = new System.Drawing.Point(107, 108);
            this.txt_EditarPrecio.Name = "txt_EditarPrecio";
            this.txt_EditarPrecio.Size = new System.Drawing.Size(213, 23);
            this.txt_EditarPrecio.TabIndex = 8;
            // 
            // txt_Editar_IdProducto
            // 
            this.txt_Editar_IdProducto.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Editar_IdProducto.Location = new System.Drawing.Point(107, 26);
            this.txt_Editar_IdProducto.Name = "txt_Editar_IdProducto";
            this.txt_Editar_IdProducto.Size = new System.Drawing.Size(213, 23);
            this.txt_Editar_IdProducto.TabIndex = 21;
            // 
            // lbl_Editar_IdProducto
            // 
            this.lbl_Editar_IdProducto.AutoSize = true;
            this.lbl_Editar_IdProducto.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Editar_IdProducto.Location = new System.Drawing.Point(10, 28);
            this.lbl_Editar_IdProducto.Name = "lbl_Editar_IdProducto";
            this.lbl_Editar_IdProducto.Size = new System.Drawing.Size(83, 16);
            this.lbl_Editar_IdProducto.TabIndex = 20;
            this.lbl_Editar_IdProducto.Text = "Id Producto";
            // 
            // P_productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(900, 450);
            this.Controls.Add(this.gpbox_EditarProducto);
            this.Controls.Add(this.btn_EditarProducto);
            this.Controls.Add(this.btn_EliminarProducto);
            this.Controls.Add(this.gpbox_EliminarProducto);
            this.Controls.Add(this.gpbox_IngresarProductos);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.DGView_Productos);
            this.Controls.Add(this.lbl_Productos);
            this.Controls.Add(this.img_Salir);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "P_productos";
            this.Text = "P_productos";
            this.Load += new System.EventHandler(this.P_productos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.img_Salir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGView_Productos)).EndInit();
            this.gpbox_IngresarProductos.ResumeLayout(false);
            this.gpbox_IngresarProductos.PerformLayout();
            this.gpbox_EliminarProducto.ResumeLayout(false);
            this.gpbox_EliminarProducto.PerformLayout();
            this.gpbox_EditarProducto.ResumeLayout(false);
            this.gpbox_EditarProducto.PerformLayout();
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
        private System.Windows.Forms.GroupBox gpbox_IngresarProductos;
        private System.Windows.Forms.Label lbl_Stock;
        private System.Windows.Forms.Label lbl_Categoria;
        private System.Windows.Forms.TextBox txt_Descripcion;
        private System.Windows.Forms.Label lbl_Descripcion;
        private System.Windows.Forms.ComboBox ListBox_CategoriaProducto;
        private System.Windows.Forms.TextBox txt_Stock;
        private System.Windows.Forms.GroupBox gpbox_EliminarProducto;
        private System.Windows.Forms.Label lbl_IdProducto;
        private System.Windows.Forms.TextBox txt_IdProducto;
        private System.Windows.Forms.Button btn_EliminarProducto;
        private System.Windows.Forms.Button btn_EditarProducto;
        private System.Windows.Forms.GroupBox gpbox_EditarProducto;
        private System.Windows.Forms.TextBox txt_EditarStock;
        private System.Windows.Forms.ComboBox ListBox_EditarCategoriaProducto;
        private System.Windows.Forms.Label lbl_EditarStock;
        private System.Windows.Forms.Label lbl_Editar_Categoria;
        private System.Windows.Forms.TextBox txt_EditarDescripcion;
        private System.Windows.Forms.Label lbl_EditarDescripcion;
        private System.Windows.Forms.TextBox txt_EditarNombre;
        private System.Windows.Forms.Label lbl_EditarNombre;
        private System.Windows.Forms.Label lbl_EditarPrecio;
        private System.Windows.Forms.TextBox txt_EditarPrecio;
        private System.Windows.Forms.TextBox txt_Editar_IdProducto;
        private System.Windows.Forms.Label lbl_Editar_IdProducto;
    }
}