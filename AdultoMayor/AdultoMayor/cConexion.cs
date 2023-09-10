using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
namespace AdultoMayor
{
    public class cConexion
    {
        public String cadenaConexion = "Server=localhost;User=root;Password=;Port=3306;database=prueba1 ";
        public void conexion()
        {
            MySqlConnection mySqlConexion = new MySqlConnection(cadenaConexion);
            try
            {
                mySqlConexion.Open();

                //  MessageBox.Show("Conexio exitosa");
            }
            catch
            {
                //   MessageBox.Show("Error en la conexio");
            }
            mySqlConexion.Close();
        }
        public void crear(String id, String nombre, String apellido, String clave)
        {
            MySqlConnection conexion = new MySqlConnection(cadenaConexion);
            conexion.Open();
            string query = "INSERT INTO usuario(id, nombre, apellido, clave) VALUES('" + id + "','" + nombre + "','" + apellido + "','" + clave + "');";
            MySqlCommand comando = new MySqlCommand(query, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
        }


        public void agregarUsuario(String cedula, String nombre, String apellido, float altura, float peso, int edad, String estadoRec,  double icm, String recomendacion, String estado)
        {
            try
            {
                MySqlConnection conexion = new MySqlConnection(cadenaConexion);
                conexion.Open();
                string query = "INSERT INTO usuario(cedula, nombre, apellido, altura, peso, edad, estadoReco) VALUES('" + cedula + "','" + nombre + "','" + apellido + "','" + altura + "','" + peso + "','" + edad + "','" + estadoRec + "');";
                MySqlCommand comando = new MySqlCommand(query, conexion);
                comando.ExecuteNonQuery();
                query = "INSERT INTO desc_usu(cedula, icm, recomendacion , estado) VALUES('" + cedula + "','" + icm + "','" + recomendacion + "','" + estado + "');";
                comando = new MySqlCommand(query, conexion);
                comando.ExecuteNonQuery();
                conexion.Close();
            }
            catch
            {
                MessageBox.Show("Error al ingresar los datos, intente de nuevo");
            }
        }
        public void agregarEstudiante(String cedula, String nombre, String apellido, float altura, float peso, int edad, String estadoRec, double icm, String recomendacion, String estado)
        {
            try
            {
                MySqlConnection conexion = new MySqlConnection(cadenaConexion);
                conexion.Open();
                string query = "INSERT INTO usuario(cedula, nombre, apellido, altura, peso, edad, estadoReco, opcion) VALUES('" + cedula + "','" + nombre + "','" + apellido + "','" + altura + "','" + peso + "','" + edad + "','" + estadoRec + "', 1);";
                MySqlCommand comando = new MySqlCommand(query, conexion);
                comando.ExecuteNonQuery();
                query = "INSERT INTO desc_usu(cedula, icm, recomendacion , estado) VALUES('" + cedula + "','" + icm + "','" + recomendacion + "','" + estado + "');";
                comando = new MySqlCommand(query, conexion);
                comando.ExecuteNonQuery();
                conexion.Close();
            }
            catch
            {
                MessageBox.Show("Error al ingresar los datos, intente de nuevo");
            }
        }

        public void editarUsuario(String cedula, String nombre, String apellido, float altura, float peso, int edad, String estadoRec, double icm, String recomendacion, String estado)
        {
            try
            {
                MySqlConnection conexion = new MySqlConnection(cadenaConexion);
                conexion.Open();
                string query = "UPDATE usuario SET nombre='"+nombre+ "', apellido='" + apellido + "', altura='" + altura + "', peso='" + peso + "', edad='" + edad + "', estadoReco='" + estadoRec + "' WHERE cedula='" + cedula + "'";
                MySqlCommand comando = new MySqlCommand(query, conexion);
                comando.ExecuteNonQuery();
                query = "UPDATE desc_usu SET icm ='" + icm + "', recomendacion='" + recomendacion + "' , estado='" + estado + "' where cedula='" + cedula + "'";
                comando = new MySqlCommand(query, conexion);
                comando.ExecuteNonQuery();
                conexion.Close();
            }
            catch
            {
                MessageBox.Show("Error al ingresar los datos, intente de nuevo");
            }
        }

        public void editarEstudiante(String cedula, String nombre, String apellido)
        {
            string cadenaCon = "Server=localhost;User=root;Password=;Port=3306;database=prueba ";
            try
            {
                MySqlConnection conexion = new MySqlConnection(cadenaCon);
                conexion.Open();
                string query = "UPDATE usuario SET nombre='" + nombre + "', apellido='" + apellido + "' WHERE cedula='" + cedula + "'";
                MySqlCommand comando = new MySqlCommand(query, conexion);
                comando.ExecuteNonQuery();
                conexion.Close();
            }
            catch
            {
                MessageBox.Show("Error al ingresar los datos, intente de nuevo");
            }
        }

        public DataTable mostrarPorEdad()
        {
            string cadenaCon = "Server=localhost;User=root;Password=;Port=3306;database=prueba1 ";
            MySqlConnection conexionDB;
            DataTable datatable = new DataTable();
            MySqlDataReader resultado;

            conexionDB = new MySqlConnection(cadenaCon);
            conexionDB.Open();
            string query = "SELECT nombre as Nombre,apellido as Apellido,edad as Edad, estadoReco as 'Relacion edad', estado as 'Estado salud',icm as IMC FROM usuario as oU join desc_usu as oD  ON (oU.cedula = oD.cedula);";
            //MySqlCommand comando = new MySqlCommand("SELECT nombre,apellido,edad, estado, altura, peso, icm FROM usuario as oU join desc_usu as oD  ON (oU.cedula = oD.cedula);");
            MySql.Data.MySqlClient.MySqlCommand myCommand = new MySql.Data.MySqlClient.MySqlCommand(query, conexionDB);
            myCommand.CommandType = CommandType.Text;
            resultado = myCommand.ExecuteReader();
            datatable.Load(resultado);

            return datatable;
        }
        public DataTable mostrarPorEdad(String edadR)
        {
            string cadenaCon = "Server=localhost;User=root;Password=;Port=3306;database=prueba1 ";
            MySqlConnection conexionDB;
            DataTable datatable = new DataTable();
            MySqlDataReader resultado;

            conexionDB = new MySqlConnection(cadenaCon);
            conexionDB.Open();
            string query = "SELECT nombre as Nombre,apellido as Apellido,edad as Edad, estadoReco as 'Relacion edad', estado as 'Estado salud', altura as Altura, peso as Peso, icm as IMC FROM usuario as oU join desc_usu as oD  ON (oU.cedula = oD.cedula) WHERE estadoReco='" + edadR + "';";
            //MySqlCommand comando = new MySqlCommand("SELECT nombre,apellido,edad, estado, altura, peso, icm FROM usuario as oU join desc_usu as oD  ON (oU.cedula = oD.cedula);");
            MySql.Data.MySqlClient.MySqlCommand myCommand = new MySql.Data.MySqlClient.MySqlCommand(query, conexionDB);
            myCommand.CommandType = CommandType.Text;
            resultado = myCommand.ExecuteReader();
            datatable.Load(resultado);
            return datatable;
        }
        public DataTable mostrarPorEstadoSalud()
        {
            string cadenaCon = "Server=localhost;User=root;Password=;Port=3306;database=prueba1 ";
            MySqlConnection conexionDB;
            DataTable datatable = new DataTable();
            MySqlDataReader resultado;

            conexionDB = new MySqlConnection(cadenaCon);
            conexionDB.Open();
            string query = "SELECT nombre as Nombre,apellido as Apellido, estado as 'Estado salud', altura as Altura, peso as Peso, icm as IMC FROM usuario as oU join desc_usu as oD  ON (oU.cedula = oD.cedula);";
            //MySqlCommand comando = new MySqlCommand("SELECT nombre,apellido,edad, estado, altura, peso, icm FROM usuario as oU join desc_usu as oD  ON (oU.cedula = oD.cedula);");
            MySql.Data.MySqlClient.MySqlCommand myCommand = new MySql.Data.MySqlClient.MySqlCommand(query, conexionDB);
            myCommand.CommandType = CommandType.Text;
            resultado = myCommand.ExecuteReader();
            datatable.Load(resultado);

            return datatable;
        }
        public DataTable mostrarPorEstadoSalud(String estSalud)
        {
            string cadenaCon = "Server=localhost;User=root;Password=;Port=3306;database=prueba1 ";
            MySqlConnection conexionDB;
            DataTable datatable = new DataTable();
            MySqlDataReader resultado;

            conexionDB = new MySqlConnection(cadenaCon);
            conexionDB.Open();
            string query = "SELECT nombre as Nombre,apellido as Apellido, estado as 'Estado salud', altura as Altura, peso as Peso, icm as IMC FROM usuario as oU join desc_usu as oD  ON (oU.cedula = oD.cedula) WHERE estado='" + estSalud + "';";
            //MySqlCommand comando = new MySqlCommand("SELECT nombre,apellido,edad, estado, altura, peso, icm FROM usuario as oU join desc_usu as oD  ON (oU.cedula = oD.cedula);");
            MySql.Data.MySqlClient.MySqlCommand myCommand = new MySql.Data.MySqlClient.MySqlCommand(query, conexionDB);
            myCommand.CommandType = CommandType.Text;
            resultado = myCommand.ExecuteReader();
            datatable.Load(resultado);

            return datatable;
        }
        public ArrayList buscar(String ced)
        {
            MySqlDataReader reader=null;
            ArrayList datos = new ArrayList();
            MySqlConnection conexion = new MySqlConnection(cadenaConexion);
            conexion.Open();
            string query = "SELECT oU.cedula, nombre, apellido, peso, edad, altura FROM usuario as oU join desc_usu as oD  ON (oU.cedula = oD.cedula) WHERE oU.cedula='" + ced + "';";
            MySqlCommand comando = new MySqlCommand(query, conexion);
            reader = comando.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    datos.Add(reader.GetString(0));
                    datos.Add(reader.GetString(1));
                    datos.Add(reader.GetString(2));
                    datos.Add(reader.GetString(3));
                    datos.Add(reader.GetString(4));
                    datos.Add(reader.GetString(5));
                }
            }
            else
            {
                datos.Add("");
            }
            conexion.Close();

