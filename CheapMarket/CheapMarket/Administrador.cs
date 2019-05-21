using System;
using System.Collections.Generic;
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
            string consulta;
            if (prod.Info=="")
            {
                consulta = string.Format("INSERT INTO productos(Codigo,Nombre,Precio,Descripcion,Categoria" +
                "VALUES ('{0}','{1}','{2}','{3}','{4}','{5}'", prod.Codigo, prod.Nombre, prod.Precio, prod.Descripcion, prod.Categoria);
            }
            else
            {
                consulta = string.Format("INSERT INTO productos(Codigo,Nombre,Precio,Descripcion,Categoria,InformacionNutritiva" +
                "VALUES ('{0}','{1}','{2}','{3}','{4}','{5}'", prod.Codigo, prod.Nombre, prod.Precio, prod.Descripcion, prod.Categoria, prod.Info);
            }
            MySqlCommand comando = new MySqlCommand(consulta, conexion);
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
            consultaProducto = string.Format("DELETE FROM productos WHERE codigo = '{0}'",codigo);
            consultaCarrito = string.Format("DELETE FROM CarritoTemporal WHERE codigo = '{0}'", codigo);
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
            if (informacionNutritiva=="")
            {
                consulta = string.Format("ALTER TABLE productos SET Nombre='{0}',Precio='{1}',Descripcion='{2}',Categoria='{3}'", nombre,
                precio, descripcion, categoria);
            }
            else
            {
                consulta = string.Format("UPDATE productos SET Nombre='{0}',Precio='{1}',Descripcion='{2}',Categoria='{3}',InformacionNutritiva='{4}'", nombre,
                precio, descripcion, categoria, informacionNutritiva);
            }
            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            return comando.ExecuteNonQuery();
        }

        
    }
}
