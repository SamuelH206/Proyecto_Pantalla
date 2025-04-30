using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Pantalla
{
    class Conexion
    {
        public static SqlConnection Conectar()
        {
            SqlConnection Conexion = new SqlConnection("server=Henao14\\SQLEXPRESS; database=DB_Proyecto; integrated security=true");
            Conexion.Open();
            return Conexion;
        }

    }
}
