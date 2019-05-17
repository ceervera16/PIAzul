using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheapMarket
{
    class CarritoTemporal
    {
        //Atributos
        private int codigoProducto;
        private string dniUsuario;
        private string producto;
        private int cantidad;
        private double precio;
        private double descuento;

        //Propiedades
        public int CodigoProducto { get { return codigoProducto; } set { codigoProducto = value; } }
        public string DniUsuario { get { return dniUsuario; } set { dniUsuario = value; } }
        public string Producto { get { return producto; } set { producto = value; } }
        public int Cantidad { get { return cantidad; } set { cantidad = value; } }
        public double Precio { get { return precio; } set { precio = value; } }
        public double Descuento { get { return descuento; } set { descuento = value; } }

        //Constructores
        public CarritoTemporal(int codigoProducto, string dniUsuario, string producto, int cantidad, double precio, double descuento)
        {
            this.codigoProducto = codigoProducto;
            this.dniUsuario = dniUsuario;
            this.producto = producto;
            this.cantidad = cantidad;
            this.precio = precio;
            this.descuento = descuento;
        }

        public CarritoTemporal() { }

        /// <summary>
        /// Aplica el descuento del producto
        /// </summary>
        /// <returns>Precio resultado</returns>
        public double AplicarDescuento()
        {
            precio = precio - (precio * descuento / 100);
            return precio;
        }
    }
    
}