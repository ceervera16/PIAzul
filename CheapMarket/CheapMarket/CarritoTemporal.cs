using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheapMarket
{
    class CarritoTemporal
    {
        //Atributos
        private string dniUsuario;
        private string producto;
        private int cantidad;
        private double importe;

        //Propiedades
        public string DniUsuario { get { return dniUsuario; } set { dniUsuario = value; } }
        public string Producto { get { return producto; } set { producto = value; } }
        public int Cantidad { get { return cantidad; } set { cantidad = value; } }
        public double Importe { get { return importe; } set { importe = value; } }

        //Constructores
        public CarritoTemporal(int codigoProducto, string dniUsuario, string producto, int cantidad, double importe)
        {
            this.dniUsuario = dniUsuario;
            this.producto = producto;
            this.cantidad = cantidad;
            this.importe = importe;
        }

        //Metodos


        /// <summary>
        /// Método para vaciar el carrito del cliente
        /// </summary>
        /// <param name="conexion">Conexión a la base de datos</param>
        /// <param name="nif">DNI del cliente</param>
        /// <returns></returns>
        public static int VaciarCarrito(MySqlConnection conexion, string nif)
        {
            int retorno;

            string consulta = String.Format($"DELETE FROM carritotemporal where DniCliente LIKE '{Sesion.NifUsu}'");

            MySqlCommand comando = new MySqlCommand(consulta, conexion);

            retorno = comando.ExecuteNonQuery();

            return retorno;
        }

        /// <summary>
        /// Método para cargar el carrito del cliente
        /// </summary>
        /// <param name="conexion">Conexión a la base de datos</param>
        /// <param name="consulta">Consulta sql para cargar los datos del carrito</param>
        /// <returns>Tabla con la información del carrito del cliente</returns>
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

        /// <summary>
        /// Método para agregar productos al carrito
        /// </summary>
        /// <param name="conexion">Conexión a la base de datos</param>
        /// <param name="consulta">Consulta sql que realiza un insert a la tabla carrito</param>
        /// <returns></returns>
        public static int AgregarAlCarrito(MySqlConnection conexion, string consulta)
        {
            int retorno;

            MySqlCommand comando = new MySqlCommand(consulta, conexion);

            retorno = comando.ExecuteNonQuery();

            return retorno;
        }

        /// <summary>
        /// Método para filtrar productos del carrito
        /// </summary>
        /// <param name="conexion">Conexión a la base de datos</param>
        /// <param name="palabra">Palabra que se filtra </param>
        /// <returns>Tabla con los productos filtrados</returns>
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

        /// <summary>
        /// Método para comprobar si el cliente tiene algun producto en su carrrito
        /// </summary>
        /// <param name="conexion">Conexión a la base de datos</param>
        /// <returns>True o false en funcion de si tiene productos o no</returns>
        public static bool ComprobarCarrito(MySqlConnection conexion)
        {
            string consulta = String.Format($"SELECT * FROM carritotemporal WHERE DniCliente LIKE '{Sesion.NifUsu}'");

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
    }
    
}