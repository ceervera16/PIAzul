using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheapMarket
{
    static class Sesion
    {
        //Atributos
        private static string nombreUsu;
        private static string nifUsu;
        private static bool invitado;

        //Propiedades
        public static string NombreUsu { get => nombreUsu; set => nombreUsu = value; }
        public static string NifUsu { get => nifUsu; set => nifUsu = value; }
        public static bool Invitado { get => invitado; set => invitado = value; }


        //Metodos

        /// <summary>
        /// Método para averiguar el nombre de un cliente en base a su correo
        /// </summary>
        /// <param name="conexion">Conexión a la base de datos</param>
        /// <param name="correo">Correo del cliente</param>
        /// <returns>Nombre del cliente</returns>
        public static string NombreUsuario(MySqlConnection conexion, string correo)
        {
            string consulta = String.Format($"SELECT Nombre FROM cliente WHERE correo LIKE '{correo}'");

            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            MySqlDataReader reader = comando.ExecuteReader();

            string nombre = "Nombre";

            while (reader.Read())
            {
                nombre = reader.GetString(0);
            }

            return nombre;
        }

        /// <summary>
        /// Método para averiguarel dni de un cliente en base a su correo
        /// </summary>
        /// <param name="conexion">Conexión a la base de datos</param>
        /// <param name="correo">Correo del cliente</param>
        /// <returns>Nombre del cliente</returns>
        public static string NifUsuario(MySqlConnection conexion, string correo)
        {
            string consulta = String.Format($"SELECT DNI FROM cliente WHERE correo LIKE '{correo}'");

            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            MySqlDataReader reader = comando.ExecuteReader();

            string nif = "Nif";

            while (reader.Read())
            {
                nif = reader.GetString(0);
            }

            return nif;
        }
    }
}
