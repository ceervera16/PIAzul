using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CheapMarket
{
    class ConexionBD
    {
        //Atributos
        private static MySqlConnection conexion;

        //Propiedades
        public static MySqlConnection Conexion { get { return conexion; } }


        // Constructor que instancia la conexión, definiendo la cadena de conexión (ConnectionString)

        public ConexionBD()
        {
            string server = "server=cheapmarket.c4szol6geym3.us-east-1.rds.amazonaws.com;";
            string oldguids = "oldguids=true;";
            string database = "database=CheapMarket;";
            string usuario = "uid=admin;";
            string password = "pwd=cheapmarket;";
            string conversor = "Convert Zero Datetime=True;";
            string connectionstring = server + oldguids + database + usuario + password + conversor;

            conexion = new MySqlConnection(connectionstring);
        }

        // Método que se encarga de abrir la conexión
        // Devuelve true/false dependiendo si la conexión se ha abierto con éxito o no
        public static bool AbrirConexion()
        {
            try
            {
                conexion.Open();
                return true;
            }
            catch (MySqlException ex)  // Inicialmente no es necesario utilizar el objeto ex
            {
                return false;
            }
        }

        // Método que se encarga de cerrar la conexión (evitar dejar conexiones abiertas)
        // Devuelve true/false dependiendo si la conexión se ha cerrado con éxito
        public static bool CerrarConexion()
        {
            try
            {
                conexion.Close();
                return true;
            }
            catch (MySqlException ex) // Inicialmente no es necesario utilizar el objeto ex
            {
                return false;
            }
        }
    }
}
