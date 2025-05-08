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
using Proyecto_Pantalla.Clases;

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
            Registro pantalla_Registro = new Registro();
            pantalla_Registro.Show();
            this.Hide();
        }

        private void btn_Ingresar_Click(object sender, EventArgs e)
        {
            P_Administrador p_admin = new P_Administrador();
            P_productos p_productos = new P_productos();
            P_vendedor p_vendedor = new P_vendedor();
            P_Almacen p_almacen = new P_Almacen();
            Persona.Consultar_Login(txt_Correo.Text, txt_Contraseña.Text);
            string Consulta_RolUsuario = "select Rol from Usuario where Correo = '" + txt_Correo.Text + "' and Contraseña = '" + txt_Contraseña.Text + "';";
            SqlCommand cmd_ConsultaRol_Login = new SqlCommand(Consulta_RolUsuario, Conexion.Conectar());
            SqlDataReader Roles_Registrados = cmd_ConsultaRol_Login.ExecuteReader();
            if (Roles_Registrados.Read())
            {
                string tipoRol = Roles_Registrados["Rol"].ToString();
                string admin = "Administrador";
                if (tipoRol == admin)
                {
                    p_admin.Show();
                    this.Hide();
                }
                else
                {
                    tipoRol = Roles_Registrados["Rol"].ToString();
                    string venta = "Vendedor";
                    if (tipoRol == venta)
                    {
                        p_productos.Show();
                        this.Hide();
                    }
                    else
                    {
                        tipoRol = Roles_Registrados["Rol"].ToString();
                        string almacen = "Almacenista";
                        if (tipoRol == almacen)
                        {
                            p_almacen.Show();
                            this.Hide();
                        }
                    }
                }
            }
        }
    } 
}
