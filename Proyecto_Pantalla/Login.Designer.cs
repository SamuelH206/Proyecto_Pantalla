namespace Proyecto_Pantalla
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.Panel_Login = new System.Windows.Forms.Panel();
            this.img_Login = new System.Windows.Forms.PictureBox();
            this.lbl_InicioSesion = new System.Windows.Forms.Label();
            this.lbl_Correo = new System.Windows.Forms.Label();
            this.txt_Correo = new System.Windows.Forms.TextBox();
            this.btn_Ingresar = new System.Windows.Forms.Button();
            this.lbl_Contraseña = new System.Windows.Forms.Label();
            this.txt_Contraseña = new System.Windows.Forms.TextBox();
            this.img_Contraseña = new System.Windows.Forms.PictureBox();
            this.img_Usuario = new System.Windows.Forms.PictureBox();
            this.link_Registro = new System.Windows.Forms.LinkLabel();
            this.img_Salir = new System.Windows.Forms.PictureBox();
            this.Panel_Login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_Login)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_Contraseña)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_Usuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_Salir)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel_Login
            // 
            this.Panel_Login.BackColor = System.Drawing.Color.White;
            this.Panel_Login.Controls.Add(this.img_Login);
            this.Panel_Login.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel_Login.Location = new System.Drawing.Point(0, 0);
            this.Panel_Login.Name = "Panel_Login";
            this.Panel_Login.Size = new System.Drawing.Size(343, 450);
            this.Panel_Login.TabIndex = 0;
            // 
            // img_Login
            // 
            this.img_Login.BackColor = System.Drawing.Color.White;
            this.img_Login.Image = ((System.Drawing.Image)(resources.GetObject("img_Login.Image")));
            this.img_Login.Location = new System.Drawing.Point(0, 12);
            this.img_Login.Name = "img_Login";
            this.img_Login.Size = new System.Drawing.Size(343, 416);
            this.img_Login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_Login.TabIndex = 0;
            this.img_Login.TabStop = false;
            // 
            // lbl_InicioSesion
            // 
            this.lbl_InicioSesion.AutoSize = true;
            this.lbl_InicioSesion.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold);
            this.lbl_InicioSesion.Location = new System.Drawing.Point(491, 58);
            this.lbl_InicioSesion.Name = "lbl_InicioSesion";
            this.lbl_InicioSesion.Size = new System.Drawing.Size(228, 33);
            this.lbl_InicioSesion.TabIndex = 1;
            this.lbl_InicioSesion.Text = "INICIO SESION";
            // 
            // lbl_Correo
            // 
            this.lbl_Correo.AutoSize = true;
            this.lbl_Correo.Font = new System.Drawing.Font("Tahoma", 13.25F, System.Drawing.FontStyle.Bold);
            this.lbl_Correo.Location = new System.Drawing.Point(493, 137);
            this.lbl_Correo.Name = "lbl_Correo";
            this.lbl_Correo.Size = new System.Drawing.Size(160, 22);
            this.lbl_Correo.TabIndex = 2;
            this.lbl_Correo.Text = "Usuario / Correo";
            // 
            // txt_Correo
            // 
            this.txt_Correo.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txt_Correo.Location = new System.Drawing.Point(450, 165);
            this.txt_Correo.Name = "txt_Correo";
            this.txt_Correo.Size = new System.Drawing.Size(245, 25);
            this.txt_Correo.TabIndex = 3;
            // 
            // btn_Ingresar
            // 
            this.btn_Ingresar.BackColor = System.Drawing.Color.Black;
            this.btn_Ingresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Ingresar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Ingresar.ForeColor = System.Drawing.Color.White;
            this.btn_Ingresar.Location = new System.Drawing.Point(632, 362);
            this.btn_Ingresar.Name = "btn_Ingresar";
            this.btn_Ingresar.Size = new System.Drawing.Size(139, 31);
            this.btn_Ingresar.TabIndex = 4;
            this.btn_Ingresar.Text = "Ingresar";
            this.btn_Ingresar.UseVisualStyleBackColor = false;
            this.btn_Ingresar.Click += new System.EventHandler(this.btn_Ingresar_Click);
            // 
            // lbl_Contraseña
            // 
            this.lbl_Contraseña.AutoSize = true;
            this.lbl_Contraseña.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Contraseña.Location = new System.Drawing.Point(493, 211);
            this.lbl_Contraseña.Name = "lbl_Contraseña";
            this.lbl_Contraseña.Size = new System.Drawing.Size(107, 21);
            this.lbl_Contraseña.TabIndex = 5;
            this.lbl_Contraseña.Text = "Contraseña";
            // 
            // txt_Contraseña
            // 
            this.txt_Contraseña.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Contraseña.Location = new System.Drawing.Point(451, 245);
            this.txt_Contraseña.Name = "txt_Contraseña";
            this.txt_Contraseña.Size = new System.Drawing.Size(244, 26);
            this.txt_Contraseña.TabIndex = 6;
            // 
            // img_Contraseña
            // 
            this.img_Contraseña.Image = ((System.Drawing.Image)(resources.GetObject("img_Contraseña.Image")));
            this.img_Contraseña.Location = new System.Drawing.Point(451, 200);
            this.img_Contraseña.Name = "img_Contraseña";
            this.img_Contraseña.Size = new System.Drawing.Size(39, 39);
            this.img_Contraseña.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_Contraseña.TabIndex = 7;
            this.img_Contraseña.TabStop = false;
            // 
            // img_Usuario
            // 
            this.img_Usuario.Image = ((System.Drawing.Image)(resources.GetObject("img_Usuario.Image")));
            this.img_Usuario.Location = new System.Drawing.Point(452, 123);
            this.img_Usuario.Name = "img_Usuario";
            this.img_Usuario.Size = new System.Drawing.Size(38, 36);
            this.img_Usuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_Usuario.TabIndex = 8;
            this.img_Usuario.TabStop = false;
            // 
            // link_Registro
            // 
            this.link_Registro.AutoSize = true;
            this.link_Registro.LinkColor = System.Drawing.Color.Purple;
            this.link_Registro.Location = new System.Drawing.Point(478, 290);
            this.link_Registro.Name = "link_Registro";
            this.link_Registro.Size = new System.Drawing.Size(184, 13);
            this.link_Registro.TabIndex = 9;
            this.link_Registro.TabStop = true;
            this.link_Registro.Text = "Aun no tengo cuenta   -   Registrarme";
            this.link_Registro.VisitedLinkColor = System.Drawing.Color.Red;
            this.link_Registro.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_Registro_LinkClicked);
            // 
            // img_Salir
            // 
            this.img_Salir.Image = ((System.Drawing.Image)(resources.GetObject("img_Salir.Image")));
            this.img_Salir.Location = new System.Drawing.Point(767, 0);
            this.img_Salir.Name = "img_Salir";
            this.img_Salir.Size = new System.Drawing.Size(32, 33);
            this.img_Salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_Salir.TabIndex = 10;
            this.img_Salir.TabStop = false;
            this.img_Salir.Click += new System.EventHandler(this.img_Salir_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.img_Salir);
            this.Controls.Add(this.link_Registro);
            this.Controls.Add(this.img_Usuario);
            this.Controls.Add(this.img_Contraseña);
            this.Controls.Add(this.txt_Contraseña);
            this.Controls.Add(this.lbl_Contraseña);
            this.Controls.Add(this.btn_Ingresar);
            this.Controls.Add(this.txt_Correo);
            this.Controls.Add(this.lbl_Correo);
            this.Controls.Add(this.lbl_InicioSesion);
            this.Controls.Add(this.Panel_Login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.Panel_Login.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.img_Login)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_Contraseña)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_Usuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_Salir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Login;
        private System.Windows.Forms.PictureBox img_Login;
        private System.Windows.Forms.Label lbl_InicioSesion;
        private System.Windows.Forms.Label lbl_Correo;
        private System.Windows.Forms.TextBox txt_Correo;
        private System.Windows.Forms.Button btn_Ingresar;
        private System.Windows.Forms.Label lbl_Contraseña;
        private System.Windows.Forms.TextBox txt_Contraseña;
        private System.Windows.Forms.PictureBox img_Contraseña;
        private System.Windows.Forms.PictureBox img_Usuario;
        private System.Windows.Forms.LinkLabel link_Registro;
        private System.Windows.Forms.PictureBox img_Salir;
    }
}

