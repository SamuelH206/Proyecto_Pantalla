using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Pantalla
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void Login_Load(object sender, EventArgs e)
        {
            Conexion.Conectar();
        }


        private void img_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void link_Registro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
        }

        {
            P_Administrador p_admin = new P_Administrador();
            P_productos p_productos = new P_productos();
            //string Consulta_Usuario = "select Correo,Contraseña from Usuario where Correo = '234jhg@gmail.com' and Contraseña = 'pollokfc'";
            string Consulta_Usuario = "select Correo,Contraseña from Usuario where Correo= '" + txt_Correo.Text + "' and Contraseña= '" + txt_Contraseña.Text + "'";

            SqlCommand cmd = new SqlCommand(Consulta_Usuario, Conexion.Conectar());
            SqlDataReader registros = cmd.ExecuteReader();

            if (registros.Read())
            {
                p_productos.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("El Correo y/o la contraseña son invalidos!!");
            }
        }
    } 
}
