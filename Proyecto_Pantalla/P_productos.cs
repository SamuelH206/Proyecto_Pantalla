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
            //Con estos comandos hacemos el registro de los productos
            string Registro_Productos = "Insert into Producto values ('"+txt_NombreProducto.Text+"',"+txt_PrecioProducto.Text+");";
            SqlCommand cmd = new SqlCommand(Registro_Productos, Conexion.Conectar());
            cmd.ExecuteNonQuery();
            txt_PrecioProducto.Clear();
            txt_NombreProducto.Clear();
            DGView_Productos.DataSource = Index();
        }

        private void img_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
