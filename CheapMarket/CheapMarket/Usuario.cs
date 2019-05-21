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

    }
}
