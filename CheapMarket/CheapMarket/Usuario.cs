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
        public string Dni { get => dni; }
        public string Nombre { get => nombre; }
        public string Apellidos { get => apellidos; }
        public string Correo { get => correo; }
        public string Password { get => password; }
        public int Telefono { get => telefono; }
        public int Puntos { get => puntos; }
        public string Provincia { get => provincia; }
        public string Localidad { get => localidad; }
        public string Calle { get => calle; }
        public int CodigoPostal { get => codigoPostal; }
        public int Portal { get => portal; }
        public int Piso { get => piso; }
        public int Puerta { get => puerta; }

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

        //Metodos

    }
}
