using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace CheapMarket
{
    static class Utilidades
    {
        public static bool NifCorrecto(string nif)
        {
            bool valido = false;

            if (nif.Length == 9)
            {

                ArrayList letras = new ArrayList() { "T", "R", "W", "A", "G", "M", "Y", "F", "P", "D", "X", "B", "N", "J",
                                                     "Z", "S", "Q", "V", "H", "L", "C", "K", "E" };

                string letraNif = nif.Substring(nif.Length - 1); //Guardamos en una variable la letra del nif enviado por el formulario
                string DNI = nif.Remove(nif.Length - 1);         //Guardamos en una variable los 8 numeros del nif enviado por el formulario
                int numDNI = 0;

                if (int.TryParse(DNI, out numDNI))
                {
                    int letra = int.Parse(DNI) % 23;                 //Generamos la posicion de la letra en el arraylist "letras"

                    if (letras[letra].ToString() == letraNif)        //Comprobamos que la letra generada y la del nif enviado son la misma
                    {
                        valido = true;
                    }
                }

            }

            return valido;
        }

        public static int EditarUsuario(MySqlConnection conexion, Usuario usu)
        {
            int retorno;

            string consulta = string.Format("UPDATE cliente SET Nombre='{1}', Apellidos='{2}', Correo='{3}', Password='{4}', Telefono={5}," +
                "Puntos={6}, Provincia='{7}', Localidad='{8}', Calle='{9}', CodigoPostal={10}, Patio={11}, Piso={12}, Puerta={13} " +
                "WHERE DNI='{14}'", usu.Dni, usu.Nombre, usu.Apellidos, usu.Correo, usu.Password, usu.Telefono, usu.Puntos, usu.Provincia,
                usu.Localidad, usu.Calle, usu.CodigoPostal, usu.Portal, usu.Piso, usu.Puerta, usu.Dni);

            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            retorno = comando.ExecuteNonQuery();

            return retorno; ;
        }

        public static int AgregarUsuario(MySqlConnection conexion, Usuario usu)
        {
            int retorno;

            string consulta = String.Format("INSERT INTO cliente (DNI,Nombre,Apellidos,Correo,Password,Telefono,Puntos,Provincia,Localidad," +
                "Calle,CodigoPostal,Patio,Piso,Puerta) VALUES " +
                "('{0}','{1}','{2}','{3}','{4}',{5},{6},'{7}','{8}','{9}',{10},{11},{12},{13})", usu.Dni, usu.Nombre, usu.Apellidos,
                usu.Correo, usu.Password, usu.Telefono, usu.Puntos, usu.Provincia, usu.Localidad, usu.Calle, usu.CodigoPostal, usu.Portal, usu.Piso, usu.Puerta);

            MySqlCommand comando = new MySqlCommand(consulta, conexion);

            retorno = comando.ExecuteNonQuery();

            return retorno;
        }

        public static int VaciarCarrito(MySqlConnection conexion, string nif)
        {
            int retorno;

            string consulta = String.Format($"DELETE FROM carritotemporal where DniCliente LIKE '{Sesion.NifUsu}'");

            MySqlCommand comando = new MySqlCommand(consulta, conexion);

            retorno = comando.ExecuteNonQuery();

            return retorno;
        }

        public static DataTable CargarCarrito(MySqlConnection conexion, string consulta)
        {
            DataTable lista = new DataTable();

            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            MySqlDataReader reader = comando.ExecuteReader();

            if (reader.HasRows)   // En caso que se hayan registros en el objeto reader
            {
                lista.Load(reader);
            }

            return lista;
        }

        public static int EliminarUsuario(MySqlConnection conexion, string nif)
        {
            int retorno;
            string consulta = string.Format("DELETE FROM cliente WHERE DNI={0}", nif);
            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

        public static bool ComprobarCorreo(string correo)
        {
            if (correo.Length == 0)
            {
                return false;
            }

            string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
            @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
            @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";

            Regex re = new Regex(strRegex);
            if (re.IsMatch(correo))
                return (true);
            else
                return (false);

            /*try
            {
                new MailAddress(correo);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }*/
        }


        public static bool IniciarSesion(MySqlConnection conexion, string correo, string pass)
        {
            string consulta = String.Format($"SELECT DNI, Password FROM cliente WHERE correo LIKE '{correo}' AND Password LIKE '{pass}'");

            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            MySqlDataReader reader = comando.ExecuteReader();

            if (reader.HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool ExisteUsuario(MySqlConnection conexion, string correo)
        {
            string consulta = String.Format($"SELECT * FROM cliente WHERE correo LIKE '{correo}'");

            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            MySqlDataReader reader = comando.ExecuteReader();

            if (reader.HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public static bool ExisteUsuario2(MySqlConnection conexion, string nif)
        {
            string consulta = String.Format($"SELECT * FROM cliente WHERE DNI LIKE '{nif}'");

            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            MySqlDataReader reader = comando.ExecuteReader();

            if (reader.HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public static DataTable CargarProductos2(MySqlConnection conexion, string consulta)
        {
            DataTable lista = new DataTable();

            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            MySqlDataReader reader = comando.ExecuteReader();

            if (reader.HasRows)   // En caso que se hayan registros en el objeto reader
            {
                lista.Load(reader);
            }
            
            return lista;
        }

        public static List<string> CargarDatos2(MySqlConnection conexion)
        {
            List<string> usu = new List<string>();

            string consulta = String.Format($"SELECT * FROM cliente WHERE DNI LIKE '{Sesion.NifUsu}'");

            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            MySqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                usu.Add(reader.GetString(0));
                usu.Add(reader.GetString(1));
                usu.Add(reader.GetString(2));
                usu.Add(reader.GetString(3));
                usu.Add(reader.GetString(4));
                usu.Add(reader.GetInt32(5).ToString());
                usu.Add(reader.GetInt32(6).ToString());
                usu.Add(reader.GetString(7));
                usu.Add(reader.GetString(8));
                usu.Add(reader.GetString(9));
                usu.Add(reader.GetInt32(10).ToString());
                usu.Add(reader.GetInt32(11).ToString());
                usu.Add(reader.GetInt32(12).ToString());
                usu.Add(reader.GetInt32(13).ToString());
            }

            return usu;
        }

        public static string InfoProducto(MySqlConnection conexion, string consulta)
        {
            string info="Información";

            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            MySqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                info = reader.GetString(0);
            }

            return info;
        }

        public static int AgregarAlCarrito(MySqlConnection conexion, string consulta)
        {
            int retorno;

            MySqlCommand comando = new MySqlCommand(consulta, conexion);

            retorno = comando.ExecuteNonQuery();

            return retorno;
        }

        public static Image ImagenProducto(MySqlConnection conexion, string consulta2)
        {
            MySqlCommand comando = new MySqlCommand(consulta2, conexion);
            MySqlDataReader reader = comando.ExecuteReader();

            Image imagen = null;

            while (reader.Read())
            {
                byte[] num = (byte[])reader[0];
                MemoryStream ms = new MemoryStream(num);
                imagen = Image.FromStream(ms);
            }

            return imagen;
        }

        public static bool ComprobarProducto(MySqlConnection conexion, string producto)
        {
            bool existe = false;

            string consulta = String.Format($"SELECT NomProducto FROM carritotemporal WHERE DniCliente LIKE '{Sesion.NifUsu}' AND NomProducto LIKE '{producto}'");

            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            MySqlDataReader reader = comando.ExecuteReader();

            if (reader.HasRows)
            {
                existe = true;
            }

            return existe;
        }

        public static int CalcularCantidad(MySqlConnection conexion, string producto, string dni)
        {
            int cantidad = 0;

            string consulta = String.Format($"SELECT Cantidad FROM carritotemporal WHERE DniCliente LIKE '{dni}' AND NomProducto LIKE '{producto}'");

            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            MySqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                cantidad = reader.GetInt32(0);
            }

            return cantidad;
        }

        public static DataTable FiltrarProductos(MySqlConnection conexion, string categoria, string palabra)
        {
            DataTable lista = new DataTable();

            string consulta = String.Format($"SELECT Nombre, Precio, Descripcion FROM producto WHERE Categoria LIKE '{categoria}' AND (Nombre LIKE '%{palabra}%' OR Precio LIKE '%{palabra}%' OR Descripcion LIKE '%{palabra}%' OR Informacion LIKE '%{palabra}%')");

            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            MySqlDataReader reader = comando.ExecuteReader();

            if (reader.HasRows)
            {
                lista.Load(reader);
            }

            return lista;
        }

        public static DataTable FiltrarCarrito(MySqlConnection conexion, string palabra)
        {
            DataTable lista = new DataTable();

            string consulta = String.Format($"SELECT NomProducto, Cantidad, Importe FROM carritotemporal where DniCliente LIKE '{Sesion.NifUsu}' AND (NomProducto LIKE '%{palabra}%' OR Cantidad LIKE '%{palabra}%' OR Importe LIKE '%{palabra}%')");

            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            MySqlDataReader reader = comando.ExecuteReader();

            if (reader.HasRows)
            {
                lista.Load(reader);
            }

            return lista;
        }

        public static double CalcularPrecio(MySqlConnection conexion, string producto)
        {
            double precio = 0;

            string consulta = String.Format($"SELECT Precio FROM producto WHERE Nombre LIKE '{producto}'");

            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            MySqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                precio = reader.GetDouble(0);
            }

            return precio;
        }
    }
}
