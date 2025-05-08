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
using Microsoft.Win32;
using Proyecto_Pantalla.Clases;

namespace Proyecto_Pantalla
{
    public partial class P_productos : Form
    {
        public P_productos()
        {
            InitializeComponent();
        }

        private void P_productos_Load(object sender, EventArgs e)
        {
            Conexion.Conectar();
            DGView_Productos.DataSource = Index();
        }
        public DataTable Index()
        {
            Conexion.Conectar();
            DataTable datatable = new DataTable();
            string Consulta_Productos = "select *from Producto";
            SqlCommand cmd = new SqlCommand(Consulta_Productos, Conexion.Conectar());

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            adapter.Fill(datatable);

            return datatable;
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            Producto.RegistrarProducto(txt_NombreProducto.Text,txt_Descripcion.Text,txt_PrecioProducto.Text,ListBox_CategoriaProducto.Text,txt_Stock.Text);
            txt_PrecioProducto.Clear();
            txt_NombreProducto.Clear();
            txt_Descripcion.Clear();
            txt_Stock.Clear();
            DGView_Productos.DataSource = Index();
        }

        private void img_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_EliminarProducto_Click(object sender, EventArgs e)
        {
            Producto.EliminarProducto(txt_IdProducto.Text);
            txt_IdProducto.Clear();
            DGView_Productos.DataSource = Index();
        }

        private void btn_EditarProducto_Click(object sender, EventArgs e)
        {
            Producto.EditarProducto(txt_Editar_IdProducto.Text, txt_EditarNombre.Text, txt_EditarDescripcion.Text, txt_EditarPrecio.Text, ListBox_EditarCategoriaProducto.Text, txt_EditarStock.Text);
            //txt_EditarPrecio.Clear();
            //txt_EditarNombre.Clear();
            //txt_EditarDescripcion.Clear();
            //txt_EditarStock.Clear();
            //txt_Editar_IdProducto.Clear();
            DGView_Productos.DataSource = Index();
        }

    }
}
