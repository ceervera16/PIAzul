using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public void AgregarProducto()
        {

        }

        public void BorrarProducto()
        {

        }

        public void EditarProducto()
        {

        }
    }
}
