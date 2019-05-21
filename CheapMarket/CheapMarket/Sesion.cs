﻿using MySql.Data.MySqlClient;
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

        //Propiedades
        public static string NombreUsu { get => nombreUsu; set => nombreUsu = value; }
        public static string NifUsu { get => nifUsu; set => nifUsu = value; }

        //Metodos
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
