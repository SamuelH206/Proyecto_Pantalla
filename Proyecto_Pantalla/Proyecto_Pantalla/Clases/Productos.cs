using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Pantalla.Clases
{
    public class Producto
    {
        public string Id_Producto { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Precio { get; set; }
        public string Categoria { get; set; }
        public string Stock { get; set; }

        public Producto(string _nombre, string _descripcion, string _precio, string _categoria, string _stock)
        {
            this.Nombre = _nombre;
            this.Descripcion = _descripcion;
            this.Precio = _precio;
            this.Categoria = _categoria;
            this.Stock = _stock;
        }
        public static Producto RegistrarProducto(string _nombre, string _descripcion, string _precio, string _categoria, string _stock)
        {
            if (string.IsNullOrEmpty(_nombre) || string.IsNullOrEmpty(_descripcion) || string.IsNullOrEmpty(_precio)
                || string.IsNullOrEmpty(_categoria) || string.IsNullOrEmpty(_stock))
            {
                MessageBox.Show("Ningun campo debe permanecer vacio!!");
            }
            else
            {
                string Registro_Productos = "Insert into Producto (Nombre, Descripcion, Precio, Categoria, Stock) values ('" + _nombre + "','" + _descripcion + "'," + _precio + ",'" + _categoria + "'," + _stock + ");";
                SqlCommand cmd = new SqlCommand(Registro_Productos, Conexion.Conectar());
                cmd.ExecuteNonQuery();
            }
            return new Producto(_nombre, _descripcion, _precio, _categoria, _stock);
        }

        ////CONSTRUCTOR PARA EDITAR PRODUCTOS
        public Producto(string _id_producto, string _nombre, string _descripcion, string _precio, string _categoria, string _stock)
        {
            this.Id_Producto = _id_producto;
            this.Nombre = _nombre;
            this.Descripcion = _descripcion;
            this.Precio = _precio;
            this.Categoria = _categoria;
            this.Stock = _stock;
        }
        public static Producto EditarProducto(string _id_producto, string _nombre, string _descripcion, string _precio, string _categoria, string _stock)
        {
            if (string.IsNullOrEmpty(_id_producto)|| string.IsNullOrEmpty(_nombre)||  string.IsNullOrEmpty(_descripcion)||  string.IsNullOrEmpty(_precio)|| 
                string.IsNullOrEmpty(_categoria)|| string.IsNullOrEmpty(_stock))
            {
                MessageBox.Show("Ningun campo debe permanecer vacio!!");
            }
            else
            {
                string Consulta_Editar_Producto = "select id from Producto where id = " + _id_producto + " ";
                SqlCommand cmd_Consulta_Edicion = new SqlCommand(Consulta_Editar_Producto, Conexion.Conectar());
                //cmd_Consulta_Edicion.ExecuteNonQuery();
                SqlDataReader ConsultaProducto = cmd_Consulta_Edicion.ExecuteReader();
                if (ConsultaProducto.Read())
                {
                    string Editar_Producto = "update Producto set Nombre= '" + _nombre + "', Descripcion='" + _descripcion + "', Precio=" + _precio + ", Categoria='" + _categoria + "', Stock=" + _stock + " where id= " + _id_producto + ";";
                    SqlCommand cmd_Editar = new SqlCommand(Editar_Producto, Conexion.Conectar());
                    cmd_Editar.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("El Producto que quiere editar no se encuentra!!!");
                    MessageBox.Show("Ingrese Corectamente el ID del producto que quiere Editar");
                }

            }
            return new Producto(_id_producto, _nombre, _descripcion, _precio, _categoria, _stock);
        }
        
        ////CONSTRUCTOR PARA ELIMINAR PRODUCTOS
        public Producto(string _id_producto)
        {
            this.Id_Producto = _id_producto;
        }
        public static Producto EliminarProducto(string _id_producto)
        {
            if (string.IsNullOrEmpty(_id_producto))
            {
                MessageBox.Show("Ningun campo debe permanecer vacio!!");
            }
            else
            {
                string Consulta_Eliminar_Producto = "select id from Producto where id = " + _id_producto + "";
                SqlCommand cmd_Consulta_Producto = new SqlCommand(Consulta_Eliminar_Producto, Conexion.Conectar());
                SqlDataReader Productos_Registrados = cmd_Consulta_Producto.ExecuteReader();
                if (Productos_Registrados.Read())
                {
                    string Elimar_Producto = "delete from Producto where id = " + _id_producto + ";";
                    SqlCommand cmd_Eliminar = new SqlCommand(Elimar_Producto, Conexion.Conectar());
                    cmd_Eliminar.ExecuteNonQuery();

                }
                else
                {
                    MessageBox.Show("El Producto no existe!!!");
                }
            }
            return new Producto(_id_producto);
        }
    }
}
