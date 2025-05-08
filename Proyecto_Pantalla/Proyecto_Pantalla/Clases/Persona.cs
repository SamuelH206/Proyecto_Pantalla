using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Pantalla.Clases
{
    class Persona
    {

        public string Id_Persona { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Rol { get; set; }
        public string Correo { get; set; }
        public string Contraseña { get; set; }

        public Persona(string _correo, string _contraseña)
        {
            this.Correo = _correo;
            this.Contraseña = _contraseña;
        }
        public static Persona Consultar_Login(string _correo, string _contraseña)
        {
            if(string.IsNullOrEmpty(_correo) || string.IsNullOrEmpty(_contraseña))
            {
                MessageBox.Show("Ningun campo debe permanecer vacio!!");
            }
            else
            {
                string Consulta_Usuario = "select Correo,Contraseña from Usuario where Correo= '" + _correo + "' and Contraseña= '" + _contraseña + "'";
                SqlCommand cmd_ConsultaUsuario = new SqlCommand(Consulta_Usuario, Conexion.Conectar());
                cmd_ConsultaUsuario.ExecuteNonQuery();
            }
                return new Persona(_correo, _contraseña);
        }
        //CONSTRUCTOR PARA AGREGAR Y EDITAR USUARIOS
        public Persona(string _id_Persona, string _nombre, string _apellido, string _rol, string _correo, string _contraseña)
        {
            this.Id_Persona = _id_Persona;
            this.Nombre = _nombre;
            this.Apellido = _apellido;
            this.Rol = _rol;
            this.Correo = _correo;
            this.Contraseña = _contraseña;
        }
        public static Persona AgregarPersona(string _id_Persona, string _nombre, string _apellido, string _rol, string _correo, string _contraseña)
        {
            if (string.IsNullOrEmpty(_id_Persona) || string.IsNullOrEmpty(_nombre) || string.IsNullOrEmpty(_apellido) ||
               string.IsNullOrEmpty(_rol) || string.IsNullOrEmpty(_correo) || string.IsNullOrEmpty(_contraseña))
            {
                MessageBox.Show("Ningun campo debe permanecer vacio!!");
            }
            else
            {
                string Consulta_Registro = "Insert into Usuario values (" + _id_Persona + ",'" + _nombre + "','" + _apellido + "','" + _rol + "','" + _correo + "','" + _contraseña + "');";
                SqlCommand cmd = new SqlCommand(Consulta_Registro, Conexion.Conectar());
                cmd.ExecuteNonQuery();
            }
            return new Persona(_id_Persona, _nombre, _apellido, _rol, _correo, _contraseña);
        }
       
        //CONSTRUCTOR PARA ELIMINAR USUARIOS
        public Persona (string _id_persona)
        {
            this.Id_Persona = _id_persona;
        }

    }
}
