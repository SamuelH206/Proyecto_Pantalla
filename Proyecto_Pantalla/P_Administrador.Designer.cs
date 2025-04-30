namespace Proyecto_Pantalla
{
    partial class P_Administrador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(P_Administrador));
            this.lbl_Bienvenido = new System.Windows.Forms.Label();
            this.img_Salir = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.img_Salir)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Bienvenido
            // 
            this.lbl_Bienvenido.AutoSize = true;
            this.lbl_Bienvenido.Font = new System.Drawing.Font("Tahoma", 26.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Bienvenido.Location = new System.Drawing.Point(171, 150);
            this.lbl_Bienvenido.Name = "lbl_Bienvenido";
            this.lbl_Bienvenido.Size = new System.Drawing.Size(475, 42);
            this.lbl_Bienvenido.TabIndex = 0;
            this.lbl_Bienvenido.Text = "Bienvenido Administrador";
            // 
            // img_Salir
            // 
            this.img_Salir.Image = ((System.Drawing.Image)(resources.GetObject("img_Salir.Image")));
            this.img_Salir.Location = new System.Drawing.Point(767, 0);
            this.img_Salir.Name = "img_Salir";
            this.img_Salir.Size = new System.Drawing.Size(32, 33);
            this.img_Salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_Salir.TabIndex = 1;
            this.img_Salir.TabStop = false;
            this.img_Salir.Click += new System.EventHandler(this.img_Salir_Click);
            // 
            // P_Administrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.img_Salir);
            this.Controls.Add(this.lbl_Bienvenido);
            this.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "P_Administrador";
            this.Text = "P_Administrador";
            ((System.ComponentModel.ISupportInitialize)(this.img_Salir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Bienvenido;
        private System.Windows.Forms.PictureBox img_Salir;
    }
}