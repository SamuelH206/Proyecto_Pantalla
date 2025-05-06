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
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }
        private void Registro_Load(object sender, EventArgs e)
        {
            Conexion.Conectar();
        }

        private void Link_Login_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login p_Login = new Login();
            p_Login.Show();
            this.Hide();
        }

        private void img_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Crear_Click(object sender, EventArgs e)
        {
            P_productos p_productos = new P_productos();
            P_Almacen p_almacenista = new P_Almacen();
            P_Administrador p_admin = new P_Administrador();
            if(txt_Id.Text == "" || txt_Nombres.Text == "" || txt_Apellidos.Text == "" || ListBox_ListaRol.Text == ""
                || txt_Correo.Text == "" || txt_Contraseña.Text == "")
            {
                MessageBox.Show("Ningun campo debe permanecer vacio!!");
            }
            else
            {
                string Consulta_Registro = "Insert into Usuario values ("+txt_Id.Text+",'"+txt_Nombres.Text+"','"+txt_Apellidos.Text + "','"+ListBox_ListaRol.Text+ "','"+txt_Correo.Text+"','"+txt_Contraseña.Text+"');";
                SqlCommand cmd = new SqlCommand(Consulta_Registro,Conexion.Conectar());
                cmd.ExecuteNonQuery();

                if(ListBox_ListaRol.Text == "Administrador")
                {
                    p_admin.Show();
                    this.Hide();
                }
                else
                {
                    if (ListBox_ListaRol.Text == "Vendedor")
                    {
                        p_productos.Show();
                        this.Hide();
                    }
                    else
                    {
                        p_almacenista.Show();
                        this.Hide();
                    }
            
                
        }

       
    }
}