            return datos;
        }
        public ArrayList buscarEstudiantes(String ced)
        {
            string cadenaCon = "Server=localhost;User=root;Password=;Port=3306;database=prueba ";
            MySqlDataReader reader = null;
            ArrayList datos = new ArrayList();
            MySqlConnection conexion = new MySqlConnection(cadenaCon);
            conexion.Open();
            string query = "SELECT cedula, nombre, apellido, clave FROM usuario WHERE cedula='" + ced + "';";
            MySqlCommand comando = new MySqlCommand(query, conexion);
            reader = comando.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    datos.Add(reader.GetString(0));
                    datos.Add(reader.GetString(1));
                    datos.Add(reader.GetString(2));
                    datos.Add(reader.GetString(3));
                }
            }
            else
            {
                datos.Add("");
            }
            conexion.Close();

            return datos;
        }

        public ArrayList buscarUsuario(String ced)
        {
            MySqlDataReader reader = null;
            ArrayList datos = new ArrayList();
            MySqlConnection conexion = new MySqlConnection(cadenaConexion);
            conexion.Open();
            string query = "SELECT oU.cedula, nombre, apellido,altura, peso, edad, estadoReco, icm, recomendacion, estado FROM usuario as oU join desc_usu as oD  ON (oU.cedula = oD.cedula) WHERE oU.cedula='" + ced + "';";
            MySqlCommand comando = new MySqlCommand(query, conexion);
            reader = comando.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    datos.Add(reader.GetString(0));
                    datos.Add(reader.GetString(1));
                    datos.Add(reader.GetString(2));
                    datos.Add(reader.GetString(3));
                    datos.Add(reader.GetString(4));
                    datos.Add(reader.GetString(5));
                    datos.Add(reader.GetString(6));
                    datos.Add(reader.GetString(7));
                    datos.Add(reader.GetString(8));
                    datos.Add(reader.GetString(9));
                }
            }
            else
            {
                datos.Add("");
            }
            conexion.Close();

            return datos;
        }
        public ArrayList buscarEstudiantesNoRegistrados(String ced)
        {
            string cadenaCon = "Server=localhost;User=root;Password=;Port=3306;database=prueba ";
            MySqlDataReader reader = null;
            ArrayList datos = new ArrayList();
            MySqlConnection conexion = new MySqlConnection(cadenaCon);
            conexion.Open();
            string query = "SELECT cedula, nombre, apellido, clave FROM usuario WHERE cedula='" + ced + "';";
            MySqlCommand comando = new MySqlCommand(query, conexion);
            reader = comando.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    datos.Add(reader.GetString(0));
                    datos.Add(reader.GetString(1));
                    datos.Add(reader.GetString(2));
                    datos.Add(reader.GetString(3));
                }
            }
            else
            {
                datos.Add("");
            }
            conexion.Close();

            return datos;
        }

    }

}
