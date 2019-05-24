using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CheapMarket
{
    class Administrador
    {
        //Atributos
        private string dni;
        private string contrasenya;
        private string correoElectronico;

        //Propiedades
        public string Dni { get { return dni; } set { dni = value; } }
        public string Contrasenya { get { return contrasenya; } set { contrasenya = value; } }
        public string CorreoElectronico { get { return correoElectronico; } set { correoElectronico = value; } }

        //Constructores
        public Administrador(string dni, string contrasenya, string correoElectronico)
        {
            this.dni = dni;
            this.contrasenya = contrasenya;
            this.correoElectronico = correoElectronico;
        }

        public Administrador()
        {

        }

        //Métodos

        /// <summary>
        /// Añade un producto a la base de datos
        /// </summary>
        /// <param name="conexion">Conexión con la base de datos</param>
        /// <param name="prod">Producto a insertar</param>
        /// <returns></returns>
        public int AgregarProducto(MySqlConnection conexion, Productos prod)
        {
            MemoryStream ms = new MemoryStream();
            prod.Foto.Save(ms, ImageFormat.Jpeg);
            byte[] img = ms.ToArray();

            string consulta = string.Format("INSERT INTO producto (Codigo,Nombre,Precio,Descripcion,Categoria,Informacion,Imagen) " +
                "VALUES ('{0}','{1}','{2}','{3}','{4}','{5}',@imagen);", prod.Codigo, prod.Nombre, prod.Precio, prod.Descripcion, prod.Categoria, prod.Info);

            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            comando.Parameters.AddWithValue("imagen", img);

            return comando.ExecuteNonQuery();
        }

        /// <summary>
        /// Borra un producto de la base de datos
        /// </summary>
        /// <param name="conexion">Conexión con la base de datos</param>
        /// <param name="codigo">Código del producto a borrar</param>
        /// <returns>Número de registros afectados</returns>
        public int BorrarProducto(MySqlConnection conexion, int codigo)
        {
            string consultaProducto;
            string consultaCarrito;
            consultaProducto = string.Format("DELETE FROM producto WHERE codigo = '{0}';",codigo);
            consultaCarrito = string.Format("DELETE FROM CarritoTemporal WHERE codigo = '{0}';", codigo);
            MySqlCommand comandoProducto = new MySqlCommand(consultaProducto, conexion);
            MySqlCommand comandoCarrito = new MySqlCommand(consultaProducto, conexion);
            comandoProducto.ExecuteNonQuery();
            return comandoProducto.ExecuteNonQuery();
        }

        /// <summary>
        /// Edita la información de un producto de la base de datos
        /// </summary>
        /// <param name="conexion">Conexión con la base de datos</param>
        /// <param name="codigo">Código del producto</param>
        /// <param name="nombre">Nuevo nombre del producto</param>
        /// <param name="precio">Nuevo precio del producto</param>
        /// <param name="descripcion">Nueva descripcion del producto</param>
        /// <param name="categoria">Nueva categoria del producto</param>
        /// <param name="informacionNutritiva">Nueva informacionNutritiva del producto</param>
        /// <returns>Número de registros afectados</returns>
        public int EditarProducto(MySqlConnection conexion, int codigo, string nombre, double precio, string descripcion, string categoria, string informacionNutritiva)
        {
            string consulta;
            
            consulta = string.Format("UPDATE producto SET Nombre='{0}',Precio='{1}',Descripcion='{2}',Categoria='{3}',Informacion='{4}' WHERE Codigo='{5}';", nombre,
            precio, descripcion, categoria, informacionNutritiva, codigo);
            
            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            return comando.ExecuteNonQuery();
        }

        /// <summary>
        /// Edita la información de un producto de la base de datos
        /// </summary>
        /// <param name="conexion">Conexión con la base de datos</param>
        /// <param name="codigo">Código del producto</param>
        /// <param name="nombre">Nuevo nombre del producto</param>
        /// <param name="precio">Nuevo precio del producto</param>
        /// <param name="descripcion">Nueva descripcion del producto</param>
        /// <param name="categoria">Nueva categoria del producto</param>
        /// <param name="informacionNutritiva">Nueva informacionNutritiva del producto</param>
        /// <returns>Número de registros afectados</returns>
        public int EditarProducto(MySqlConnection conexion, int codigo, string nombre, double precio, string descripcion, string categoria)
        {
            string consulta;

            consulta = string.Format("UPDATE producto SET Nombre='{0}',Precio='{1}',Descripcion='{2}',Categoria='{3}' WHERE Codigo='{4}';", nombre,
            precio, descripcion, categoria, codigo);

            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            return comando.ExecuteNonQuery();
        }

        /// <summary>
        /// Busca productos en la base de datos segun la consulta que reciba, debe ser un select, utiliza el orden de la base de datos
        /// </summary>
        /// <param name="Conexion"></param>
        /// <param name="consulta"></param>
        /// <returns>lista de productos</returns>
        public static List<Productos> BuscarProducto(MySqlConnection Conexion, string consulta)
        {
            List<Productos> lista = new List<Productos>();

            MySqlCommand comando = new MySqlCommand(consulta, Conexion);

            MySqlDataReader reader = comando.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Productos prod = new Productos();
                    prod.Codigo = reader.GetInt32(0);
                    prod.Nombre = reader.GetString(1);
                    prod.Precio = reader.GetDouble(2);
                    prod.Categoria = reader.GetString(3);
                    prod.Descripcion = reader.GetString(4);
                    try
                    {
                        prod.Info = reader.GetString(5);
                    }
                    catch (Exception)
                    { }
                    lista.Add(prod);
                }
            }
            reader.Close();
            return lista;
        }
    }
}
