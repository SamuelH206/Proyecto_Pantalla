namespace Proyecto_Pantalla
{
    partial class Registro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro));
            this.lbl_Registro = new System.Windows.Forms.Label();
            this.lbl_Id = new System.Windows.Forms.Label();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.img_Registro = new System.Windows.Forms.PictureBox();
            this.Panel_Registro = new System.Windows.Forms.Panel();
            this.txt_Nombres = new System.Windows.Forms.TextBox();
            this.lbl_Nombres = new System.Windows.Forms.Label();
            this.lbl_Rol = new System.Windows.Forms.Label();
            this.txt_Apellidos = new System.Windows.Forms.TextBox();
            this.lbl_Apellidos = new System.Windows.Forms.Label();
            this.txt_Contraseña = new System.Windows.Forms.TextBox();
            this.lbl_Contraseña = new System.Windows.Forms.Label();
            this.txt_Correo = new System.Windows.Forms.TextBox();
            this.lbl_Correo = new System.Windows.Forms.Label();
            this.ListBox_ListaRol = new System.Windows.Forms.ComboBox();
            this.btn_Crear = new System.Windows.Forms.Button();
            this.Link_Login = new System.Windows.Forms.LinkLabel();
            this.img_Salir = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.img_Registro)).BeginInit();
            this.Panel_Registro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_Salir)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Registro
            // 
            this.lbl_Registro.AutoSize = true;
            this.lbl_Registro.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Registro.Location = new System.Drawing.Point(482, 20);
            this.lbl_Registro.Name = "lbl_Registro";
            this.lbl_Registro.Size = new System.Drawing.Size(160, 33);
            this.lbl_Registro.TabIndex = 1;
            this.lbl_Registro.Text = "REGISTRO";
            // 
            // lbl_Id
            // 
            this.lbl_Id.AutoSize = true;
            this.lbl_Id.Font = new System.Drawing.Font("Tahoma", 10.75F, System.Drawing.FontStyle.Bold);
            this.lbl_Id.Location = new System.Drawing.Point(354, 71);
            this.lbl_Id.Name = "lbl_Id";
            this.lbl_Id.Size = new System.Drawing.Size(169, 18);
            this.lbl_Id.TabIndex = 2;
            this.lbl_Id.Text = "Id / N° Identificacion";
            // 
            // txt_Id
            // 
            this.txt_Id.Font = new System.Drawing.Font("Tahoma", 10.75F, System.Drawing.FontStyle.Bold);
            this.txt_Id.Location = new System.Drawing.Point(329, 92);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(201, 25);
            this.txt_Id.TabIndex = 0;
            // 
            // img_Registro
            // 
            this.img_Registro.BackColor = System.Drawing.Color.White;
            this.img_Registro.Image = ((System.Drawing.Image)(resources.GetObject("img_Registro.Image")));
            this.img_Registro.Location = new System.Drawing.Point(-53, -17);
            this.img_Registro.Name = "img_Registro";
            this.img_Registro.Size = new System.Drawing.Size(358, 476);
            this.img_Registro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_Registro.TabIndex = 0;
            this.img_Registro.TabStop = false;
            // 
            // Panel_Registro
            // 
            this.Panel_Registro.Controls.Add(this.img_Registro);
            this.Panel_Registro.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel_Registro.Location = new System.Drawing.Point(0, 0);
            this.Panel_Registro.Name = "Panel_Registro";
            this.Panel_Registro.Size = new System.Drawing.Size(289, 450);
            this.Panel_Registro.TabIndex = 0;
            // 
            // txt_Nombres
            // 
            this.txt_Nombres.Font = new System.Drawing.Font("Tahoma", 10.75F, System.Drawing.FontStyle.Bold);
            this.txt_Nombres.Location = new System.Drawing.Point(556, 127);
            this.txt_Nombres.Name = "txt_Nombres";
            this.txt_Nombres.Size = new System.Drawing.Size(201, 25);
            this.txt_Nombres.TabIndex = 1;
            // 
            // lbl_Nombres
            // 
            this.lbl_Nombres.AutoSize = true;
            this.lbl_Nombres.Font = new System.Drawing.Font("Tahoma", 10.75F, System.Drawing.FontStyle.Bold);
            this.lbl_Nombres.Location = new System.Drawing.Point(581, 104);
            this.lbl_Nombres.Name = "lbl_Nombres";
            this.lbl_Nombres.Size = new System.Drawing.Size(75, 18);
            this.lbl_Nombres.TabIndex = 5;
            this.lbl_Nombres.Text = "Nombres";
            // 
            // lbl_Rol
            // 
            this.lbl_Rol.AutoSize = true;
            this.lbl_Rol.Font = new System.Drawing.Font("Tahoma", 10.75F, System.Drawing.FontStyle.Bold);
            this.lbl_Rol.Location = new System.Drawing.Point(576, 167);
            this.lbl_Rol.Name = "lbl_Rol";
            this.lbl_Rol.Size = new System.Drawing.Size(33, 18);
            this.lbl_Rol.TabIndex = 9;
            this.lbl_Rol.Text = "Rol";
            // 
            // txt_Apellidos
            // 
            this.txt_Apellidos.Font = new System.Drawing.Font("Tahoma", 10.75F, System.Drawing.FontStyle.Bold);
            this.txt_Apellidos.Location = new System.Drawing.Point(329, 156);
            this.txt_Apellidos.Name = "txt_Apellidos";
            this.txt_Apellidos.Size = new System.Drawing.Size(201, 25);
            this.txt_Apellidos.TabIndex = 2;
            // 
            // lbl_Apellidos
            // 
            this.lbl_Apellidos.AutoSize = true;
            this.lbl_Apellidos.Font = new System.Drawing.Font("Tahoma", 10.75F, System.Drawing.FontStyle.Bold);
            this.lbl_Apellidos.Location = new System.Drawing.Point(354, 134);
            this.lbl_Apellidos.Name = "lbl_Apellidos";
            this.lbl_Apellidos.Size = new System.Drawing.Size(77, 18);
            this.lbl_Apellidos.TabIndex = 7;
            this.lbl_Apellidos.Text = "Apellidos";
            // 
            // txt_Contraseña
            // 
            this.txt_Contraseña.Font = new System.Drawing.Font("Tahoma", 10.75F, System.Drawing.FontStyle.Bold);
            this.txt_Contraseña.Location = new System.Drawing.Point(556, 252);
            this.txt_Contraseña.Name = "txt_Contraseña";
            this.txt_Contraseña.PasswordChar = '*';
            this.txt_Contraseña.Size = new System.Drawing.Size(201, 25);
            this.txt_Contraseña.TabIndex = 5;
            // 
            // lbl_Contraseña
            // 
            this.lbl_Contraseña.AutoSize = true;
            this.lbl_Contraseña.Font = new System.Drawing.Font("Tahoma", 10.75F, System.Drawing.FontStyle.Bold);
            this.lbl_Contraseña.Location = new System.Drawing.Point(576, 231);
            this.lbl_Contraseña.Name = "lbl_Contraseña";
            this.lbl_Contraseña.Size = new System.Drawing.Size(93, 18);
            this.lbl_Contraseña.TabIndex = 13;
            this.lbl_Contraseña.Text = "Contraseña";
            // 
            // txt_Correo
            // 
            this.txt_Correo.Font = new System.Drawing.Font("Tahoma", 10.75F, System.Drawing.FontStyle.Bold);
            this.txt_Correo.Location = new System.Drawing.Point(329, 219);
            this.txt_Correo.Name = "txt_Correo";
            this.txt_Correo.Size = new System.Drawing.Size(201, 25);
            this.txt_Correo.TabIndex = 4;
            // 
            // lbl_Correo
            // 
            this.lbl_Correo.AutoSize = true;
            this.lbl_Correo.Font = new System.Drawing.Font("Tahoma", 10.75F, System.Drawing.FontStyle.Bold);
            this.lbl_Correo.Location = new System.Drawing.Point(354, 197);
            this.lbl_Correo.Name = "lbl_Correo";
            this.lbl_Correo.Size = new System.Drawing.Size(134, 18);
            this.lbl_Correo.TabIndex = 11;
            this.lbl_Correo.Text = "Usuario / Correo";
            // 
            // ListBox_ListaRol
            // 
            this.ListBox_ListaRol.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListBox_ListaRol.FormattingEnabled = true;
            this.ListBox_ListaRol.Items.AddRange(new object[] {
            "",
            "Administrador",
            "Almancenista",
            "Vendedor"});
            this.ListBox_ListaRol.Location = new System.Drawing.Point(556, 188);
            this.ListBox_ListaRol.Name = "ListBox_ListaRol";
            this.ListBox_ListaRol.Size = new System.Drawing.Size(201, 24);
            this.ListBox_ListaRol.TabIndex = 3;
            // 
            // btn_Crear
            // 
            this.btn_Crear.BackColor = System.Drawing.Color.Black;
            this.btn_Crear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Crear.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Crear.ForeColor = System.Drawing.Color.White;
            this.btn_Crear.Location = new System.Drawing.Point(632, 362);
            this.btn_Crear.Name = "btn_Crear";
            this.btn_Crear.Size = new System.Drawing.Size(139, 31);
            this.btn_Crear.TabIndex = 6;
            this.btn_Crear.Text = "Crear";
            this.btn_Crear.UseVisualStyleBackColor = false;
            this.btn_Crear.Click += new System.EventHandler(this.btn_Crear_Click);
            // 
            // Link_Login
            // 
            this.Link_Login.AutoSize = true;
            this.Link_Login.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.Link_Login.LinkColor = System.Drawing.Color.Purple;
            this.Link_Login.Location = new System.Drawing.Point(427, 300);
            this.Link_Login.Name = "Link_Login";
            this.Link_Login.Size = new System.Drawing.Size(258, 16);
            this.Link_Login.TabIndex = 7;
            this.Link_Login.TabStop = true;
            this.Link_Login.Text = "Ya tengo una cuanta   -   Iniciar sesion";
            this.Link_Login.VisitedLinkColor = System.Drawing.Color.Red;
            this.Link_Login.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Link_Login_LinkClicked);
            // 
            // img_Salir
            // 
            this.img_Salir.Image = ((System.Drawing.Image)(resources.GetObject("img_Salir.Image")));
            this.img_Salir.Location = new System.Drawing.Point(767, 0);
            this.img_Salir.Name = "img_Salir";
            this.img_Salir.Size = new System.Drawing.Size(32, 33);
            this.img_Salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_Salir.TabIndex = 18;
            this.img_Salir.TabStop = false;
            this.img_Salir.Click += new System.EventHandler(this.img_Salir_Click);
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.img_Salir);
            this.Controls.Add(this.Link_Login);
            this.Controls.Add(this.btn_Crear);
            this.Controls.Add(this.ListBox_ListaRol);
            this.Controls.Add(this.txt_Contraseña);
            this.Controls.Add(this.lbl_Contraseña);
            this.Controls.Add(this.txt_Correo);
            this.Controls.Add(this.lbl_Correo);
            this.Controls.Add(this.lbl_Rol);
            this.Controls.Add(this.txt_Apellidos);
            this.Controls.Add(this.lbl_Apellidos);
            this.Controls.Add(this.txt_Nombres);
            this.Controls.Add(this.lbl_Nombres);
            this.Controls.Add(this.txt_Id);
            this.Controls.Add(this.lbl_Id);
            this.Controls.Add(this.lbl_Registro);
            this.Controls.Add(this.Panel_Registro);
            this.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Registro";
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.Registro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.img_Registro)).EndInit();
            this.Panel_Registro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.img_Salir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_Registro;
        private System.Windows.Forms.Label lbl_Id;
        private System.Windows.Forms.TextBox txt_Id;
        private System.Windows.Forms.PictureBox img_Registro;
        private System.Windows.Forms.Panel Panel_Registro;
        private System.Windows.Forms.TextBox txt_Nombres;
        private System.Windows.Forms.Label lbl_Nombres;
        private System.Windows.Forms.Label lbl_Rol;
        private System.Windows.Forms.TextBox txt_Apellidos;
        private System.Windows.Forms.Label lbl_Apellidos;
        private System.Windows.Forms.TextBox txt_Contraseña;
        private System.Windows.Forms.Label lbl_Contraseña;
        private System.Windows.Forms.TextBox txt_Correo;
        private System.Windows.Forms.Label lbl_Correo;
        private System.Windows.Forms.ComboBox ListBox_ListaRol;
        private System.Windows.Forms.Button btn_Crear;
        private System.Windows.Forms.LinkLabel Link_Login;
        private System.Windows.Forms.PictureBox img_Salir
            ;
    }
}