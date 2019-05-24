using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheapMarket
{
    class Usuario
    {
        //Atributos
        private string dni;
        private string nombre;
        private string apellidos;
        private string correo;
        private string password;
        private int telefono;
        private int puntos;
        private string provincia;
        private string localidad;
        private string calle;
        private int codigoPostal;
        private int portal;
        private int piso;
        private int puerta;

        //Atributos
        public string Dni { get => dni; set => dni = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Password { get => password; set => password = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public int Puntos { get => puntos; set => puntos = value; }
        public string Provincia { get => provincia; set => provincia = value; }
        public string Localidad { get => localidad; set => localidad = value; }
        public string Calle { get => calle; set => calle = value; }
        public int CodigoPostal { get => codigoPostal; set => codigoPostal = value; }
        public int Portal { get => portal; set => portal = value; }
        public int Piso { get => piso; set => piso = value; }
        public int Puerta { get => puerta; set => puerta = value; }

        //Constructor
        public Usuario(string dni, string nombre, string apellidos, string correo, string password, int telefono, string provincia,
                       string localidad, string calle, int codigoPostal, int portal, int piso, int puerta)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.correo = correo;
            this.password = password;
            this.telefono = telefono;
            this.puntos = 100;
            this.provincia = provincia;
            this.localidad = localidad;
            this.calle = calle;
            this.codigoPostal = codigoPostal;
            this.portal = portal;
            this.piso = piso;
            this.puerta = puerta;
        }

        public Usuario()
        {
        }

        //Metodos

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


    }
}
