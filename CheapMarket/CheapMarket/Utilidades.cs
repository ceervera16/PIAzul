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
        /// <summary>
        /// Método para comprobar si un dni es correcto
        /// </summary>
        /// <param name="nif">Dni que se comprueba</param>
        /// <returns>True o false en función de si es correcto o no</returns>
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

        /// <summary>
        /// Método para comprobar si un correo es correcto
        /// </summary>
        /// <param name="correo">Correo que se comprueba</param>
        /// <returns>True o false en función de si es correcto o no</returns>
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
        }

        /// <summary>
        /// Método para comprobar si el correo y la contraseña son correctos
        /// </summary>
        /// <param name="conexion">Conexión a la base de datos</param>
        /// <param name="correo">Correo con el que se intenta iniciar sesión</param>
        /// <param name="pass">Contraseña con el que se intenta iniciar sesión </param>
        /// <returns>True o false en función de si es correcto o no</returns>
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

        /// <summary>
        /// Método para comprobar si un producto esta en el carrito del cliente
        /// </summary>
        /// <param name="conexion">Conexión a la base de datos</param>
        /// <param name="producto">Nombre del producto</param>
        /// <returns>True o false en función el producto esta en el carrito o no</returns>
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

        /// <summary>
        /// Método para calcular la cantidad de un producto en el carrito
        /// </summary>
        /// <param name="conexion">Conexión a la base de datos</param>
        /// <param name="producto">Nombre del producto</param>
        /// <param name="dni">dni del cliente</param>
        /// <returns>Cantidad del producto</returns>
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
    }
}
