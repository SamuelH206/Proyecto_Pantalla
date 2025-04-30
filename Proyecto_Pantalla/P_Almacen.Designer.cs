namespace Proyecto_Pantalla
{
    partial class P_Almacen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(P_Almacen));
            this.lbl_BienvenidoAlmacenista = new System.Windows.Forms.Label();
            this.img_Salir = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.img_Salir)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_BienvenidoAlmacenista
            // 
            this.lbl_BienvenidoAlmacenista.AutoSize = true;
            this.lbl_BienvenidoAlmacenista.Font = new System.Drawing.Font("Tahoma", 26.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
            this.lbl_BienvenidoAlmacenista.Location = new System.Drawing.Point(171, 150);
            this.lbl_BienvenidoAlmacenista.Name = "lbl_BienvenidoAlmacenista";
            this.lbl_BienvenidoAlmacenista.Size = new System.Drawing.Size(439, 42);
            this.lbl_BienvenidoAlmacenista.TabIndex = 0;
            this.lbl_BienvenidoAlmacenista.Text = "Bienvenido Almacenista";
            // 
            // img_Salir
            // 
            this.img_Salir.Image = ((System.Drawing.Image)(resources.GetObject("img_Salir.Image")));
            this.img_Salir.Location = new System.Drawing.Point(767, 0);
            this.img_Salir.Name = "img_Salir";
            this.img_Salir.Size = new System.Drawing.Size(32, 33);
            this.img_Salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_Salir.TabIndex = 19;
            this.img_Salir.TabStop = false;
            this.img_Salir.Click += new System.EventHandler(this.img_Salir_Click);
            // 
            // P_Almacen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.img_Salir);
            this.Controls.Add(this.lbl_BienvenidoAlmacenista);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "P_Almacen";
            this.Text = "P_Almacen";
            ((System.ComponentModel.ISupportInitialize)(this.img_Salir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_BienvenidoAlmacenista;
        private System.Windows.Forms.PictureBox img_Salir;
    }
}