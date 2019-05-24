using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheapMarket
{
    class Productos
    {
        //ATRIBUTOS
        private int codigo;
        private string nombre;
        private double precio;
        private string descripcion;
        private string categoria;
        private string info;


        //PROPIEDADES
        public int Codigo { get {return codigo; } set { value=codigo; } }
        public string Nombre { get {return nombre; } set { value = nombre; } }
        public double Precio { get { return precio; } set { value = precio; } }
        public string Descripcion { get { return nombre; } set { value = nombre; } }
        public string Categoria { get { return categoria; } set { value = categoria; } }
        public string Info { get { return info; } set { value = info; } }

        //CONSTRUCTOR
        public Productos() { }
        public Productos(int codigo, string nombre, double precio, string descripcion, string categoria, string info)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.precio = precio;
            this.descripcion = descripcion;
            this.categoria = categoria;
            this.info = info;
        }

        //Metodos
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

        public static string InfoProducto(MySqlConnection conexion, string consulta)
        {
            string info = "Información";

            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            MySqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                info = reader.GetString(0);
            }

            return info;
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

        public static int CodigoProducto(MySqlConnection conexion, string producto)
        {
            int codigo = 0;

            string consulta = String.Format($"SELECT Codigo FROM producto WHERE Nombre LIKE '{producto}'");

            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            MySqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                codigo = reader.GetInt32(0);
            }

            return codigo;
        }
    }
}
